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
    [Cmdlet(
        "Invoke",
        "RscQueryAzureO365",
        DefaultParameterSetName = "Exocompute")
    ]
    public class Invoke_RscQueryAzureO365 : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Exocompute parameter set
        //
        // [GraphQL: azureO365Exocompute]
        //
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

        
        // -------------------------------------------------------------------
        // CheckStorageAccountName parameter set
        //
        // [GraphQL: azureO365CheckStorageAccountName]
        //
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

        
        // -------------------------------------------------------------------
        // CheckStorageAccountAccessibility parameter set
        //
        // [GraphQL: azureO365CheckStorageAccountAccessibility]
        //
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

        
        // -------------------------------------------------------------------
        // CheckSubscriptionQuota parameter set
        //
        // [GraphQL: azureO365CheckSubscriptionQuota]
        //
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

        
        // -------------------------------------------------------------------
        // CheckResourceGroupName parameter set
        //
        // [GraphQL: azureO365CheckResourceGroupName]
        //
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

        
        // -------------------------------------------------------------------
        // CheckVirtualNetworkName parameter set
        //
        // [GraphQL: azureO365CheckVirtualNetworkName]
        //
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

        
        // -------------------------------------------------------------------
        // ValidateUserRoles parameter set
        //
        // [GraphQL: azureO365ValidateUserRoles]
        //
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

        
        // -------------------------------------------------------------------
        // CheckNSGOutboundRules parameter set
        //
        // [GraphQL: azureO365CheckNSGOutboundRules]
        //
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

        
        // -------------------------------------------------------------------
        // CheckNetworkSubnet parameter set
        //
        // [GraphQL: azureO365CheckNetworkSubnet]
        //
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

        
        // -------------------------------------------------------------------
        // GetNetworkSubnetUnusedAddr parameter set
        //
        // [GraphQL: azureO365GetNetworkSubnetUnusedAddr]
        //
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

        
        // -------------------------------------------------------------------
        // GetAzureHostType parameter set
        //
        // [GraphQL: azureO365GetAzureHostType]
        //
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

        // This parameter set invokes a single graphql operation:
        // azureO365Exocompute.
        protected void ProcessRecord_Exocompute()
        {
            this._logger.name += " -Exocompute";
            // Invoke graphql operation azureO365Exocompute
            InvokeQueryAzureO365Exocompute();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckStorageAccountName.
        protected void ProcessRecord_CheckStorageAccountName()
        {
            this._logger.name += " -CheckStorageAccountName";
            // Invoke graphql operation azureO365CheckStorageAccountName
            InvokeQueryAzureO365CheckStorageAccountName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckStorageAccountAccessibility.
        protected void ProcessRecord_CheckStorageAccountAccessibility()
        {
            this._logger.name += " -CheckStorageAccountAccessibility";
            // Invoke graphql operation azureO365CheckStorageAccountAccessibility
            InvokeQueryAzureO365CheckStorageAccountAccessibility();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckSubscriptionQuota.
        protected void ProcessRecord_CheckSubscriptionQuota()
        {
            this._logger.name += " -CheckSubscriptionQuota";
            // Invoke graphql operation azureO365CheckSubscriptionQuota
            InvokeQueryAzureO365CheckSubscriptionQuota();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckResourceGroupName.
        protected void ProcessRecord_CheckResourceGroupName()
        {
            this._logger.name += " -CheckResourceGroupName";
            // Invoke graphql operation azureO365CheckResourceGroupName
            InvokeQueryAzureO365CheckResourceGroupName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckVirtualNetworkName.
        protected void ProcessRecord_CheckVirtualNetworkName()
        {
            this._logger.name += " -CheckVirtualNetworkName";
            // Invoke graphql operation azureO365CheckVirtualNetworkName
            InvokeQueryAzureO365CheckVirtualNetworkName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365ValidateUserRoles.
        protected void ProcessRecord_ValidateUserRoles()
        {
            this._logger.name += " -ValidateUserRoles";
            // Invoke graphql operation azureO365ValidateUserRoles
            InvokeQueryAzureO365ValidateUserRoles();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckNSGOutboundRules.
        protected void ProcessRecord_CheckNSGOutboundRules()
        {
            this._logger.name += " -CheckNSGOutboundRules";
            // Invoke graphql operation azureO365CheckNSGOutboundRules
            InvokeQueryAzureO365CheckNsgOutboundRules();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckNetworkSubnet.
        protected void ProcessRecord_CheckNetworkSubnet()
        {
            this._logger.name += " -CheckNetworkSubnet";
            // Invoke graphql operation azureO365CheckNetworkSubnet
            InvokeQueryAzureO365CheckNetworkSubnet();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365GetNetworkSubnetUnusedAddr.
        protected void ProcessRecord_GetNetworkSubnetUnusedAddr()
        {
            this._logger.name += " -GetNetworkSubnetUnusedAddr";
            // Invoke graphql operation azureO365GetNetworkSubnetUnusedAddr
            InvokeQueryAzureO365GetNetworkSubnetUnusedAddr();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365GetAzureHostType.
        protected void ProcessRecord_GetAzureHostType()
        {
            this._logger.name += " -GetAzureHostType";
            // Invoke graphql operation azureO365GetAzureHostType
            InvokeQueryAzureO365GetAzureHostType();
        }


        // Invoke GraphQL Query:
        // azureO365Exocompute(orgId: UUID!, exocomputeClusterId: String!): GetAzureO365ExocomputeResp!
        protected void InvokeQueryAzureO365Exocompute()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("exocomputeClusterId", "String!"),
            };
            GetAzureO365ExocomputeResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (GetAzureO365ExocomputeResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (GetAzureO365ExocomputeResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureO365Exocompute(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureO365Exocompute",
                "($orgId: UUID!,$exocomputeClusterId: String!)",
                fieldSpecDoc,
                "GetAzureO365ExocomputeResp"
            );
        }

        // Invoke GraphQL Query:
        // azureO365CheckStorageAccountName(tenantId: String!, subscriptionId: UUID!, storage_account_name: String!): AzureResourceAvailabilityResp!
        protected void InvokeQueryAzureO365CheckStorageAccountName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("storage_account_name", "String!"),
            };
            AzureResourceAvailabilityResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureResourceAvailabilityResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureResourceAvailabilityResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureO365CheckStorageAccountName(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureO365CheckStorageAccountName",
                "($tenantId: String!,$subscriptionId: UUID!,$storage_account_name: String!)",
                fieldSpecDoc,
                "AzureResourceAvailabilityResp"
            );
        }

        // Invoke GraphQL Query:
        // azureO365CheckStorageAccountAccessibility(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     storage_account_name: String!
        //     groupName: String!
        //   ): AzureResourceAvailabilityResp!
        protected void InvokeQueryAzureO365CheckStorageAccountAccessibility()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("storage_account_name", "String!"),
                Tuple.Create("groupName", "String!"),
            };
            AzureResourceAvailabilityResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureResourceAvailabilityResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureResourceAvailabilityResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureO365CheckStorageAccountAccessibility(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureO365CheckStorageAccountAccessibility",
                "($tenantId: String!,$subscriptionId: UUID!,$storage_account_name: String!,$groupName: String!)",
                fieldSpecDoc,
                "AzureResourceAvailabilityResp"
            );
        }

        // Invoke GraphQL Query:
        // azureO365CheckSubscriptionQuota(tenantId: String!, subscriptionId: UUID!, regionName: String!): AzureResourceAvailabilityResp!
        protected void InvokeQueryAzureO365CheckSubscriptionQuota()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            AzureResourceAvailabilityResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureResourceAvailabilityResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureResourceAvailabilityResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureO365CheckSubscriptionQuota(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureO365CheckSubscriptionQuota",
                "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)",
                fieldSpecDoc,
                "AzureResourceAvailabilityResp"
            );
        }

        // Invoke GraphQL Query:
        // azureO365CheckResourceGroupName(tenantId: String!, subscriptionId: UUID!, groupName: String!): AzureResourceAvailabilityResp!
        protected void InvokeQueryAzureO365CheckResourceGroupName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("groupName", "String!"),
            };
            AzureResourceAvailabilityResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureResourceAvailabilityResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureResourceAvailabilityResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureO365CheckResourceGroupName(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureO365CheckResourceGroupName",
                "($tenantId: String!,$subscriptionId: UUID!,$groupName: String!)",
                fieldSpecDoc,
                "AzureResourceAvailabilityResp"
            );
        }

        // Invoke GraphQL Query:
        // azureO365CheckVirtualNetworkName(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     groupName: String!
        //     vnet_name: String!
        //   ): AzureResourceAvailabilityResp!
        protected void InvokeQueryAzureO365CheckVirtualNetworkName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("groupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
            };
            AzureResourceAvailabilityResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureResourceAvailabilityResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureResourceAvailabilityResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureO365CheckVirtualNetworkName(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureO365CheckVirtualNetworkName",
                "($tenantId: String!,$subscriptionId: UUID!,$groupName: String!,$vnet_name: String!)",
                fieldSpecDoc,
                "AzureResourceAvailabilityResp"
            );
        }

        // Invoke GraphQL Query:
        // azureO365ValidateUserRoles(tenantId: String!, subscriptionId: UUID!): AzureUserRoleResp!
        protected void InvokeQueryAzureO365ValidateUserRoles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            AzureUserRoleResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureUserRoleResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureUserRoleResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureO365ValidateUserRoles(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureO365ValidateUserRoles",
                "($tenantId: String!,$subscriptionId: UUID!)",
                fieldSpecDoc,
                "AzureUserRoleResp"
            );
        }

        // Invoke GraphQL Query:
        // azureO365CheckNSGOutboundRules(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //   ): AzureNetworkSecurityGroupResp!
        protected void InvokeQueryAzureO365CheckNsgOutboundRules()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
            };
            AzureNetworkSecurityGroupResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNetworkSecurityGroupResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNetworkSecurityGroupResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureO365CheckNsgOutboundRules(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureO365CheckNsgOutboundRules",
                "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!)",
                fieldSpecDoc,
                "AzureNetworkSecurityGroupResp"
            );
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
        protected void InvokeQueryAzureO365CheckNetworkSubnet()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
                Tuple.Create("strict_addr_check", "Boolean!"),
            };
            AzureNetworkSubnetResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNetworkSubnetResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNetworkSubnetResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureO365CheckNetworkSubnet(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureO365CheckNetworkSubnet",
                "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!,$strict_addr_check: Boolean!)",
                fieldSpecDoc,
                "AzureNetworkSubnetResp"
            );
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
        protected void InvokeQueryAzureO365GetNetworkSubnetUnusedAddr()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
                Tuple.Create("strict_addr_check", "Boolean!"),
            };
            AzureNetworkSubnetUnusedAddrResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNetworkSubnetUnusedAddrResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNetworkSubnetUnusedAddrResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureO365GetNetworkSubnetUnusedAddr(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureO365GetNetworkSubnetUnusedAddr",
                "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!,$strict_addr_check: Boolean!)",
                fieldSpecDoc,
                "AzureNetworkSubnetUnusedAddrResp"
            );
        }

        // Invoke GraphQL Query:
        // azureO365GetAzureHostType: GetAzureHostTypeResp!
        protected void InvokeQueryAzureO365GetAzureHostType()
        {
            Tuple<string, string>[] argDefs = {
            };
            GetAzureHostTypeResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (GetAzureHostTypeResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (GetAzureHostTypeResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureO365GetAzureHostType(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureO365GetAzureHostType",
                "",
                fieldSpecDoc,
                "GetAzureHostTypeResp"
            );
        }


    } // class Invoke_RscQueryAzureO365
}