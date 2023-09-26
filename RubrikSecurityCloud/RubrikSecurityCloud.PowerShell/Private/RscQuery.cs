using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.PowerShell.Private;
using GraphQL;
using System.Management.Automation.Runspaces;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

// namespace is RubrikSecurityCloud (and not private)
// because this class is used by the public cmdlets
// and is visible to the user
namespace RubrikSecurityCloud
{
    public delegate string QueryDocMethod(object fieldSpecObj);

    public delegate object QueryFieldSpecMethod(ExplorationContext ec = null);

    public class RscQuery
    {

        public String Op { get; set; }
        public RscGqlVars Var { get; set; }
        public System.Object Field { get; set; }
        internal RscGqlOperation _gqlOperation = null;
        internal IRscLogger Logger = null;
        internal string OperationsDir = null;
        internal string CustomOperationsDir = null;

        /// <summary>
        /// Method that returns the query document as a string.
        /// It does not explore. It takes a field object as input,
        /// and returns the query document as a string.
        /// "query document": the text of the operation: 
        /// the operation name, the operation arguments,
        /// and the fields to select for retrieval. For example in
        /// the final query, it's all the text inside
        /// query QueryClusterConnection($first: Int ...) {
        ///         -- query document --
        /// }
        /// So it's: the query name, the query arguments, and 
        /// the field spec.
        /// </summary>
        internal QueryDocMethod queryDocMethod = null;

        /// <summary>
        /// Method that builds the field object for this query
        /// using exploration. It takes for input an exploration context,
        /// and returns the field object.
        /// </summary>
        internal QueryFieldSpecMethod queryFieldSpecMethod = null;

        /// <summary>
        /// Create a new RscQuery object.
        /// </summary>
        public RscQuery(
            string op,
            RscGqlVars vars,
            System.Object field,
            RscGqlOperation gqlOperation)
        {
            this.Op = op;
            this.Var = vars;
            this.Field = field;
            _gqlOperation = gqlOperation;
        }

        internal void Init(
            IRscLogger logger,
            string operationsDir,
            string customOperationsDir,
            QueryDocMethod queryDocMethod,
            QueryFieldSpecMethod queryFieldSpecMethod)
        {
            this.Logger = logger;
            this.OperationsDir = operationsDir;
            this.CustomOperationsDir = customOperationsDir;
            this.queryDocMethod = queryDocMethod;
            this.queryFieldSpecMethod = queryFieldSpecMethod;
            this.Logger?.Debug("RscQuery.Init: " + this.ToString());
        }

        /// <summary>
        /// Invoke the GraphQL query (send it to the API server)
        /// and return the result as a PowerShell object of
        /// the appropriate schema type.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public object Invoke()
        {
            var request = this.GqlRequest();
            if (request == null)
            {
                throw new Exception("Could not generate GQL request");
            }
            using (System.Management.Automation.PowerShell powerShell = System.Management.Automation.PowerShell.Create(RunspaceMode.CurrentRunspace))
            {
                powerShell.AddCommand("Invoke-Rsc")
                    .AddParameter("Query", this);
                var result = powerShell.Invoke();
                return result;
            }
        }

        /// <summary>
        /// The name of the underlying GQL operation.
        /// </summary>
        internal RscGqlOperation GqlOperation()
        {
            return _gqlOperation;
        }

        /// <summary>
        /// Return the flattened list of fields in the Field object.
        /// </summary>
        /// <returns></returns>
        public List<string> FlattenField()
        {
            return ReflectionUtils.FlattenField(this._gqlOperation.ReturnType);
        }

        /// <summary>
        /// Return documentation links for variables and Field object.
        /// </summary>
        public List<VarInfo> Info()
        {
            List<VarInfo> info = this.Var.Info().Select(v => new VarInfo(
                "Var." + v.Name, v.Type, v.Description)).ToList();
            info.Add(new VarInfo(
                "Field",
                StringUtils.GqlTypeToType(_gqlOperation.ReturnType),
                StringUtils.DocLinkForGqlType(_gqlOperation.ReturnType)
            ));
            return info;
        }

        /// <summary>
        /// Return an example of how the variables can be initialized.
        /// </summary>
        public string VarTemplate()
        {
            return this.Var.Example();
        }

        /// <summary>
        /// Build the GraphQL request
        /// </summary>
        public RscGqlRequest GqlRequest(bool verifyQuery = true)
        {
            _gqlOperation.FieldSpec = this.queryDocMethod(this.Field);

            string query = _gqlOperation.Query();
            OperationVariableSet gqlVars = new OperationVariableSet();
            if (this.Var != null && this.Var.Count > 0)
            {
                gqlVars.Variables = verifyQuery ? this.Var.Finalize() : this.Var;
            }

            //  GQL override file
            query = ApplyOverrideGqlFileIfAny(query);

            return new RscGqlRequest(
                _gqlOperation.Name,
                gqlVars.AsJson(this.Logger),
                _gqlOperation.ReturnType,
                query,
                this.CustomOperationsDir
            );
        }

        internal string ApplyOverrideGqlFileIfAny(string query)
        {
            if (string.IsNullOrEmpty(this.OperationsDir))
            {
                return query;
            }

            string overrideFile = Path.Combine(
                this.OperationsDir, _gqlOperation.Name + ".gql");
            string overrideQuery = Files.ReadFileIfExists(overrideFile);

            if (!string.IsNullOrEmpty(overrideQuery))
            {
                this.Logger?.Debug("Using override " + overrideFile);
                query = overrideQuery;
            }
            else
            {
                this.Logger?.Debug("No override " + overrideFile);
            }
            return query;
        }

        /// <summary>
        ///  String representation of this object.
        /// </summary>
        public override string ToString()
        {
            var FieldStr = this.Field == null ? "null" : this.Field.ToString();
            if (this.Field != null && this.Field is IFieldSpec)
            {
                FieldStr = ((IFieldSpec)this.Field).AsFieldSpec();
                FieldStr = Regex.Replace(FieldStr, @"\s+", " ");
            }
            return $"RscQuery(Op: {this.Op}, Var: {this.Var}, Field: {FieldStr})";
        }
    }
}