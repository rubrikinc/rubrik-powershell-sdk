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
        DefaultParameterSetName = "VNets")
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
        // NativeSubscriptions parameter set
        //
        // [GraphQL: azureNativeSubscriptions]
        //
        [Parameter(
            ParameterSetName = "NativeSubscriptions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure Native Subscriptions.
[GraphQL: azureNativeSubscriptions]",
            Position = 0
        )]
        public SwitchParameter NativeSubscriptions { get; set; }

        
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
        // NativeResourceGroups parameter set
        //
        // [GraphQL: azureNativeResourceGroups]
        //
        [Parameter(
            ParameterSetName = "NativeResourceGroups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure Native Resource Groups.
[GraphQL: azureNativeResourceGroups]",
            Position = 0
        )]
        public SwitchParameter NativeResourceGroups { get; set; }

        
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
        // NativeVirtualMachines parameter set
        //
        // [GraphQL: azureNativeVirtualMachines]
        //
        [Parameter(
            ParameterSetName = "NativeVirtualMachines",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure Virtual Machines (VMs).
[GraphQL: azureNativeVirtualMachines]",
            Position = 0
        )]
        public SwitchParameter NativeVirtualMachines { get; set; }

        
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
        // NativeManagedDisks parameter set
        //
        // [GraphQL: azureNativeManagedDisks]
        //
        [Parameter(
            ParameterSetName = "NativeManagedDisks",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure Native Managed Disks.
[GraphQL: azureNativeManagedDisks]",
            Position = 0
        )]
        public SwitchParameter NativeManagedDisks { get; set; }

        
        // -------------------------------------------------------------------
        // AllNativeVirtualNetworks parameter set
        //
        // [GraphQL: allAzureNativeVirtualNetworks]
        //
        [Parameter(
            ParameterSetName = "AllNativeVirtualNetworks",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all virtual networks (VNets) in the protected subscriptions. VNet enables secure communication with other VNets, the internet, and on-premise networks. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/virtual-networks-overview.
[GraphQL: allAzureNativeVirtualNetworks]",
            Position = 0
        )]
        public SwitchParameter AllNativeVirtualNetworks { get; set; }

        
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
        // AllNativeVirtualMachineSizes parameter set
        //
        // [GraphQL: allAzureNativeVirtualMachineSizes]
        //
        [Parameter(
            ParameterSetName = "AllNativeVirtualMachineSizes",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all virtual machine (VM) sizes in the subscriptions protected by Rubrik that have been configured for protection. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.
[GraphQL: allAzureNativeVirtualMachineSizes]",
            Position = 0
        )]
        public SwitchParameter AllNativeVirtualMachineSizes { get; set; }

        
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
        // SqlDatabases parameter set
        //
        // [GraphQL: azureSqlDatabases]
        //
        [Parameter(
            ParameterSetName = "SqlDatabases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure SQL Databases.
[GraphQL: azureSqlDatabases]",
            Position = 0
        )]
        public SwitchParameter SqlDatabases { get; set; }

        
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
        // SqlDatabaseServers parameter set
        //
        // [GraphQL: azureSqlDatabaseServers]
        //
        [Parameter(
            ParameterSetName = "SqlDatabaseServers",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure SQL Database Servers.
[GraphQL: azureSqlDatabaseServers]",
            Position = 0
        )]
        public SwitchParameter SqlDatabaseServers { get; set; }

        
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
        // SqlManagedInstanceDatabases parameter set
        //
        // [GraphQL: azureSqlManagedInstanceDatabases]
        //
        [Parameter(
            ParameterSetName = "SqlManagedInstanceDatabases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure SQL Managed Instance Databases.
[GraphQL: azureSqlManagedInstanceDatabases]",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceDatabases { get; set; }

        
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
        // SqlManagedInstanceServers parameter set
        //
        // [GraphQL: azureSqlManagedInstanceServers]
        //
        [Parameter(
            ParameterSetName = "SqlManagedInstanceServers",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure SQL Managed Instance Servers.
[GraphQL: azureSqlManagedInstanceServers]",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceServers { get; set; }

        
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
        // AllSqlDatabaseServerElasticPools parameter set
        //
        // [GraphQL: allAzureSqlDatabaseServerElasticPools]
        //
        [Parameter(
            ParameterSetName = "AllSqlDatabaseServerElasticPools",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the list of elastic pools available for a SQL Database Server.For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/elastic-pool-overview.
[GraphQL: allAzureSqlDatabaseServerElasticPools]",
            Position = 0
        )]
        public SwitchParameter AllSqlDatabaseServerElasticPools { get; set; }

        
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
        // NativeLiveMountDisks parameter set
        //
        // [GraphQL: azureNativeLiveMountDisks]
        //
        [Parameter(
            ParameterSetName = "NativeLiveMountDisks",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of mounted disks for Azure.
[GraphQL: azureNativeLiveMountDisks]",
            Position = 0
        )]
        public SwitchParameter NativeLiveMountDisks { get; set; }

        
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
        // AllEncryptionKeys parameter set
        //
        // [GraphQL: allAzureEncryptionKeys]
        //
        [Parameter(
            ParameterSetName = "AllEncryptionKeys",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Encryption Keys in an Azure Key Vault.
[GraphQL: allAzureEncryptionKeys]",
            Position = 0
        )]
        public SwitchParameter AllEncryptionKeys { get; set; }

        
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
        // CloudAccountTenantWithExoConfigs parameter set
        //
        // [GraphQL: azureCloudAccountTenantWithExoConfigs]
        //
        [Parameter(
            ParameterSetName = "CloudAccountTenantWithExoConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves details about the Azure cloud account tenant including the Exocompute configurations for the tenant subscriptions, for a specified feature.
[GraphQL: azureCloudAccountTenantWithExoConfigs]",
            Position = 0
        )]
        public SwitchParameter CloudAccountTenantWithExoConfigs { get; set; }

        
        // -------------------------------------------------------------------
        // AllCloudAccountTenantsWithExoConfigs parameter set
        //
        // [GraphQL: allAzureCloudAccountTenantsWithExoConfigs]
        //
        [Parameter(
            ParameterSetName = "AllCloudAccountTenantsWithExoConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves details about all the Azure cloud account tenants including the Exocompute configurations for the tenant subscriptions, for specified set of features.
[GraphQL: allAzureCloudAccountTenantsWithExoConfigs]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountTenantsWithExoConfigs { get; set; }

        
        // -------------------------------------------------------------------
        // AllCloudAccountTenants parameter set
        //
        // [GraphQL: allAzureCloudAccountTenants]
        //
        [Parameter(
            ParameterSetName = "AllCloudAccountTenants",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of all the Azure tenants and tenant subscriptions for features. The list can be filtered by feature status, subscription native ID, and subscription name.
[GraphQL: allAzureCloudAccountTenants]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountTenants { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountSubscriptionWithFeatures parameter set
        //
        // [GraphQL: azureCloudAccountSubscriptionWithFeatures]
        //
        [Parameter(
            ParameterSetName = "CloudAccountSubscriptionWithFeatures",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the details of the Azure cloud account.
[GraphQL: azureCloudAccountSubscriptionWithFeatures]",
            Position = 0
        )]
        public SwitchParameter CloudAccountSubscriptionWithFeatures { get; set; }

        
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
        // AllSubscriptionWithExocomputeMappings parameter set
        //
        // [GraphQL: allAzureSubscriptionWithExocomputeMappings]
        //
        [Parameter(
            ParameterSetName = "AllSubscriptionWithExocomputeMappings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of all Azure subscriptions with Exocompute subscription mapping.
[GraphQL: allAzureSubscriptionWithExocomputeMappings]",
            Position = 0
        )]
        public SwitchParameter AllSubscriptionWithExocomputeMappings { get; set; }

        
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
        // AllCloudAccountMissingPermissions parameter set
        //
        // [GraphQL: allAzureCloudAccountMissingPermissions]
        //
        [Parameter(
            ParameterSetName = "AllCloudAccountMissingPermissions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of all the missing permissions on Azure subscriptions that are a part of the Azure Cloud Account.
[GraphQL: allAzureCloudAccountMissingPermissions]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountMissingPermissions { get; set; }

        
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
        // CloudAccountGrantedPermissionsGroups parameter set
        //
        // [GraphQL: azureCloudAccountGrantedPermissionsGroups]
        //
        [Parameter(
            ParameterSetName = "CloudAccountGrantedPermissionsGroups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the permissions groups which have been granted for a specific feature.
[GraphQL: azureCloudAccountGrantedPermissionsGroups]",
            Position = 0
        )]
        public SwitchParameter CloudAccountGrantedPermissionsGroups { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountGrantedPermissionsGroupsForRecovery parameter set
        //
        // [GraphQL: azureCloudAccountGrantedPermissionsGroupsForRecovery]
        //
        [Parameter(
            ParameterSetName = "CloudAccountGrantedPermissionsGroupsForRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the permissions groups which have been granted for a specific feature.
[GraphQL: azureCloudAccountGrantedPermissionsGroupsForRecovery]",
            Position = 0
        )]
        public SwitchParameter CloudAccountGrantedPermissionsGroupsForRecovery { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountCheckRefreshTokenExistsForRecovery parameter set
        //
        // [GraphQL: azureCloudAccountCheckRefreshTokenExistsForRecovery]
        //
        [Parameter(
            ParameterSetName = "CloudAccountCheckRefreshTokenExistsForRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Check whether a refresh token exists for the current user.
[GraphQL: azureCloudAccountCheckRefreshTokenExistsForRecovery]",
            Position = 0
        )]
        public SwitchParameter CloudAccountCheckRefreshTokenExistsForRecovery { get; set; }

        
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
        // ValidateCloudAccountExocomputeConfigurations parameter set
        //
        // [GraphQL: validateAzureCloudAccountExocomputeConfigurations]
        //
        [Parameter(
            ParameterSetName = "ValidateCloudAccountExocomputeConfigurations",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates if Azure subnets are correctly configured for running Azure Kubernetes Service (AKS) Clusters. When correctly configured, the Azure subnets allow the required region-specific outbound connectivity and do not overlap with Azure restricted IP Address Space.
[GraphQL: validateAzureCloudAccountExocomputeConfigurations]",
            Position = 0
        )]
        public SwitchParameter ValidateCloudAccountExocomputeConfigurations { get; set; }

        
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
        // CheckPersistentStorageSubscriptionCanUnmap parameter set
        //
        // [GraphQL: checkAzurePersistentStorageSubscriptionCanUnmap]
        //
        [Parameter(
            ParameterSetName = "CheckPersistentStorageSubscriptionCanUnmap",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks if we can unmap the archival location from the subscription.
[GraphQL: checkAzurePersistentStorageSubscriptionCanUnmap]",
            Position = 0
        )]
        public SwitchParameter CheckPersistentStorageSubscriptionCanUnmap { get; set; }

        
        // -------------------------------------------------------------------
        // Subscriptions parameter set
        //
        // [GraphQL: azureSubscriptions]
        //
        [Parameter(
            ParameterSetName = "Subscriptions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the subscriptions for the given Azure tenant.
[GraphQL: azureSubscriptions]",
            Position = 0
        )]
        public SwitchParameter Subscriptions { get; set; }

        
        // -------------------------------------------------------------------
        // Regions parameter set
        //
        // [GraphQL: azureRegions]
        //
        [Parameter(
            ParameterSetName = "Regions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the Azure regions for the given subscription.
[GraphQL: azureRegions]",
            Position = 0
        )]
        public SwitchParameter Regions { get; set; }

        
        // -------------------------------------------------------------------
        // ResourceGroups parameter set
        //
        // [GraphQL: azureResourceGroups]
        //
        [Parameter(
            ParameterSetName = "ResourceGroups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the Azure resource groups for the given subscription.
[GraphQL: azureResourceGroups]",
            Position = 0
        )]
        public SwitchParameter ResourceGroups { get; set; }

        
        // -------------------------------------------------------------------
        // VNets parameter set
        //
        // [GraphQL: azureVNets]
        //
        [Parameter(
            ParameterSetName = "VNets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the VNets for the given subscription.
[GraphQL: azureVNets]",
            Position = 0
        )]
        public SwitchParameter VNets { get; set; }

        
        // -------------------------------------------------------------------
        // Subnets parameter set
        //
        // [GraphQL: azureSubnets]
        //
        [Parameter(
            ParameterSetName = "Subnets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the subnets for the given subscription.
[GraphQL: azureSubnets]",
            Position = 0
        )]
        public SwitchParameter Subnets { get; set; }

        
        // -------------------------------------------------------------------
        // StorageAccounts parameter set
        //
        // [GraphQL: azureStorageAccounts]
        //
        [Parameter(
            ParameterSetName = "StorageAccounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the storage accounts for the given subscription.
[GraphQL: azureStorageAccounts]",
            Position = 0
        )]
        public SwitchParameter StorageAccounts { get; set; }

        
        // -------------------------------------------------------------------
        // AllHostedRegions parameter set
        //
        // [GraphQL: allHostedAzureRegions]
        //
        [Parameter(
            ParameterSetName = "AllHostedRegions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Lists all Azure regions supported by the Rubrik-Hosted SaaS protection.
[GraphQL: allHostedAzureRegions]",
            Position = 0
        )]
        public SwitchParameter AllHostedRegions { get; set; }

        
        // -------------------------------------------------------------------
        // AllResourceGroups parameter set
        //
        // [GraphQL: allAzureResourceGroups]
        //
        [Parameter(
            ParameterSetName = "AllResourceGroups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get resource groups for a service principal in Azure.
[GraphQL: allAzureResourceGroups]",
            Position = 0
        )]
        public SwitchParameter AllResourceGroups { get; set; }

        
        // -------------------------------------------------------------------
        // AllVnets parameter set
        //
        // [GraphQL: allAzureVnets]
        //
        [Parameter(
            ParameterSetName = "AllVnets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get VNets for a given account in Azure.
[GraphQL: allAzureVnets]",
            Position = 0
        )]
        public SwitchParameter AllVnets { get; set; }

        
        // -------------------------------------------------------------------
        // AllSubnets parameter set
        //
        // [GraphQL: allAzureSubnets]
        //
        [Parameter(
            ParameterSetName = "AllSubnets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get subnets for a given account in Azure.
[GraphQL: allAzureSubnets]",
            Position = 0
        )]
        public SwitchParameter AllSubnets { get; set; }

        
        // -------------------------------------------------------------------
        // AllCdmVersions parameter set
        //
        // [GraphQL: allAzureCdmVersions]
        //
        [Parameter(
            ParameterSetName = "AllCdmVersions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all Rubrik CDM versions in the Azure marketplace.
[GraphQL: allAzureCdmVersions]",
            Position = 0
        )]
        public SwitchParameter AllCdmVersions { get; set; }

        
        // -------------------------------------------------------------------
        // AllRegions parameter set
        //
        // [GraphQL: allAzureRegions]
        //
        [Parameter(
            ParameterSetName = "AllRegions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all available regions for Azure.
[GraphQL: allAzureRegions]",
            Position = 0
        )]
        public SwitchParameter AllRegions { get; set; }

        
        // -------------------------------------------------------------------
        // AllNsgs parameter set
        //
        // [GraphQL: allAzureNsgs]
        //
        [Parameter(
            ParameterSetName = "AllNsgs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all available network security groups for Azure.
[GraphQL: allAzureNsgs]",
            Position = 0
        )]
        public SwitchParameter AllNsgs { get; set; }

        
        // -------------------------------------------------------------------
        // AllStorageAccounts parameter set
        //
        // [GraphQL: allAzureStorageAccounts]
        //
        [Parameter(
            ParameterSetName = "AllStorageAccounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List all storage accounts from Azure.
[GraphQL: allAzureStorageAccounts]",
            Position = 0
        )]
        public SwitchParameter AllStorageAccounts { get; set; }

        
        // -------------------------------------------------------------------
        // AdDirectories parameter set
        //
        // [GraphQL: azureAdDirectories]
        //
        [Parameter(
            ParameterSetName = "AdDirectories",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All Azure AD directories for the account.
[GraphQL: azureAdDirectories]",
            Position = 0
        )]
        public SwitchParameter AdDirectories { get; set; }

        
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

        
        // -------------------------------------------------------------------
        // AdObjectsByType parameter set
        //
        // [GraphQL: azureAdObjectsByType]
        //
        [Parameter(
            ParameterSetName = "AdObjectsByType",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the Azure AD objects corresponding to the type.
[GraphQL: azureAdObjectsByType]",
            Position = 0
        )]
        public SwitchParameter AdObjectsByType { get; set; }


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
                    case "NativeSubscriptions":
                        this.ProcessRecord_NativeSubscriptions();
                        break;
                    case "NativeResourceGroup":
                        this.ProcessRecord_NativeResourceGroup();
                        break;
                    case "NativeResourceGroups":
                        this.ProcessRecord_NativeResourceGroups();
                        break;
                    case "NativeVirtualMachine":
                        this.ProcessRecord_NativeVirtualMachine();
                        break;
                    case "NativeVirtualMachines":
                        this.ProcessRecord_NativeVirtualMachines();
                        break;
                    case "NativeManagedDisk":
                        this.ProcessRecord_NativeManagedDisk();
                        break;
                    case "NativeManagedDisks":
                        this.ProcessRecord_NativeManagedDisks();
                        break;
                    case "AllNativeVirtualNetworks":
                        this.ProcessRecord_AllNativeVirtualNetworks();
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
                    case "AllNativeVirtualMachineSizes":
                        this.ProcessRecord_AllNativeVirtualMachineSizes();
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
                    case "SqlDatabases":
                        this.ProcessRecord_SqlDatabases();
                        break;
                    case "SqlDatabaseServer":
                        this.ProcessRecord_SqlDatabaseServer();
                        break;
                    case "SqlDatabaseServers":
                        this.ProcessRecord_SqlDatabaseServers();
                        break;
                    case "SqlManagedInstanceDatabase":
                        this.ProcessRecord_SqlManagedInstanceDatabase();
                        break;
                    case "SqlManagedInstanceDatabases":
                        this.ProcessRecord_SqlManagedInstanceDatabases();
                        break;
                    case "SqlManagedInstanceServer":
                        this.ProcessRecord_SqlManagedInstanceServer();
                        break;
                    case "SqlManagedInstanceServers":
                        this.ProcessRecord_SqlManagedInstanceServers();
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
                    case "AllSqlDatabaseServerElasticPools":
                        this.ProcessRecord_AllSqlDatabaseServerElasticPools();
                        break;
                    case "IsNativeSqlDatabaseSnapshotPersistent":
                        this.ProcessRecord_IsNativeSqlDatabaseSnapshotPersistent();
                        break;
                    case "NativeLiveMountDisks":
                        this.ProcessRecord_NativeLiveMountDisks();
                        break;
                    case "AllKeyVaultsByRegion":
                        this.ProcessRecord_AllKeyVaultsByRegion();
                        break;
                    case "AllEncryptionKeys":
                        this.ProcessRecord_AllEncryptionKeys();
                        break;
                    case "CloudAccountTenant":
                        this.ProcessRecord_CloudAccountTenant();
                        break;
                    case "CloudAccountTenantWithExoConfigs":
                        this.ProcessRecord_CloudAccountTenantWithExoConfigs();
                        break;
                    case "AllCloudAccountTenantsWithExoConfigs":
                        this.ProcessRecord_AllCloudAccountTenantsWithExoConfigs();
                        break;
                    case "AllCloudAccountTenants":
                        this.ProcessRecord_AllCloudAccountTenants();
                        break;
                    case "CloudAccountSubscriptionWithFeatures":
                        this.ProcessRecord_CloudAccountSubscriptionWithFeatures();
                        break;
                    case "AllCloudAccountSubscriptionsByFeature":
                        this.ProcessRecord_AllCloudAccountSubscriptionsByFeature();
                        break;
                    case "AllSubscriptionWithExocomputeMappings":
                        this.ProcessRecord_AllSubscriptionWithExocomputeMappings();
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
                    case "AllCloudAccountMissingPermissions":
                        this.ProcessRecord_AllCloudAccountMissingPermissions();
                        break;
                    case "CloudAccountPermissionConfig":
                        this.ProcessRecord_CloudAccountPermissionConfig();
                        break;
                    case "CloudAccountGrantedPermissionsGroups":
                        this.ProcessRecord_CloudAccountGrantedPermissionsGroups();
                        break;
                    case "CloudAccountGrantedPermissionsGroupsForRecovery":
                        this.ProcessRecord_CloudAccountGrantedPermissionsGroupsForRecovery();
                        break;
                    case "CloudAccountCheckRefreshTokenExistsForRecovery":
                        this.ProcessRecord_CloudAccountCheckRefreshTokenExistsForRecovery();
                        break;
                    case "AllExocomputeConfigsInAccount":
                        this.ProcessRecord_AllExocomputeConfigsInAccount();
                        break;
                    case "AllCloudAccountSubnetsByRegion":
                        this.ProcessRecord_AllCloudAccountSubnetsByRegion();
                        break;
                    case "ValidateCloudAccountExocomputeConfigurations":
                        this.ProcessRecord_ValidateCloudAccountExocomputeConfigurations();
                        break;
                    case "AllArmTemplatesByFeature":
                        this.ProcessRecord_AllArmTemplatesByFeature();
                        break;
                    case "CheckPersistentStorageSubscriptionCanUnmap":
                        this.ProcessRecord_CheckPersistentStorageSubscriptionCanUnmap();
                        break;
                    case "Subscriptions":
                        this.ProcessRecord_Subscriptions();
                        break;
                    case "Regions":
                        this.ProcessRecord_Regions();
                        break;
                    case "ResourceGroups":
                        this.ProcessRecord_ResourceGroups();
                        break;
                    case "VNets":
                        this.ProcessRecord_VNets();
                        break;
                    case "Subnets":
                        this.ProcessRecord_Subnets();
                        break;
                    case "StorageAccounts":
                        this.ProcessRecord_StorageAccounts();
                        break;
                    case "AllHostedRegions":
                        this.ProcessRecord_AllHostedRegions();
                        break;
                    case "AllResourceGroups":
                        this.ProcessRecord_AllResourceGroups();
                        break;
                    case "AllVnets":
                        this.ProcessRecord_AllVnets();
                        break;
                    case "AllSubnets":
                        this.ProcessRecord_AllSubnets();
                        break;
                    case "AllCdmVersions":
                        this.ProcessRecord_AllCdmVersions();
                        break;
                    case "AllRegions":
                        this.ProcessRecord_AllRegions();
                        break;
                    case "AllNsgs":
                        this.ProcessRecord_AllNsgs();
                        break;
                    case "AllStorageAccounts":
                        this.ProcessRecord_AllStorageAccounts();
                        break;
                    case "AdDirectories":
                        this.ProcessRecord_AdDirectories();
                        break;
                    case "AdDirectory":
                        this.ProcessRecord_AdDirectory();
                        break;
                    case "AdObjectsByType":
                        this.ProcessRecord_AdObjectsByType();
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
        // azureNativeSubscriptions.
        protected void ProcessRecord_NativeSubscriptions()
        {
            this._logger.name += " -NativeSubscriptions";
            // Invoke graphql operation azureNativeSubscriptions
            InvokeQueryAzureNativeSubscriptions();
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
        // azureNativeResourceGroups.
        protected void ProcessRecord_NativeResourceGroups()
        {
            this._logger.name += " -NativeResourceGroups";
            // Invoke graphql operation azureNativeResourceGroups
            InvokeQueryAzureNativeResourceGroups();
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
        // azureNativeVirtualMachines.
        protected void ProcessRecord_NativeVirtualMachines()
        {
            this._logger.name += " -NativeVirtualMachines";
            // Invoke graphql operation azureNativeVirtualMachines
            InvokeQueryAzureNativeVirtualMachines();
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
        // azureNativeManagedDisks.
        protected void ProcessRecord_NativeManagedDisks()
        {
            this._logger.name += " -NativeManagedDisks";
            // Invoke graphql operation azureNativeManagedDisks
            InvokeQueryAzureNativeManagedDisks();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeVirtualNetworks.
        protected void ProcessRecord_AllNativeVirtualNetworks()
        {
            this._logger.name += " -AllNativeVirtualNetworks";
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
        protected void ProcessRecord_AllNativeVirtualMachineSizes()
        {
            this._logger.name += " -AllNativeVirtualMachineSizes";
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
        // azureSqlDatabases.
        protected void ProcessRecord_SqlDatabases()
        {
            this._logger.name += " -SqlDatabases";
            // Invoke graphql operation azureSqlDatabases
            InvokeQueryAzureSqlDatabases();
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
        // azureSqlDatabaseServers.
        protected void ProcessRecord_SqlDatabaseServers()
        {
            this._logger.name += " -SqlDatabaseServers";
            // Invoke graphql operation azureSqlDatabaseServers
            InvokeQueryAzureSqlDatabaseServers();
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
        // azureSqlManagedInstanceDatabases.
        protected void ProcessRecord_SqlManagedInstanceDatabases()
        {
            this._logger.name += " -SqlManagedInstanceDatabases";
            // Invoke graphql operation azureSqlManagedInstanceDatabases
            InvokeQueryAzureSqlManagedInstanceDatabases();
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
        // azureSqlManagedInstanceServers.
        protected void ProcessRecord_SqlManagedInstanceServers()
        {
            this._logger.name += " -SqlManagedInstanceServers";
            // Invoke graphql operation azureSqlManagedInstanceServers
            InvokeQueryAzureSqlManagedInstanceServers();
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
        protected void ProcessRecord_AllSqlDatabaseServerElasticPools()
        {
            this._logger.name += " -AllSqlDatabaseServerElasticPools";
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
        // azureNativeLiveMountDisks.
        protected void ProcessRecord_NativeLiveMountDisks()
        {
            this._logger.name += " -NativeLiveMountDisks";
            // Invoke graphql operation azureNativeLiveMountDisks
            InvokeQueryAzureNativeLiveMountDisks();
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
        protected void ProcessRecord_AllEncryptionKeys()
        {
            this._logger.name += " -AllEncryptionKeys";
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
        protected void ProcessRecord_CloudAccountTenantWithExoConfigs()
        {
            this._logger.name += " -CloudAccountTenantWithExoConfigs";
            // Invoke graphql operation azureCloudAccountTenantWithExoConfigs
            InvokeQueryAzureCloudAccountTenantWithExoConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountTenantsWithExoConfigs.
        protected void ProcessRecord_AllCloudAccountTenantsWithExoConfigs()
        {
            this._logger.name += " -AllCloudAccountTenantsWithExoConfigs";
            // Invoke graphql operation allAzureCloudAccountTenantsWithExoConfigs
            InvokeQueryAllAzureCloudAccountTenantsWithExoConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountTenants.
        protected void ProcessRecord_AllCloudAccountTenants()
        {
            this._logger.name += " -AllCloudAccountTenants";
            // Invoke graphql operation allAzureCloudAccountTenants
            InvokeQueryAllAzureCloudAccountTenants();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountSubscriptionWithFeatures.
        protected void ProcessRecord_CloudAccountSubscriptionWithFeatures()
        {
            this._logger.name += " -CloudAccountSubscriptionWithFeatures";
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
        protected void ProcessRecord_AllSubscriptionWithExocomputeMappings()
        {
            this._logger.name += " -AllSubscriptionWithExocomputeMappings";
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
        protected void ProcessRecord_AllCloudAccountMissingPermissions()
        {
            this._logger.name += " -AllCloudAccountMissingPermissions";
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
        // azureCloudAccountGrantedPermissionsGroups.
        protected void ProcessRecord_CloudAccountGrantedPermissionsGroups()
        {
            this._logger.name += " -CloudAccountGrantedPermissionsGroups";
            // Invoke graphql operation azureCloudAccountGrantedPermissionsGroups
            InvokeQueryAzureCloudAccountGrantedPermissionsGroups();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountGrantedPermissionsGroupsForRecovery.
        protected void ProcessRecord_CloudAccountGrantedPermissionsGroupsForRecovery()
        {
            this._logger.name += " -CloudAccountGrantedPermissionsGroupsForRecovery";
            // Invoke graphql operation azureCloudAccountGrantedPermissionsGroupsForRecovery
            InvokeQueryAzureCloudAccountGrantedPermissionsGroupsForRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountCheckRefreshTokenExistsForRecovery.
        protected void ProcessRecord_CloudAccountCheckRefreshTokenExistsForRecovery()
        {
            this._logger.name += " -CloudAccountCheckRefreshTokenExistsForRecovery";
            // Invoke graphql operation azureCloudAccountCheckRefreshTokenExistsForRecovery
            InvokeQueryAzureCloudAccountCheckRefreshTokenExistsForRecovery();
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
        protected void ProcessRecord_ValidateCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -ValidateCloudAccountExocomputeConfigurations";
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
        // checkAzurePersistentStorageSubscriptionCanUnmap.
        protected void ProcessRecord_CheckPersistentStorageSubscriptionCanUnmap()
        {
            this._logger.name += " -CheckPersistentStorageSubscriptionCanUnmap";
            // Invoke graphql operation checkAzurePersistentStorageSubscriptionCanUnmap
            InvokeQueryCheckAzurePersistentStorageSubscriptionCanUnmap();
        }

        // This parameter set invokes a single graphql operation:
        // azureSubscriptions.
        protected void ProcessRecord_Subscriptions()
        {
            this._logger.name += " -Subscriptions";
            // Invoke graphql operation azureSubscriptions
            InvokeQueryAzureSubscriptions();
        }

        // This parameter set invokes a single graphql operation:
        // azureRegions.
        protected void ProcessRecord_Regions()
        {
            this._logger.name += " -Regions";
            // Invoke graphql operation azureRegions
            InvokeQueryAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // azureResourceGroups.
        protected void ProcessRecord_ResourceGroups()
        {
            this._logger.name += " -ResourceGroups";
            // Invoke graphql operation azureResourceGroups
            InvokeQueryAzureResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // azureVNets.
        protected void ProcessRecord_VNets()
        {
            this._logger.name += " -VNets";
            // Invoke graphql operation azureVNets
            InvokeQueryAzureVnets();
        }

        // This parameter set invokes a single graphql operation:
        // azureSubnets.
        protected void ProcessRecord_Subnets()
        {
            this._logger.name += " -Subnets";
            // Invoke graphql operation azureSubnets
            InvokeQueryAzureSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // azureStorageAccounts.
        protected void ProcessRecord_StorageAccounts()
        {
            this._logger.name += " -StorageAccounts";
            // Invoke graphql operation azureStorageAccounts
            InvokeQueryAzureStorageAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // allHostedAzureRegions.
        protected void ProcessRecord_AllHostedRegions()
        {
            this._logger.name += " -AllHostedRegions";
            // Invoke graphql operation allHostedAzureRegions
            InvokeQueryAllHostedAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureResourceGroups.
        protected void ProcessRecord_AllResourceGroups()
        {
            this._logger.name += " -AllResourceGroups";
            // Invoke graphql operation allAzureResourceGroups
            InvokeQueryAllAzureResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureVnets.
        protected void ProcessRecord_AllVnets()
        {
            this._logger.name += " -AllVnets";
            // Invoke graphql operation allAzureVnets
            InvokeQueryAllAzureVnets();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSubnets.
        protected void ProcessRecord_AllSubnets()
        {
            this._logger.name += " -AllSubnets";
            // Invoke graphql operation allAzureSubnets
            InvokeQueryAllAzureSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCdmVersions.
        protected void ProcessRecord_AllCdmVersions()
        {
            this._logger.name += " -AllCdmVersions";
            // Invoke graphql operation allAzureCdmVersions
            InvokeQueryAllAzureCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureRegions.
        protected void ProcessRecord_AllRegions()
        {
            this._logger.name += " -AllRegions";
            // Invoke graphql operation allAzureRegions
            InvokeQueryAllAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNsgs.
        protected void ProcessRecord_AllNsgs()
        {
            this._logger.name += " -AllNsgs";
            // Invoke graphql operation allAzureNsgs
            InvokeQueryAllAzureNsgs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureStorageAccounts.
        protected void ProcessRecord_AllStorageAccounts()
        {
            this._logger.name += " -AllStorageAccounts";
            // Invoke graphql operation allAzureStorageAccounts
            InvokeQueryAllAzureStorageAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // azureAdDirectories.
        protected void ProcessRecord_AdDirectories()
        {
            this._logger.name += " -AdDirectories";
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

        // This parameter set invokes a single graphql operation:
        // azureAdObjectsByType.
        protected void ProcessRecord_AdObjectsByType()
        {
            this._logger.name += " -AdObjectsByType";
            // Invoke graphql operation azureAdObjectsByType
            InvokeQueryAzureAdObjectsByType();
        }


        // Invoke GraphQL Query:
        // azureNativeRoot: AzureNativeRoot!
        protected void InvokeQueryAzureNativeRoot()
        {
            Tuple<string, string>[] argDefs = {
            };
            AzureNativeRoot? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNativeRoot)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNativeRoot)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureNativeRoot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureNativeRoot",
                "",
                fieldSpecDoc,
                "AzureNativeRoot"
            );
        }

        // Invoke GraphQL Query:
        // azureNativeSubscription(azureSubscriptionRubrikId: UUID!): AzureNativeSubscription!
        protected void InvokeQueryAzureNativeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
            };
            AzureNativeSubscription? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNativeSubscription)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNativeSubscription)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureNativeSubscription(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureNativeSubscription",
                "($azureSubscriptionRubrikId: UUID!)",
                fieldSpecDoc,
                "AzureNativeSubscription"
            );
        }

        // Invoke GraphQL Query:
        // azureNativeSubscriptions(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureNativeSubscriptionSortFields
        //     sortOrder: SortOrder
        //     subscriptionFilters: AzureNativeSubscriptionFilters
        //     authorizedOperationFilter: Operation
        //     workloadHierarchy: WorkloadLevelHierarchy
        //     azureNativeProtectionFeature: AzureNativeProtectionFeature
        //   ): AzureNativeSubscriptionConnection!
        protected void InvokeQueryAzureNativeSubscriptions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeSubscriptionSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("subscriptionFilters", "AzureNativeSubscriptionFilters"),
                Tuple.Create("authorizedOperationFilter", "Operation"),
                Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
                Tuple.Create("azureNativeProtectionFeature", "AzureNativeProtectionFeature"),
            };
            AzureNativeSubscriptionConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNativeSubscriptionConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNativeSubscriptionConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureNativeSubscriptions(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureNativeSubscriptions",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeSubscriptionSortFields,$sortOrder: SortOrder,$subscriptionFilters: AzureNativeSubscriptionFilters,$authorizedOperationFilter: Operation,$workloadHierarchy: WorkloadLevelHierarchy,$azureNativeProtectionFeature: AzureNativeProtectionFeature)",
                fieldSpecDoc,
                "AzureNativeSubscriptionConnection"
            );
        }

        // Invoke GraphQL Query:
        // azureNativeResourceGroup(resourceGroupId: UUID!): AzureNativeResourceGroup!
        protected void InvokeQueryAzureNativeResourceGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("resourceGroupId", "UUID!"),
            };
            AzureNativeResourceGroup? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNativeResourceGroup)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNativeResourceGroup)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureNativeResourceGroup(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureNativeResourceGroup",
                "($resourceGroupId: UUID!)",
                fieldSpecDoc,
                "AzureNativeResourceGroup"
            );
        }

        // Invoke GraphQL Query:
        // azureNativeResourceGroups(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureNativeCommonResourceGroupSortFields
        //     sortOrder: SortOrder
        //     commonResourceGroupFilters: AzureNativeCommonResourceGroupFilters
        //     protectedObjectTypes: [WorkloadLevelHierarchy!]
        //     azureNativeProtectionFeatures: [AzureNativeProtectionFeature!]
        //   ): AzureNativeResourceGroupConnection!
        protected void InvokeQueryAzureNativeResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeCommonResourceGroupSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("commonResourceGroupFilters", "AzureNativeCommonResourceGroupFilters"),
                Tuple.Create("protectedObjectTypes", "[WorkloadLevelHierarchy!]"),
                Tuple.Create("azureNativeProtectionFeatures", "[AzureNativeProtectionFeature!]"),
            };
            AzureNativeResourceGroupConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNativeResourceGroupConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNativeResourceGroupConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureNativeResourceGroups(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureNativeResourceGroups",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeCommonResourceGroupSortFields,$sortOrder: SortOrder,$commonResourceGroupFilters: AzureNativeCommonResourceGroupFilters,$protectedObjectTypes: [WorkloadLevelHierarchy!],$azureNativeProtectionFeatures: [AzureNativeProtectionFeature!])",
                fieldSpecDoc,
                "AzureNativeResourceGroupConnection"
            );
        }

        // Invoke GraphQL Query:
        // azureNativeVirtualMachine(azureVirtualMachineRubrikId: UUID!): AzureNativeVirtualMachine!
        protected void InvokeQueryAzureNativeVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureVirtualMachineRubrikId", "UUID!"),
            };
            AzureNativeVirtualMachine? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNativeVirtualMachine)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNativeVirtualMachine)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureNativeVirtualMachine(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureNativeVirtualMachine",
                "($azureVirtualMachineRubrikId: UUID!)",
                fieldSpecDoc,
                "AzureNativeVirtualMachine"
            );
        }

        // Invoke GraphQL Query:
        // azureNativeVirtualMachines(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureNativeVirtualMachineSortFields
        //     sortOrder: SortOrder
        //     descendantTypeFilter: [HierarchyObjectTypeEnum!]
        //     virtualMachineFilters: AzureNativeVirtualMachineFilters
        //   ): AzureNativeVirtualMachineConnection!
        protected void InvokeQueryAzureNativeVirtualMachines()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeVirtualMachineSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("descendantTypeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("virtualMachineFilters", "AzureNativeVirtualMachineFilters"),
            };
            AzureNativeVirtualMachineConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNativeVirtualMachineConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNativeVirtualMachineConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureNativeVirtualMachines(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureNativeVirtualMachines",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeVirtualMachineSortFields,$sortOrder: SortOrder,$descendantTypeFilter: [HierarchyObjectTypeEnum!],$virtualMachineFilters: AzureNativeVirtualMachineFilters)",
                fieldSpecDoc,
                "AzureNativeVirtualMachineConnection"
            );
        }

        // Invoke GraphQL Query:
        // azureNativeManagedDisk(azureManagedDiskRubrikId: UUID!): AzureNativeManagedDisk!
        protected void InvokeQueryAzureNativeManagedDisk()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureManagedDiskRubrikId", "UUID!"),
            };
            AzureNativeManagedDisk? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNativeManagedDisk)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNativeManagedDisk)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureNativeManagedDisk(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureNativeManagedDisk",
                "($azureManagedDiskRubrikId: UUID!)",
                fieldSpecDoc,
                "AzureNativeManagedDisk"
            );
        }

        // Invoke GraphQL Query:
        // azureNativeManagedDisks(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureNativeDiskSortFields
        //     sortOrder: SortOrder
        //     diskFilters: AzureNativeDiskFilters
        //   ): AzureNativeManagedDiskConnection!
        protected void InvokeQueryAzureNativeManagedDisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeDiskSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("diskFilters", "AzureNativeDiskFilters"),
            };
            AzureNativeManagedDiskConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNativeManagedDiskConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNativeManagedDiskConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureNativeManagedDisks(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureNativeManagedDisks",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeDiskSortFields,$sortOrder: SortOrder,$diskFilters: AzureNativeDiskFilters)",
                fieldSpecDoc,
                "AzureNativeManagedDiskConnection"
            );
        }

        // Invoke GraphQL Query:
        // allAzureNativeVirtualNetworks(azureSubscriptionRubrikId: UUID): [AzureNativeVirtualNetwork!]!
        protected void InvokeQueryAllAzureNativeVirtualNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID"),
            };
            List<AzureNativeVirtualNetwork>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureNativeVirtualNetwork>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureNativeVirtualNetwork>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureNativeVirtualNetworks(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureNativeVirtualNetworks",
                "($azureSubscriptionRubrikId: UUID)",
                fieldSpecDoc,
                "List<AzureNativeVirtualNetwork>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureNativeSubnetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeSubnet!]!
        protected void InvokeQueryAllAzureNativeSubnetsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            List<AzureNativeSubnet>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureNativeSubnet>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureNativeSubnet>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureNativeSubnetsByRegionFromAzure(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureNativeSubnetsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                fieldSpecDoc,
                "List<AzureNativeSubnet>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureNativeSecurityGroupsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeSecurityGroup!]!
        protected void InvokeQueryAllAzureNativeSecurityGroupsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            List<AzureNativeSecurityGroup>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureNativeSecurityGroup>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureNativeSecurityGroup>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureNativeSecurityGroupsByRegionFromAzure(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureNativeSecurityGroupsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                fieldSpecDoc,
                "List<AzureNativeSecurityGroup>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureDiskEncryptionSetsByRegion(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeDiskEncryptionSet!]!
        protected void InvokeQueryAllAzureDiskEncryptionSetsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            List<AzureNativeDiskEncryptionSet>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureNativeDiskEncryptionSet>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureNativeDiskEncryptionSet>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureDiskEncryptionSetsByRegion(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureDiskEncryptionSetsByRegion",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                fieldSpecDoc,
                "List<AzureNativeDiskEncryptionSet>"
            );
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
            List<AzureNativeAvailabilitySet>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureNativeAvailabilitySet>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureNativeAvailabilitySet>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureNativeAvailabilitySetsByRegionFromAzure(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureNativeAvailabilitySetsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$resourceGroupName: String!,$region: AzureNativeRegion!)",
                fieldSpecDoc,
                "List<AzureNativeAvailabilitySet>"
            );
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
            List<AzureNativeExportCompatibleVmSizes>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureNativeExportCompatibleVmSizes>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureNativeExportCompatibleVmSizes>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureNativeExportCompatibleVmSizesByRegionFromAzure(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!,$vmSnapshotId: UUID!)",
                fieldSpecDoc,
                "List<AzureNativeExportCompatibleVmSizes>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureNativeExportCompatibleDiskTypesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeExportCompatibleDiskTypes!]!
        protected void InvokeQueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            List<AzureNativeExportCompatibleDiskTypes>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureNativeExportCompatibleDiskTypes>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureNativeExportCompatibleDiskTypes>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                fieldSpecDoc,
                "List<AzureNativeExportCompatibleDiskTypes>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureNativeVirtualMachineSizes(azureSubscriptionRubrikId: UUID): [String!]!
        protected void InvokeQueryAllAzureNativeVirtualMachineSizes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID"),
            };
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<System.String>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<System.String>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureNativeVirtualMachineSizes(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureNativeVirtualMachineSizes",
                "($azureSubscriptionRubrikId: UUID)",
                fieldSpecDoc,
                "List<System.String>"
            );
        }

        // Invoke GraphQL Query:
        // isAzureNativeManagedDiskSnapshotRestorable(azureSubscriptionRubrikId: UUID!, diskSnapshotId: UUID!): Boolean!
        protected void InvokeQueryIsAzureNativeManagedDiskSnapshotRestorable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("diskSnapshotId", "UUID!"),
            };
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Query.IsAzureNativeManagedDiskSnapshotRestorable(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryIsAzureNativeManagedDiskSnapshotRestorable",
                "($azureSubscriptionRubrikId: UUID!,$diskSnapshotId: UUID!)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Query:
        // isAzureStorageAccountNameAvailable(azureSubscriptionRubrikId: UUID!, storageAccountName: String!): Boolean!
        protected void InvokeQueryIsAzureStorageAccountNameAvailable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("storageAccountName", "String!"),
            };
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Query.IsAzureStorageAccountNameAvailable(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryIsAzureStorageAccountNameAvailable",
                "($azureSubscriptionRubrikId: UUID!,$storageAccountName: String!)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Query:
        // allAzureNativeStorageAccountsFromAzure(azureSubscriptionRubrikId: UUID!): [AzureNativeStorageAccount!]!
        protected void InvokeQueryAllAzureNativeStorageAccountsFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
            };
            List<AzureNativeStorageAccount>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureNativeStorageAccount>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureNativeStorageAccount>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureNativeStorageAccountsFromAzure(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureNativeStorageAccountsFromAzure",
                "($azureSubscriptionRubrikId: UUID!)",
                fieldSpecDoc,
                "List<AzureNativeStorageAccount>"
            );
        }

        // Invoke GraphQL Query:
        // azureSqlDatabase(azureSqlDatabaseRubrikId: UUID!): AzureSqlDatabaseDb!
        protected void InvokeQueryAzureSqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseRubrikId", "UUID!"),
            };
            AzureSqlDatabaseDb? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureSqlDatabaseDb)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureSqlDatabaseDb)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureSqlDatabase(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureSqlDatabase",
                "($azureSqlDatabaseRubrikId: UUID!)",
                fieldSpecDoc,
                "AzureSqlDatabaseDb"
            );
        }

        // Invoke GraphQL Query:
        // azureSqlDatabases(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureSqlDatabaseSortFields
        //     sortOrder: SortOrder
        //     azureSqlDatabaseFilters: AzureSqlDatabaseFilters
        //   ): AzureSqlDatabaseDbConnection!
        protected void InvokeQueryAzureSqlDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlDatabaseSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlDatabaseFilters", "AzureSqlDatabaseFilters"),
            };
            AzureSqlDatabaseDbConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureSqlDatabaseDbConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureSqlDatabaseDbConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureSqlDatabases(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureSqlDatabases",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlDatabaseSortFields,$sortOrder: SortOrder,$azureSqlDatabaseFilters: AzureSqlDatabaseFilters)",
                fieldSpecDoc,
                "AzureSqlDatabaseDbConnection"
            );
        }

        // Invoke GraphQL Query:
        // azureSqlDatabaseServer(azureSqlDatabaseServerRubrikId: UUID!): AzureSqlDatabaseServer!
        protected void InvokeQueryAzureSqlDatabaseServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            AzureSqlDatabaseServer? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureSqlDatabaseServer)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureSqlDatabaseServer)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureSqlDatabaseServer(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureSqlDatabaseServer",
                "($azureSqlDatabaseServerRubrikId: UUID!)",
                fieldSpecDoc,
                "AzureSqlDatabaseServer"
            );
        }

        // Invoke GraphQL Query:
        // azureSqlDatabaseServers(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureSqlDatabaseServerSortFields
        //     sortOrder: SortOrder
        //     azureSqlDatabaseServerFilters: AzureSqlDatabaseServerFilters
        //   ): AzureSqlDatabaseServerConnection!
        protected void InvokeQueryAzureSqlDatabaseServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlDatabaseServerSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlDatabaseServerFilters", "AzureSqlDatabaseServerFilters"),
            };
            AzureSqlDatabaseServerConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureSqlDatabaseServerConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureSqlDatabaseServerConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureSqlDatabaseServers(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureSqlDatabaseServers",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlDatabaseServerSortFields,$sortOrder: SortOrder,$azureSqlDatabaseServerFilters: AzureSqlDatabaseServerFilters)",
                fieldSpecDoc,
                "AzureSqlDatabaseServerConnection"
            );
        }

        // Invoke GraphQL Query:
        // azureSqlManagedInstanceDatabase(azureSqlManagedInstanceDatabaseRubrikId: UUID!): AzureSqlManagedInstanceDatabase!
        protected void InvokeQueryAzureSqlManagedInstanceDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceDatabaseRubrikId", "UUID!"),
            };
            AzureSqlManagedInstanceDatabase? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureSqlManagedInstanceDatabase)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureSqlManagedInstanceDatabase)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureSqlManagedInstanceDatabase(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureSqlManagedInstanceDatabase",
                "($azureSqlManagedInstanceDatabaseRubrikId: UUID!)",
                fieldSpecDoc,
                "AzureSqlManagedInstanceDatabase"
            );
        }

        // Invoke GraphQL Query:
        // azureSqlManagedInstanceDatabases(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureSqlManagedInstanceDatabaseSortFields
        //     sortOrder: SortOrder
        //     azureSqlManagedInstanceDatabaseFilters: AzureSqlManagedInstanceDatabaseFilters
        //   ): AzureSqlManagedInstanceDatabaseConnection!
        protected void InvokeQueryAzureSqlManagedInstanceDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlManagedInstanceDatabaseSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlManagedInstanceDatabaseFilters", "AzureSqlManagedInstanceDatabaseFilters"),
            };
            AzureSqlManagedInstanceDatabaseConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureSqlManagedInstanceDatabaseConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureSqlManagedInstanceDatabaseConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureSqlManagedInstanceDatabases(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureSqlManagedInstanceDatabases",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlManagedInstanceDatabaseSortFields,$sortOrder: SortOrder,$azureSqlManagedInstanceDatabaseFilters: AzureSqlManagedInstanceDatabaseFilters)",
                fieldSpecDoc,
                "AzureSqlManagedInstanceDatabaseConnection"
            );
        }

        // Invoke GraphQL Query:
        // azureSqlManagedInstanceServer(azureSqlManagedInstanceServerRubrikId: UUID!): AzureSqlManagedInstanceServer!
        protected void InvokeQueryAzureSqlManagedInstanceServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceServerRubrikId", "UUID!"),
            };
            AzureSqlManagedInstanceServer? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureSqlManagedInstanceServer)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureSqlManagedInstanceServer)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureSqlManagedInstanceServer(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureSqlManagedInstanceServer",
                "($azureSqlManagedInstanceServerRubrikId: UUID!)",
                fieldSpecDoc,
                "AzureSqlManagedInstanceServer"
            );
        }

        // Invoke GraphQL Query:
        // azureSqlManagedInstanceServers(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureSqlManagedInstanceServerSortFields
        //     sortOrder: SortOrder
        //     azureSqlManagedInstanceServerFilters: AzureSqlManagedInstanceServerFilters
        //   ): AzureSqlManagedInstanceServerConnection!
        protected void InvokeQueryAzureSqlManagedInstanceServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlManagedInstanceServerSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlManagedInstanceServerFilters", "AzureSqlManagedInstanceServerFilters"),
            };
            AzureSqlManagedInstanceServerConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureSqlManagedInstanceServerConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureSqlManagedInstanceServerConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureSqlManagedInstanceServers(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureSqlManagedInstanceServers",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlManagedInstanceServerSortFields,$sortOrder: SortOrder,$azureSqlManagedInstanceServerFilters: AzureSqlManagedInstanceServerFilters)",
                fieldSpecDoc,
                "AzureSqlManagedInstanceServerConnection"
            );
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
            AzureNativeSqlDatabasePointInTimeRestoreWindow? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNativeSqlDatabasePointInTimeRestoreWindow)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNativeSqlDatabasePointInTimeRestoreWindow)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseName: String!)",
                fieldSpecDoc,
                "AzureNativeSqlDatabasePointInTimeRestoreWindow"
            );
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
            AzureNativeSqlDatabasePointInTimeRestoreWindow? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureNativeSqlDatabasePointInTimeRestoreWindow)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureNativeSqlDatabasePointInTimeRestoreWindow)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlManagedInstanceName: String!,$azureSqlDatabaseName: String!)",
                fieldSpecDoc,
                "AzureNativeSqlDatabasePointInTimeRestoreWindow"
            );
        }

        // Invoke GraphQL Query:
        // validateAzureNativeSqlDatabaseDbNameForExport(azureSqlDatabaseName: String!, azureSqlDatabaseServerRubrikId: UUID!): ValidateAzureNativeSqlDatabaseDbNameForExportReply!
        protected void InvokeQueryValidateAzureNativeSqlDatabaseDbNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseName", "String!"),
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            ValidateAzureNativeSqlDatabaseDbNameForExportReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ValidateAzureNativeSqlDatabaseDbNameForExportReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ValidateAzureNativeSqlDatabaseDbNameForExportReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.ValidateAzureNativeSqlDatabaseDbNameForExport(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryValidateAzureNativeSqlDatabaseDbNameForExport",
                "($azureSqlDatabaseName: String!,$azureSqlDatabaseServerRubrikId: UUID!)",
                fieldSpecDoc,
                "ValidateAzureNativeSqlDatabaseDbNameForExportReply"
            );
        }

        // Invoke GraphQL Query:
        // validateAzureNativeSqlManagedInstanceDbNameForExport(azureSqlDatabaseName: String!, azureSqlManagedInstanceServerRubrikId: UUID!): ValidateAzureNativeSqlManagedInstanceDbNameForExportReply!
        protected void InvokeQueryValidateAzureNativeSqlManagedInstanceDbNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseName", "String!"),
                Tuple.Create("azureSqlManagedInstanceServerRubrikId", "UUID!"),
            };
            ValidateAzureNativeSqlManagedInstanceDbNameForExportReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ValidateAzureNativeSqlManagedInstanceDbNameForExportReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ValidateAzureNativeSqlManagedInstanceDbNameForExportReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.ValidateAzureNativeSqlManagedInstanceDbNameForExport(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryValidateAzureNativeSqlManagedInstanceDbNameForExport",
                "($azureSqlDatabaseName: String!,$azureSqlManagedInstanceServerRubrikId: UUID!)",
                fieldSpecDoc,
                "ValidateAzureNativeSqlManagedInstanceDbNameForExportReply"
            );
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
            List<AzureSqlDatabaseServerElasticPool>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureSqlDatabaseServerElasticPool>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureSqlDatabaseServerElasticPool>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureSqlDatabaseServerElasticPools(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureSqlDatabaseServerElasticPools",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseServerRubrikId: UUID!)",
                fieldSpecDoc,
                "List<AzureSqlDatabaseServerElasticPool>"
            );
        }

        // Invoke GraphQL Query:
        // isAzureNativeSqlDatabaseSnapshotPersistent(snapshotId: UUID!): Boolean!
        protected void InvokeQueryIsAzureNativeSqlDatabaseSnapshotPersistent()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "UUID!"),
            };
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Query.IsAzureNativeSqlDatabaseSnapshotPersistent(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryIsAzureNativeSqlDatabaseSnapshotPersistent",
                "($snapshotId: UUID!)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Query:
        // azureNativeLiveMountDisks(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     cloudNativeObjectType: CloudNativeObjectType!
        //     liveMountFilters: [CloudNativeLiveMountFilter!]
        //     sortBy: CloudNativeLiveMountSortByFields
        //     sortOrder: SortOrder
        //   ): LiveMountDetailsConnection!
        protected void InvokeQueryAzureNativeLiveMountDisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("cloudNativeObjectType", "CloudNativeObjectType!"),
                Tuple.Create("liveMountFilters", "[CloudNativeLiveMountFilter!]"),
                Tuple.Create("sortBy", "CloudNativeLiveMountSortByFields"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            LiveMountDetailsConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (LiveMountDetailsConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (LiveMountDetailsConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureNativeLiveMountDisks(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureNativeLiveMountDisks",
                "($first: Int,$after: String,$last: Int,$before: String,$cloudNativeObjectType: CloudNativeObjectType!,$liveMountFilters: [CloudNativeLiveMountFilter!],$sortBy: CloudNativeLiveMountSortByFields,$sortOrder: SortOrder)",
                fieldSpecDoc,
                "LiveMountDetailsConnection"
            );
        }

        // Invoke GraphQL Query:
        // allAzureKeyVaultsByRegion(azureKeyVaultsInput: AzureKeyVaultsInput!): [AzureKeyVault!]!
        protected void InvokeQueryAllAzureKeyVaultsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureKeyVaultsInput", "AzureKeyVaultsInput!"),
            };
            List<AzureKeyVault>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureKeyVault>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureKeyVault>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureKeyVaultsByRegion(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureKeyVaultsByRegion",
                "($azureKeyVaultsInput: AzureKeyVaultsInput!)",
                fieldSpecDoc,
                "List<AzureKeyVault>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureEncryptionKeys(azureEncryptionKeysInput: AzureEncryptionKeysInput!): [AzureEncryptionKey!]!
        protected void InvokeQueryAllAzureEncryptionKeys()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureEncryptionKeysInput", "AzureEncryptionKeysInput!"),
            };
            List<AzureEncryptionKey>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureEncryptionKey>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureEncryptionKey>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureEncryptionKeys(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureEncryptionKeys",
                "($azureEncryptionKeysInput: AzureEncryptionKeysInput!)",
                fieldSpecDoc,
                "List<AzureEncryptionKey>"
            );
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
            AzureCloudAccountTenant? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureCloudAccountTenant)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureCloudAccountTenant)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureCloudAccountTenant(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureCloudAccountTenant",
                "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])",
                fieldSpecDoc,
                "AzureCloudAccountTenant"
            );
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
            AzureCloudAccountTenantWithExoConfigs? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureCloudAccountTenantWithExoConfigs)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureCloudAccountTenantWithExoConfigs)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureCloudAccountTenantWithExoConfigs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureCloudAccountTenantWithExoConfigs",
                "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])",
                fieldSpecDoc,
                "AzureCloudAccountTenantWithExoConfigs"
            );
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountTenantsWithExoConfigs(features: [CloudAccountFeature!]!): [AzureCloudAccountTenantWithExoConfigs!]!
        protected void InvokeQueryAllAzureCloudAccountTenantsWithExoConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]!"),
            };
            List<AzureCloudAccountTenantWithExoConfigs>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureCloudAccountTenantWithExoConfigs>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureCloudAccountTenantWithExoConfigs>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureCloudAccountTenantsWithExoConfigs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureCloudAccountTenantsWithExoConfigs",
                "($features: [CloudAccountFeature!]!)",
                fieldSpecDoc,
                "List<AzureCloudAccountTenantWithExoConfigs>"
            );
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
            List<AzureCloudAccountTenant>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureCloudAccountTenant>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureCloudAccountTenant>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureCloudAccountTenants(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureCloudAccountTenants",
                "($features: [CloudAccountFeature!],$feature: CloudAccountFeature!,$includeSubscriptionDetails: Boolean!)",
                fieldSpecDoc,
                "List<AzureCloudAccountTenant>"
            );
        }

        // Invoke GraphQL Query:
        // azureCloudAccountSubscriptionWithFeatures(cloudAccountId: UUID!): AzureCloudAccountSubscriptionWithFeatures!
        protected void InvokeQueryAzureCloudAccountSubscriptionWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
            };
            AzureCloudAccountSubscriptionWithFeatures? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureCloudAccountSubscriptionWithFeatures)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureCloudAccountSubscriptionWithFeatures)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureCloudAccountSubscriptionWithFeatures(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureCloudAccountSubscriptionWithFeatures",
                "($cloudAccountId: UUID!)",
                fieldSpecDoc,
                "AzureCloudAccountSubscriptionWithFeatures"
            );
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountSubscriptionsByFeature(feature: CloudAccountFeature!, subscriptionStatusFilters: [CloudAccountStatus!]!): [AzureSubscriptionWithFeaturesType!]!
        protected void InvokeQueryAllAzureCloudAccountSubscriptionsByFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
            };
            List<AzureSubscriptionWithFeaturesType>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureSubscriptionWithFeaturesType>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureSubscriptionWithFeaturesType>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureCloudAccountSubscriptionsByFeature(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureCloudAccountSubscriptionsByFeature",
                "($feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!)",
                fieldSpecDoc,
                "List<AzureSubscriptionWithFeaturesType>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureSubscriptionWithExocomputeMappings(features: [CloudAccountFeature!], exocomputeSubscriptionIdsFilter: [UUID!]): [AzureSubscriptionWithExocomputeMapping!]!
        protected void InvokeQueryAllAzureSubscriptionWithExocomputeMappings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("exocomputeSubscriptionIdsFilter", "[UUID!]"),
            };
            List<AzureSubscriptionWithExocomputeMapping>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureSubscriptionWithExocomputeMapping>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureSubscriptionWithExocomputeMapping>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureSubscriptionWithExocomputeMappings(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureSubscriptionWithExocomputeMappings",
                "($features: [CloudAccountFeature!],$exocomputeSubscriptionIdsFilter: [UUID!])",
                fieldSpecDoc,
                "List<AzureSubscriptionWithExocomputeMapping>"
            );
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
            List<AzureResourceGroup>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureResourceGroup>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureResourceGroup>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllResourceGroupsFromAzure(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllResourceGroupsFromAzure",
                "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$feature: CloudAccountFeature!)",
                fieldSpecDoc,
                "List<AzureResourceGroup>"
            );
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
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Query.DoesAzureNativeResourceGroupExist(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryDoesAzureNativeResourceGroupExist",
                "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$resourceGroupName: String!,$feature: CloudAccountFeature!)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Query:
        // allAzureNativeResourceGroupsInfoIfExist(input: AzureGetResourceGroupsInfoIfExistInput!): [AzureResourceGroupInfo!]!
        protected void InvokeQueryAllAzureNativeResourceGroupsInfoIfExist()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureGetResourceGroupsInfoIfExistInput!"),
            };
            List<AzureResourceGroupInfo>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureResourceGroupInfo>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureResourceGroupInfo>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureNativeResourceGroupsInfoIfExist(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureNativeResourceGroupsInfoIfExist",
                "($input: AzureGetResourceGroupsInfoIfExistInput!)",
                fieldSpecDoc,
                "List<AzureResourceGroupInfo>"
            );
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
            List<AzureSubscriptionMissingPermissions>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureSubscriptionMissingPermissions>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureSubscriptionMissingPermissions>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureCloudAccountMissingPermissions(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureCloudAccountMissingPermissions",
                "($sessionId: String!,$subscriptionIds: [UUID!]!,$cloudAccountAction: CloudAccountAction!)",
                fieldSpecDoc,
                "List<AzureSubscriptionMissingPermissions>"
            );
        }

        // Invoke GraphQL Query:
        // azureCloudAccountPermissionConfig(feature: CloudAccountFeature!): AzureCloudAccountPermissionConfigResponse!
        protected void InvokeQueryAzureCloudAccountPermissionConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            AzureCloudAccountPermissionConfigResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureCloudAccountPermissionConfigResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureCloudAccountPermissionConfigResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureCloudAccountPermissionConfig(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureCloudAccountPermissionConfig",
                "($feature: CloudAccountFeature!)",
                fieldSpecDoc,
                "AzureCloudAccountPermissionConfigResponse"
            );
        }

        // Invoke GraphQL Query:
        // azureCloudAccountGrantedPermissionsGroups(cloudAccountId: UUID!, feature: CloudAccountFeature!): AzureCloudAccountGrantedPermissionsGroupsReply!
        protected void InvokeQueryAzureCloudAccountGrantedPermissionsGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            AzureCloudAccountGrantedPermissionsGroupsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureCloudAccountGrantedPermissionsGroupsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureCloudAccountGrantedPermissionsGroupsReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureCloudAccountGrantedPermissionsGroups(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureCloudAccountGrantedPermissionsGroups",
                "($cloudAccountId: UUID!,$feature: CloudAccountFeature!)",
                fieldSpecDoc,
                "AzureCloudAccountGrantedPermissionsGroupsReply"
            );
        }

        // Invoke GraphQL Query:
        // azureCloudAccountGrantedPermissionsGroupsForRecovery(cloudAccountId: UUID!, azureNativeSubscriptionId: UUID!, feature: CloudAccountFeature!): AzureCloudAccountGrantedPermissionsGroupsReply!
        protected void InvokeQueryAzureCloudAccountGrantedPermissionsGroupsForRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureNativeSubscriptionId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            AzureCloudAccountGrantedPermissionsGroupsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureCloudAccountGrantedPermissionsGroupsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureCloudAccountGrantedPermissionsGroupsReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureCloudAccountGrantedPermissionsGroupsForRecovery(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureCloudAccountGrantedPermissionsGroupsForRecovery",
                "($cloudAccountId: UUID!,$azureNativeSubscriptionId: UUID!,$feature: CloudAccountFeature!)",
                fieldSpecDoc,
                "AzureCloudAccountGrantedPermissionsGroupsReply"
            );
        }

        // Invoke GraphQL Query:
        // azureCloudAccountCheckRefreshTokenExistsForRecovery(cloudAccountId: UUID!, azureNativeSubscriptionId: UUID!): AzureCloudAccountCheckRefreshTokenExistsReply!
        protected void InvokeQueryAzureCloudAccountCheckRefreshTokenExistsForRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureNativeSubscriptionId", "UUID!"),
            };
            AzureCloudAccountCheckRefreshTokenExistsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureCloudAccountCheckRefreshTokenExistsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureCloudAccountCheckRefreshTokenExistsReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureCloudAccountCheckRefreshTokenExistsForRecovery(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureCloudAccountCheckRefreshTokenExistsForRecovery",
                "($cloudAccountId: UUID!,$azureNativeSubscriptionId: UUID!)",
                fieldSpecDoc,
                "AzureCloudAccountCheckRefreshTokenExistsReply"
            );
        }

        // Invoke GraphQL Query:
        // allAzureExocomputeConfigsInAccount(azureExocomputeSearchQuery: String, cloudAccountIDs: [UUID!]): [AzureExocomputeConfigsInAccount!]!
        protected void InvokeQueryAllAzureExocomputeConfigsInAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureExocomputeSearchQuery", "String"),
                Tuple.Create("cloudAccountIDs", "[UUID!]"),
            };
            List<AzureExocomputeConfigsInAccount>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureExocomputeConfigsInAccount>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureExocomputeConfigsInAccount>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureExocomputeConfigsInAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureExocomputeConfigsInAccount",
                "($azureExocomputeSearchQuery: String,$cloudAccountIDs: [UUID!])",
                fieldSpecDoc,
                "List<AzureExocomputeConfigsInAccount>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountSubnetsByRegion(cloudAccountId: UUID!, region: AzureCloudAccountRegion!): [AzureNativeSubnet!]!
        protected void InvokeQueryAllAzureCloudAccountSubnetsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("region", "AzureCloudAccountRegion!"),
            };
            List<AzureNativeSubnet>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureNativeSubnet>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureNativeSubnet>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureCloudAccountSubnetsByRegion(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureCloudAccountSubnetsByRegion",
                "($cloudAccountId: UUID!,$region: AzureCloudAccountRegion!)",
                fieldSpecDoc,
                "List<AzureNativeSubnet>"
            );
        }

        // Invoke GraphQL Query:
        // validateAzureCloudAccountExocomputeConfigurations(input: ValidateAzureCloudAccountExocomputeConfigurationsInput!): ValidateAzureSubnetsForCloudAccountExocomputeReply!
        protected void InvokeQueryValidateAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            ValidateAzureSubnetsForCloudAccountExocomputeReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ValidateAzureSubnetsForCloudAccountExocomputeReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ValidateAzureSubnetsForCloudAccountExocomputeReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.ValidateAzureCloudAccountExocomputeConfigurations(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryValidateAzureCloudAccountExocomputeConfigurations",
                "($input: ValidateAzureCloudAccountExocomputeConfigurationsInput!)",
                fieldSpecDoc,
                "ValidateAzureSubnetsForCloudAccountExocomputeReply"
            );
        }

        // Invoke GraphQL Query:
        // allAzureArmTemplatesByFeature(input: AzureArmTemplatesByFeatureInput!): [AzureArmTemplateByFeature!]!
        protected void InvokeQueryAllAzureArmTemplatesByFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureArmTemplatesByFeatureInput!"),
            };
            List<AzureArmTemplateByFeature>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureArmTemplateByFeature>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureArmTemplateByFeature>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureArmTemplatesByFeature(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureArmTemplatesByFeature",
                "($input: AzureArmTemplatesByFeatureInput!)",
                fieldSpecDoc,
                "List<AzureArmTemplateByFeature>"
            );
        }

        // Invoke GraphQL Query:
        // checkAzurePersistentStorageSubscriptionCanUnmap(cloudAccountId: UUID!, feature: CloudAccountFeature!, unmappingValidationType: UnmappingValidationType!): CheckAzurePersistentStorageSubscriptionCanUnmapReply!
        protected void InvokeQueryCheckAzurePersistentStorageSubscriptionCanUnmap()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("unmappingValidationType", "UnmappingValidationType!"),
            };
            CheckAzurePersistentStorageSubscriptionCanUnmapReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CheckAzurePersistentStorageSubscriptionCanUnmapReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CheckAzurePersistentStorageSubscriptionCanUnmapReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.CheckAzurePersistentStorageSubscriptionCanUnmap(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryCheckAzurePersistentStorageSubscriptionCanUnmap",
                "($cloudAccountId: UUID!,$feature: CloudAccountFeature!,$unmappingValidationType: UnmappingValidationType!)",
                fieldSpecDoc,
                "CheckAzurePersistentStorageSubscriptionCanUnmapReply"
            );
        }

        // Invoke GraphQL Query:
        // azureSubscriptions(tenantId: String!): AzureSubscriptionConnection!
        protected void InvokeQueryAzureSubscriptions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
            };
            AzureSubscriptionConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureSubscriptionConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureSubscriptionConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureSubscriptions(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureSubscriptions",
                "($tenantId: String!)",
                fieldSpecDoc,
                "AzureSubscriptionConnection"
            );
        }

        // Invoke GraphQL Query:
        // azureRegions(tenantId: String!, subscriptionId: UUID!): RegionConnection!
        protected void InvokeQueryAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            RegionConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RegionConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RegionConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureRegions(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureRegions",
                "($tenantId: String!,$subscriptionId: UUID!)",
                fieldSpecDoc,
                "RegionConnection"
            );
        }

        // Invoke GraphQL Query:
        // azureResourceGroups(tenantId: String!, subscriptionId: UUID!): ResourceGroupConnection!
        protected void InvokeQueryAzureResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            ResourceGroupConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ResourceGroupConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ResourceGroupConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureResourceGroups(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureResourceGroups",
                "($tenantId: String!,$subscriptionId: UUID!)",
                fieldSpecDoc,
                "ResourceGroupConnection"
            );
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
            VnetConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VnetConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VnetConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureVnets(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureVnets",
                "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)",
                fieldSpecDoc,
                "VnetConnection"
            );
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
            SubnetConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (SubnetConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (SubnetConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureSubnets(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureSubnets",
                "($tenantId: String!,$subscriptionId: UUID!,$vNetId: String!)",
                fieldSpecDoc,
                "SubnetConnection"
            );
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
            StorageAccountConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (StorageAccountConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (StorageAccountConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureStorageAccounts(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureStorageAccounts",
                "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)",
                fieldSpecDoc,
                "StorageAccountConnection"
            );
        }

        // Invoke GraphQL Query:
        // allHostedAzureRegions: AzureRegionsResp!
        protected void InvokeQueryAllHostedAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
            };
            AzureRegionsResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureRegionsResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureRegionsResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllHostedAzureRegions(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllHostedAzureRegions",
                "",
                fieldSpecDoc,
                "AzureRegionsResp"
            );
        }

        // Invoke GraphQL Query:
        // allAzureResourceGroups(cloudAccountId: String!, azureRegion: String!): [String!]!
        protected void InvokeQueryAllAzureResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
                Tuple.Create("azureRegion", "String!"),
            };
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<System.String>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<System.String>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureResourceGroups(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureResourceGroups",
                "($cloudAccountId: String!,$azureRegion: String!)",
                fieldSpecDoc,
                "List<System.String>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureVnets(vnetRequest: AzureVnetReq!): [String!]!
        protected void InvokeQueryAllAzureVnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("vnetRequest", "AzureVnetReq!"),
            };
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<System.String>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<System.String>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureVnets(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureVnets",
                "($vnetRequest: AzureVnetReq!)",
                fieldSpecDoc,
                "List<System.String>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureSubnets(subnetRequest: AzureSubnetReq!): [String!]!
        protected void InvokeQueryAllAzureSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subnetRequest", "AzureSubnetReq!"),
            };
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<System.String>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<System.String>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureSubnets(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureSubnets",
                "($subnetRequest: AzureSubnetReq!)",
                fieldSpecDoc,
                "List<System.String>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureCdmVersions(cdmVersionRequest: AzureCdmVersionReq!): [AzureCdmVersion!]!
        protected void InvokeQueryAllAzureCdmVersions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmVersionRequest", "AzureCdmVersionReq!"),
            };
            List<AzureCdmVersion>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureCdmVersion>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureCdmVersion>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureCdmVersions(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureCdmVersions",
                "($cdmVersionRequest: AzureCdmVersionReq!)",
                fieldSpecDoc,
                "List<AzureCdmVersion>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureRegions(cloudAccountId: String!): [AzureCloudAccountRegion!]!
        protected void InvokeQueryAllAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
            };
            List<AzureCloudAccountRegion>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AzureCloudAccountRegion>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AzureCloudAccountRegion>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureRegions(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureRegions",
                "($cloudAccountId: String!)",
                fieldSpecDoc,
                "List<AzureCloudAccountRegion>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureNsgs(nsgRequest: AzureNsgRequest!): [String!]!
        protected void InvokeQueryAllAzureNsgs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("nsgRequest", "AzureNsgRequest!"),
            };
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<System.String>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<System.String>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureNsgs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureNsgs",
                "($nsgRequest: AzureNsgRequest!)",
                fieldSpecDoc,
                "List<System.String>"
            );
        }

        // Invoke GraphQL Query:
        // allAzureStorageAccounts(storageAccountsRequest: AzureStorageAccountsReq!): [String!]!
        protected void InvokeQueryAllAzureStorageAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("storageAccountsRequest", "AzureStorageAccountsReq!"),
            };
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<System.String>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<System.String>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAzureStorageAccounts(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAzureStorageAccounts",
                "($storageAccountsRequest: AzureStorageAccountsReq!)",
                fieldSpecDoc,
                "List<System.String>"
            );
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
            AzureAdDirectoryConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureAdDirectoryConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureAdDirectoryConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureAdDirectories(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureAdDirectories",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "AzureAdDirectoryConnection"
            );
        }

        // Invoke GraphQL Query:
        // azureAdDirectory(workloadFid: UUID!): AzureAdDirectory!
        protected void InvokeQueryAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadFid", "UUID!"),
            };
            AzureAdDirectory? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureAdDirectory)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureAdDirectory)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureAdDirectory(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureAdDirectory",
                "($workloadFid: UUID!)",
                fieldSpecDoc,
                "AzureAdDirectory"
            );
        }

        // Invoke GraphQL Query:
        // azureAdObjectsByType(
        //     first: Int
        //     after: String
        //     sortByOption: [AzureAdObjectSearchType!]
        //     sortOrder: SortOrder
        //     input: AzureAdObjectTypeInput!
        //   ): AzureAdObjectConnection!
        protected void InvokeQueryAzureAdObjectsByType()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortByOption", "[AzureAdObjectSearchType!]"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("input", "AzureAdObjectTypeInput!"),
            };
            AzureAdObjectConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureAdObjectConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureAdObjectConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AzureAdObjectsByType(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAzureAdObjectsByType",
                "($first: Int,$after: String,$sortByOption: [AzureAdObjectSearchType!],$sortOrder: SortOrder,$input: AzureAdObjectTypeInput!)",
                fieldSpecDoc,
                "AzureAdObjectConnection"
            );
        }


    } // class Invoke_RscQueryAzure
}