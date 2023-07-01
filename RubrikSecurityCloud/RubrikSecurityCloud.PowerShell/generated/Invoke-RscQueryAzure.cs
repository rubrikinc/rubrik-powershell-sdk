// Invoke-RscQueryAzure.cs
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
        "RscQueryAzure",
        DefaultParameterSetName = "VNet")
    ]
    public class Invoke_RscQueryAzure : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // NativeRoot parameter set
        //
        // [GraphQL: azureNativeRoot]
        //
        [Parameter(
            ParameterSetName = "NativeRoot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Root of Azure native hierarchy.
[GraphQL: azureNativeRoot]",
            Position = 0
        )]
        public SwitchParameter NativeRoot { get; set; }

        
        // -------------------------------------------------------------------
        // NativeSubscription parameter set
        //
        // [GraphQL: azureNativeSubscription]
        //
        [Parameter(
            ParameterSetName = "NativeSubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure Native Subscription. Refers to the logical entity that provides entitlement to deploy and consume Azure resources.
[GraphQL: azureNativeSubscription]",
            Position = 0
        )]
        public SwitchParameter NativeSubscription { get; set; }

        
        // -------------------------------------------------------------------
        // NativeResourceGroup parameter set
        //
        // [GraphQL: azureNativeResourceGroup]
        //
        [Parameter(
            ParameterSetName = "NativeResourceGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure Native Resource Group. Refers to a collection of resources in which multiple Azure services can reside.
[GraphQL: azureNativeResourceGroup]",
            Position = 0
        )]
        public SwitchParameter NativeResourceGroup { get; set; }

        
        // -------------------------------------------------------------------
        // NativeVirtualMachine parameter set
        //
        // [GraphQL: azureNativeVirtualMachine]
        //
        [Parameter(
            ParameterSetName = "NativeVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure Virtual Machine that refers to the Azure infrastructure as a service (IaaS) used to deploy persistent VMs. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/.
[GraphQL: azureNativeVirtualMachine]",
            Position = 0
        )]
        public SwitchParameter NativeVirtualMachine { get; set; }

        
        // -------------------------------------------------------------------
        // NativeManagedDisk parameter set
        //
        // [GraphQL: azureNativeManagedDisk]
        //
        [Parameter(
            ParameterSetName = "NativeManagedDisk",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure Native Managed Disk that refers to the block storage designed to be used with Azure Virtual Machines. Some examples are: ultra disks, premium solid-state drives (SSD), standard SSDs, and standard hard disk drives (HDD). For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/managed-disks-overview.
[GraphQL: azureNativeManagedDisk]",
            Position = 0
        )]
        public SwitchParameter NativeManagedDisk { get; set; }

        
        // -------------------------------------------------------------------
        // AllNativeVirtualNetwork parameter set
        //
        // [GraphQL: allAzureNativeVirtualNetworks]
        //
        [Parameter(
            ParameterSetName = "AllNativeVirtualNetwork",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all virtual networks (VNets) in the protected subscriptions. VNet enables secure communication with other VNets, the internet, and on-premise networks. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/virtual-networks-overview.
[GraphQL: allAzureNativeVirtualNetworks]",
            Position = 0
        )]
        public SwitchParameter AllNativeVirtualNetwork { get; set; }

        
        // -------------------------------------------------------------------
        // AllNativeSubnetsByRegionFromAzure parameter set
        //
        // [GraphQL: allAzureNativeSubnetsByRegionFromAzure]
        //
        [Parameter(
            ParameterSetName = "AllNativeSubnetsByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.
[GraphQL: allAzureNativeSubnetsByRegionFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllNativeSubnetsByRegionFromAzure { get; set; }

        
        // -------------------------------------------------------------------
        // AllNativeSecurityGroupsByRegionFromAzure parameter set
        //
        // [GraphQL: allAzureNativeSecurityGroupsByRegionFromAzure]
        //
        [Parameter(
            ParameterSetName = "AllNativeSecurityGroupsByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all security groups in the specified region and subscription. Security groups enable you to configure network security as a natural extension of an application's structure, allowing you to group virtual machines and define network security policies based on those groups. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/application-security-groups.
[GraphQL: allAzureNativeSecurityGroupsByRegionFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllNativeSecurityGroupsByRegionFromAzure { get; set; }

        
        // -------------------------------------------------------------------
        // AllDiskEncryptionSetsByRegion parameter set
        //
        // [GraphQL: allAzureDiskEncryptionSetsByRegion]
        //
        [Parameter(
            ParameterSetName = "AllDiskEncryptionSetsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Azure Disk Encryption Sets in a region.
[GraphQL: allAzureDiskEncryptionSetsByRegion]",
            Position = 0
        )]
        public SwitchParameter AllDiskEncryptionSetsByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // AllNativeAvailabilitySetsByRegionFromAzure parameter set
        //
        // [GraphQL: allAzureNativeAvailabilitySetsByRegionFromAzure]
        //
        [Parameter(
            ParameterSetName = "AllNativeAvailabilitySetsByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all availability sets in the specified region, resource group, and subscription. An availability set is a logical grouping of VMs to facilitate redundancy and availability. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/availability-set-overview.
[GraphQL: allAzureNativeAvailabilitySetsByRegionFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllNativeAvailabilitySetsByRegionFromAzure { get; set; }

        
        // -------------------------------------------------------------------
        // AllNativeExportCompatibleVmSizesByRegionFromAzure parameter set
        //
        // [GraphQL: allAzureNativeExportCompatibleVmSizesByRegionFromAzure]
        //
        [Parameter(
            ParameterSetName = "AllNativeExportCompatibleVmSizesByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all supported virtual machine (VM) sizes when exporting a particular snapshot. Not all VM sizes are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.
[GraphQL: allAzureNativeExportCompatibleVmSizesByRegionFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllNativeExportCompatibleVmSizesByRegionFromAzure { get; set; }

        
        // -------------------------------------------------------------------
        // AllNativeExportCompatibleDiskTypesByRegionFromAzure parameter set
        //
        // [GraphQL: allAzureNativeExportCompatibleDiskTypesByRegionFromAzure]
        //
        [Parameter(
            ParameterSetName = "AllNativeExportCompatibleDiskTypesByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all supported disk types when exporting a specific snapshot. Not all disk types are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/disks-types.
[GraphQL: allAzureNativeExportCompatibleDiskTypesByRegionFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllNativeExportCompatibleDiskTypesByRegionFromAzure { get; set; }

        
        // -------------------------------------------------------------------
        // AllNativeVirtualMachineSize parameter set
        //
        // [GraphQL: allAzureNativeVirtualMachineSizes]
        //
        [Parameter(
            ParameterSetName = "AllNativeVirtualMachineSize",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all virtual machine (VM) sizes in the subscriptions protected by Rubrik that have been configured for protection. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.
[GraphQL: allAzureNativeVirtualMachineSizes]",
            Position = 0
        )]
        public SwitchParameter AllNativeVirtualMachineSize { get; set; }

        
        // -------------------------------------------------------------------
        // IsNativeManagedDiskSnapshotRestorable parameter set
        //
        // [GraphQL: isAzureNativeManagedDiskSnapshotRestorable]
        //
        [Parameter(
            ParameterSetName = "IsNativeManagedDiskSnapshotRestorable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether the Managed Disk snapshot is restorable or not. A managed disk is restorable when the restore settings of the Managed Disk are configured on the Azure portal and on the Rubrik platform. When the value is true, the managed disk snapshot is restorable.
[GraphQL: isAzureNativeManagedDiskSnapshotRestorable]",
            Position = 0
        )]
        public SwitchParameter IsNativeManagedDiskSnapshotRestorable { get; set; }

        
        // -------------------------------------------------------------------
        // IsStorageAccountNameAvailable parameter set
        //
        // [GraphQL: isAzureStorageAccountNameAvailable]
        //
        [Parameter(
            ParameterSetName = "IsStorageAccountNameAvailable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether the given storage account name is valid and available in Azure to be assigned to a new storage account. When the value is true, the specified account name is available in Azure.
[GraphQL: isAzureStorageAccountNameAvailable]",
            Position = 0
        )]
        public SwitchParameter IsStorageAccountNameAvailable { get; set; }

        
        // -------------------------------------------------------------------
        // AllNativeStorageAccountsFromAzure parameter set
        //
        // [GraphQL: allAzureNativeStorageAccountsFromAzure]
        //
        [Parameter(
            ParameterSetName = "AllNativeStorageAccountsFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves list of all storage Accounts in a subscription.
[GraphQL: allAzureNativeStorageAccountsFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllNativeStorageAccountsFromAzure { get; set; }

        
        // -------------------------------------------------------------------
        // SqlDatabase parameter set
        //
        // [GraphQL: azureSqlDatabase]
        //
        [Parameter(
            ParameterSetName = "SqlDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure SQL Database. Refers to the fully managed SQL database built for the cloud. For more information, see https://azure.microsoft.com/en-us/products/azure-sql/database/.
[GraphQL: azureSqlDatabase]",
            Position = 0
        )]
        public SwitchParameter SqlDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // SqlDatabaseServer parameter set
        //
        // [GraphQL: azureSqlDatabaseServer]
        //
        [Parameter(
            ParameterSetName = "SqlDatabaseServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure SQL Database Server. Refers to the server that contains the Azure SQL Databases. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/logical-servers.
[GraphQL: azureSqlDatabaseServer]",
            Position = 0
        )]
        public SwitchParameter SqlDatabaseServer { get; set; }

        
        // -------------------------------------------------------------------
        // SqlManagedInstanceDatabase parameter set
        //
        // [GraphQL: azureSqlManagedInstanceDatabase]
        //
        [Parameter(
            ParameterSetName = "SqlManagedInstanceDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure SQL Managed Instance Database. Refers to the database engine compatible with the latest SQL Server (Enterprise Edition) database engine. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/sql-managed-instance-paas-overview.
[GraphQL: azureSqlManagedInstanceDatabase]",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // SqlManagedInstanceServer parameter set
        //
        // [GraphQL: azureSqlManagedInstanceServer]
        //
        [Parameter(
            ParameterSetName = "SqlManagedInstanceServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure SQL Managed Instance Server. Refers to the server the Azure SQL Managed Instance Database is a part of.
[GraphQL: azureSqlManagedInstanceServer]",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceServer { get; set; }

        
        // -------------------------------------------------------------------
        // SqlDatabaseDbPointInTimeRestoreWindowFromAzure parameter set
        //
        // [GraphQL: azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure]
        //
        [Parameter(
            ParameterSetName = "SqlDatabaseDbPointInTimeRestoreWindowFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Point-in-Time (PiT) restore window of the Azure SQL Database instance in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://azure.microsoft.com/en-in/blog/azure-sql-database-point-in-time-restore/.
[GraphQL: azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure]",
            Position = 0
        )]
        public SwitchParameter SqlDatabaseDbPointInTimeRestoreWindowFromAzure { get; set; }

        
        // -------------------------------------------------------------------
        // SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure parameter set
        //
        // [GraphQL: azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure]
        //
        [Parameter(
            ParameterSetName = "SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Point-in-Time (PiT) restore window of the Azure SQL Managed Instance database in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/point-in-time-restore?tabs=azure-portal.
[GraphQL: azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure]",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure { get; set; }

        
        // -------------------------------------------------------------------
        // ValidateNativeSqlDatabaseDbNameForExport parameter set
        //
        // [GraphQL: validateAzureNativeSqlDatabaseDbNameForExport]
        //
        [Parameter(
            ParameterSetName = "ValidateNativeSqlDatabaseDbNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates the name used for an Sql Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.
[GraphQL: validateAzureNativeSqlDatabaseDbNameForExport]",
            Position = 0
        )]
        public SwitchParameter ValidateNativeSqlDatabaseDbNameForExport { get; set; }

        
        // -------------------------------------------------------------------
        // ValidateNativeSqlManagedInstanceDbNameForExport parameter set
        //
        // [GraphQL: validateAzureNativeSqlManagedInstanceDbNameForExport]
        //
        [Parameter(
            ParameterSetName = "ValidateNativeSqlManagedInstanceDbNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates the name used for an Managed Instance Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.
[GraphQL: validateAzureNativeSqlManagedInstanceDbNameForExport]",
            Position = 0
        )]
        public SwitchParameter ValidateNativeSqlManagedInstanceDbNameForExport { get; set; }

        
        // -------------------------------------------------------------------
        // AllSqlDatabaseServerElasticPool parameter set
        //
        // [GraphQL: allAzureSqlDatabaseServerElasticPools]
        //
        [Parameter(
            ParameterSetName = "AllSqlDatabaseServerElasticPool",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the list of elastic pools available for a SQL Database Server.For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/elastic-pool-overview.
[GraphQL: allAzureSqlDatabaseServerElasticPools]",
            Position = 0
        )]
        public SwitchParameter AllSqlDatabaseServerElasticPool { get; set; }

        
        // -------------------------------------------------------------------
        // IsNativeSqlDatabaseSnapshotPersistent parameter set
        //
        // [GraphQL: isAzureNativeSqlDatabaseSnapshotPersistent]
        //
        [Parameter(
            ParameterSetName = "IsNativeSqlDatabaseSnapshotPersistent",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks if an Azure SQL Database Snapshot or an Azure SQL Managed Instance Database Snapshot is a persistent snapshot.
[GraphQL: isAzureNativeSqlDatabaseSnapshotPersistent]",
            Position = 0
        )]
        public SwitchParameter IsNativeSqlDatabaseSnapshotPersistent { get; set; }

        
        // -------------------------------------------------------------------
        // AllKeyVaultsByRegion parameter set
        //
        // [GraphQL: allAzureKeyVaultsByRegion]
        //
        [Parameter(
            ParameterSetName = "AllKeyVaultsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Azure Key Vaults in a region.
[GraphQL: allAzureKeyVaultsByRegion]",
            Position = 0
        )]
        public SwitchParameter AllKeyVaultsByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // AllEncryptionKey parameter set
        //
        // [GraphQL: allAzureEncryptionKeys]
        //
        [Parameter(
            ParameterSetName = "AllEncryptionKey",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Encryption Keys in an Azure Key Vault.
[GraphQL: allAzureEncryptionKeys]",
            Position = 0
        )]
        public SwitchParameter AllEncryptionKey { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountTenant parameter set
        //
        // [GraphQL: azureCloudAccountTenant]
        //
        [Parameter(
            ParameterSetName = "CloudAccountTenant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the details of the Azure tenant and all the subscriptions of the tenant, for a feature.
[GraphQL: azureCloudAccountTenant]",
            Position = 0
        )]
        public SwitchParameter CloudAccountTenant { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountTenantWithExoConfig parameter set
        //
        // [GraphQL: azureCloudAccountTenantWithExoConfigs]
        //
        [Parameter(
            ParameterSetName = "CloudAccountTenantWithExoConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves details about the Azure cloud account tenant including the Exocompute configurations for the tenant subscriptions, for a specified feature.
[GraphQL: azureCloudAccountTenantWithExoConfigs]",
            Position = 0
        )]
        public SwitchParameter CloudAccountTenantWithExoConfig { get; set; }

        
        // -------------------------------------------------------------------
        // AllCloudAccountTenantsWithExoConfig parameter set
        //
        // [GraphQL: allAzureCloudAccountTenantsWithExoConfigs]
        //
        [Parameter(
            ParameterSetName = "AllCloudAccountTenantsWithExoConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves details about all the Azure cloud account tenants including the Exocompute configurations for the tenant subscriptions, for specified set of features.
[GraphQL: allAzureCloudAccountTenantsWithExoConfigs]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountTenantsWithExoConfig { get; set; }

        
        // -------------------------------------------------------------------
        // AllCloudAccountTenant parameter set
        //
        // [GraphQL: allAzureCloudAccountTenants]
        //
        [Parameter(
            ParameterSetName = "AllCloudAccountTenant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of all the Azure tenants and tenant subscriptions for features. The list can be filtered by feature status, subscription native ID, and subscription name.
[GraphQL: allAzureCloudAccountTenants]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountTenant { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountSubscriptionWithFeature parameter set
        //
        // [GraphQL: azureCloudAccountSubscriptionWithFeatures]
        //
        [Parameter(
            ParameterSetName = "CloudAccountSubscriptionWithFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the details of the Azure cloud account.
[GraphQL: azureCloudAccountSubscriptionWithFeatures]",
            Position = 0
        )]
        public SwitchParameter CloudAccountSubscriptionWithFeature { get; set; }

        
        // -------------------------------------------------------------------
        // AllCloudAccountSubscriptionsByFeature parameter set
        //
        // [GraphQL: allAzureCloudAccountSubscriptionsByFeature]
        //
        [Parameter(
            ParameterSetName = "AllCloudAccountSubscriptionsByFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of all Azure Subscriptions with feature details such as feature, status, and regions.
[GraphQL: allAzureCloudAccountSubscriptionsByFeature]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountSubscriptionsByFeature { get; set; }

        
        // -------------------------------------------------------------------
        // AllSubscriptionWithExocomputeMapping parameter set
        //
        // [GraphQL: allAzureSubscriptionWithExocomputeMappings]
        //
        [Parameter(
            ParameterSetName = "AllSubscriptionWithExocomputeMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of all Azure subscriptions with Exocompute subscription mapping.
[GraphQL: allAzureSubscriptionWithExocomputeMappings]",
            Position = 0
        )]
        public SwitchParameter AllSubscriptionWithExocomputeMapping { get; set; }

        
        // -------------------------------------------------------------------
        // AllResourceGroupsFrom parameter set
        //
        // [GraphQL: allResourceGroupsFromAzure]
        //
        [Parameter(
            ParameterSetName = "AllResourceGroupsFrom",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list og all resource groups in the specified account.
[GraphQL: allResourceGroupsFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllResourceGroupsFrom { get; set; }

        
        // -------------------------------------------------------------------
        // DoesNativeResourceGroupExist parameter set
        //
        // [GraphQL: doesAzureNativeResourceGroupExist]
        //
        [Parameter(
            ParameterSetName = "DoesNativeResourceGroupExist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks if a resource group with the specified name exists in the specified account.
[GraphQL: doesAzureNativeResourceGroupExist]",
            Position = 0
        )]
        public SwitchParameter DoesNativeResourceGroupExist { get; set; }

        
        // -------------------------------------------------------------------
        // AllNativeResourceGroupsInfoIfExist parameter set
        //
        // [GraphQL: allAzureNativeResourceGroupsInfoIfExist]
        //
        [Parameter(
            ParameterSetName = "AllNativeResourceGroupsInfoIfExist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of resource groups with the specified names which exist in the specified account.
[GraphQL: allAzureNativeResourceGroupsInfoIfExist]",
            Position = 0
        )]
        public SwitchParameter AllNativeResourceGroupsInfoIfExist { get; set; }

        
        // -------------------------------------------------------------------
        // AllCloudAccountMissingPermission parameter set
        //
        // [GraphQL: allAzureCloudAccountMissingPermissions]
        //
        [Parameter(
            ParameterSetName = "AllCloudAccountMissingPermission",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of all the missing permissions on Azure subscriptions that are a part of the Azure Cloud Account.
[GraphQL: allAzureCloudAccountMissingPermissions]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountMissingPermission { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountPermissionConfig parameter set
        //
        // [GraphQL: azureCloudAccountPermissionConfig]
        //
        [Parameter(
            ParameterSetName = "CloudAccountPermissionConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the configuration consisting of role permissions and feature policy version required for Azure subscription setup. Features refer to the Polaris features that the customer wants to be enabled on the cloud account.
[GraphQL: azureCloudAccountPermissionConfig]",
            Position = 0
        )]
        public SwitchParameter CloudAccountPermissionConfig { get; set; }

        
        // -------------------------------------------------------------------
        // AllExocomputeConfigsInAccount parameter set
        //
        // [GraphQL: allAzureExocomputeConfigsInAccount]
        //
        [Parameter(
            ParameterSetName = "AllExocomputeConfigsInAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of Azure Exocompute configurations filtered by a cloud account ID or a search query.
[GraphQL: allAzureExocomputeConfigsInAccount]",
            Position = 0
        )]
        public SwitchParameter AllExocomputeConfigsInAccount { get; set; }

        
        // -------------------------------------------------------------------
        // AllCloudAccountSubnetsByRegion parameter set
        //
        // [GraphQL: allAzureCloudAccountSubnetsByRegion]
        //
        [Parameter(
            ParameterSetName = "AllCloudAccountSubnetsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.
[GraphQL: allAzureCloudAccountSubnetsByRegion]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountSubnetsByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // ValidateCloudAccountExocomputeConfiguration parameter set
        //
        // [GraphQL: validateAzureCloudAccountExocomputeConfigurations]
        //
        [Parameter(
            ParameterSetName = "ValidateCloudAccountExocomputeConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates if Azure subnets are correctly configured for running Azure Kubernetes Service (AKS) Clusters. When correctly configured, the Azure subnets allow the required region-specific outbound connectivity and do not overlap with Azure restricted IP Address Space.
[GraphQL: validateAzureCloudAccountExocomputeConfigurations]",
            Position = 0
        )]
        public SwitchParameter ValidateCloudAccountExocomputeConfiguration { get; set; }

        
        // -------------------------------------------------------------------
        // AllArmTemplatesByFeature parameter set
        //
        // [GraphQL: allAzureArmTemplatesByFeature]
        //
        [Parameter(
            ParameterSetName = "AllArmTemplatesByFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve ARM templates for role definition and role assignment.
[GraphQL: allAzureArmTemplatesByFeature]",
            Position = 0
        )]
        public SwitchParameter AllArmTemplatesByFeature { get; set; }

        
        // -------------------------------------------------------------------
        // Subscription parameter set
        //
        // [GraphQL: azureSubscriptions]
        //
        [Parameter(
            ParameterSetName = "Subscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the subscriptions for the given Azure tenant.
[GraphQL: azureSubscriptions]",
            Position = 0
        )]
        public SwitchParameter Subscription { get; set; }

        
        // -------------------------------------------------------------------
        // Region parameter set
        //
        // [GraphQL: azureRegions]
        //
        [Parameter(
            ParameterSetName = "Region",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the Azure regions for the given subscription.
[GraphQL: azureRegions]",
            Position = 0
        )]
        public SwitchParameter Region { get; set; }

        
        // -------------------------------------------------------------------
        // ResourceGroup parameter set
        //
        // [GraphQL: azureResourceGroups]
        //
        [Parameter(
            ParameterSetName = "ResourceGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the Azure resource groups for the given subscription.
[GraphQL: azureResourceGroups]",
            Position = 0
        )]
        public SwitchParameter ResourceGroup { get; set; }

        
        // -------------------------------------------------------------------
        // VNet parameter set
        //
        // [GraphQL: azureVNets]
        //
        [Parameter(
            ParameterSetName = "VNet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the VNets for the given subscription.
[GraphQL: azureVNets]",
            Position = 0
        )]
        public SwitchParameter VNet { get; set; }

        
        // -------------------------------------------------------------------
        // Subnet parameter set
        //
        // [GraphQL: azureSubnets]
        //
        [Parameter(
            ParameterSetName = "Subnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the subnets for the given subscription.
[GraphQL: azureSubnets]",
            Position = 0
        )]
        public SwitchParameter Subnet { get; set; }

        
        // -------------------------------------------------------------------
        // StorageAccount parameter set
        //
        // [GraphQL: azureStorageAccounts]
        //
        [Parameter(
            ParameterSetName = "StorageAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the storage accounts for the given subscription.
[GraphQL: azureStorageAccounts]",
            Position = 0
        )]
        public SwitchParameter StorageAccount { get; set; }

        
        // -------------------------------------------------------------------
        // AllHostedRegion parameter set
        //
        // [GraphQL: allHostedAzureRegions]
        //
        [Parameter(
            ParameterSetName = "AllHostedRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Lists all Azure regions supported by the Rubrik-Hosted SaaS protection.
[GraphQL: allHostedAzureRegions]",
            Position = 0
        )]
        public SwitchParameter AllHostedRegion { get; set; }

        
        // -------------------------------------------------------------------
        // AllResourceGroup parameter set
        //
        // [GraphQL: allAzureResourceGroups]
        //
        [Parameter(
            ParameterSetName = "AllResourceGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get resource groups for a service principal in Azure.
[GraphQL: allAzureResourceGroups]",
            Position = 0
        )]
        public SwitchParameter AllResourceGroup { get; set; }

        
        // -------------------------------------------------------------------
        // AllVnet parameter set
        //
        // [GraphQL: allAzureVnets]
        //
        [Parameter(
            ParameterSetName = "AllVnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get VNets for a given account in Azure.
[GraphQL: allAzureVnets]",
            Position = 0
        )]
        public SwitchParameter AllVnet { get; set; }

        
        // -------------------------------------------------------------------
        // AllSubnet parameter set
        //
        // [GraphQL: allAzureSubnets]
        //
        [Parameter(
            ParameterSetName = "AllSubnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get subnets for a given account in Azure.
[GraphQL: allAzureSubnets]",
            Position = 0
        )]
        public SwitchParameter AllSubnet { get; set; }

        
        // -------------------------------------------------------------------
        // AllCdmVersion parameter set
        //
        // [GraphQL: allAzureCdmVersions]
        //
        [Parameter(
            ParameterSetName = "AllCdmVersion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all Rubrik CDM versions in the Azure marketplace.
[GraphQL: allAzureCdmVersions]",
            Position = 0
        )]
        public SwitchParameter AllCdmVersion { get; set; }

        
        // -------------------------------------------------------------------
        // AllRegion parameter set
        //
        // [GraphQL: allAzureRegions]
        //
        [Parameter(
            ParameterSetName = "AllRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all available regions for Azure.
[GraphQL: allAzureRegions]",
            Position = 0
        )]
        public SwitchParameter AllRegion { get; set; }

        
        // -------------------------------------------------------------------
        // AllNsg parameter set
        //
        // [GraphQL: allAzureNsgs]
        //
        [Parameter(
            ParameterSetName = "AllNsg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all available network security groups for Azure.
[GraphQL: allAzureNsgs]",
            Position = 0
        )]
        public SwitchParameter AllNsg { get; set; }

        
        // -------------------------------------------------------------------
        // AllStorageAccount parameter set
        //
        // [GraphQL: allAzureStorageAccounts]
        //
        [Parameter(
            ParameterSetName = "AllStorageAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List all storage accounts from Azure.
[GraphQL: allAzureStorageAccounts]",
            Position = 0
        )]
        public SwitchParameter AllStorageAccount { get; set; }

        
        // -------------------------------------------------------------------
        // AdDirectorie parameter set
        //
        // [GraphQL: azureAdDirectories]
        //
        [Parameter(
            ParameterSetName = "AdDirectorie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All Azure AD directories for the account.
[GraphQL: azureAdDirectories]",
            Position = 0
        )]
        public SwitchParameter AdDirectorie { get; set; }

        
        // -------------------------------------------------------------------
        // AdDirectory parameter set
        //
        // [GraphQL: azureAdDirectory]
        //
        [Parameter(
            ParameterSetName = "AdDirectory",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the Azure AD corresponds to the workload ID.
[GraphQL: azureAdDirectory]",
            Position = 0
        )]
        public SwitchParameter AdDirectory { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "NativeRoot":
                        this.ProcessRecord_NativeRoot();
                        break;
                    case "NativeSubscription":
                        this.ProcessRecord_NativeSubscription();
                        break;
                    case "NativeResourceGroup":
                        this.ProcessRecord_NativeResourceGroup();
                        break;
                    case "NativeVirtualMachine":
                        this.ProcessRecord_NativeVirtualMachine();
                        break;
                    case "NativeManagedDisk":
                        this.ProcessRecord_NativeManagedDisk();
                        break;
                    case "AllNativeVirtualNetwork":
                        this.ProcessRecord_AllNativeVirtualNetwork();
                        break;
                    case "AllNativeSubnetsByRegionFromAzure":
                        this.ProcessRecord_AllNativeSubnetsByRegionFromAzure();
                        break;
                    case "AllNativeSecurityGroupsByRegionFromAzure":
                        this.ProcessRecord_AllNativeSecurityGroupsByRegionFromAzure();
                        break;
                    case "AllDiskEncryptionSetsByRegion":
                        this.ProcessRecord_AllDiskEncryptionSetsByRegion();
                        break;
                    case "AllNativeAvailabilitySetsByRegionFromAzure":
                        this.ProcessRecord_AllNativeAvailabilitySetsByRegionFromAzure();
                        break;
                    case "AllNativeExportCompatibleVmSizesByRegionFromAzure":
                        this.ProcessRecord_AllNativeExportCompatibleVmSizesByRegionFromAzure();
                        break;
                    case "AllNativeExportCompatibleDiskTypesByRegionFromAzure":
                        this.ProcessRecord_AllNativeExportCompatibleDiskTypesByRegionFromAzure();
                        break;
                    case "AllNativeVirtualMachineSize":
                        this.ProcessRecord_AllNativeVirtualMachineSize();
                        break;
                    case "IsNativeManagedDiskSnapshotRestorable":
                        this.ProcessRecord_IsNativeManagedDiskSnapshotRestorable();
                        break;
                    case "IsStorageAccountNameAvailable":
                        this.ProcessRecord_IsStorageAccountNameAvailable();
                        break;
                    case "AllNativeStorageAccountsFromAzure":
                        this.ProcessRecord_AllNativeStorageAccountsFromAzure();
                        break;
                    case "SqlDatabase":
                        this.ProcessRecord_SqlDatabase();
                        break;
                    case "SqlDatabaseServer":
                        this.ProcessRecord_SqlDatabaseServer();
                        break;
                    case "SqlManagedInstanceDatabase":
                        this.ProcessRecord_SqlManagedInstanceDatabase();
                        break;
                    case "SqlManagedInstanceServer":
                        this.ProcessRecord_SqlManagedInstanceServer();
                        break;
                    case "SqlDatabaseDbPointInTimeRestoreWindowFromAzure":
                        this.ProcessRecord_SqlDatabaseDbPointInTimeRestoreWindowFromAzure();
                        break;
                    case "SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure":
                        this.ProcessRecord_SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure();
                        break;
                    case "ValidateNativeSqlDatabaseDbNameForExport":
                        this.ProcessRecord_ValidateNativeSqlDatabaseDbNameForExport();
                        break;
                    case "ValidateNativeSqlManagedInstanceDbNameForExport":
                        this.ProcessRecord_ValidateNativeSqlManagedInstanceDbNameForExport();
                        break;
                    case "AllSqlDatabaseServerElasticPool":
                        this.ProcessRecord_AllSqlDatabaseServerElasticPool();
                        break;
                    case "IsNativeSqlDatabaseSnapshotPersistent":
                        this.ProcessRecord_IsNativeSqlDatabaseSnapshotPersistent();
                        break;
                    case "AllKeyVaultsByRegion":
                        this.ProcessRecord_AllKeyVaultsByRegion();
                        break;
                    case "AllEncryptionKey":
                        this.ProcessRecord_AllEncryptionKey();
                        break;
                    case "CloudAccountTenant":
                        this.ProcessRecord_CloudAccountTenant();
                        break;
                    case "CloudAccountTenantWithExoConfig":
                        this.ProcessRecord_CloudAccountTenantWithExoConfig();
                        break;
                    case "AllCloudAccountTenantsWithExoConfig":
                        this.ProcessRecord_AllCloudAccountTenantsWithExoConfig();
                        break;
                    case "AllCloudAccountTenant":
                        this.ProcessRecord_AllCloudAccountTenant();
                        break;
                    case "CloudAccountSubscriptionWithFeature":
                        this.ProcessRecord_CloudAccountSubscriptionWithFeature();
                        break;
                    case "AllCloudAccountSubscriptionsByFeature":
                        this.ProcessRecord_AllCloudAccountSubscriptionsByFeature();
                        break;
                    case "AllSubscriptionWithExocomputeMapping":
                        this.ProcessRecord_AllSubscriptionWithExocomputeMapping();
                        break;
                    case "AllResourceGroupsFrom":
                        this.ProcessRecord_AllResourceGroupsFrom();
                        break;
                    case "DoesNativeResourceGroupExist":
                        this.ProcessRecord_DoesNativeResourceGroupExist();
                        break;
                    case "AllNativeResourceGroupsInfoIfExist":
                        this.ProcessRecord_AllNativeResourceGroupsInfoIfExist();
                        break;
                    case "AllCloudAccountMissingPermission":
                        this.ProcessRecord_AllCloudAccountMissingPermission();
                        break;
                    case "CloudAccountPermissionConfig":
                        this.ProcessRecord_CloudAccountPermissionConfig();
                        break;
                    case "AllExocomputeConfigsInAccount":
                        this.ProcessRecord_AllExocomputeConfigsInAccount();
                        break;
                    case "AllCloudAccountSubnetsByRegion":
                        this.ProcessRecord_AllCloudAccountSubnetsByRegion();
                        break;
                    case "ValidateCloudAccountExocomputeConfiguration":
                        this.ProcessRecord_ValidateCloudAccountExocomputeConfiguration();
                        break;
                    case "AllArmTemplatesByFeature":
                        this.ProcessRecord_AllArmTemplatesByFeature();
                        break;
                    case "Subscription":
                        this.ProcessRecord_Subscription();
                        break;
                    case "Region":
                        this.ProcessRecord_Region();
                        break;
                    case "ResourceGroup":
                        this.ProcessRecord_ResourceGroup();
                        break;
                    case "VNet":
                        this.ProcessRecord_VNet();
                        break;
                    case "Subnet":
                        this.ProcessRecord_Subnet();
                        break;
                    case "StorageAccount":
                        this.ProcessRecord_StorageAccount();
                        break;
                    case "AllHostedRegion":
                        this.ProcessRecord_AllHostedRegion();
                        break;
                    case "AllResourceGroup":
                        this.ProcessRecord_AllResourceGroup();
                        break;
                    case "AllVnet":
                        this.ProcessRecord_AllVnet();
                        break;
                    case "AllSubnet":
                        this.ProcessRecord_AllSubnet();
                        break;
                    case "AllCdmVersion":
                        this.ProcessRecord_AllCdmVersion();
                        break;
                    case "AllRegion":
                        this.ProcessRecord_AllRegion();
                        break;
                    case "AllNsg":
                        this.ProcessRecord_AllNsg();
                        break;
                    case "AllStorageAccount":
                        this.ProcessRecord_AllStorageAccount();
                        break;
                    case "AdDirectorie":
                        this.ProcessRecord_AdDirectorie();
                        break;
                    case "AdDirectory":
                        this.ProcessRecord_AdDirectory();
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
        // azureNativeRoot.
        protected void ProcessRecord_NativeRoot()
        {
            this._logger.name += " -NativeRoot";
            // Invoke graphql operation azureNativeRoot
            InvokeQueryAzureNativeRoot();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeSubscription.
        protected void ProcessRecord_NativeSubscription()
        {
            this._logger.name += " -NativeSubscription";
            // Invoke graphql operation azureNativeSubscription
            InvokeQueryAzureNativeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeResourceGroup.
        protected void ProcessRecord_NativeResourceGroup()
        {
            this._logger.name += " -NativeResourceGroup";
            // Invoke graphql operation azureNativeResourceGroup
            InvokeQueryAzureNativeResourceGroup();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeVirtualMachine.
        protected void ProcessRecord_NativeVirtualMachine()
        {
            this._logger.name += " -NativeVirtualMachine";
            // Invoke graphql operation azureNativeVirtualMachine
            InvokeQueryAzureNativeVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeManagedDisk.
        protected void ProcessRecord_NativeManagedDisk()
        {
            this._logger.name += " -NativeManagedDisk";
            // Invoke graphql operation azureNativeManagedDisk
            InvokeQueryAzureNativeManagedDisk();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeVirtualNetworks.
        protected void ProcessRecord_AllNativeVirtualNetwork()
        {
            this._logger.name += " -AllNativeVirtualNetwork";
            // Invoke graphql operation allAzureNativeVirtualNetworks
            InvokeQueryAllAzureNativeVirtualNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeSubnetsByRegionFromAzure.
        protected void ProcessRecord_AllNativeSubnetsByRegionFromAzure()
        {
            this._logger.name += " -AllNativeSubnetsByRegionFromAzure";
            // Invoke graphql operation allAzureNativeSubnetsByRegionFromAzure
            InvokeQueryAllAzureNativeSubnetsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeSecurityGroupsByRegionFromAzure.
        protected void ProcessRecord_AllNativeSecurityGroupsByRegionFromAzure()
        {
            this._logger.name += " -AllNativeSecurityGroupsByRegionFromAzure";
            // Invoke graphql operation allAzureNativeSecurityGroupsByRegionFromAzure
            InvokeQueryAllAzureNativeSecurityGroupsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureDiskEncryptionSetsByRegion.
        protected void ProcessRecord_AllDiskEncryptionSetsByRegion()
        {
            this._logger.name += " -AllDiskEncryptionSetsByRegion";
            // Invoke graphql operation allAzureDiskEncryptionSetsByRegion
            InvokeQueryAllAzureDiskEncryptionSetsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeAvailabilitySetsByRegionFromAzure.
        protected void ProcessRecord_AllNativeAvailabilitySetsByRegionFromAzure()
        {
            this._logger.name += " -AllNativeAvailabilitySetsByRegionFromAzure";
            // Invoke graphql operation allAzureNativeAvailabilitySetsByRegionFromAzure
            InvokeQueryAllAzureNativeAvailabilitySetsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeExportCompatibleVmSizesByRegionFromAzure.
        protected void ProcessRecord_AllNativeExportCompatibleVmSizesByRegionFromAzure()
        {
            this._logger.name += " -AllNativeExportCompatibleVmSizesByRegionFromAzure";
            // Invoke graphql operation allAzureNativeExportCompatibleVmSizesByRegionFromAzure
            InvokeQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeExportCompatibleDiskTypesByRegionFromAzure.
        protected void ProcessRecord_AllNativeExportCompatibleDiskTypesByRegionFromAzure()
        {
            this._logger.name += " -AllNativeExportCompatibleDiskTypesByRegionFromAzure";
            // Invoke graphql operation allAzureNativeExportCompatibleDiskTypesByRegionFromAzure
            InvokeQueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeVirtualMachineSizes.
        protected void ProcessRecord_AllNativeVirtualMachineSize()
        {
            this._logger.name += " -AllNativeVirtualMachineSize";
            // Invoke graphql operation allAzureNativeVirtualMachineSizes
            InvokeQueryAllAzureNativeVirtualMachineSizes();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureNativeManagedDiskSnapshotRestorable.
        protected void ProcessRecord_IsNativeManagedDiskSnapshotRestorable()
        {
            this._logger.name += " -IsNativeManagedDiskSnapshotRestorable";
            // Invoke graphql operation isAzureNativeManagedDiskSnapshotRestorable
            InvokeQueryIsAzureNativeManagedDiskSnapshotRestorable();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureStorageAccountNameAvailable.
        protected void ProcessRecord_IsStorageAccountNameAvailable()
        {
            this._logger.name += " -IsStorageAccountNameAvailable";
            // Invoke graphql operation isAzureStorageAccountNameAvailable
            InvokeQueryIsAzureStorageAccountNameAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeStorageAccountsFromAzure.
        protected void ProcessRecord_AllNativeStorageAccountsFromAzure()
        {
            this._logger.name += " -AllNativeStorageAccountsFromAzure";
            // Invoke graphql operation allAzureNativeStorageAccountsFromAzure
            InvokeQueryAllAzureNativeStorageAccountsFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabase.
        protected void ProcessRecord_SqlDatabase()
        {
            this._logger.name += " -SqlDatabase";
            // Invoke graphql operation azureSqlDatabase
            InvokeQueryAzureSqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabaseServer.
        protected void ProcessRecord_SqlDatabaseServer()
        {
            this._logger.name += " -SqlDatabaseServer";
            // Invoke graphql operation azureSqlDatabaseServer
            InvokeQueryAzureSqlDatabaseServer();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceDatabase.
        protected void ProcessRecord_SqlManagedInstanceDatabase()
        {
            this._logger.name += " -SqlManagedInstanceDatabase";
            // Invoke graphql operation azureSqlManagedInstanceDatabase
            InvokeQueryAzureSqlManagedInstanceDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceServer.
        protected void ProcessRecord_SqlManagedInstanceServer()
        {
            this._logger.name += " -SqlManagedInstanceServer";
            // Invoke graphql operation azureSqlManagedInstanceServer
            InvokeQueryAzureSqlManagedInstanceServer();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure.
        protected void ProcessRecord_SqlDatabaseDbPointInTimeRestoreWindowFromAzure()
        {
            this._logger.name += " -SqlDatabaseDbPointInTimeRestoreWindowFromAzure";
            // Invoke graphql operation azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure
            InvokeQueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure.
        protected void ProcessRecord_SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure()
        {
            this._logger.name += " -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure";
            // Invoke graphql operation azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
            InvokeQueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureNativeSqlDatabaseDbNameForExport.
        protected void ProcessRecord_ValidateNativeSqlDatabaseDbNameForExport()
        {
            this._logger.name += " -ValidateNativeSqlDatabaseDbNameForExport";
            // Invoke graphql operation validateAzureNativeSqlDatabaseDbNameForExport
            InvokeQueryValidateAzureNativeSqlDatabaseDbNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureNativeSqlManagedInstanceDbNameForExport.
        protected void ProcessRecord_ValidateNativeSqlManagedInstanceDbNameForExport()
        {
            this._logger.name += " -ValidateNativeSqlManagedInstanceDbNameForExport";
            // Invoke graphql operation validateAzureNativeSqlManagedInstanceDbNameForExport
            InvokeQueryValidateAzureNativeSqlManagedInstanceDbNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSqlDatabaseServerElasticPools.
        protected void ProcessRecord_AllSqlDatabaseServerElasticPool()
        {
            this._logger.name += " -AllSqlDatabaseServerElasticPool";
            // Invoke graphql operation allAzureSqlDatabaseServerElasticPools
            InvokeQueryAllAzureSqlDatabaseServerElasticPools();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureNativeSqlDatabaseSnapshotPersistent.
        protected void ProcessRecord_IsNativeSqlDatabaseSnapshotPersistent()
        {
            this._logger.name += " -IsNativeSqlDatabaseSnapshotPersistent";
            // Invoke graphql operation isAzureNativeSqlDatabaseSnapshotPersistent
            InvokeQueryIsAzureNativeSqlDatabaseSnapshotPersistent();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureKeyVaultsByRegion.
        protected void ProcessRecord_AllKeyVaultsByRegion()
        {
            this._logger.name += " -AllKeyVaultsByRegion";
            // Invoke graphql operation allAzureKeyVaultsByRegion
            InvokeQueryAllAzureKeyVaultsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureEncryptionKeys.
        protected void ProcessRecord_AllEncryptionKey()
        {
            this._logger.name += " -AllEncryptionKey";
            // Invoke graphql operation allAzureEncryptionKeys
            InvokeQueryAllAzureEncryptionKeys();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountTenant.
        protected void ProcessRecord_CloudAccountTenant()
        {
            this._logger.name += " -CloudAccountTenant";
            // Invoke graphql operation azureCloudAccountTenant
            InvokeQueryAzureCloudAccountTenant();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountTenantWithExoConfigs.
        protected void ProcessRecord_CloudAccountTenantWithExoConfig()
        {
            this._logger.name += " -CloudAccountTenantWithExoConfig";
            // Invoke graphql operation azureCloudAccountTenantWithExoConfigs
            InvokeQueryAzureCloudAccountTenantWithExoConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountTenantsWithExoConfigs.
        protected void ProcessRecord_AllCloudAccountTenantsWithExoConfig()
        {
            this._logger.name += " -AllCloudAccountTenantsWithExoConfig";
            // Invoke graphql operation allAzureCloudAccountTenantsWithExoConfigs
            InvokeQueryAllAzureCloudAccountTenantsWithExoConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountTenants.
        protected void ProcessRecord_AllCloudAccountTenant()
        {
            this._logger.name += " -AllCloudAccountTenant";
            // Invoke graphql operation allAzureCloudAccountTenants
            InvokeQueryAllAzureCloudAccountTenants();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountSubscriptionWithFeatures.
        protected void ProcessRecord_CloudAccountSubscriptionWithFeature()
        {
            this._logger.name += " -CloudAccountSubscriptionWithFeature";
            // Invoke graphql operation azureCloudAccountSubscriptionWithFeatures
            InvokeQueryAzureCloudAccountSubscriptionWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountSubscriptionsByFeature.
        protected void ProcessRecord_AllCloudAccountSubscriptionsByFeature()
        {
            this._logger.name += " -AllCloudAccountSubscriptionsByFeature";
            // Invoke graphql operation allAzureCloudAccountSubscriptionsByFeature
            InvokeQueryAllAzureCloudAccountSubscriptionsByFeature();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSubscriptionWithExocomputeMappings.
        protected void ProcessRecord_AllSubscriptionWithExocomputeMapping()
        {
            this._logger.name += " -AllSubscriptionWithExocomputeMapping";
            // Invoke graphql operation allAzureSubscriptionWithExocomputeMappings
            InvokeQueryAllAzureSubscriptionWithExocomputeMappings();
        }

        // This parameter set invokes a single graphql operation:
        // allResourceGroupsFromAzure.
        protected void ProcessRecord_AllResourceGroupsFrom()
        {
            this._logger.name += " -AllResourceGroupsFrom";
            // Invoke graphql operation allResourceGroupsFromAzure
            InvokeQueryAllResourceGroupsFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // doesAzureNativeResourceGroupExist.
        protected void ProcessRecord_DoesNativeResourceGroupExist()
        {
            this._logger.name += " -DoesNativeResourceGroupExist";
            // Invoke graphql operation doesAzureNativeResourceGroupExist
            InvokeQueryDoesAzureNativeResourceGroupExist();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeResourceGroupsInfoIfExist.
        protected void ProcessRecord_AllNativeResourceGroupsInfoIfExist()
        {
            this._logger.name += " -AllNativeResourceGroupsInfoIfExist";
            // Invoke graphql operation allAzureNativeResourceGroupsInfoIfExist
            InvokeQueryAllAzureNativeResourceGroupsInfoIfExist();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountMissingPermissions.
        protected void ProcessRecord_AllCloudAccountMissingPermission()
        {
            this._logger.name += " -AllCloudAccountMissingPermission";
            // Invoke graphql operation allAzureCloudAccountMissingPermissions
            InvokeQueryAllAzureCloudAccountMissingPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountPermissionConfig.
        protected void ProcessRecord_CloudAccountPermissionConfig()
        {
            this._logger.name += " -CloudAccountPermissionConfig";
            // Invoke graphql operation azureCloudAccountPermissionConfig
            InvokeQueryAzureCloudAccountPermissionConfig();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureExocomputeConfigsInAccount.
        protected void ProcessRecord_AllExocomputeConfigsInAccount()
        {
            this._logger.name += " -AllExocomputeConfigsInAccount";
            // Invoke graphql operation allAzureExocomputeConfigsInAccount
            InvokeQueryAllAzureExocomputeConfigsInAccount();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountSubnetsByRegion.
        protected void ProcessRecord_AllCloudAccountSubnetsByRegion()
        {
            this._logger.name += " -AllCloudAccountSubnetsByRegion";
            // Invoke graphql operation allAzureCloudAccountSubnetsByRegion
            InvokeQueryAllAzureCloudAccountSubnetsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureCloudAccountExocomputeConfigurations.
        protected void ProcessRecord_ValidateCloudAccountExocomputeConfiguration()
        {
            this._logger.name += " -ValidateCloudAccountExocomputeConfiguration";
            // Invoke graphql operation validateAzureCloudAccountExocomputeConfigurations
            InvokeQueryValidateAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureArmTemplatesByFeature.
        protected void ProcessRecord_AllArmTemplatesByFeature()
        {
            this._logger.name += " -AllArmTemplatesByFeature";
            // Invoke graphql operation allAzureArmTemplatesByFeature
            InvokeQueryAllAzureArmTemplatesByFeature();
        }

        // This parameter set invokes a single graphql operation:
        // azureSubscriptions.
        protected void ProcessRecord_Subscription()
        {
            this._logger.name += " -Subscription";
            // Invoke graphql operation azureSubscriptions
            InvokeQueryAzureSubscriptions();
        }

        // This parameter set invokes a single graphql operation:
        // azureRegions.
        protected void ProcessRecord_Region()
        {
            this._logger.name += " -Region";
            // Invoke graphql operation azureRegions
            InvokeQueryAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // azureResourceGroups.
        protected void ProcessRecord_ResourceGroup()
        {
            this._logger.name += " -ResourceGroup";
            // Invoke graphql operation azureResourceGroups
            InvokeQueryAzureResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // azureVNets.
        protected void ProcessRecord_VNet()
        {
            this._logger.name += " -VNet";
            // Invoke graphql operation azureVNets
            InvokeQueryAzureVnets();
        }

        // This parameter set invokes a single graphql operation:
        // azureSubnets.
        protected void ProcessRecord_Subnet()
        {
            this._logger.name += " -Subnet";
            // Invoke graphql operation azureSubnets
            InvokeQueryAzureSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // azureStorageAccounts.
        protected void ProcessRecord_StorageAccount()
        {
            this._logger.name += " -StorageAccount";
            // Invoke graphql operation azureStorageAccounts
            InvokeQueryAzureStorageAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // allHostedAzureRegions.
        protected void ProcessRecord_AllHostedRegion()
        {
            this._logger.name += " -AllHostedRegion";
            // Invoke graphql operation allHostedAzureRegions
            InvokeQueryAllHostedAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureResourceGroups.
        protected void ProcessRecord_AllResourceGroup()
        {
            this._logger.name += " -AllResourceGroup";
            // Invoke graphql operation allAzureResourceGroups
            InvokeQueryAllAzureResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureVnets.
        protected void ProcessRecord_AllVnet()
        {
            this._logger.name += " -AllVnet";
            // Invoke graphql operation allAzureVnets
            InvokeQueryAllAzureVnets();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSubnets.
        protected void ProcessRecord_AllSubnet()
        {
            this._logger.name += " -AllSubnet";
            // Invoke graphql operation allAzureSubnets
            InvokeQueryAllAzureSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCdmVersions.
        protected void ProcessRecord_AllCdmVersion()
        {
            this._logger.name += " -AllCdmVersion";
            // Invoke graphql operation allAzureCdmVersions
            InvokeQueryAllAzureCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureRegions.
        protected void ProcessRecord_AllRegion()
        {
            this._logger.name += " -AllRegion";
            // Invoke graphql operation allAzureRegions
            InvokeQueryAllAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNsgs.
        protected void ProcessRecord_AllNsg()
        {
            this._logger.name += " -AllNsg";
            // Invoke graphql operation allAzureNsgs
            InvokeQueryAllAzureNsgs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureStorageAccounts.
        protected void ProcessRecord_AllStorageAccount()
        {
            this._logger.name += " -AllStorageAccount";
            // Invoke graphql operation allAzureStorageAccounts
            InvokeQueryAllAzureStorageAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // azureAdDirectories.
        protected void ProcessRecord_AdDirectorie()
        {
            this._logger.name += " -AdDirectorie";
            // Invoke graphql operation azureAdDirectories
            InvokeQueryAzureAdDirectories();
        }

        // This parameter set invokes a single graphql operation:
        // azureAdDirectory.
        protected void ProcessRecord_AdDirectory()
        {
            this._logger.name += " -AdDirectory";
            // Invoke graphql operation azureAdDirectory
            InvokeQueryAzureAdDirectory();
        }


        // Invoke GraphQL Query:
        // azureNativeRoot: AzureNativeRoot!
        protected void InvokeQueryAzureNativeRoot()
        {
            Tuple<string, string>[] argDefs = {
            };
            AzureNativeRoot? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureNativeRoot)psObject.BaseObject;
                } else {
                    fields = (AzureNativeRoot)this.Field;
                }
            }
            string document = Query.AzureNativeRoot(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureNativeRoot");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureNativeRoot" + parameters + "{" + document + "}",
                OperationName = "QueryAzureNativeRoot",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "AzureNativeRoot", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureNativeSubscription(azureSubscriptionRubrikId: UUID!): AzureNativeSubscription!
        protected void InvokeQueryAzureNativeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
            };
            AzureNativeSubscription? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureNativeSubscription)psObject.BaseObject;
                } else {
                    fields = (AzureNativeSubscription)this.Field;
                }
            }
            string document = Query.AzureNativeSubscription(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureNativeSubscription");
            var parameters = "($azureSubscriptionRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureNativeSubscription" + parameters + "{" + document + "}",
                OperationName = "QueryAzureNativeSubscription",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureNativeSubscription", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureNativeResourceGroup(resourceGroupId: UUID!): AzureNativeResourceGroup!
        protected void InvokeQueryAzureNativeResourceGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("resourceGroupId", "UUID!"),
            };
            AzureNativeResourceGroup? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureNativeResourceGroup)psObject.BaseObject;
                } else {
                    fields = (AzureNativeResourceGroup)this.Field;
                }
            }
            string document = Query.AzureNativeResourceGroup(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureNativeResourceGroup");
            var parameters = "($resourceGroupId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureNativeResourceGroup" + parameters + "{" + document + "}",
                OperationName = "QueryAzureNativeResourceGroup",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureNativeResourceGroup", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureNativeVirtualMachine(azureVirtualMachineRubrikId: UUID!): AzureNativeVirtualMachine!
        protected void InvokeQueryAzureNativeVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureVirtualMachineRubrikId", "UUID!"),
            };
            AzureNativeVirtualMachine? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureNativeVirtualMachine)psObject.BaseObject;
                } else {
                    fields = (AzureNativeVirtualMachine)this.Field;
                }
            }
            string document = Query.AzureNativeVirtualMachine(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureNativeVirtualMachine");
            var parameters = "($azureVirtualMachineRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureNativeVirtualMachine" + parameters + "{" + document + "}",
                OperationName = "QueryAzureNativeVirtualMachine",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureNativeVirtualMachine", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureNativeManagedDisk(azureManagedDiskRubrikId: UUID!): AzureNativeManagedDisk!
        protected void InvokeQueryAzureNativeManagedDisk()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureManagedDiskRubrikId", "UUID!"),
            };
            AzureNativeManagedDisk? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureNativeManagedDisk)psObject.BaseObject;
                } else {
                    fields = (AzureNativeManagedDisk)this.Field;
                }
            }
            string document = Query.AzureNativeManagedDisk(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureNativeManagedDisk");
            var parameters = "($azureManagedDiskRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureNativeManagedDisk" + parameters + "{" + document + "}",
                OperationName = "QueryAzureNativeManagedDisk",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureNativeManagedDisk", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureNativeVirtualNetworks(azureSubscriptionRubrikId: UUID): [AzureNativeVirtualNetwork!]!
        protected void InvokeQueryAllAzureNativeVirtualNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID"),
            };
            List<AzureNativeVirtualNetwork>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureNativeVirtualNetwork>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeVirtualNetwork>)this.Field;
                }
            }
            string document = Query.AllAzureNativeVirtualNetworks(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeVirtualNetworks");
            var parameters = "($azureSubscriptionRubrikId: UUID)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeVirtualNetworks" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeVirtualNetworks",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureNativeVirtualNetwork>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureNativeSubnetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeSubnet!]!
        protected void InvokeQueryAllAzureNativeSubnetsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            List<AzureNativeSubnet>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureNativeSubnet>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeSubnet>)this.Field;
                }
            }
            string document = Query.AllAzureNativeSubnetsByRegionFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeSubnetsByRegionFromAzure");
            var parameters = "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeSubnetsByRegionFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeSubnetsByRegionFromAzure",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureNativeSubnet>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureNativeSecurityGroupsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeSecurityGroup!]!
        protected void InvokeQueryAllAzureNativeSecurityGroupsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            List<AzureNativeSecurityGroup>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureNativeSecurityGroup>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeSecurityGroup>)this.Field;
                }
            }
            string document = Query.AllAzureNativeSecurityGroupsByRegionFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeSecurityGroupsByRegionFromAzure");
            var parameters = "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeSecurityGroupsByRegionFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeSecurityGroupsByRegionFromAzure",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureNativeSecurityGroup>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureDiskEncryptionSetsByRegion(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeDiskEncryptionSet!]!
        protected void InvokeQueryAllAzureDiskEncryptionSetsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            List<AzureNativeDiskEncryptionSet>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureNativeDiskEncryptionSet>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeDiskEncryptionSet>)this.Field;
                }
            }
            string document = Query.AllAzureDiskEncryptionSetsByRegion(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureDiskEncryptionSetsByRegion");
            var parameters = "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureDiskEncryptionSetsByRegion" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureDiskEncryptionSetsByRegion",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureNativeDiskEncryptionSet>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureNativeAvailabilitySetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, resourceGroupName: String!, region: AzureNativeRegion!): [AzureNativeAvailabilitySet!]!
        protected void InvokeQueryAllAzureNativeAvailabilitySetsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            List<AzureNativeAvailabilitySet>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureNativeAvailabilitySet>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeAvailabilitySet>)this.Field;
                }
            }
            string document = Query.AllAzureNativeAvailabilitySetsByRegionFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeAvailabilitySetsByRegionFromAzure");
            var parameters = "($azureSubscriptionRubrikId: UUID!,$resourceGroupName: String!,$region: AzureNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeAvailabilitySetsByRegionFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeAvailabilitySetsByRegionFromAzure",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureNativeAvailabilitySet>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureNativeExportCompatibleVmSizesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!, vmSnapshotId: UUID!): [AzureNativeExportCompatibleVmSizes!]!
        protected void InvokeQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
                Tuple.Create("vmSnapshotId", "UUID!"),
            };
            List<AzureNativeExportCompatibleVmSizes>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureNativeExportCompatibleVmSizes>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeExportCompatibleVmSizes>)this.Field;
                }
            }
            string document = Query.AllAzureNativeExportCompatibleVmSizesByRegionFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeExportCompatibleVmSizesByRegionFromAzure");
            var parameters = "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!,$vmSnapshotId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureNativeExportCompatibleVmSizes>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureNativeExportCompatibleDiskTypesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeExportCompatibleDiskTypes!]!
        protected void InvokeQueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            List<AzureNativeExportCompatibleDiskTypes>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureNativeExportCompatibleDiskTypes>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeExportCompatibleDiskTypes>)this.Field;
                }
            }
            string document = Query.AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure");
            var parameters = "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureNativeExportCompatibleDiskTypes>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureNativeVirtualMachineSizes(azureSubscriptionRubrikId: UUID): [String!]!
        protected void InvokeQueryAllAzureNativeVirtualMachineSizes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID"),
            };
            List<System.String>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAzureNativeVirtualMachineSizes(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeVirtualMachineSizes");
            var parameters = "($azureSubscriptionRubrikId: UUID)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeVirtualMachineSizes" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeVirtualMachineSizes",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.String>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // isAzureNativeManagedDiskSnapshotRestorable(azureSubscriptionRubrikId: UUID!, diskSnapshotId: UUID!): Boolean!
        protected void InvokeQueryIsAzureNativeManagedDiskSnapshotRestorable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("diskSnapshotId", "UUID!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Query.IsAzureNativeManagedDiskSnapshotRestorable(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsAzureNativeManagedDiskSnapshotRestorable");
            var parameters = "($azureSubscriptionRubrikId: UUID!,$diskSnapshotId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAzureNativeManagedDiskSnapshotRestorable" + parameters + "{" + document + "}",
                OperationName = "QueryIsAzureNativeManagedDiskSnapshotRestorable",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // isAzureStorageAccountNameAvailable(azureSubscriptionRubrikId: UUID!, storageAccountName: String!): Boolean!
        protected void InvokeQueryIsAzureStorageAccountNameAvailable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("storageAccountName", "String!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Query.IsAzureStorageAccountNameAvailable(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsAzureStorageAccountNameAvailable");
            var parameters = "($azureSubscriptionRubrikId: UUID!,$storageAccountName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAzureStorageAccountNameAvailable" + parameters + "{" + document + "}",
                OperationName = "QueryIsAzureStorageAccountNameAvailable",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureNativeStorageAccountsFromAzure(azureSubscriptionRubrikId: UUID!): [AzureNativeStorageAccount!]!
        protected void InvokeQueryAllAzureNativeStorageAccountsFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
            };
            List<AzureNativeStorageAccount>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureNativeStorageAccount>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeStorageAccount>)this.Field;
                }
            }
            string document = Query.AllAzureNativeStorageAccountsFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeStorageAccountsFromAzure");
            var parameters = "($azureSubscriptionRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeStorageAccountsFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeStorageAccountsFromAzure",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureNativeStorageAccount>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureSqlDatabase(azureSqlDatabaseRubrikId: UUID!): AzureSqlDatabaseDb!
        protected void InvokeQueryAzureSqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseRubrikId", "UUID!"),
            };
            AzureSqlDatabaseDb? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureSqlDatabaseDb)psObject.BaseObject;
                } else {
                    fields = (AzureSqlDatabaseDb)this.Field;
                }
            }
            string document = Query.AzureSqlDatabase(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSqlDatabase");
            var parameters = "($azureSqlDatabaseRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSqlDatabase" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSqlDatabase",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureSqlDatabaseDb", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureSqlDatabaseServer(azureSqlDatabaseServerRubrikId: UUID!): AzureSqlDatabaseServer!
        protected void InvokeQueryAzureSqlDatabaseServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            AzureSqlDatabaseServer? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureSqlDatabaseServer)psObject.BaseObject;
                } else {
                    fields = (AzureSqlDatabaseServer)this.Field;
                }
            }
            string document = Query.AzureSqlDatabaseServer(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSqlDatabaseServer");
            var parameters = "($azureSqlDatabaseServerRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSqlDatabaseServer" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSqlDatabaseServer",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureSqlDatabaseServer", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureSqlManagedInstanceDatabase(azureSqlManagedInstanceDatabaseRubrikId: UUID!): AzureSqlManagedInstanceDatabase!
        protected void InvokeQueryAzureSqlManagedInstanceDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceDatabaseRubrikId", "UUID!"),
            };
            AzureSqlManagedInstanceDatabase? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureSqlManagedInstanceDatabase)psObject.BaseObject;
                } else {
                    fields = (AzureSqlManagedInstanceDatabase)this.Field;
                }
            }
            string document = Query.AzureSqlManagedInstanceDatabase(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSqlManagedInstanceDatabase");
            var parameters = "($azureSqlManagedInstanceDatabaseRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSqlManagedInstanceDatabase" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSqlManagedInstanceDatabase",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureSqlManagedInstanceDatabase", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureSqlManagedInstanceServer(azureSqlManagedInstanceServerRubrikId: UUID!): AzureSqlManagedInstanceServer!
        protected void InvokeQueryAzureSqlManagedInstanceServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceServerRubrikId", "UUID!"),
            };
            AzureSqlManagedInstanceServer? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureSqlManagedInstanceServer)psObject.BaseObject;
                } else {
                    fields = (AzureSqlManagedInstanceServer)this.Field;
                }
            }
            string document = Query.AzureSqlManagedInstanceServer(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSqlManagedInstanceServer");
            var parameters = "($azureSqlManagedInstanceServerRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSqlManagedInstanceServer" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSqlManagedInstanceServer",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureSqlManagedInstanceServer", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     azureSqlDatabaseServerName: String!
        //     azureSqlDatabaseName: String!
        //   ): AzureNativeSqlDatabasePointInTimeRestoreWindow!
        protected void InvokeQueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlDatabaseServerName", "String!"),
                Tuple.Create("azureSqlDatabaseName", "String!"),
            };
            AzureNativeSqlDatabasePointInTimeRestoreWindow? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureNativeSqlDatabasePointInTimeRestoreWindow)psObject.BaseObject;
                } else {
                    fields = (AzureNativeSqlDatabasePointInTimeRestoreWindow)this.Field;
                }
            }
            string document = Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure");
            var parameters = "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureNativeSqlDatabasePointInTimeRestoreWindow", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     azureSqlManagedInstanceName: String!
        //     azureSqlDatabaseName: String!
        //   ): AzureNativeSqlDatabasePointInTimeRestoreWindow!
        protected void InvokeQueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlManagedInstanceName", "String!"),
                Tuple.Create("azureSqlDatabaseName", "String!"),
            };
            AzureNativeSqlDatabasePointInTimeRestoreWindow? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureNativeSqlDatabasePointInTimeRestoreWindow)psObject.BaseObject;
                } else {
                    fields = (AzureNativeSqlDatabasePointInTimeRestoreWindow)this.Field;
                }
            }
            string document = Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure");
            var parameters = "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlManagedInstanceName: String!,$azureSqlDatabaseName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureNativeSqlDatabasePointInTimeRestoreWindow", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // validateAzureNativeSqlDatabaseDbNameForExport(azureSqlDatabaseName: String!, azureSqlDatabaseServerRubrikId: UUID!): ValidateAzureNativeSqlDatabaseDbNameForExportReply!
        protected void InvokeQueryValidateAzureNativeSqlDatabaseDbNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseName", "String!"),
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            ValidateAzureNativeSqlDatabaseDbNameForExportReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ValidateAzureNativeSqlDatabaseDbNameForExportReply)psObject.BaseObject;
                } else {
                    fields = (ValidateAzureNativeSqlDatabaseDbNameForExportReply)this.Field;
                }
            }
            string document = Query.ValidateAzureNativeSqlDatabaseDbNameForExport(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ValidateAzureNativeSqlDatabaseDbNameForExport");
            var parameters = "($azureSqlDatabaseName: String!,$azureSqlDatabaseServerRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryValidateAzureNativeSqlDatabaseDbNameForExport" + parameters + "{" + document + "}",
                OperationName = "QueryValidateAzureNativeSqlDatabaseDbNameForExport",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ValidateAzureNativeSqlDatabaseDbNameForExportReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // validateAzureNativeSqlManagedInstanceDbNameForExport(azureSqlDatabaseName: String!, azureSqlManagedInstanceServerRubrikId: UUID!): ValidateAzureNativeSqlManagedInstanceDbNameForExportReply!
        protected void InvokeQueryValidateAzureNativeSqlManagedInstanceDbNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseName", "String!"),
                Tuple.Create("azureSqlManagedInstanceServerRubrikId", "UUID!"),
            };
            ValidateAzureNativeSqlManagedInstanceDbNameForExportReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ValidateAzureNativeSqlManagedInstanceDbNameForExportReply)psObject.BaseObject;
                } else {
                    fields = (ValidateAzureNativeSqlManagedInstanceDbNameForExportReply)this.Field;
                }
            }
            string document = Query.ValidateAzureNativeSqlManagedInstanceDbNameForExport(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ValidateAzureNativeSqlManagedInstanceDbNameForExport");
            var parameters = "($azureSqlDatabaseName: String!,$azureSqlManagedInstanceServerRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryValidateAzureNativeSqlManagedInstanceDbNameForExport" + parameters + "{" + document + "}",
                OperationName = "QueryValidateAzureNativeSqlManagedInstanceDbNameForExport",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ValidateAzureNativeSqlManagedInstanceDbNameForExportReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureSqlDatabaseServerElasticPools(
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     azureSqlDatabaseServerName: String!
        //     azureSqlDatabaseServerRubrikId: UUID!
        //   ): [AzureSqlDatabaseServerElasticPool!]!
        protected void InvokeQueryAllAzureSqlDatabaseServerElasticPools()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlDatabaseServerName", "String!"),
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            List<AzureSqlDatabaseServerElasticPool>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureSqlDatabaseServerElasticPool>)psObject.BaseObject;
                } else {
                    fields = (List<AzureSqlDatabaseServerElasticPool>)this.Field;
                }
            }
            string document = Query.AllAzureSqlDatabaseServerElasticPools(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureSqlDatabaseServerElasticPools");
            var parameters = "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseServerRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureSqlDatabaseServerElasticPools" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureSqlDatabaseServerElasticPools",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureSqlDatabaseServerElasticPool>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // isAzureNativeSqlDatabaseSnapshotPersistent(snapshotId: UUID!): Boolean!
        protected void InvokeQueryIsAzureNativeSqlDatabaseSnapshotPersistent()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "UUID!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Query.IsAzureNativeSqlDatabaseSnapshotPersistent(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsAzureNativeSqlDatabaseSnapshotPersistent");
            var parameters = "($snapshotId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAzureNativeSqlDatabaseSnapshotPersistent" + parameters + "{" + document + "}",
                OperationName = "QueryIsAzureNativeSqlDatabaseSnapshotPersistent",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureKeyVaultsByRegion(azureKeyVaultsInput: AzureKeyVaultsInput!): [AzureKeyVault!]!
        protected void InvokeQueryAllAzureKeyVaultsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureKeyVaultsInput", "AzureKeyVaultsInput!"),
            };
            List<AzureKeyVault>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureKeyVault>)psObject.BaseObject;
                } else {
                    fields = (List<AzureKeyVault>)this.Field;
                }
            }
            string document = Query.AllAzureKeyVaultsByRegion(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureKeyVaultsByRegion");
            var parameters = "($azureKeyVaultsInput: AzureKeyVaultsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureKeyVaultsByRegion" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureKeyVaultsByRegion",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureKeyVault>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureEncryptionKeys(azureEncryptionKeysInput: AzureEncryptionKeysInput!): [AzureEncryptionKey!]!
        protected void InvokeQueryAllAzureEncryptionKeys()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureEncryptionKeysInput", "AzureEncryptionKeysInput!"),
            };
            List<AzureEncryptionKey>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureEncryptionKey>)psObject.BaseObject;
                } else {
                    fields = (List<AzureEncryptionKey>)this.Field;
                }
            }
            string document = Query.AllAzureEncryptionKeys(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureEncryptionKeys");
            var parameters = "($azureEncryptionKeysInput: AzureEncryptionKeysInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureEncryptionKeys" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureEncryptionKeys",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureEncryptionKey>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureCloudAccountTenant(
        //     tenantId: UUID!
        //     feature: CloudAccountFeature!
        //     subscriptionStatusFilters: [CloudAccountStatus!]!
        //     subscriptionSearchText: String!
        //     subscriptionIdsFilter: [UUID!]
        //   ): AzureCloudAccountTenant!
        protected void InvokeQueryAzureCloudAccountTenant()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("subscriptionSearchText", "String!"),
                Tuple.Create("subscriptionIdsFilter", "[UUID!]"),
            };
            AzureCloudAccountTenant? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureCloudAccountTenant)psObject.BaseObject;
                } else {
                    fields = (AzureCloudAccountTenant)this.Field;
                }
            }
            string document = Query.AzureCloudAccountTenant(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureCloudAccountTenant");
            var parameters = "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureCloudAccountTenant" + parameters + "{" + document + "}",
                OperationName = "QueryAzureCloudAccountTenant",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureCloudAccountTenant", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureCloudAccountTenantWithExoConfigs(
        //     tenantId: UUID!
        //     feature: CloudAccountFeature!
        //     subscriptionStatusFilters: [CloudAccountStatus!]!
        //     subscriptionSearchText: String!
        //     subscriptionIdsFilter: [UUID!]
        //   ): AzureCloudAccountTenantWithExoConfigs!
        protected void InvokeQueryAzureCloudAccountTenantWithExoConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("subscriptionSearchText", "String!"),
                Tuple.Create("subscriptionIdsFilter", "[UUID!]"),
            };
            AzureCloudAccountTenantWithExoConfigs? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureCloudAccountTenantWithExoConfigs)psObject.BaseObject;
                } else {
                    fields = (AzureCloudAccountTenantWithExoConfigs)this.Field;
                }
            }
            string document = Query.AzureCloudAccountTenantWithExoConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureCloudAccountTenantWithExoConfigs");
            var parameters = "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureCloudAccountTenantWithExoConfigs" + parameters + "{" + document + "}",
                OperationName = "QueryAzureCloudAccountTenantWithExoConfigs",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureCloudAccountTenantWithExoConfigs", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountTenantsWithExoConfigs(features: [CloudAccountFeature!]!): [AzureCloudAccountTenantWithExoConfigs!]!
        protected void InvokeQueryAllAzureCloudAccountTenantsWithExoConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]!"),
            };
            List<AzureCloudAccountTenantWithExoConfigs>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureCloudAccountTenantWithExoConfigs>)psObject.BaseObject;
                } else {
                    fields = (List<AzureCloudAccountTenantWithExoConfigs>)this.Field;
                }
            }
            string document = Query.AllAzureCloudAccountTenantsWithExoConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureCloudAccountTenantsWithExoConfigs");
            var parameters = "($features: [CloudAccountFeature!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureCloudAccountTenantsWithExoConfigs" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureCloudAccountTenantsWithExoConfigs",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureCloudAccountTenantWithExoConfigs>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountTenants(features: [CloudAccountFeature!], feature: CloudAccountFeature!, includeSubscriptionDetails: Boolean!): [AzureCloudAccountTenant!]!
        protected void InvokeQueryAllAzureCloudAccountTenants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("includeSubscriptionDetails", "Boolean!"),
            };
            List<AzureCloudAccountTenant>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureCloudAccountTenant>)psObject.BaseObject;
                } else {
                    fields = (List<AzureCloudAccountTenant>)this.Field;
                }
            }
            string document = Query.AllAzureCloudAccountTenants(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureCloudAccountTenants");
            var parameters = "($features: [CloudAccountFeature!],$feature: CloudAccountFeature!,$includeSubscriptionDetails: Boolean!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureCloudAccountTenants" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureCloudAccountTenants",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureCloudAccountTenant>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureCloudAccountSubscriptionWithFeatures(cloudAccountId: UUID!): AzureCloudAccountSubscriptionWithFeatures!
        protected void InvokeQueryAzureCloudAccountSubscriptionWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
            };
            AzureCloudAccountSubscriptionWithFeatures? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureCloudAccountSubscriptionWithFeatures)psObject.BaseObject;
                } else {
                    fields = (AzureCloudAccountSubscriptionWithFeatures)this.Field;
                }
            }
            string document = Query.AzureCloudAccountSubscriptionWithFeatures(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureCloudAccountSubscriptionWithFeatures");
            var parameters = "($cloudAccountId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureCloudAccountSubscriptionWithFeatures" + parameters + "{" + document + "}",
                OperationName = "QueryAzureCloudAccountSubscriptionWithFeatures",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureCloudAccountSubscriptionWithFeatures", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountSubscriptionsByFeature(feature: CloudAccountFeature!, subscriptionStatusFilters: [CloudAccountStatus!]!): [AzureSubscriptionWithFeaturesType!]!
        protected void InvokeQueryAllAzureCloudAccountSubscriptionsByFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
            };
            List<AzureSubscriptionWithFeaturesType>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureSubscriptionWithFeaturesType>)psObject.BaseObject;
                } else {
                    fields = (List<AzureSubscriptionWithFeaturesType>)this.Field;
                }
            }
            string document = Query.AllAzureCloudAccountSubscriptionsByFeature(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureCloudAccountSubscriptionsByFeature");
            var parameters = "($feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureCloudAccountSubscriptionsByFeature" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureCloudAccountSubscriptionsByFeature",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureSubscriptionWithFeaturesType>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureSubscriptionWithExocomputeMappings(features: [CloudAccountFeature!], exocomputeSubscriptionIdsFilter: [UUID!]): [AzureSubscriptionWithExocomputeMapping!]!
        protected void InvokeQueryAllAzureSubscriptionWithExocomputeMappings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("exocomputeSubscriptionIdsFilter", "[UUID!]"),
            };
            List<AzureSubscriptionWithExocomputeMapping>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureSubscriptionWithExocomputeMapping>)psObject.BaseObject;
                } else {
                    fields = (List<AzureSubscriptionWithExocomputeMapping>)this.Field;
                }
            }
            string document = Query.AllAzureSubscriptionWithExocomputeMappings(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureSubscriptionWithExocomputeMappings");
            var parameters = "($features: [CloudAccountFeature!],$exocomputeSubscriptionIdsFilter: [UUID!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureSubscriptionWithExocomputeMappings" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureSubscriptionWithExocomputeMappings",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureSubscriptionWithExocomputeMapping>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allResourceGroupsFromAzure(cloudAccountId: UUID!, azureSubscriptionNativeId: UUID!, feature: CloudAccountFeature!): [AzureResourceGroup!]!
        protected void InvokeQueryAllResourceGroupsFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureSubscriptionNativeId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            List<AzureResourceGroup>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureResourceGroup>)psObject.BaseObject;
                } else {
                    fields = (List<AzureResourceGroup>)this.Field;
                }
            }
            string document = Query.AllResourceGroupsFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllResourceGroupsFromAzure");
            var parameters = "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$feature: CloudAccountFeature!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllResourceGroupsFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllResourceGroupsFromAzure",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureResourceGroup>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // doesAzureNativeResourceGroupExist(
        //     cloudAccountId: UUID!
        //     azureSubscriptionNativeId: UUID!
        //     resourceGroupName: String!
        //     feature: CloudAccountFeature!
        //   ): Boolean!
        protected void InvokeQueryDoesAzureNativeResourceGroupExist()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureSubscriptionNativeId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Query.DoesAzureNativeResourceGroupExist(ref fields);
            this._input.Initialize(argDefs, fields, "Query.DoesAzureNativeResourceGroupExist");
            var parameters = "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$resourceGroupName: String!,$feature: CloudAccountFeature!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryDoesAzureNativeResourceGroupExist" + parameters + "{" + document + "}",
                OperationName = "QueryDoesAzureNativeResourceGroupExist",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureNativeResourceGroupsInfoIfExist(input: AzureGetResourceGroupsInfoIfExistInput!): [AzureResourceGroupInfo!]!
        protected void InvokeQueryAllAzureNativeResourceGroupsInfoIfExist()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureGetResourceGroupsInfoIfExistInput!"),
            };
            List<AzureResourceGroupInfo>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureResourceGroupInfo>)psObject.BaseObject;
                } else {
                    fields = (List<AzureResourceGroupInfo>)this.Field;
                }
            }
            string document = Query.AllAzureNativeResourceGroupsInfoIfExist(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeResourceGroupsInfoIfExist");
            var parameters = "($input: AzureGetResourceGroupsInfoIfExistInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeResourceGroupsInfoIfExist" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeResourceGroupsInfoIfExist",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureResourceGroupInfo>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountMissingPermissions(sessionId: String!, subscriptionIds: [UUID!]!, cloudAccountAction: CloudAccountAction!): [AzureSubscriptionMissingPermissions!]!
        protected void InvokeQueryAllAzureCloudAccountMissingPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sessionId", "String!"),
                Tuple.Create("subscriptionIds", "[UUID!]!"),
                Tuple.Create("cloudAccountAction", "CloudAccountAction!"),
            };
            List<AzureSubscriptionMissingPermissions>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureSubscriptionMissingPermissions>)psObject.BaseObject;
                } else {
                    fields = (List<AzureSubscriptionMissingPermissions>)this.Field;
                }
            }
            string document = Query.AllAzureCloudAccountMissingPermissions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureCloudAccountMissingPermissions");
            var parameters = "($sessionId: String!,$subscriptionIds: [UUID!]!,$cloudAccountAction: CloudAccountAction!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureCloudAccountMissingPermissions" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureCloudAccountMissingPermissions",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureSubscriptionMissingPermissions>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureCloudAccountPermissionConfig(feature: CloudAccountFeature!): AzureCloudAccountPermissionConfigResponse!
        protected void InvokeQueryAzureCloudAccountPermissionConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            AzureCloudAccountPermissionConfigResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureCloudAccountPermissionConfigResponse)psObject.BaseObject;
                } else {
                    fields = (AzureCloudAccountPermissionConfigResponse)this.Field;
                }
            }
            string document = Query.AzureCloudAccountPermissionConfig(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureCloudAccountPermissionConfig");
            var parameters = "($feature: CloudAccountFeature!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureCloudAccountPermissionConfig" + parameters + "{" + document + "}",
                OperationName = "QueryAzureCloudAccountPermissionConfig",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureCloudAccountPermissionConfigResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureExocomputeConfigsInAccount(azureExocomputeSearchQuery: String, cloudAccountIDs: [UUID!]): [AzureExocomputeConfigsInAccount!]!
        protected void InvokeQueryAllAzureExocomputeConfigsInAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureExocomputeSearchQuery", "String"),
                Tuple.Create("cloudAccountIDs", "[UUID!]"),
            };
            List<AzureExocomputeConfigsInAccount>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureExocomputeConfigsInAccount>)psObject.BaseObject;
                } else {
                    fields = (List<AzureExocomputeConfigsInAccount>)this.Field;
                }
            }
            string document = Query.AllAzureExocomputeConfigsInAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureExocomputeConfigsInAccount");
            var parameters = "($azureExocomputeSearchQuery: String,$cloudAccountIDs: [UUID!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureExocomputeConfigsInAccount" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureExocomputeConfigsInAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureExocomputeConfigsInAccount>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountSubnetsByRegion(cloudAccountId: UUID!, region: AzureCloudAccountRegion!): [AzureNativeSubnet!]!
        protected void InvokeQueryAllAzureCloudAccountSubnetsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("region", "AzureCloudAccountRegion!"),
            };
            List<AzureNativeSubnet>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureNativeSubnet>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeSubnet>)this.Field;
                }
            }
            string document = Query.AllAzureCloudAccountSubnetsByRegion(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureCloudAccountSubnetsByRegion");
            var parameters = "($cloudAccountId: UUID!,$region: AzureCloudAccountRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureCloudAccountSubnetsByRegion" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureCloudAccountSubnetsByRegion",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureNativeSubnet>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // validateAzureCloudAccountExocomputeConfigurations(input: ValidateAzureCloudAccountExocomputeConfigurationsInput!): ValidateAzureSubnetsForCloudAccountExocomputeReply!
        protected void InvokeQueryValidateAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            ValidateAzureSubnetsForCloudAccountExocomputeReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ValidateAzureSubnetsForCloudAccountExocomputeReply)psObject.BaseObject;
                } else {
                    fields = (ValidateAzureSubnetsForCloudAccountExocomputeReply)this.Field;
                }
            }
            string document = Query.ValidateAzureCloudAccountExocomputeConfigurations(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ValidateAzureCloudAccountExocomputeConfigurations");
            var parameters = "($input: ValidateAzureCloudAccountExocomputeConfigurationsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryValidateAzureCloudAccountExocomputeConfigurations" + parameters + "{" + document + "}",
                OperationName = "QueryValidateAzureCloudAccountExocomputeConfigurations",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ValidateAzureSubnetsForCloudAccountExocomputeReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureArmTemplatesByFeature(input: AzureArmTemplatesByFeatureInput!): [AzureArmTemplateByFeature!]!
        protected void InvokeQueryAllAzureArmTemplatesByFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureArmTemplatesByFeatureInput!"),
            };
            List<AzureArmTemplateByFeature>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureArmTemplateByFeature>)psObject.BaseObject;
                } else {
                    fields = (List<AzureArmTemplateByFeature>)this.Field;
                }
            }
            string document = Query.AllAzureArmTemplatesByFeature(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureArmTemplatesByFeature");
            var parameters = "($input: AzureArmTemplatesByFeatureInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureArmTemplatesByFeature" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureArmTemplatesByFeature",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureArmTemplateByFeature>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureSubscriptions(tenantId: String!): AzureSubscriptionConnection!
        protected void InvokeQueryAzureSubscriptions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
            };
            AzureSubscriptionConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureSubscriptionConnection)psObject.BaseObject;
                } else {
                    fields = (AzureSubscriptionConnection)this.Field;
                }
            }
            string document = Query.AzureSubscriptions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSubscriptions");
            var parameters = "($tenantId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSubscriptions" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSubscriptions",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureSubscriptionConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureRegions(tenantId: String!, subscriptionId: UUID!): RegionConnection!
        protected void InvokeQueryAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            RegionConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RegionConnection)psObject.BaseObject;
                } else {
                    fields = (RegionConnection)this.Field;
                }
            }
            string document = Query.AzureRegions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureRegions");
            var parameters = "($tenantId: String!,$subscriptionId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureRegions" + parameters + "{" + document + "}",
                OperationName = "QueryAzureRegions",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RegionConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureResourceGroups(tenantId: String!, subscriptionId: UUID!): ResourceGroupConnection!
        protected void InvokeQueryAzureResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            ResourceGroupConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ResourceGroupConnection)psObject.BaseObject;
                } else {
                    fields = (ResourceGroupConnection)this.Field;
                }
            }
            string document = Query.AzureResourceGroups(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureResourceGroups");
            var parameters = "($tenantId: String!,$subscriptionId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureResourceGroups" + parameters + "{" + document + "}",
                OperationName = "QueryAzureResourceGroups",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ResourceGroupConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureVNets(tenantId: String!, subscriptionId: UUID!, regionName: String!): VnetConnection!
        protected void InvokeQueryAzureVnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            VnetConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VnetConnection)psObject.BaseObject;
                } else {
                    fields = (VnetConnection)this.Field;
                }
            }
            string document = Query.AzureVnets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureVnets");
            var parameters = "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureVnets" + parameters + "{" + document + "}",
                OperationName = "QueryAzureVnets",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VnetConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureSubnets(tenantId: String!, subscriptionId: UUID!, vNetId: String!): SubnetConnection!
        protected void InvokeQueryAzureSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("vNetId", "String!"),
            };
            SubnetConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (SubnetConnection)psObject.BaseObject;
                } else {
                    fields = (SubnetConnection)this.Field;
                }
            }
            string document = Query.AzureSubnets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSubnets");
            var parameters = "($tenantId: String!,$subscriptionId: UUID!,$vNetId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSubnets" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSubnets",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "SubnetConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureStorageAccounts(tenantId: String!, subscriptionId: UUID!, regionName: String!): StorageAccountConnection!
        protected void InvokeQueryAzureStorageAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            StorageAccountConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (StorageAccountConnection)psObject.BaseObject;
                } else {
                    fields = (StorageAccountConnection)this.Field;
                }
            }
            string document = Query.AzureStorageAccounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureStorageAccounts");
            var parameters = "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureStorageAccounts" + parameters + "{" + document + "}",
                OperationName = "QueryAzureStorageAccounts",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "StorageAccountConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allHostedAzureRegions: AzureRegionsResp!
        protected void InvokeQueryAllHostedAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
            };
            AzureRegionsResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureRegionsResp)psObject.BaseObject;
                } else {
                    fields = (AzureRegionsResp)this.Field;
                }
            }
            string document = Query.AllHostedAzureRegions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllHostedAzureRegions");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllHostedAzureRegions" + parameters + "{" + document + "}",
                OperationName = "QueryAllHostedAzureRegions",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "AzureRegionsResp", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureResourceGroups(cloudAccountId: String!, azureRegion: String!): [String!]!
        protected void InvokeQueryAllAzureResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
                Tuple.Create("azureRegion", "String!"),
            };
            List<System.String>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAzureResourceGroups(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureResourceGroups");
            var parameters = "($cloudAccountId: String!,$azureRegion: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureResourceGroups" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureResourceGroups",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.String>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureVnets(vnetRequest: AzureVnetReq!): [String!]!
        protected void InvokeQueryAllAzureVnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("vnetRequest", "AzureVnetReq!"),
            };
            List<System.String>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAzureVnets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureVnets");
            var parameters = "($vnetRequest: AzureVnetReq!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureVnets" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureVnets",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.String>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureSubnets(subnetRequest: AzureSubnetReq!): [String!]!
        protected void InvokeQueryAllAzureSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subnetRequest", "AzureSubnetReq!"),
            };
            List<System.String>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAzureSubnets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureSubnets");
            var parameters = "($subnetRequest: AzureSubnetReq!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureSubnets" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureSubnets",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.String>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureCdmVersions(cdmVersionRequest: AzureCdmVersionReq!): [AzureCdmVersion!]!
        protected void InvokeQueryAllAzureCdmVersions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmVersionRequest", "AzureCdmVersionReq!"),
            };
            List<AzureCdmVersion>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureCdmVersion>)psObject.BaseObject;
                } else {
                    fields = (List<AzureCdmVersion>)this.Field;
                }
            }
            string document = Query.AllAzureCdmVersions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureCdmVersions");
            var parameters = "($cdmVersionRequest: AzureCdmVersionReq!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureCdmVersions" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureCdmVersions",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureCdmVersion>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureRegions(cloudAccountId: String!): [AzureCloudAccountRegion!]!
        protected void InvokeQueryAllAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
            };
            List<AzureCloudAccountRegion>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AzureCloudAccountRegion>)psObject.BaseObject;
                } else {
                    fields = (List<AzureCloudAccountRegion>)this.Field;
                }
            }
            string document = Query.AllAzureRegions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureRegions");
            var parameters = "($cloudAccountId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureRegions" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureRegions",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AzureCloudAccountRegion>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureNsgs(nsgRequest: AzureNsgRequest!): [String!]!
        protected void InvokeQueryAllAzureNsgs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("nsgRequest", "AzureNsgRequest!"),
            };
            List<System.String>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAzureNsgs(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNsgs");
            var parameters = "($nsgRequest: AzureNsgRequest!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNsgs" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNsgs",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.String>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAzureStorageAccounts(storageAccountsRequest: AzureStorageAccountsReq!): [String!]!
        protected void InvokeQueryAllAzureStorageAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("storageAccountsRequest", "AzureStorageAccountsReq!"),
            };
            List<System.String>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAzureStorageAccounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureStorageAccounts");
            var parameters = "($storageAccountsRequest: AzureStorageAccountsReq!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureStorageAccounts" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureStorageAccounts",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.String>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureAdDirectories(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): AzureAdDirectoryConnection!
        protected void InvokeQueryAzureAdDirectories()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            AzureAdDirectoryConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureAdDirectoryConnection)psObject.BaseObject;
                } else {
                    fields = (AzureAdDirectoryConnection)this.Field;
                }
            }
            string document = Query.AzureAdDirectories(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureAdDirectories");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureAdDirectories" + parameters + "{" + document + "}",
                OperationName = "QueryAzureAdDirectories",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureAdDirectoryConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // azureAdDirectory(workloadFid: UUID!): AzureAdDirectory!
        protected void InvokeQueryAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadFid", "UUID!"),
            };
            AzureAdDirectory? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureAdDirectory)psObject.BaseObject;
                } else {
                    fields = (AzureAdDirectory)this.Field;
                }
            }
            string document = Query.AzureAdDirectory(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureAdDirectory");
            var parameters = "($workloadFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureAdDirectory" + parameters + "{" + document + "}",
                OperationName = "QueryAzureAdDirectory",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AzureAdDirectory", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryAzure
}