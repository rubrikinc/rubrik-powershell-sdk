// New-RscQueryIntegration.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 2
    /// operations in the 'Integration' API domain:
    /// Integration, or Integrations.
    /// </summary>
    /// <description>
    /// New-RscQueryIntegration creates a new
    /// query object for operations
    /// in the 'Integration' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 2 operations
    /// in the 'Integration' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Integration, or Integrations.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryIntegration -Integration).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryIntegration -Integration).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Integration operation
    /// of the 'Integration' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Integration
    /// # API Operation: Integration
    /// 
    /// $query = New-RscQueryIntegration -Integration
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReadIntegrationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Integrations operation
    /// of the 'Integration' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Integration
    /// # API Operation: Integrations
    /// 
    /// $query = New-RscQueryIntegration -Integrations
    /// 
    /// # REQUIRED
    /// $query.Var.integrationTypes = @(
    /// 	$someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.nameFilter = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ListIntegrationsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryIntegration",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryIntegration : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Integration",
                "Integrations",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "Integration":
                        this.ProcessRecord_Integration();
                        break;
                    case "Integrations":
                        this.ProcessRecord_Integrations();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // integration.
        internal void ProcessRecord_Integration()
        {
            this._logger.name += " -Integration";
            // Create new graphql operation integration
            InitQueryIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // allIntegrations.
        internal void ProcessRecord_Integrations()
        {
            this._logger.name += " -Integrations";
            // Create new graphql operation allIntegrations
            InitQueryAllIntegrations();
        }


        // Create new GraphQL Query:
        // integration(id: Int!): ReadIntegrationReply!
        internal void InitQueryIntegration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "Int!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIntegration",
                "($id: Int!)",
                "ReadIntegrationReply",
                Query.Integration,
                Query.IntegrationFieldSpec,
                @"# REQUIRED
$query.Var.id = $someInt"
            );
        }

        // Create new GraphQL Query:
        // allIntegrations(integrationTypes: [IntegrationType!]!, nameFilter: String): ListIntegrationsReply!
        internal void InitQueryAllIntegrations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("integrationTypes", "[IntegrationType!]!"),
                Tuple.Create("nameFilter", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllIntegrations",
                "($integrationTypes: [IntegrationType!]!,$nameFilter: String)",
                "ListIntegrationsReply",
                Query.AllIntegrations,
                Query.AllIntegrationsFieldSpec,
                @"# REQUIRED
$query.Var.integrationTypes = @(
	$someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
)
# OPTIONAL
$query.Var.nameFilter = $someString"
            );
        }


    } // class New_RscQueryIntegration
}