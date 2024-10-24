// New-RscQueryAzureO365.cs
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
    /// Create a new RscQuery object for any of the 11
    /// operations in the 'Azure Office365' API domain:
    /// CheckNSGOutboundRules, CheckNetworkSubnet, CheckResourceGroupName, CheckStorageAccountAccessibility, CheckStorageAccountName, CheckSubscriptionQuota, CheckVirtualNetworkName, Exocompute, GetAzureHostType, GetNetworkSubnetUnusedAddr, or ValidateUserRoles.
    /// </summary>
    /// <description>
    /// New-RscQueryAzureO365 creates a new
    /// query object for operations
    /// in the 'Azure Office365' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 11 operations
    /// in the 'Azure Office365' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CheckNSGOutboundRules, CheckNetworkSubnet, CheckResourceGroupName, CheckStorageAccountAccessibility, CheckStorageAccountName, CheckSubscriptionQuota, CheckVirtualNetworkName, Exocompute, GetAzureHostType, GetNetworkSubnetUnusedAddr, or ValidateUserRoles.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryAzureO365 -CheckNSGOutboundRules).Info().
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
    /// (New-RscQueryAzureO365 -CheckNSGOutboundRules).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CheckNSGOutboundRules operation
    /// of the 'Azure Office365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureO365
    /// # API Operation: CheckNSGOutboundRules
    /// 
    /// $query = New-RscQueryAzureO365 -Operation CheckNSGOutboundRules
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.resourceGroupName = $someString
    /// # REQUIRED
    /// $query.Var.vnet_name = $someString
    /// # REQUIRED
    /// $query.Var.subnet_name = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNetworkSecurityGroupResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckNetworkSubnet operation
    /// of the 'Azure Office365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureO365
    /// # API Operation: CheckNetworkSubnet
    /// 
    /// $query = New-RscQueryAzureO365 -Operation CheckNetworkSubnet
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.resourceGroupName = $someString
    /// # REQUIRED
    /// $query.Var.vnet_name = $someString
    /// # REQUIRED
    /// $query.Var.subnet_name = $someString
    /// # REQUIRED
    /// $query.Var.strict_addr_check = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNetworkSubnetResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckResourceGroupName operation
    /// of the 'Azure Office365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureO365
    /// # API Operation: CheckResourceGroupName
    /// 
    /// $query = New-RscQueryAzureO365 -Operation CheckResourceGroupName
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.groupName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureResourceAvailabilityResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckStorageAccountAccessibility operation
    /// of the 'Azure Office365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureO365
    /// # API Operation: CheckStorageAccountAccessibility
    /// 
    /// $query = New-RscQueryAzureO365 -Operation CheckStorageAccountAccessibility
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.storage_account_name = $someString
    /// # REQUIRED
    /// $query.Var.groupName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureResourceAvailabilityResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckStorageAccountName operation
    /// of the 'Azure Office365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureO365
    /// # API Operation: CheckStorageAccountName
    /// 
    /// $query = New-RscQueryAzureO365 -Operation CheckStorageAccountName
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.storage_account_name = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureResourceAvailabilityResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckSubscriptionQuota operation
    /// of the 'Azure Office365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureO365
    /// # API Operation: CheckSubscriptionQuota
    /// 
    /// $query = New-RscQueryAzureO365 -Operation CheckSubscriptionQuota
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.regionName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureResourceAvailabilityResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckVirtualNetworkName operation
    /// of the 'Azure Office365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureO365
    /// # API Operation: CheckVirtualNetworkName
    /// 
    /// $query = New-RscQueryAzureO365 -Operation CheckVirtualNetworkName
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.groupName = $someString
    /// # REQUIRED
    /// $query.Var.vnet_name = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureResourceAvailabilityResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Exocompute operation
    /// of the 'Azure Office365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureO365
    /// # API Operation: Exocompute
    /// 
    /// $query = New-RscQueryAzureO365 -Operation Exocompute
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # REQUIRED
    /// $query.Var.exocomputeClusterId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetAzureO365ExocomputeResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetAzureHostType operation
    /// of the 'Azure Office365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureO365
    /// # API Operation: GetAzureHostType
    /// 
    /// $query = New-RscQueryAzureO365 -Operation GetAzureHostType
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetAzureHostTypeResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetNetworkSubnetUnusedAddr operation
    /// of the 'Azure Office365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureO365
    /// # API Operation: GetNetworkSubnetUnusedAddr
    /// 
    /// $query = New-RscQueryAzureO365 -Operation GetNetworkSubnetUnusedAddr
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.resourceGroupName = $someString
    /// # REQUIRED
    /// $query.Var.vnet_name = $someString
    /// # REQUIRED
    /// $query.Var.subnet_name = $someString
    /// # REQUIRED
    /// $query.Var.strict_addr_check = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNetworkSubnetUnusedAddrResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateUserRoles operation
    /// of the 'Azure Office365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureO365
    /// # API Operation: ValidateUserRoles
    /// 
    /// $query = New-RscQueryAzureO365 -Operation ValidateUserRoles
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureUserRoleResp
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
        "RscQueryAzureO365",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryAzureO365 : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CheckNSGOutboundRules",
                "CheckNetworkSubnet",
                "CheckResourceGroupName",
                "CheckStorageAccountAccessibility",
                "CheckStorageAccountName",
                "CheckSubscriptionQuota",
                "CheckVirtualNetworkName",
                "Exocompute",
                "GetAzureHostType",
                "GetNetworkSubnetUnusedAddr",
                "ValidateUserRoles",
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
                    case "CheckNSGOutboundRules":
                        this.ProcessRecord_CheckNSGOutboundRules();
                        break;
                    case "CheckNetworkSubnet":
                        this.ProcessRecord_CheckNetworkSubnet();
                        break;
                    case "CheckResourceGroupName":
                        this.ProcessRecord_CheckResourceGroupName();
                        break;
                    case "CheckStorageAccountAccessibility":
                        this.ProcessRecord_CheckStorageAccountAccessibility();
                        break;
                    case "CheckStorageAccountName":
                        this.ProcessRecord_CheckStorageAccountName();
                        break;
                    case "CheckSubscriptionQuota":
                        this.ProcessRecord_CheckSubscriptionQuota();
                        break;
                    case "CheckVirtualNetworkName":
                        this.ProcessRecord_CheckVirtualNetworkName();
                        break;
                    case "Exocompute":
                        this.ProcessRecord_Exocompute();
                        break;
                    case "GetAzureHostType":
                        this.ProcessRecord_GetAzureHostType();
                        break;
                    case "GetNetworkSubnetUnusedAddr":
                        this.ProcessRecord_GetNetworkSubnetUnusedAddr();
                        break;
                    case "ValidateUserRoles":
                        this.ProcessRecord_ValidateUserRoles();
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
        // azureO365CheckNSGOutboundRules.
        internal void ProcessRecord_CheckNSGOutboundRules()
        {
            this._logger.name += " -CheckNSGOutboundRules";
            // Create new graphql operation azureO365CheckNSGOutboundRules
            InitQueryAzureO365CheckNsgOutboundRules();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckNetworkSubnet.
        internal void ProcessRecord_CheckNetworkSubnet()
        {
            this._logger.name += " -CheckNetworkSubnet";
            // Create new graphql operation azureO365CheckNetworkSubnet
            InitQueryAzureO365CheckNetworkSubnet();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckResourceGroupName.
        internal void ProcessRecord_CheckResourceGroupName()
        {
            this._logger.name += " -CheckResourceGroupName";
            // Create new graphql operation azureO365CheckResourceGroupName
            InitQueryAzureO365CheckResourceGroupName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckStorageAccountAccessibility.
        internal void ProcessRecord_CheckStorageAccountAccessibility()
        {
            this._logger.name += " -CheckStorageAccountAccessibility";
            // Create new graphql operation azureO365CheckStorageAccountAccessibility
            InitQueryAzureO365CheckStorageAccountAccessibility();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckStorageAccountName.
        internal void ProcessRecord_CheckStorageAccountName()
        {
            this._logger.name += " -CheckStorageAccountName";
            // Create new graphql operation azureO365CheckStorageAccountName
            InitQueryAzureO365CheckStorageAccountName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckSubscriptionQuota.
        internal void ProcessRecord_CheckSubscriptionQuota()
        {
            this._logger.name += " -CheckSubscriptionQuota";
            // Create new graphql operation azureO365CheckSubscriptionQuota
            InitQueryAzureO365CheckSubscriptionQuota();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckVirtualNetworkName.
        internal void ProcessRecord_CheckVirtualNetworkName()
        {
            this._logger.name += " -CheckVirtualNetworkName";
            // Create new graphql operation azureO365CheckVirtualNetworkName
            InitQueryAzureO365CheckVirtualNetworkName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365Exocompute.
        internal void ProcessRecord_Exocompute()
        {
            this._logger.name += " -Exocompute";
            // Create new graphql operation azureO365Exocompute
            InitQueryAzureO365Exocompute();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365GetAzureHostType.
        internal void ProcessRecord_GetAzureHostType()
        {
            this._logger.name += " -GetAzureHostType";
            // Create new graphql operation azureO365GetAzureHostType
            InitQueryAzureO365GetAzureHostType();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365GetNetworkSubnetUnusedAddr.
        internal void ProcessRecord_GetNetworkSubnetUnusedAddr()
        {
            this._logger.name += " -GetNetworkSubnetUnusedAddr";
            // Create new graphql operation azureO365GetNetworkSubnetUnusedAddr
            InitQueryAzureO365GetNetworkSubnetUnusedAddr();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365ValidateUserRoles.
        internal void ProcessRecord_ValidateUserRoles()
        {
            this._logger.name += " -ValidateUserRoles";
            // Create new graphql operation azureO365ValidateUserRoles
            InitQueryAzureO365ValidateUserRoles();
        }


        // Create new GraphQL Query:
        // azureO365CheckNSGOutboundRules(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //   ): AzureNetworkSecurityGroupResp!
        internal void InitQueryAzureO365CheckNsgOutboundRules()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckNsgOutboundRules",
                "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!)",
                "AzureNetworkSecurityGroupResp",
                Query.AzureO365CheckNsgOutboundRules,
                Query.AzureO365CheckNsgOutboundRulesFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.resourceGroupName = $someString
# REQUIRED
$query.Var.vnet_name = $someString
# REQUIRED
$query.Var.subnet_name = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckNetworkSubnet(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //     strict_addr_check: Boolean!
        //   ): AzureNetworkSubnetResp!
        internal void InitQueryAzureO365CheckNetworkSubnet()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
                Tuple.Create("strict_addr_check", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckNetworkSubnet",
                "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!,$strict_addr_check: Boolean!)",
                "AzureNetworkSubnetResp",
                Query.AzureO365CheckNetworkSubnet,
                Query.AzureO365CheckNetworkSubnetFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.resourceGroupName = $someString
# REQUIRED
$query.Var.vnet_name = $someString
# REQUIRED
$query.Var.subnet_name = $someString
# REQUIRED
$query.Var.strict_addr_check = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckResourceGroupName(tenantId: String!, subscriptionId: UUID!, groupName: String!): AzureResourceAvailabilityResp!
        internal void InitQueryAzureO365CheckResourceGroupName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("groupName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckResourceGroupName",
                "($tenantId: String!,$subscriptionId: UUID!,$groupName: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckResourceGroupName,
                Query.AzureO365CheckResourceGroupNameFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.groupName = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckStorageAccountAccessibility(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     storage_account_name: String!
        //     groupName: String!
        //   ): AzureResourceAvailabilityResp!
        internal void InitQueryAzureO365CheckStorageAccountAccessibility()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("storage_account_name", "String!"),
                Tuple.Create("groupName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckStorageAccountAccessibility",
                "($tenantId: String!,$subscriptionId: UUID!,$storage_account_name: String!,$groupName: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckStorageAccountAccessibility,
                Query.AzureO365CheckStorageAccountAccessibilityFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.storage_account_name = $someString
# REQUIRED
$query.Var.groupName = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckStorageAccountName(tenantId: String!, subscriptionId: UUID!, storage_account_name: String!): AzureResourceAvailabilityResp!
        internal void InitQueryAzureO365CheckStorageAccountName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("storage_account_name", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckStorageAccountName",
                "($tenantId: String!,$subscriptionId: UUID!,$storage_account_name: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckStorageAccountName,
                Query.AzureO365CheckStorageAccountNameFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.storage_account_name = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckSubscriptionQuota(tenantId: String!, subscriptionId: UUID!, regionName: String!): AzureResourceAvailabilityResp!
        internal void InitQueryAzureO365CheckSubscriptionQuota()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckSubscriptionQuota",
                "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckSubscriptionQuota,
                Query.AzureO365CheckSubscriptionQuotaFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.regionName = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckVirtualNetworkName(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     groupName: String!
        //     vnet_name: String!
        //   ): AzureResourceAvailabilityResp!
        internal void InitQueryAzureO365CheckVirtualNetworkName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("groupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckVirtualNetworkName",
                "($tenantId: String!,$subscriptionId: UUID!,$groupName: String!,$vnet_name: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckVirtualNetworkName,
                Query.AzureO365CheckVirtualNetworkNameFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.groupName = $someString
# REQUIRED
$query.Var.vnet_name = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureO365Exocompute(orgId: UUID!, exocomputeClusterId: String!): GetAzureO365ExocomputeResp!
        internal void InitQueryAzureO365Exocompute()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("exocomputeClusterId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365Exocompute",
                "($orgId: UUID!,$exocomputeClusterId: String!)",
                "GetAzureO365ExocomputeResp",
                Query.AzureO365Exocompute,
                Query.AzureO365ExocomputeFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString
# REQUIRED
$query.Var.exocomputeClusterId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureO365GetAzureHostType: GetAzureHostTypeResp!
        internal void InitQueryAzureO365GetAzureHostType()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365GetAzureHostType",
                "",
                "GetAzureHostTypeResp",
                Query.AzureO365GetAzureHostType,
                Query.AzureO365GetAzureHostTypeFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // azureO365GetNetworkSubnetUnusedAddr(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //     strict_addr_check: Boolean!
        //   ): AzureNetworkSubnetUnusedAddrResp!
        internal void InitQueryAzureO365GetNetworkSubnetUnusedAddr()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
                Tuple.Create("strict_addr_check", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365GetNetworkSubnetUnusedAddr",
                "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!,$strict_addr_check: Boolean!)",
                "AzureNetworkSubnetUnusedAddrResp",
                Query.AzureO365GetNetworkSubnetUnusedAddr,
                Query.AzureO365GetNetworkSubnetUnusedAddrFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.resourceGroupName = $someString
# REQUIRED
$query.Var.vnet_name = $someString
# REQUIRED
$query.Var.subnet_name = $someString
# REQUIRED
$query.Var.strict_addr_check = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // azureO365ValidateUserRoles(tenantId: String!, subscriptionId: UUID!): AzureUserRoleResp!
        internal void InitQueryAzureO365ValidateUserRoles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365ValidateUserRoles",
                "($tenantId: String!,$subscriptionId: UUID!)",
                "AzureUserRoleResp",
                Query.AzureO365ValidateUserRoles,
                Query.AzureO365ValidateUserRolesFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString"
            );
        }


    } // class New_RscQueryAzureO365
}