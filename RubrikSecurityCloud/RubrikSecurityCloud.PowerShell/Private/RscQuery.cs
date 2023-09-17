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
using System.Management.Automation;
using System.Management.Automation.Runspaces;

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
        internal QueryDocMethod queryDocMethod = null;
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
        public RscGqlOperation GqlOperation()
        {
            return _gqlOperation;
        }

        /// <summary>
        /// Return documentation links for the Field object.
        /// </summary>
        public string FieldInfo()
        {
            return StringUtils.DocLinkForGqlType(_gqlOperation.ReturnType);
        }

        public List<string> FlattenField()
        {
            return ReflectionUtils.FlattenField(this._gqlOperation.ReturnType);
        }

        /// <summary>
        /// Return documentation links for variables and Field object.
        /// </summary>
        public List<VarInfo> Info()
        {
            List<VarInfo> info = this.Var.Info();
            info.Add(new VarInfo(
                "Field",
                StringUtils.GqlTypeToType(_gqlOperation.ReturnType),
                FieldInfo()
            ));
            return info;
        }

        public void VarTemplate()
        {
            Console.WriteLine(this.Var.Example());
        }

        /// <summary>
        /// Build the GraphQL request
        /// </summary>
        public RscGqlRequest GqlRequest()
        {
            _gqlOperation.FieldSpec = this.queryDocMethod(this.Field);

            string query = _gqlOperation.Query();
            OperationVariableSet gqlVars = new OperationVariableSet();
            if (this.Var != null && this.Var.Count > 0)
            {
                gqlVars.Variables = this.Var.Finalize();
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