using System;
using System.Collections;
using System.Management.Automation;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RubrikSecurityCloud;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Send a query to the RSC API.
    /// </summary>
    /// <description>
    /// There are 2 usages of this cmdlet:
    /// - Send a query obtained from a `New-RscQuery*` cmdlet.
    /// - Send a raw GraphQL query.
    /// </description>
    /// <example>
    /// Send a query obtained from a `New-RscQuery*` cmdlet.
    /// <code>
    /// New-RscQueryGetVsphereVmList -Name "my-vm" | Invoke-Rsc
    /// </code>
    /// </example>
    /// <example>
    /// Read GraphQL query from gql file
    /// <code>
    /// Get-Content -Path ./Samples/queryAccountOwners -Raw | Invoke-Rsc
    /// </code>
    /// </example>
    /// <example>
    /// Pass GraphQL query as parameter.
    /// <code>
    /// Invoke-Rsc -GqlQuery "mutation DeleteWebhookMutation(`$id: Int!) { deleteWebhook(input: {id: `$id}) }" -Var @{id = 1}
    /// </code>
    /// </example>
    [Cmdlet(
        VerbsLifecycle.Invoke,
        "Rsc",
        DefaultParameterSetName = "Query")]
    public class Invoke_Rsc : RscBasePSCmdlet
    {
        [Parameter(
            ParameterSetName = "Query",
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true
        )]
        public object Query { get; set; }

        // Parameter Set "NativeGQL"
        // is used when the user writes their own GQL queries
        /// <summary>
        /// The GQL query to send to the RSC API.
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeGQL",
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true
        )]
        public string GqlQuery { get; set; }

        /// <summary>
        /// The variables to supply to the GraphQL query.
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeGQL",
            Mandatory = false,
            Position = 1,
            ValueFromPipeline = true
        )]
        public Hashtable Var { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            RetrieveConnection();
        }
        protected override void ProcessRecord()
        {
            try
            {
                switch (ParameterSetName)
                {
                    case "Query":
                        ProcessRecord_Query();
                        break;
                    case "NativeGQL":
                        ProcessRecord_NativeGQL();
                        break;
                }
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_Query()
        {
            if (Query is PSObject pSObject)
            {
                Query = pSObject.BaseObject;
            }
            if (Query is string sQuery)
            {
                GqlQuery = sQuery;
                ProcessRecord_NativeGQL();
                return;
            }
            if (Query is RscQuery query)
            {
                this.SendGqlRequest(query.GqlRequest());
                return;
            }
            throw new ArgumentException($"Invalid query type {Query.GetType().Name}");
        }

        internal void ProcessRecord_NativeGQL()
        {
            var (inlineVars, query) = StringUtils.ParseGqlAndVarString(GqlQuery);
            if (!string.IsNullOrEmpty(inlineVars) && (
                Var == null || Var.Count == 0 ))
            {
                Var = JsonConvert.DeserializeObject<Hashtable>(inlineVars);
            }
            object reply = _rbkClient.InvokeRawQuery(
                query,
                Var,
                _logger,
                GetMetricTags()
            );
            WriteObject(reply);
        }

        public static Type GetType(string typeName)
        {
            var type = Type.GetType(typeName);
            if (type != null)
                return type;
            // type = Type.GetType("RubrikSecurityCloud.Operations." + typeName + ", RubrikSecurityCloud.Schema");
            // if (type != null)
            //     return type;
            type = Type.GetType(
                "RubrikSecurityCloud.Types." + typeName
                    + ", RubrikSecurityCloud.Schema"
            );
            if (type != null)
                return type;
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var a in assemblies)
            {
                type = a.GetType(typeName);
                if (type != null)
                    return type;
            }
            return null;
        }
    }
}
