// Invoke-RscQueryAzureO365.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// AzureO365 queries
    /// </summary>
    /// <description>
    /// Invoke-RscQueryAzureO365 is a master cmdlet for AzureO365 work that can invoke any of the following subcommands: Exocompute, CheckStorageAccountName, CheckStorageAccountAccessibility, CheckSubscriptionQuota, CheckResourceGroupName, CheckVirtualNetworkName, ValidateUserRoles, CheckNSGOutboundRules, CheckNetworkSubnet, GetNetworkSubnetUnusedAddr, GetAzureHostType.
    /// </description>
    /// <example>
    /// <code>Invoke-RscQueryAzureO365 -Exocompute [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzureO365 -CheckStorageAccountName [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzureO365 -CheckStorageAccountAccessibility [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzureO365 -CheckSubscriptionQuota [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzureO365 -CheckResourceGroupName [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzureO365 -CheckVirtualNetworkName [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzureO365 -ValidateUserRoles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzureO365 -CheckNSGOutboundRules [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzureO365 -CheckNetworkSubnet [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzureO365 -GetAzureHostType [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscQueryAzureO365",
        DefaultParameterSetName = "Exocompute")
    ]
    public class Invoke_RscQueryAzureO365 : RscPSCmdlet
    {
        
        /// <summary>
        /// Exocompute parameter set
        ///
        /// [GraphQL: azureO365Exocompute]
        /// </summary>
        [Parameter(
            ParameterSetName = "Exocompute",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the exocompute details of the given cluster.
[GraphQL: azureO365Exocompute]",
            Position = 0
        )]
        public SwitchParameter Exocompute { get; set; }

        
        /// <summary>
        /// CheckStorageAccountName parameter set
        ///
        /// [GraphQL: azureO365CheckStorageAccountName]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckStorageAccountName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the storage account name.
[GraphQL: azureO365CheckStorageAccountName]",
            Position = 0
        )]
        public SwitchParameter CheckStorageAccountName { get; set; }

        
        /// <summary>
        /// CheckStorageAccountAccessibility parameter set
        ///
        /// [GraphQL: azureO365CheckStorageAccountAccessibility]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckStorageAccountAccessibility",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the accessibility of the storage account.
[GraphQL: azureO365CheckStorageAccountAccessibility]",
            Position = 0
        )]
        public SwitchParameter CheckStorageAccountAccessibility { get; set; }

        
        /// <summary>
        /// CheckSubscriptionQuota parameter set
        ///
        /// [GraphQL: azureO365CheckSubscriptionQuota]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckSubscriptionQuota",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the Azure subscription quota.
[GraphQL: azureO365CheckSubscriptionQuota]",
            Position = 0
        )]
        public SwitchParameter CheckSubscriptionQuota { get; set; }

        
        /// <summary>
        /// CheckResourceGroupName parameter set
        ///
        /// [GraphQL: azureO365CheckResourceGroupName]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckResourceGroupName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the resource group name.
[GraphQL: azureO365CheckResourceGroupName]",
            Position = 0
        )]
        public SwitchParameter CheckResourceGroupName { get; set; }

        
        /// <summary>
        /// CheckVirtualNetworkName parameter set
        ///
        /// [GraphQL: azureO365CheckVirtualNetworkName]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckVirtualNetworkName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the virtual network name.
[GraphQL: azureO365CheckVirtualNetworkName]",
            Position = 0
        )]
        public SwitchParameter CheckVirtualNetworkName { get; set; }

        
        /// <summary>
        /// ValidateUserRoles parameter set
        ///
        /// [GraphQL: azureO365ValidateUserRoles]
        /// </summary>
        [Parameter(
            ParameterSetName = "ValidateUserRoles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates the user roles in the subscription.
[GraphQL: azureO365ValidateUserRoles]",
            Position = 0
        )]
        public SwitchParameter ValidateUserRoles { get; set; }

        
        /// <summary>
        /// CheckNSGOutboundRules parameter set
        ///
        /// [GraphQL: azureO365CheckNSGOutboundRules]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckNSGOutboundRules",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the NSG Outbound rules of the Azure resources.
[GraphQL: azureO365CheckNSGOutboundRules]",
            Position = 0
        )]
        public SwitchParameter CheckNSGOutboundRules { get; set; }

        
        /// <summary>
        /// CheckNetworkSubnet parameter set
        ///
        /// [GraphQL: azureO365CheckNetworkSubnet]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckNetworkSubnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the network subnet of the Azure resources.
