// New-RscQueryRcv.cs
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
    /// Create a new RscQuery object for any of the 5
    /// operations in the 'RCV' API domain:
    /// AccountEntitlement, AccountEntitlements, IsTriggerGrsTprConfigured, MigrationInfo, or PrivateEndpointConnections.
    /// </summary>
    /// <description>
    /// New-RscQueryRcv creates a new
    /// query object for operations
    /// in the 'RCV' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 5 operations
    /// in the 'RCV' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AccountEntitlement, AccountEntitlements, IsTriggerGrsTprConfigured, MigrationInfo, or PrivateEndpointConnections.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryRcv -AccountEntitlement).Info().
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
    /// (New-RscQueryRcv -AccountEntitlement).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AccountEntitlement operation
    /// of the 'RCV' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcv
    /// # API Operation: AccountEntitlement
    /// 
    /// $query = New-RscQueryRcv -Operation AccountEntitlement
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RcvAccountEntitlement
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AccountEntitlements operation
    /// of the 'RCV' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcv
    /// # API Operation: AccountEntitlements
    /// 
    /// $query = New-RscQueryRcv -Operation AccountEntitlements
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AllRcvAccountEntitlements
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsTriggerGrsTprConfigured operation
    /// of the 'RCV' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcv
    /// # API Operation: IsTriggerGrsTprConfigured
    /// 
    /// $query = New-RscQueryRcv -Operation IsTriggerGrsTprConfigured
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MigrationInfo operation
    /// of the 'RCV' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcv
    /// # API Operation: MigrationInfo
    /// 
    /// $query = New-RscQueryRcv -Operation MigrationInfo
    /// 
    /// # REQUIRED
    /// $query.Var.locationId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;PerLocationMigrationInfo&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PrivateEndpointConnections operation
    /// of the 'RCV' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcv
    /// # API Operation: PrivateEndpointConnections
    /// 
    /// $query = New-RscQueryRcv -Operation PrivateEndpointConnections
    /// 
    /// # REQUIRED
    /// $query.Var.input = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;DetailedPrivateEndpointConnection&gt;
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
        "RscQueryRcv",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryRcv : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AccountEntitlement",
                "AccountEntitlements",
                "IsTriggerGrsTprConfigured",
                "MigrationInfo",
                "PrivateEndpointConnections",
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
                    case "AccountEntitlement":
                        this.ProcessRecord_AccountEntitlement();
                        break;
                    case "AccountEntitlements":
                        this.ProcessRecord_AccountEntitlements();
                        break;
                    case "IsTriggerGrsTprConfigured":
                        this.ProcessRecord_IsTriggerGrsTprConfigured();
                        break;
                    case "MigrationInfo":
                        this.ProcessRecord_MigrationInfo();
                        break;
                    case "PrivateEndpointConnections":
                        this.ProcessRecord_PrivateEndpointConnections();
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
        // rcvAccountEntitlement.
        internal void ProcessRecord_AccountEntitlement()
        {
            this._logger.name += " -AccountEntitlement";
            // Create new graphql operation rcvAccountEntitlement
            InitQueryRcvAccountEntitlement();
        }

        // This parameter set invokes a single graphql operation:
        // allRcvAccountEntitlements.
        internal void ProcessRecord_AccountEntitlements()
        {
            this._logger.name += " -AccountEntitlements";
            // Create new graphql operation allRcvAccountEntitlements
            InitQueryAllRcvAccountEntitlements();
        }

        // This parameter set invokes a single graphql operation:
        // isTriggerRcvGrsTprConfigured.
        internal void ProcessRecord_IsTriggerGrsTprConfigured()
        {
            this._logger.name += " -IsTriggerGrsTprConfigured";
            // Create new graphql operation isTriggerRcvGrsTprConfigured
            InitQueryIsTriggerRcvGrsTprConfigured();
        }

        // This parameter set invokes a single graphql operation:
        // allRcvMigrationInfo.
        internal void ProcessRecord_MigrationInfo()
        {
            this._logger.name += " -MigrationInfo";
            // Create new graphql operation allRcvMigrationInfo
            InitQueryAllRcvMigrationInfo();
        }

        // This parameter set invokes a single graphql operation:
        // allRcvPrivateEndpointConnections.
        internal void ProcessRecord_PrivateEndpointConnections()
        {
            this._logger.name += " -PrivateEndpointConnections";
            // Create new graphql operation allRcvPrivateEndpointConnections
            InitQueryAllRcvPrivateEndpointConnections();
        }


        // Create new GraphQL Query:
        // rcvAccountEntitlement: RcvAccountEntitlement!
        internal void InitQueryRcvAccountEntitlement()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryRcvAccountEntitlement",
                "",
                "RcvAccountEntitlement",
                Query.RcvAccountEntitlement,
                Query.RcvAccountEntitlementFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allRcvAccountEntitlements: AllRcvAccountEntitlements!
        internal void InitQueryAllRcvAccountEntitlements()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllRcvAccountEntitlements",
                "",
                "AllRcvAccountEntitlements",
                Query.AllRcvAccountEntitlements,
                Query.AllRcvAccountEntitlementsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // isTriggerRcvGrsTprConfigured: Boolean!
        internal void InitQueryIsTriggerRcvGrsTprConfigured()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsTriggerRcvGrsTprConfigured",
                "",
                "System.Boolean",
                Query.IsTriggerRcvGrsTprConfigured,
                Query.IsTriggerRcvGrsTprConfiguredFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allRcvMigrationInfo(locationId: UUID!): [PerLocationMigrationInfo!]!
        internal void InitQueryAllRcvMigrationInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("locationId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllRcvMigrationInfo",
                "($locationId: UUID!)",
                "List<PerLocationMigrationInfo>",
                Query.AllRcvMigrationInfo,
                Query.AllRcvMigrationInfoFieldSpec,
                @"# REQUIRED
$query.Var.locationId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allRcvPrivateEndpointConnections(input: UUID!): [DetailedPrivateEndpointConnection!]!
        internal void InitQueryAllRcvPrivateEndpointConnections()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllRcvPrivateEndpointConnections",
                "($input: UUID!)",
                "List<DetailedPrivateEndpointConnection>",
                Query.AllRcvPrivateEndpointConnections,
                Query.AllRcvPrivateEndpointConnectionsFieldSpec,
                @"# REQUIRED
$query.Var.input = $someString"
            );
        }


    } // class New_RscQueryRcv
}