[GraphQL: azureO365CheckNetworkSubnet]",
            Position = 0
        )]
        public SwitchParameter CheckNetworkSubnet { get; set; }

        
        /// <summary>
        /// GetNetworkSubnetUnusedAddr parameter set
        ///
        /// [GraphQL: azureO365GetNetworkSubnetUnusedAddr]
        /// </summary>
        [Parameter(
            ParameterSetName = "GetNetworkSubnetUnusedAddr",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the unused addresses available in a subnet.
[GraphQL: azureO365GetNetworkSubnetUnusedAddr]",
            Position = 0
        )]
        public SwitchParameter GetNetworkSubnetUnusedAddr { get; set; }

        
        /// <summary>
        /// GetAzureHostType parameter set
        ///
        /// [GraphQL: azureO365GetAzureHostType]
        /// </summary>
        [Parameter(
            ParameterSetName = "GetAzureHostType",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the AzureHostType of the account.
[GraphQL: azureO365GetAzureHostType]",
            Position = 0
        )]
        public SwitchParameter GetAzureHostType { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Exocompute":
                        this.ProcessRecord_Exocompute();
                        break;
                    case "CheckStorageAccountName":
                        this.ProcessRecord_CheckStorageAccountName();
                        break;
                    case "CheckStorageAccountAccessibility":
                        this.ProcessRecord_CheckStorageAccountAccessibility();
                        break;
                    case "CheckSubscriptionQuota":
                        this.ProcessRecord_CheckSubscriptionQuota();
                        break;
                    case "CheckResourceGroupName":
                        this.ProcessRecord_CheckResourceGroupName();
                        break;
                    case "CheckVirtualNetworkName":
                        this.ProcessRecord_CheckVirtualNetworkName();
                        break;
                    case "ValidateUserRoles":
                        this.ProcessRecord_ValidateUserRoles();
                        break;
                    case "CheckNSGOutboundRules":
                        this.ProcessRecord_CheckNSGOutboundRules();
                        break;
                    case "CheckNetworkSubnet":
                        this.ProcessRecord_CheckNetworkSubnet();
                        break;
                    case "GetNetworkSubnetUnusedAddr":
                        this.ProcessRecord_GetNetworkSubnetUnusedAddr();
                        break;
                    case "GetAzureHostType":
                        this.ProcessRecord_GetAzureHostType();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // azureO365Exocompute.
        internal void ProcessRecord_Exocompute()
        {
            this._logger.name += " -Exocompute";
            // Invoke graphql operation azureO365Exocompute
            InvokeQueryAzureO365Exocompute();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckStorageAccountName.
        internal void ProcessRecord_CheckStorageAccountName()
        {
            this._logger.name += " -CheckStorageAccountName";
            // Invoke graphql operation azureO365CheckStorageAccountName
            InvokeQueryAzureO365CheckStorageAccountName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckStorageAccountAccessibility.
        internal void ProcessRecord_CheckStorageAccountAccessibility()
        {
            this._logger.name += " -CheckStorageAccountAccessibility";
            // Invoke graphql operation azureO365CheckStorageAccountAccessibility
            InvokeQueryAzureO365CheckStorageAccountAccessibility();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckSubscriptionQuota.
        internal void ProcessRecord_CheckSubscriptionQuota()
        {
            this._logger.name += " -CheckSubscriptionQuota";
            // Invoke graphql operation azureO365CheckSubscriptionQuota
            InvokeQueryAzureO365CheckSubscriptionQuota();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckResourceGroupName.
        internal void ProcessRecord_CheckResourceGroupName()
        {
            this._logger.name += " -CheckResourceGroupName";
            // Invoke graphql operation azureO365CheckResourceGroupName
            InvokeQueryAzureO365CheckResourceGroupName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckVirtualNetworkName.
        internal void ProcessRecord_CheckVirtualNetworkName()
        {
            this._logger.name += " -CheckVirtualNetworkName";
            // Invoke graphql operation azureO365CheckVirtualNetworkName
            InvokeQueryAzureO365CheckVirtualNetworkName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365ValidateUserRoles.
        internal void ProcessRecord_ValidateUserRoles()
        {
            this._logger.name += " -ValidateUserRoles";
            // Invoke graphql operation azureO365ValidateUserRoles
            InvokeQueryAzureO365ValidateUserRoles();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckNSGOutboundRules.
        internal void ProcessRecord_CheckNSGOutboundRules()
        {
            this._logger.name += " -CheckNSGOutboundRules";
            // Invoke graphql operation azureO365CheckNSGOutboundRules
            InvokeQueryAzureO365CheckNsgOutboundRules();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckNetworkSubnet.
        internal void ProcessRecord_CheckNetworkSubnet()
        {
            this._logger.name += " -CheckNetworkSubnet";
            // Invoke graphql operation azureO365CheckNetworkSubnet
            InvokeQueryAzureO365CheckNetworkSubnet();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365GetNetworkSubnetUnusedAddr.
        internal void ProcessRecord_GetNetworkSubnetUnusedAddr()
        {
            this._logger.name += " -GetNetworkSubnetUnusedAddr";
            // Invoke graphql operation azureO365GetNetworkSubnetUnusedAddr
            InvokeQueryAzureO365GetNetworkSubnetUnusedAddr();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365GetAzureHostType.
        internal void ProcessRecord_GetAzureHostType()
        {
            this._logger.name += " -GetAzureHostType";
            // Invoke graphql operation azureO365GetAzureHostType
            InvokeQueryAzureO365GetAzureHostType();
        }


        // Invoke GraphQL Query:
        // azureO365Exocompute(orgId: UUID!, exocomputeClusterId: String!): GetAzureO365ExocomputeResp!
        internal void InvokeQueryAzureO365Exocompute()
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
                "GetAzureO365ExocomputeResp"
                );
            GetAzureO365ExocomputeResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (GetAzureO365ExocomputeResp)this.Field;
            }
            string fieldSpecDoc = Query.AzureO365Exocompute(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureO365CheckStorageAccountName(tenantId: String!, subscriptionId: UUID!, storage_account_name: String!): AzureResourceAvailabilityResp!
        internal void InvokeQueryAzureO365CheckStorageAccountName()
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
                "AzureResourceAvailabilityResp"
                );
            AzureResourceAvailabilityResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureResourceAvailabilityResp)this.Field;
            }
            string fieldSpecDoc = Query.AzureO365CheckStorageAccountName(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureO365CheckStorageAccountAccessibility(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     storage_account_name: String!
        //     groupName: String!
        //   ): AzureResourceAvailabilityResp!
        internal void InvokeQueryAzureO365CheckStorageAccountAccessibility()
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
                "AzureResourceAvailabilityResp"
                );
            AzureResourceAvailabilityResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureResourceAvailabilityResp)this.Field;
            }
            string fieldSpecDoc = Query.AzureO365CheckStorageAccountAccessibility(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureO365CheckSubscriptionQuota(tenantId: String!, subscriptionId: UUID!, regionName: String!): AzureResourceAvailabilityResp!
        internal void InvokeQueryAzureO365CheckSubscriptionQuota()
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
                "AzureResourceAvailabilityResp"
                );
            AzureResourceAvailabilityResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureResourceAvailabilityResp)this.Field;
            }
            string fieldSpecDoc = Query.AzureO365CheckSubscriptionQuota(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureO365CheckResourceGroupName(tenantId: String!, subscriptionId: UUID!, groupName: String!): AzureResourceAvailabilityResp!
        internal void InvokeQueryAzureO365CheckResourceGroupName()
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
                "AzureResourceAvailabilityResp"
                );
            AzureResourceAvailabilityResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureResourceAvailabilityResp)this.Field;
            }
            string fieldSpecDoc = Query.AzureO365CheckResourceGroupName(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureO365CheckVirtualNetworkName(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     groupName: String!
        //     vnet_name: String!
        //   ): AzureResourceAvailabilityResp!
        internal void InvokeQueryAzureO365CheckVirtualNetworkName()
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
                "AzureResourceAvailabilityResp"
                );
            AzureResourceAvailabilityResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureResourceAvailabilityResp)this.Field;
            }
            string fieldSpecDoc = Query.AzureO365CheckVirtualNetworkName(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureO365ValidateUserRoles(tenantId: String!, subscriptionId: UUID!): AzureUserRoleResp!
        internal void InvokeQueryAzureO365ValidateUserRoles()
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
                "AzureUserRoleResp"
                );
            AzureUserRoleResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureUserRoleResp)this.Field;
            }
            string fieldSpecDoc = Query.AzureO365ValidateUserRoles(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureO365CheckNSGOutboundRules(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //   ): AzureNetworkSecurityGroupResp!
        internal void InvokeQueryAzureO365CheckNsgOutboundRules()
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
                "AzureNetworkSecurityGroupResp"
                );
            AzureNetworkSecurityGroupResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNetworkSecurityGroupResp)this.Field;
            }
            string fieldSpecDoc = Query.AzureO365CheckNsgOutboundRules(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureO365CheckNetworkSubnet(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //     strict_addr_check: Boolean!
        //   ): AzureNetworkSubnetResp!
        internal void InvokeQueryAzureO365CheckNetworkSubnet()
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
                "AzureNetworkSubnetResp"
                );
            AzureNetworkSubnetResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNetworkSubnetResp)this.Field;
            }
            string fieldSpecDoc = Query.AzureO365CheckNetworkSubnet(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureO365GetNetworkSubnetUnusedAddr(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //     strict_addr_check: Boolean!
        //   ): AzureNetworkSubnetUnusedAddrResp!
        internal void InvokeQueryAzureO365GetNetworkSubnetUnusedAddr()
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
                "AzureNetworkSubnetUnusedAddrResp"
                );
            AzureNetworkSubnetUnusedAddrResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNetworkSubnetUnusedAddrResp)this.Field;
            }
            string fieldSpecDoc = Query.AzureO365GetNetworkSubnetUnusedAddr(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureO365GetAzureHostType: GetAzureHostTypeResp!
        internal void InvokeQueryAzureO365GetAzureHostType()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365GetAzureHostType",
                "",
                "GetAzureHostTypeResp"
                );
            GetAzureHostTypeResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (GetAzureHostTypeResp)this.Field;
            }
            string fieldSpecDoc = Query.AzureO365GetAzureHostType(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscQueryAzureO365
}