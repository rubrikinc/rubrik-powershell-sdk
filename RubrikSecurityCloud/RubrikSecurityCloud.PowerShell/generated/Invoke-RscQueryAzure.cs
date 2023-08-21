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
    /// <summary>
    /// Azure queries
    /// </summary>
    /// <description>
    /// Invoke-RscQueryAzure is a master cmdlet for Azure work that can invoke any of the following subcommands: NativeRoot, NativeSubscription, NativeSubscriptions, NativeResourceGroup, NativeResourceGroups, NativeVirtualMachine, NativeVirtualMachines, NativeManagedDisk, NativeManagedDisks, AllNativeVirtualNetworks, AllNativeSubnetsByRegionFromAzure, AllNativeSecurityGroupsByRegionFromAzure, AllDiskEncryptionSetsByRegion, AllNativeAvailabilitySetsByRegionFromAzure, AllNativeExportCompatibleVmSizesByRegionFromAzure, AllNativeExportCompatibleDiskTypesByRegionFromAzure, AllNativeVirtualMachineSizes, IsNativeManagedDiskSnapshotRestorable, IsStorageAccountNameAvailable, AllNativeStorageAccountsFromAzure, SqlDatabase, SqlDatabases, SqlDatabaseServer, SqlDatabaseServers, SqlManagedInstanceDatabase, SqlManagedInstanceDatabases, SqlManagedInstanceServer, SqlManagedInstanceServers, SqlDatabaseDbPointInTimeRestoreWindowFromAzure, SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure, ValidateNativeSqlDatabaseDbNameForExport, ValidateNativeSqlManagedInstanceDbNameForExport, AllSqlDatabaseServerElasticPools, IsNativeSqlDatabaseSnapshotPersistent, NativeLiveMountDisks, AllKeyVaultsByRegion, AllEncryptionKeys, CloudAccountTenant, CloudAccountTenantWithExoConfigs, AllCloudAccountTenantsWithExoConfigs, AllCloudAccountTenants, CloudAccountSubscriptionWithFeatures, AllCloudAccountSubscriptionsByFeature, AllSubscriptionWithExocomputeMappings, AllResourceGroupsFrom, DoesNativeResourceGroupExist, AllNativeResourceGroupsInfoIfExist, AllCloudAccountMissingPermissions, CloudAccountPermissionConfig, CloudAccountGrantedPermissionsGroups, CloudAccountGrantedPermissionsGroupsForRecovery, CloudAccountCheckRefreshTokenExistsForRecovery, AllExocomputeConfigsInAccount, AllCloudAccountSubnetsByRegion, ValidateCloudAccountExocomputeConfigurations, AllArmTemplatesByFeature, CheckPersistentStorageSubscriptionCanUnmap, Subscriptions, Regions, ResourceGroups, VNets, Subnets, StorageAccounts, AllHostedRegions, AllResourceGroups, AllVnets, AllSubnets, AllCdmVersions, AllRegions, AllNsgs, AllStorageAccounts, AllManagedIdentities, AdDirectories, AdDirectory, AdObjectsByType.
    /// </description>
    /// <example>
    /// <code>Invoke-RscQueryAzure -NativeRoot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -NativeSubscription [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -NativeSubscriptions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -NativeResourceGroup [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -NativeResourceGroups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -NativeVirtualMachine [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -NativeVirtualMachines [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -NativeManagedDisk [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -NativeManagedDisks [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllNativeVirtualNetworks [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllNativeSubnetsByRegionFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllDiskEncryptionSetsByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllNativeVirtualMachineSizes [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -IsStorageAccountNameAvailable [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllNativeStorageAccountsFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -SqlDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -SqlDatabases [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -SqlDatabaseServer [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -SqlDatabaseServers [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -SqlManagedInstanceDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -SqlManagedInstanceDatabases [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -SqlManagedInstanceServer [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -SqlManagedInstanceServers [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllSqlDatabaseServerElasticPools [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -NativeLiveMountDisks [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllKeyVaultsByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllEncryptionKeys [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -CloudAccountTenant [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -CloudAccountTenantWithExoConfigs [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllCloudAccountTenantsWithExoConfigs [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllCloudAccountTenants [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -CloudAccountSubscriptionWithFeatures [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllCloudAccountSubscriptionsByFeature [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllSubscriptionWithExocomputeMappings [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllResourceGroupsFrom [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -DoesNativeResourceGroupExist [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllNativeResourceGroupsInfoIfExist [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllCloudAccountMissingPermissions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -CloudAccountPermissionConfig [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -CloudAccountGrantedPermissionsGroups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -CloudAccountGrantedPermissionsGroupsForRecovery [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -CloudAccountCheckRefreshTokenExistsForRecovery [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllExocomputeConfigsInAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllCloudAccountSubnetsByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllArmTemplatesByFeature [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -Subscriptions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -Regions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -ResourceGroups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -VNets [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -Subnets [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -StorageAccounts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllHostedRegions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllResourceGroups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllVnets [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllSubnets [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllCdmVersions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllRegions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllNsgs [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllStorageAccounts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AllManagedIdentities [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AdDirectories [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AdDirectory [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAzure -AdObjectsByType [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscQueryAzure",
        DefaultParameterSetName = "VNets")
    ]
    public class Invoke_RscQueryAzure : RscPSCmdlet
    {
        
        /// <summary>
        /// NativeRoot parameter set
        ///
        /// [GraphQL: azureNativeRoot]
        /// </summary>
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

        
        /// <summary>
        /// NativeSubscription parameter set
        ///
        /// [GraphQL: azureNativeSubscription]
        /// </summary>
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

        
        /// <summary>
        /// NativeSubscriptions parameter set
        ///
        /// [GraphQL: azureNativeSubscriptions]
        /// </summary>
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

        
        /// <summary>
        /// NativeResourceGroup parameter set
        ///
        /// [GraphQL: azureNativeResourceGroup]
        /// </summary>
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

        
        /// <summary>
        /// NativeResourceGroups parameter set
        ///
        /// [GraphQL: azureNativeResourceGroups]
        /// </summary>
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

        
        /// <summary>
        /// NativeVirtualMachine parameter set
        ///
        /// [GraphQL: azureNativeVirtualMachine]
        /// </summary>
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

        
        /// <summary>
        /// NativeVirtualMachines parameter set
        ///
        /// [GraphQL: azureNativeVirtualMachines]
        /// </summary>
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

        
        /// <summary>
        /// NativeManagedDisk parameter set
        ///
        /// [GraphQL: azureNativeManagedDisk]
        /// </summary>
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

        
        /// <summary>
        /// NativeManagedDisks parameter set
        ///
        /// [GraphQL: azureNativeManagedDisks]
        /// </summary>
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

        
        /// <summary>
        /// AllNativeVirtualNetworks parameter set
        ///
        /// [GraphQL: allAzureNativeVirtualNetworks]
        /// </summary>
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

        
        /// <summary>
        /// AllNativeSubnetsByRegionFromAzure parameter set
        ///
        /// [GraphQL: allAzureNativeSubnetsByRegionFromAzure]
        /// </summary>
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

        
        /// <summary>
        /// AllNativeSecurityGroupsByRegionFromAzure parameter set
        ///
        /// [GraphQL: allAzureNativeSecurityGroupsByRegionFromAzure]
        /// </summary>
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

        
        /// <summary>
        /// AllDiskEncryptionSetsByRegion parameter set
        ///
        /// [GraphQL: allAzureDiskEncryptionSetsByRegion]
        /// </summary>
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

        
        /// <summary>
        /// AllNativeAvailabilitySetsByRegionFromAzure parameter set
        ///
        /// [GraphQL: allAzureNativeAvailabilitySetsByRegionFromAzure]
        /// </summary>
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

        
        /// <summary>
        /// AllNativeExportCompatibleVmSizesByRegionFromAzure parameter set
        ///
        /// [GraphQL: allAzureNativeExportCompatibleVmSizesByRegionFromAzure]
        /// </summary>
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

        
        /// <summary>
        /// AllNativeExportCompatibleDiskTypesByRegionFromAzure parameter set
        ///
        /// [GraphQL: allAzureNativeExportCompatibleDiskTypesByRegionFromAzure]
        /// </summary>
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

        
        /// <summary>
        /// AllNativeVirtualMachineSizes parameter set
        ///
        /// [GraphQL: allAzureNativeVirtualMachineSizes]
        /// </summary>
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

        
        /// <summary>
        /// IsNativeManagedDiskSnapshotRestorable parameter set
        ///
        /// [GraphQL: isAzureNativeManagedDiskSnapshotRestorable]
        /// </summary>
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

        
        /// <summary>
        /// IsStorageAccountNameAvailable parameter set
        ///
        /// [GraphQL: isAzureStorageAccountNameAvailable]
        /// </summary>
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

        
        /// <summary>
        /// AllNativeStorageAccountsFromAzure parameter set
        ///
        /// [GraphQL: allAzureNativeStorageAccountsFromAzure]
        /// </summary>
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

        
        /// <summary>
        /// SqlDatabase parameter set
        ///
        /// [GraphQL: azureSqlDatabase]
        /// </summary>
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

        
        /// <summary>
        /// SqlDatabases parameter set
        ///
        /// [GraphQL: azureSqlDatabases]
        /// </summary>
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

        
        /// <summary>
        /// SqlDatabaseServer parameter set
        ///
        /// [GraphQL: azureSqlDatabaseServer]
        /// </summary>
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

        
        /// <summary>
        /// SqlDatabaseServers parameter set
        ///
        /// [GraphQL: azureSqlDatabaseServers]
        /// </summary>
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

        
        /// <summary>
        /// SqlManagedInstanceDatabase parameter set
        ///
        /// [GraphQL: azureSqlManagedInstanceDatabase]
        /// </summary>
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

        
        /// <summary>
        /// SqlManagedInstanceDatabases parameter set
        ///
        /// [GraphQL: azureSqlManagedInstanceDatabases]
        /// </summary>
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

        
        /// <summary>
        /// SqlManagedInstanceServer parameter set
        ///
        /// [GraphQL: azureSqlManagedInstanceServer]
        /// </summary>
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

        
        /// <summary>
        /// SqlManagedInstanceServers parameter set
        ///
        /// [GraphQL: azureSqlManagedInstanceServers]
        /// </summary>
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

        
        /// <summary>
        /// SqlDatabaseDbPointInTimeRestoreWindowFromAzure parameter set
        ///
        /// [GraphQL: azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure]
        /// </summary>
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

        
        /// <summary>
        /// SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure parameter set
        ///
        /// [GraphQL: azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure]
        /// </summary>
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

        
        /// <summary>
        /// ValidateNativeSqlDatabaseDbNameForExport parameter set
        ///
        /// [GraphQL: validateAzureNativeSqlDatabaseDbNameForExport]
        /// </summary>
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

        
        /// <summary>
        /// ValidateNativeSqlManagedInstanceDbNameForExport parameter set
        ///
        /// [GraphQL: validateAzureNativeSqlManagedInstanceDbNameForExport]
        /// </summary>
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

        
        /// <summary>
        /// AllSqlDatabaseServerElasticPools parameter set
        ///
        /// [GraphQL: allAzureSqlDatabaseServerElasticPools]
        /// </summary>
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

        
        /// <summary>
        /// IsNativeSqlDatabaseSnapshotPersistent parameter set
        ///
        /// [GraphQL: isAzureNativeSqlDatabaseSnapshotPersistent]
        /// </summary>
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

        
        /// <summary>
        /// NativeLiveMountDisks parameter set
        ///
        /// [GraphQL: azureNativeLiveMountDisks]
        /// </summary>
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

        
        /// <summary>
        /// AllKeyVaultsByRegion parameter set
        ///
        /// [GraphQL: allAzureKeyVaultsByRegion]
        /// </summary>
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

        
        /// <summary>
        /// AllEncryptionKeys parameter set
        ///
        /// [GraphQL: allAzureEncryptionKeys]
        /// </summary>
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

        
        /// <summary>
        /// CloudAccountTenant parameter set
        ///
        /// [GraphQL: azureCloudAccountTenant]
        /// </summary>
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

        
        /// <summary>
        /// CloudAccountTenantWithExoConfigs parameter set
        ///
        /// [GraphQL: azureCloudAccountTenantWithExoConfigs]
        /// </summary>
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

        
        /// <summary>
        /// AllCloudAccountTenantsWithExoConfigs parameter set
        ///
        /// [GraphQL: allAzureCloudAccountTenantsWithExoConfigs]
        /// </summary>
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

        
        /// <summary>
        /// AllCloudAccountTenants parameter set
        ///
        /// [GraphQL: allAzureCloudAccountTenants]
        /// </summary>
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

        
        /// <summary>
        /// CloudAccountSubscriptionWithFeatures parameter set
        ///
        /// [GraphQL: azureCloudAccountSubscriptionWithFeatures]
        /// </summary>
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

        
        /// <summary>
        /// AllCloudAccountSubscriptionsByFeature parameter set
        ///
        /// [GraphQL: allAzureCloudAccountSubscriptionsByFeature]
        /// </summary>
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

        
        /// <summary>
        /// AllSubscriptionWithExocomputeMappings parameter set
        ///
        /// [GraphQL: allAzureSubscriptionWithExocomputeMappings]
        /// </summary>
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

        
        /// <summary>
        /// AllResourceGroupsFrom parameter set
        ///
        /// [GraphQL: allResourceGroupsFromAzure]
        /// </summary>
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

        
        /// <summary>
        /// DoesNativeResourceGroupExist parameter set
        ///
        /// [GraphQL: doesAzureNativeResourceGroupExist]
        /// </summary>
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

        
        /// <summary>
        /// AllNativeResourceGroupsInfoIfExist parameter set
        ///
        /// [GraphQL: allAzureNativeResourceGroupsInfoIfExist]
        /// </summary>
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

        
        /// <summary>
        /// AllCloudAccountMissingPermissions parameter set
        ///
        /// [GraphQL: allAzureCloudAccountMissingPermissions]
        /// </summary>
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

        
        /// <summary>
        /// CloudAccountPermissionConfig parameter set
        ///
        /// [GraphQL: azureCloudAccountPermissionConfig]
        /// </summary>
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

        
        /// <summary>
        /// CloudAccountGrantedPermissionsGroups parameter set
        ///
        /// [GraphQL: azureCloudAccountGrantedPermissionsGroups]
        /// </summary>
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

        
        /// <summary>
        /// CloudAccountGrantedPermissionsGroupsForRecovery parameter set
        ///
        /// [GraphQL: azureCloudAccountGrantedPermissionsGroupsForRecovery]
        /// </summary>
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

        
        /// <summary>
        /// CloudAccountCheckRefreshTokenExistsForRecovery parameter set
        ///
        /// [GraphQL: azureCloudAccountCheckRefreshTokenExistsForRecovery]
        /// </summary>
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

        
        /// <summary>
        /// AllExocomputeConfigsInAccount parameter set
        ///
        /// [GraphQL: allAzureExocomputeConfigsInAccount]
        /// </summary>
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

        
        /// <summary>
        /// AllCloudAccountSubnetsByRegion parameter set
        ///
        /// [GraphQL: allAzureCloudAccountSubnetsByRegion]
        /// </summary>
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

        
        /// <summary>
        /// ValidateCloudAccountExocomputeConfigurations parameter set
        ///
        /// [GraphQL: validateAzureCloudAccountExocomputeConfigurations]
        /// </summary>
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

        
        /// <summary>
        /// AllArmTemplatesByFeature parameter set
        ///
        /// [GraphQL: allAzureArmTemplatesByFeature]
        /// </summary>
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

        
        /// <summary>
        /// CheckPersistentStorageSubscriptionCanUnmap parameter set
        ///
        /// [GraphQL: checkAzurePersistentStorageSubscriptionCanUnmap]
        /// </summary>
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

        
        /// <summary>
        /// Subscriptions parameter set
        ///
        /// [GraphQL: azureSubscriptions]
        /// </summary>
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

        
        /// <summary>
        /// Regions parameter set
        ///
        /// [GraphQL: azureRegions]
        /// </summary>
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

        
        /// <summary>
        /// ResourceGroups parameter set
        ///
        /// [GraphQL: azureResourceGroups]
        /// </summary>
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

        
        /// <summary>
        /// VNets parameter set
        ///
        /// [GraphQL: azureVNets]
        /// </summary>
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

        
        /// <summary>
        /// Subnets parameter set
        ///
        /// [GraphQL: azureSubnets]
        /// </summary>
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

        
        /// <summary>
        /// StorageAccounts parameter set
        ///
        /// [GraphQL: azureStorageAccounts]
        /// </summary>
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

        
        /// <summary>
        /// AllHostedRegions parameter set
        ///
        /// [GraphQL: allHostedAzureRegions]
        /// </summary>
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

        
        /// <summary>
        /// AllResourceGroups parameter set
        ///
        /// [GraphQL: allAzureResourceGroups]
        /// </summary>
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

        
        /// <summary>
        /// AllVnets parameter set
        ///
        /// [GraphQL: allAzureVnets]
        /// </summary>
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

        
        /// <summary>
        /// AllSubnets parameter set
        ///
        /// [GraphQL: allAzureSubnets]
        /// </summary>
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

        
        /// <summary>
        /// AllCdmVersions parameter set
        ///
        /// [GraphQL: allAzureCdmVersions]
        /// </summary>
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

        
        /// <summary>
        /// AllRegions parameter set
        ///
        /// [GraphQL: allAzureRegions]
        /// </summary>
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

        
        /// <summary>
        /// AllNsgs parameter set
        ///
        /// [GraphQL: allAzureNsgs]
        /// </summary>
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

        
        /// <summary>
        /// AllStorageAccounts parameter set
        ///
        /// [GraphQL: allAzureStorageAccounts]
        /// </summary>
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

        
        /// <summary>
        /// AllManagedIdentities parameter set
        ///
        /// [GraphQL: allAzureManagedIdentities]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllManagedIdentities",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List all managed identities for Azure resources.
[GraphQL: allAzureManagedIdentities]",
            Position = 0
        )]
        public SwitchParameter AllManagedIdentities { get; set; }

        
        /// <summary>
        /// AdDirectories parameter set
        ///
        /// [GraphQL: azureAdDirectories]
        /// </summary>
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

        
        /// <summary>
        /// AdDirectory parameter set
        ///
        /// [GraphQL: azureAdDirectory]
        /// </summary>
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

        
        /// <summary>
        /// AdObjectsByType parameter set
        ///
        /// [GraphQL: azureAdObjectsByType]
        /// </summary>
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


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
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
                    case "AllManagedIdentities":
                        this.ProcessRecord_AllManagedIdentities();
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
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // azureNativeRoot.
        internal void ProcessRecord_NativeRoot()
        {
            this._logger.name += " -NativeRoot";
            // Invoke graphql operation azureNativeRoot
            InvokeQueryAzureNativeRoot();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeSubscription.
        internal void ProcessRecord_NativeSubscription()
        {
            this._logger.name += " -NativeSubscription";
            // Invoke graphql operation azureNativeSubscription
            InvokeQueryAzureNativeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeSubscriptions.
        internal void ProcessRecord_NativeSubscriptions()
        {
            this._logger.name += " -NativeSubscriptions";
            // Invoke graphql operation azureNativeSubscriptions
            InvokeQueryAzureNativeSubscriptions();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeResourceGroup.
        internal void ProcessRecord_NativeResourceGroup()
        {
            this._logger.name += " -NativeResourceGroup";
            // Invoke graphql operation azureNativeResourceGroup
            InvokeQueryAzureNativeResourceGroup();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeResourceGroups.
        internal void ProcessRecord_NativeResourceGroups()
        {
            this._logger.name += " -NativeResourceGroups";
            // Invoke graphql operation azureNativeResourceGroups
            InvokeQueryAzureNativeResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeVirtualMachine.
        internal void ProcessRecord_NativeVirtualMachine()
        {
            this._logger.name += " -NativeVirtualMachine";
            // Invoke graphql operation azureNativeVirtualMachine
            InvokeQueryAzureNativeVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeVirtualMachines.
        internal void ProcessRecord_NativeVirtualMachines()
        {
            this._logger.name += " -NativeVirtualMachines";
            // Invoke graphql operation azureNativeVirtualMachines
            InvokeQueryAzureNativeVirtualMachines();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeManagedDisk.
        internal void ProcessRecord_NativeManagedDisk()
        {
            this._logger.name += " -NativeManagedDisk";
            // Invoke graphql operation azureNativeManagedDisk
            InvokeQueryAzureNativeManagedDisk();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeManagedDisks.
        internal void ProcessRecord_NativeManagedDisks()
        {
            this._logger.name += " -NativeManagedDisks";
            // Invoke graphql operation azureNativeManagedDisks
            InvokeQueryAzureNativeManagedDisks();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeVirtualNetworks.
        internal void ProcessRecord_AllNativeVirtualNetworks()
        {
            this._logger.name += " -AllNativeVirtualNetworks";
            // Invoke graphql operation allAzureNativeVirtualNetworks
            InvokeQueryAllAzureNativeVirtualNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeSubnetsByRegionFromAzure.
        internal void ProcessRecord_AllNativeSubnetsByRegionFromAzure()
        {
            this._logger.name += " -AllNativeSubnetsByRegionFromAzure";
            // Invoke graphql operation allAzureNativeSubnetsByRegionFromAzure
            InvokeQueryAllAzureNativeSubnetsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeSecurityGroupsByRegionFromAzure.
        internal void ProcessRecord_AllNativeSecurityGroupsByRegionFromAzure()
        {
            this._logger.name += " -AllNativeSecurityGroupsByRegionFromAzure";
            // Invoke graphql operation allAzureNativeSecurityGroupsByRegionFromAzure
            InvokeQueryAllAzureNativeSecurityGroupsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureDiskEncryptionSetsByRegion.
        internal void ProcessRecord_AllDiskEncryptionSetsByRegion()
        {
            this._logger.name += " -AllDiskEncryptionSetsByRegion";
            // Invoke graphql operation allAzureDiskEncryptionSetsByRegion
            InvokeQueryAllAzureDiskEncryptionSetsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeAvailabilitySetsByRegionFromAzure.
        internal void ProcessRecord_AllNativeAvailabilitySetsByRegionFromAzure()
        {
            this._logger.name += " -AllNativeAvailabilitySetsByRegionFromAzure";
            // Invoke graphql operation allAzureNativeAvailabilitySetsByRegionFromAzure
            InvokeQueryAllAzureNativeAvailabilitySetsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeExportCompatibleVmSizesByRegionFromAzure.
        internal void ProcessRecord_AllNativeExportCompatibleVmSizesByRegionFromAzure()
        {
            this._logger.name += " -AllNativeExportCompatibleVmSizesByRegionFromAzure";
            // Invoke graphql operation allAzureNativeExportCompatibleVmSizesByRegionFromAzure
            InvokeQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeExportCompatibleDiskTypesByRegionFromAzure.
        internal void ProcessRecord_AllNativeExportCompatibleDiskTypesByRegionFromAzure()
        {
            this._logger.name += " -AllNativeExportCompatibleDiskTypesByRegionFromAzure";
            // Invoke graphql operation allAzureNativeExportCompatibleDiskTypesByRegionFromAzure
            InvokeQueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeVirtualMachineSizes.
        internal void ProcessRecord_AllNativeVirtualMachineSizes()
        {
            this._logger.name += " -AllNativeVirtualMachineSizes";
            // Invoke graphql operation allAzureNativeVirtualMachineSizes
            InvokeQueryAllAzureNativeVirtualMachineSizes();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureNativeManagedDiskSnapshotRestorable.
        internal void ProcessRecord_IsNativeManagedDiskSnapshotRestorable()
        {
            this._logger.name += " -IsNativeManagedDiskSnapshotRestorable";
            // Invoke graphql operation isAzureNativeManagedDiskSnapshotRestorable
            InvokeQueryIsAzureNativeManagedDiskSnapshotRestorable();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureStorageAccountNameAvailable.
        internal void ProcessRecord_IsStorageAccountNameAvailable()
        {
            this._logger.name += " -IsStorageAccountNameAvailable";
            // Invoke graphql operation isAzureStorageAccountNameAvailable
            InvokeQueryIsAzureStorageAccountNameAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeStorageAccountsFromAzure.
        internal void ProcessRecord_AllNativeStorageAccountsFromAzure()
        {
            this._logger.name += " -AllNativeStorageAccountsFromAzure";
            // Invoke graphql operation allAzureNativeStorageAccountsFromAzure
            InvokeQueryAllAzureNativeStorageAccountsFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabase.
        internal void ProcessRecord_SqlDatabase()
        {
            this._logger.name += " -SqlDatabase";
            // Invoke graphql operation azureSqlDatabase
            InvokeQueryAzureSqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabases.
        internal void ProcessRecord_SqlDatabases()
        {
            this._logger.name += " -SqlDatabases";
            // Invoke graphql operation azureSqlDatabases
            InvokeQueryAzureSqlDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabaseServer.
        internal void ProcessRecord_SqlDatabaseServer()
        {
            this._logger.name += " -SqlDatabaseServer";
            // Invoke graphql operation azureSqlDatabaseServer
            InvokeQueryAzureSqlDatabaseServer();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabaseServers.
        internal void ProcessRecord_SqlDatabaseServers()
        {
            this._logger.name += " -SqlDatabaseServers";
            // Invoke graphql operation azureSqlDatabaseServers
            InvokeQueryAzureSqlDatabaseServers();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceDatabase.
        internal void ProcessRecord_SqlManagedInstanceDatabase()
        {
            this._logger.name += " -SqlManagedInstanceDatabase";
            // Invoke graphql operation azureSqlManagedInstanceDatabase
            InvokeQueryAzureSqlManagedInstanceDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceDatabases.
        internal void ProcessRecord_SqlManagedInstanceDatabases()
        {
            this._logger.name += " -SqlManagedInstanceDatabases";
            // Invoke graphql operation azureSqlManagedInstanceDatabases
            InvokeQueryAzureSqlManagedInstanceDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceServer.
        internal void ProcessRecord_SqlManagedInstanceServer()
        {
            this._logger.name += " -SqlManagedInstanceServer";
            // Invoke graphql operation azureSqlManagedInstanceServer
            InvokeQueryAzureSqlManagedInstanceServer();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceServers.
        internal void ProcessRecord_SqlManagedInstanceServers()
        {
            this._logger.name += " -SqlManagedInstanceServers";
            // Invoke graphql operation azureSqlManagedInstanceServers
            InvokeQueryAzureSqlManagedInstanceServers();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure.
        internal void ProcessRecord_SqlDatabaseDbPointInTimeRestoreWindowFromAzure()
        {
            this._logger.name += " -SqlDatabaseDbPointInTimeRestoreWindowFromAzure";
            // Invoke graphql operation azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure
            InvokeQueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure.
        internal void ProcessRecord_SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure()
        {
            this._logger.name += " -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure";
            // Invoke graphql operation azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
            InvokeQueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureNativeSqlDatabaseDbNameForExport.
        internal void ProcessRecord_ValidateNativeSqlDatabaseDbNameForExport()
        {
            this._logger.name += " -ValidateNativeSqlDatabaseDbNameForExport";
            // Invoke graphql operation validateAzureNativeSqlDatabaseDbNameForExport
            InvokeQueryValidateAzureNativeSqlDatabaseDbNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureNativeSqlManagedInstanceDbNameForExport.
        internal void ProcessRecord_ValidateNativeSqlManagedInstanceDbNameForExport()
        {
            this._logger.name += " -ValidateNativeSqlManagedInstanceDbNameForExport";
            // Invoke graphql operation validateAzureNativeSqlManagedInstanceDbNameForExport
            InvokeQueryValidateAzureNativeSqlManagedInstanceDbNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSqlDatabaseServerElasticPools.
        internal void ProcessRecord_AllSqlDatabaseServerElasticPools()
        {
            this._logger.name += " -AllSqlDatabaseServerElasticPools";
            // Invoke graphql operation allAzureSqlDatabaseServerElasticPools
            InvokeQueryAllAzureSqlDatabaseServerElasticPools();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureNativeSqlDatabaseSnapshotPersistent.
        internal void ProcessRecord_IsNativeSqlDatabaseSnapshotPersistent()
        {
            this._logger.name += " -IsNativeSqlDatabaseSnapshotPersistent";
            // Invoke graphql operation isAzureNativeSqlDatabaseSnapshotPersistent
            InvokeQueryIsAzureNativeSqlDatabaseSnapshotPersistent();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeLiveMountDisks.
        internal void ProcessRecord_NativeLiveMountDisks()
        {
            this._logger.name += " -NativeLiveMountDisks";
            // Invoke graphql operation azureNativeLiveMountDisks
            InvokeQueryAzureNativeLiveMountDisks();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureKeyVaultsByRegion.
        internal void ProcessRecord_AllKeyVaultsByRegion()
        {
            this._logger.name += " -AllKeyVaultsByRegion";
            // Invoke graphql operation allAzureKeyVaultsByRegion
            InvokeQueryAllAzureKeyVaultsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureEncryptionKeys.
        internal void ProcessRecord_AllEncryptionKeys()
        {
            this._logger.name += " -AllEncryptionKeys";
            // Invoke graphql operation allAzureEncryptionKeys
            InvokeQueryAllAzureEncryptionKeys();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountTenant.
        internal void ProcessRecord_CloudAccountTenant()
        {
            this._logger.name += " -CloudAccountTenant";
            // Invoke graphql operation azureCloudAccountTenant
            InvokeQueryAzureCloudAccountTenant();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountTenantWithExoConfigs.
        internal void ProcessRecord_CloudAccountTenantWithExoConfigs()
        {
            this._logger.name += " -CloudAccountTenantWithExoConfigs";
            // Invoke graphql operation azureCloudAccountTenantWithExoConfigs
            InvokeQueryAzureCloudAccountTenantWithExoConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountTenantsWithExoConfigs.
        internal void ProcessRecord_AllCloudAccountTenantsWithExoConfigs()
        {
            this._logger.name += " -AllCloudAccountTenantsWithExoConfigs";
            // Invoke graphql operation allAzureCloudAccountTenantsWithExoConfigs
            InvokeQueryAllAzureCloudAccountTenantsWithExoConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountTenants.
        internal void ProcessRecord_AllCloudAccountTenants()
        {
            this._logger.name += " -AllCloudAccountTenants";
            // Invoke graphql operation allAzureCloudAccountTenants
            InvokeQueryAllAzureCloudAccountTenants();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountSubscriptionWithFeatures.
        internal void ProcessRecord_CloudAccountSubscriptionWithFeatures()
        {
            this._logger.name += " -CloudAccountSubscriptionWithFeatures";
            // Invoke graphql operation azureCloudAccountSubscriptionWithFeatures
            InvokeQueryAzureCloudAccountSubscriptionWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountSubscriptionsByFeature.
        internal void ProcessRecord_AllCloudAccountSubscriptionsByFeature()
        {
            this._logger.name += " -AllCloudAccountSubscriptionsByFeature";
            // Invoke graphql operation allAzureCloudAccountSubscriptionsByFeature
            InvokeQueryAllAzureCloudAccountSubscriptionsByFeature();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSubscriptionWithExocomputeMappings.
        internal void ProcessRecord_AllSubscriptionWithExocomputeMappings()
        {
            this._logger.name += " -AllSubscriptionWithExocomputeMappings";
            // Invoke graphql operation allAzureSubscriptionWithExocomputeMappings
            InvokeQueryAllAzureSubscriptionWithExocomputeMappings();
        }

        // This parameter set invokes a single graphql operation:
        // allResourceGroupsFromAzure.
        internal void ProcessRecord_AllResourceGroupsFrom()
        {
            this._logger.name += " -AllResourceGroupsFrom";
            // Invoke graphql operation allResourceGroupsFromAzure
            InvokeQueryAllResourceGroupsFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // doesAzureNativeResourceGroupExist.
        internal void ProcessRecord_DoesNativeResourceGroupExist()
        {
            this._logger.name += " -DoesNativeResourceGroupExist";
            // Invoke graphql operation doesAzureNativeResourceGroupExist
            InvokeQueryDoesAzureNativeResourceGroupExist();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeResourceGroupsInfoIfExist.
        internal void ProcessRecord_AllNativeResourceGroupsInfoIfExist()
        {
            this._logger.name += " -AllNativeResourceGroupsInfoIfExist";
            // Invoke graphql operation allAzureNativeResourceGroupsInfoIfExist
            InvokeQueryAllAzureNativeResourceGroupsInfoIfExist();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountMissingPermissions.
        internal void ProcessRecord_AllCloudAccountMissingPermissions()
        {
            this._logger.name += " -AllCloudAccountMissingPermissions";
            // Invoke graphql operation allAzureCloudAccountMissingPermissions
            InvokeQueryAllAzureCloudAccountMissingPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountPermissionConfig.
        internal void ProcessRecord_CloudAccountPermissionConfig()
        {
            this._logger.name += " -CloudAccountPermissionConfig";
            // Invoke graphql operation azureCloudAccountPermissionConfig
            InvokeQueryAzureCloudAccountPermissionConfig();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountGrantedPermissionsGroups.
        internal void ProcessRecord_CloudAccountGrantedPermissionsGroups()
        {
            this._logger.name += " -CloudAccountGrantedPermissionsGroups";
            // Invoke graphql operation azureCloudAccountGrantedPermissionsGroups
            InvokeQueryAzureCloudAccountGrantedPermissionsGroups();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountGrantedPermissionsGroupsForRecovery.
        internal void ProcessRecord_CloudAccountGrantedPermissionsGroupsForRecovery()
        {
            this._logger.name += " -CloudAccountGrantedPermissionsGroupsForRecovery";
            // Invoke graphql operation azureCloudAccountGrantedPermissionsGroupsForRecovery
            InvokeQueryAzureCloudAccountGrantedPermissionsGroupsForRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountCheckRefreshTokenExistsForRecovery.
        internal void ProcessRecord_CloudAccountCheckRefreshTokenExistsForRecovery()
        {
            this._logger.name += " -CloudAccountCheckRefreshTokenExistsForRecovery";
            // Invoke graphql operation azureCloudAccountCheckRefreshTokenExistsForRecovery
            InvokeQueryAzureCloudAccountCheckRefreshTokenExistsForRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureExocomputeConfigsInAccount.
        internal void ProcessRecord_AllExocomputeConfigsInAccount()
        {
            this._logger.name += " -AllExocomputeConfigsInAccount";
            // Invoke graphql operation allAzureExocomputeConfigsInAccount
            InvokeQueryAllAzureExocomputeConfigsInAccount();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountSubnetsByRegion.
        internal void ProcessRecord_AllCloudAccountSubnetsByRegion()
        {
            this._logger.name += " -AllCloudAccountSubnetsByRegion";
            // Invoke graphql operation allAzureCloudAccountSubnetsByRegion
            InvokeQueryAllAzureCloudAccountSubnetsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureCloudAccountExocomputeConfigurations.
        internal void ProcessRecord_ValidateCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -ValidateCloudAccountExocomputeConfigurations";
            // Invoke graphql operation validateAzureCloudAccountExocomputeConfigurations
            InvokeQueryValidateAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureArmTemplatesByFeature.
        internal void ProcessRecord_AllArmTemplatesByFeature()
        {
            this._logger.name += " -AllArmTemplatesByFeature";
            // Invoke graphql operation allAzureArmTemplatesByFeature
            InvokeQueryAllAzureArmTemplatesByFeature();
        }

        // This parameter set invokes a single graphql operation:
        // checkAzurePersistentStorageSubscriptionCanUnmap.
        internal void ProcessRecord_CheckPersistentStorageSubscriptionCanUnmap()
        {
            this._logger.name += " -CheckPersistentStorageSubscriptionCanUnmap";
            // Invoke graphql operation checkAzurePersistentStorageSubscriptionCanUnmap
            InvokeQueryCheckAzurePersistentStorageSubscriptionCanUnmap();
        }

        // This parameter set invokes a single graphql operation:
        // azureSubscriptions.
        internal void ProcessRecord_Subscriptions()
        {
            this._logger.name += " -Subscriptions";
            // Invoke graphql operation azureSubscriptions
            InvokeQueryAzureSubscriptions();
        }

        // This parameter set invokes a single graphql operation:
        // azureRegions.
        internal void ProcessRecord_Regions()
        {
            this._logger.name += " -Regions";
            // Invoke graphql operation azureRegions
            InvokeQueryAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // azureResourceGroups.
        internal void ProcessRecord_ResourceGroups()
        {
            this._logger.name += " -ResourceGroups";
            // Invoke graphql operation azureResourceGroups
            InvokeQueryAzureResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // azureVNets.
        internal void ProcessRecord_VNets()
        {
            this._logger.name += " -VNets";
            // Invoke graphql operation azureVNets
            InvokeQueryAzureVnets();
        }

        // This parameter set invokes a single graphql operation:
        // azureSubnets.
        internal void ProcessRecord_Subnets()
        {
            this._logger.name += " -Subnets";
            // Invoke graphql operation azureSubnets
            InvokeQueryAzureSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // azureStorageAccounts.
        internal void ProcessRecord_StorageAccounts()
        {
            this._logger.name += " -StorageAccounts";
            // Invoke graphql operation azureStorageAccounts
            InvokeQueryAzureStorageAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // allHostedAzureRegions.
        internal void ProcessRecord_AllHostedRegions()
        {
            this._logger.name += " -AllHostedRegions";
            // Invoke graphql operation allHostedAzureRegions
            InvokeQueryAllHostedAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureResourceGroups.
        internal void ProcessRecord_AllResourceGroups()
        {
            this._logger.name += " -AllResourceGroups";
            // Invoke graphql operation allAzureResourceGroups
            InvokeQueryAllAzureResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureVnets.
        internal void ProcessRecord_AllVnets()
        {
            this._logger.name += " -AllVnets";
            // Invoke graphql operation allAzureVnets
            InvokeQueryAllAzureVnets();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSubnets.
        internal void ProcessRecord_AllSubnets()
        {
            this._logger.name += " -AllSubnets";
            // Invoke graphql operation allAzureSubnets
            InvokeQueryAllAzureSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCdmVersions.
        internal void ProcessRecord_AllCdmVersions()
        {
            this._logger.name += " -AllCdmVersions";
            // Invoke graphql operation allAzureCdmVersions
            InvokeQueryAllAzureCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureRegions.
        internal void ProcessRecord_AllRegions()
        {
            this._logger.name += " -AllRegions";
            // Invoke graphql operation allAzureRegions
            InvokeQueryAllAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNsgs.
        internal void ProcessRecord_AllNsgs()
        {
            this._logger.name += " -AllNsgs";
            // Invoke graphql operation allAzureNsgs
            InvokeQueryAllAzureNsgs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureStorageAccounts.
        internal void ProcessRecord_AllStorageAccounts()
        {
            this._logger.name += " -AllStorageAccounts";
            // Invoke graphql operation allAzureStorageAccounts
            InvokeQueryAllAzureStorageAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureManagedIdentities.
        internal void ProcessRecord_AllManagedIdentities()
        {
            this._logger.name += " -AllManagedIdentities";
            // Invoke graphql operation allAzureManagedIdentities
            InvokeQueryAllAzureManagedIdentities();
        }

        // This parameter set invokes a single graphql operation:
        // azureAdDirectories.
        internal void ProcessRecord_AdDirectories()
        {
            this._logger.name += " -AdDirectories";
            // Invoke graphql operation azureAdDirectories
            InvokeQueryAzureAdDirectories();
        }

        // This parameter set invokes a single graphql operation:
        // azureAdDirectory.
        internal void ProcessRecord_AdDirectory()
        {
            this._logger.name += " -AdDirectory";
            // Invoke graphql operation azureAdDirectory
            InvokeQueryAzureAdDirectory();
        }

        // This parameter set invokes a single graphql operation:
        // azureAdObjectsByType.
        internal void ProcessRecord_AdObjectsByType()
        {
            this._logger.name += " -AdObjectsByType";
            // Invoke graphql operation azureAdObjectsByType
            InvokeQueryAzureAdObjectsByType();
        }


        // Invoke GraphQL Query:
        // azureNativeRoot: AzureNativeRoot!
        internal void InvokeQueryAzureNativeRoot()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeRoot",
                "",
                "AzureNativeRoot"
                );
            AzureNativeRoot? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNativeRoot)this.Field;
            }
            string fieldSpecDoc = Query.AzureNativeRoot(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureNativeSubscription(azureSubscriptionRubrikId: UUID!): AzureNativeSubscription!
        internal void InvokeQueryAzureNativeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeSubscription",
                "($azureSubscriptionRubrikId: UUID!)",
                "AzureNativeSubscription"
                );
            AzureNativeSubscription? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNativeSubscription)this.Field;
            }
            string fieldSpecDoc = Query.AzureNativeSubscription(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
        internal void InvokeQueryAzureNativeSubscriptions()
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
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeSubscriptions",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeSubscriptionSortFields,$sortOrder: SortOrder,$subscriptionFilters: AzureNativeSubscriptionFilters,$authorizedOperationFilter: Operation,$workloadHierarchy: WorkloadLevelHierarchy,$azureNativeProtectionFeature: AzureNativeProtectionFeature)",
                "AzureNativeSubscriptionConnection"
                );
            AzureNativeSubscriptionConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNativeSubscriptionConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureNativeSubscriptions(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureNativeResourceGroup(resourceGroupId: UUID!): AzureNativeResourceGroup!
        internal void InvokeQueryAzureNativeResourceGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("resourceGroupId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeResourceGroup",
                "($resourceGroupId: UUID!)",
                "AzureNativeResourceGroup"
                );
            AzureNativeResourceGroup? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNativeResourceGroup)this.Field;
            }
            string fieldSpecDoc = Query.AzureNativeResourceGroup(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
        internal void InvokeQueryAzureNativeResourceGroups()
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
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeResourceGroups",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeCommonResourceGroupSortFields,$sortOrder: SortOrder,$commonResourceGroupFilters: AzureNativeCommonResourceGroupFilters,$protectedObjectTypes: [WorkloadLevelHierarchy!],$azureNativeProtectionFeatures: [AzureNativeProtectionFeature!])",
                "AzureNativeResourceGroupConnection"
                );
            AzureNativeResourceGroupConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNativeResourceGroupConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureNativeResourceGroups(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureNativeVirtualMachine(azureVirtualMachineRubrikId: UUID!): AzureNativeVirtualMachine!
        internal void InvokeQueryAzureNativeVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureVirtualMachineRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeVirtualMachine",
                "($azureVirtualMachineRubrikId: UUID!)",
                "AzureNativeVirtualMachine"
                );
            AzureNativeVirtualMachine? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNativeVirtualMachine)this.Field;
            }
            string fieldSpecDoc = Query.AzureNativeVirtualMachine(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
        internal void InvokeQueryAzureNativeVirtualMachines()
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
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeVirtualMachines",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeVirtualMachineSortFields,$sortOrder: SortOrder,$descendantTypeFilter: [HierarchyObjectTypeEnum!],$virtualMachineFilters: AzureNativeVirtualMachineFilters)",
                "AzureNativeVirtualMachineConnection"
                );
            AzureNativeVirtualMachineConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNativeVirtualMachineConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureNativeVirtualMachines(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureNativeManagedDisk(azureManagedDiskRubrikId: UUID!): AzureNativeManagedDisk!
        internal void InvokeQueryAzureNativeManagedDisk()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureManagedDiskRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeManagedDisk",
                "($azureManagedDiskRubrikId: UUID!)",
                "AzureNativeManagedDisk"
                );
            AzureNativeManagedDisk? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNativeManagedDisk)this.Field;
            }
            string fieldSpecDoc = Query.AzureNativeManagedDisk(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
        internal void InvokeQueryAzureNativeManagedDisks()
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
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeManagedDisks",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeDiskSortFields,$sortOrder: SortOrder,$diskFilters: AzureNativeDiskFilters)",
                "AzureNativeManagedDiskConnection"
                );
            AzureNativeManagedDiskConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNativeManagedDiskConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureNativeManagedDisks(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureNativeVirtualNetworks(azureSubscriptionRubrikId: UUID): [AzureNativeVirtualNetwork!]!
        internal void InvokeQueryAllAzureNativeVirtualNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeVirtualNetworks",
                "($azureSubscriptionRubrikId: UUID)",
                "List<AzureNativeVirtualNetwork>"
                );
            List<AzureNativeVirtualNetwork>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureNativeVirtualNetwork>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureNativeVirtualNetworks(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureNativeSubnetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeSubnet!]!
        internal void InvokeQueryAllAzureNativeSubnetsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeSubnetsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeSubnet>"
                );
            List<AzureNativeSubnet>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureNativeSubnet>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureNativeSubnetsByRegionFromAzure(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureNativeSecurityGroupsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeSecurityGroup!]!
        internal void InvokeQueryAllAzureNativeSecurityGroupsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeSecurityGroupsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeSecurityGroup>"
                );
            List<AzureNativeSecurityGroup>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureNativeSecurityGroup>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureNativeSecurityGroupsByRegionFromAzure(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureDiskEncryptionSetsByRegion(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeDiskEncryptionSet!]!
        internal void InvokeQueryAllAzureDiskEncryptionSetsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureDiskEncryptionSetsByRegion",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeDiskEncryptionSet>"
                );
            List<AzureNativeDiskEncryptionSet>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureNativeDiskEncryptionSet>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureDiskEncryptionSetsByRegion(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureNativeAvailabilitySetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, resourceGroupName: String!, region: AzureNativeRegion!): [AzureNativeAvailabilitySet!]!
        internal void InvokeQueryAllAzureNativeAvailabilitySetsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeAvailabilitySetsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$resourceGroupName: String!,$region: AzureNativeRegion!)",
                "List<AzureNativeAvailabilitySet>"
                );
            List<AzureNativeAvailabilitySet>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureNativeAvailabilitySet>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureNativeAvailabilitySetsByRegionFromAzure(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureNativeExportCompatibleVmSizesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!, vmSnapshotId: UUID!): [AzureNativeExportCompatibleVmSizes!]!
        internal void InvokeQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
                Tuple.Create("vmSnapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!,$vmSnapshotId: UUID!)",
                "List<AzureNativeExportCompatibleVmSizes>"
                );
            List<AzureNativeExportCompatibleVmSizes>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureNativeExportCompatibleVmSizes>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureNativeExportCompatibleVmSizesByRegionFromAzure(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureNativeExportCompatibleDiskTypesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeExportCompatibleDiskTypes!]!
        internal void InvokeQueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeExportCompatibleDiskTypes>"
                );
            List<AzureNativeExportCompatibleDiskTypes>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureNativeExportCompatibleDiskTypes>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureNativeVirtualMachineSizes(azureSubscriptionRubrikId: UUID): [String!]!
        internal void InvokeQueryAllAzureNativeVirtualMachineSizes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeVirtualMachineSizes",
                "($azureSubscriptionRubrikId: UUID)",
                "List<System.String>"
                );
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<System.String>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureNativeVirtualMachineSizes(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // isAzureNativeManagedDiskSnapshotRestorable(azureSubscriptionRubrikId: UUID!, diskSnapshotId: UUID!): Boolean!
        internal void InvokeQueryIsAzureNativeManagedDiskSnapshotRestorable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("diskSnapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAzureNativeManagedDiskSnapshotRestorable",
                "($azureSubscriptionRubrikId: UUID!,$diskSnapshotId: UUID!)",
                "System.Boolean"
                );
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (System.Boolean)this.Field;
            }
            string fieldSpecDoc = Query.IsAzureNativeManagedDiskSnapshotRestorable(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // isAzureStorageAccountNameAvailable(azureSubscriptionRubrikId: UUID!, storageAccountName: String!): Boolean!
        internal void InvokeQueryIsAzureStorageAccountNameAvailable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("storageAccountName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAzureStorageAccountNameAvailable",
                "($azureSubscriptionRubrikId: UUID!,$storageAccountName: String!)",
                "System.Boolean"
                );
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (System.Boolean)this.Field;
            }
            string fieldSpecDoc = Query.IsAzureStorageAccountNameAvailable(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureNativeStorageAccountsFromAzure(azureSubscriptionRubrikId: UUID!): [AzureNativeStorageAccount!]!
        internal void InvokeQueryAllAzureNativeStorageAccountsFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeStorageAccountsFromAzure",
                "($azureSubscriptionRubrikId: UUID!)",
                "List<AzureNativeStorageAccount>"
                );
            List<AzureNativeStorageAccount>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureNativeStorageAccount>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureNativeStorageAccountsFromAzure(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureSqlDatabase(azureSqlDatabaseRubrikId: UUID!): AzureSqlDatabaseDb!
        internal void InvokeQueryAzureSqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabase",
                "($azureSqlDatabaseRubrikId: UUID!)",
                "AzureSqlDatabaseDb"
                );
            AzureSqlDatabaseDb? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureSqlDatabaseDb)this.Field;
            }
            string fieldSpecDoc = Query.AzureSqlDatabase(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
        internal void InvokeQueryAzureSqlDatabases()
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
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabases",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlDatabaseSortFields,$sortOrder: SortOrder,$azureSqlDatabaseFilters: AzureSqlDatabaseFilters)",
                "AzureSqlDatabaseDbConnection"
                );
            AzureSqlDatabaseDbConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureSqlDatabaseDbConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureSqlDatabases(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureSqlDatabaseServer(azureSqlDatabaseServerRubrikId: UUID!): AzureSqlDatabaseServer!
        internal void InvokeQueryAzureSqlDatabaseServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabaseServer",
                "($azureSqlDatabaseServerRubrikId: UUID!)",
                "AzureSqlDatabaseServer"
                );
            AzureSqlDatabaseServer? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureSqlDatabaseServer)this.Field;
            }
            string fieldSpecDoc = Query.AzureSqlDatabaseServer(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
        internal void InvokeQueryAzureSqlDatabaseServers()
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
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabaseServers",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlDatabaseServerSortFields,$sortOrder: SortOrder,$azureSqlDatabaseServerFilters: AzureSqlDatabaseServerFilters)",
                "AzureSqlDatabaseServerConnection"
                );
            AzureSqlDatabaseServerConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureSqlDatabaseServerConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureSqlDatabaseServers(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureSqlManagedInstanceDatabase(azureSqlManagedInstanceDatabaseRubrikId: UUID!): AzureSqlManagedInstanceDatabase!
        internal void InvokeQueryAzureSqlManagedInstanceDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceDatabaseRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDatabase",
                "($azureSqlManagedInstanceDatabaseRubrikId: UUID!)",
                "AzureSqlManagedInstanceDatabase"
                );
            AzureSqlManagedInstanceDatabase? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureSqlManagedInstanceDatabase)this.Field;
            }
            string fieldSpecDoc = Query.AzureSqlManagedInstanceDatabase(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
        internal void InvokeQueryAzureSqlManagedInstanceDatabases()
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
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDatabases",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlManagedInstanceDatabaseSortFields,$sortOrder: SortOrder,$azureSqlManagedInstanceDatabaseFilters: AzureSqlManagedInstanceDatabaseFilters)",
                "AzureSqlManagedInstanceDatabaseConnection"
                );
            AzureSqlManagedInstanceDatabaseConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureSqlManagedInstanceDatabaseConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureSqlManagedInstanceDatabases(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureSqlManagedInstanceServer(azureSqlManagedInstanceServerRubrikId: UUID!): AzureSqlManagedInstanceServer!
        internal void InvokeQueryAzureSqlManagedInstanceServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceServer",
                "($azureSqlManagedInstanceServerRubrikId: UUID!)",
                "AzureSqlManagedInstanceServer"
                );
            AzureSqlManagedInstanceServer? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureSqlManagedInstanceServer)this.Field;
            }
            string fieldSpecDoc = Query.AzureSqlManagedInstanceServer(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
        internal void InvokeQueryAzureSqlManagedInstanceServers()
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
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceServers",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlManagedInstanceServerSortFields,$sortOrder: SortOrder,$azureSqlManagedInstanceServerFilters: AzureSqlManagedInstanceServerFilters)",
                "AzureSqlManagedInstanceServerConnection"
                );
            AzureSqlManagedInstanceServerConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureSqlManagedInstanceServerConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureSqlManagedInstanceServers(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     azureSqlDatabaseServerName: String!
        //     azureSqlDatabaseName: String!
        //   ): AzureNativeSqlDatabasePointInTimeRestoreWindow!
        internal void InvokeQueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlDatabaseServerName", "String!"),
                Tuple.Create("azureSqlDatabaseName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseName: String!)",
                "AzureNativeSqlDatabasePointInTimeRestoreWindow"
                );
            AzureNativeSqlDatabasePointInTimeRestoreWindow? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNativeSqlDatabasePointInTimeRestoreWindow)this.Field;
            }
            string fieldSpecDoc = Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     azureSqlManagedInstanceName: String!
        //     azureSqlDatabaseName: String!
        //   ): AzureNativeSqlDatabasePointInTimeRestoreWindow!
        internal void InvokeQueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlManagedInstanceName", "String!"),
                Tuple.Create("azureSqlDatabaseName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlManagedInstanceName: String!,$azureSqlDatabaseName: String!)",
                "AzureNativeSqlDatabasePointInTimeRestoreWindow"
                );
            AzureNativeSqlDatabasePointInTimeRestoreWindow? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureNativeSqlDatabasePointInTimeRestoreWindow)this.Field;
            }
            string fieldSpecDoc = Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // validateAzureNativeSqlDatabaseDbNameForExport(azureSqlDatabaseName: String!, azureSqlDatabaseServerRubrikId: UUID!): ValidateAzureNativeSqlDatabaseDbNameForExportReply!
        internal void InvokeQueryValidateAzureNativeSqlDatabaseDbNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseName", "String!"),
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAzureNativeSqlDatabaseDbNameForExport",
                "($azureSqlDatabaseName: String!,$azureSqlDatabaseServerRubrikId: UUID!)",
                "ValidateAzureNativeSqlDatabaseDbNameForExportReply"
                );
            ValidateAzureNativeSqlDatabaseDbNameForExportReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ValidateAzureNativeSqlDatabaseDbNameForExportReply)this.Field;
            }
            string fieldSpecDoc = Query.ValidateAzureNativeSqlDatabaseDbNameForExport(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // validateAzureNativeSqlManagedInstanceDbNameForExport(azureSqlDatabaseName: String!, azureSqlManagedInstanceServerRubrikId: UUID!): ValidateAzureNativeSqlManagedInstanceDbNameForExportReply!
        internal void InvokeQueryValidateAzureNativeSqlManagedInstanceDbNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseName", "String!"),
                Tuple.Create("azureSqlManagedInstanceServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAzureNativeSqlManagedInstanceDbNameForExport",
                "($azureSqlDatabaseName: String!,$azureSqlManagedInstanceServerRubrikId: UUID!)",
                "ValidateAzureNativeSqlManagedInstanceDbNameForExportReply"
                );
            ValidateAzureNativeSqlManagedInstanceDbNameForExportReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ValidateAzureNativeSqlManagedInstanceDbNameForExportReply)this.Field;
            }
            string fieldSpecDoc = Query.ValidateAzureNativeSqlManagedInstanceDbNameForExport(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureSqlDatabaseServerElasticPools(
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     azureSqlDatabaseServerName: String!
        //     azureSqlDatabaseServerRubrikId: UUID!
        //   ): [AzureSqlDatabaseServerElasticPool!]!
        internal void InvokeQueryAllAzureSqlDatabaseServerElasticPools()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlDatabaseServerName", "String!"),
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureSqlDatabaseServerElasticPools",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseServerRubrikId: UUID!)",
                "List<AzureSqlDatabaseServerElasticPool>"
                );
            List<AzureSqlDatabaseServerElasticPool>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureSqlDatabaseServerElasticPool>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureSqlDatabaseServerElasticPools(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // isAzureNativeSqlDatabaseSnapshotPersistent(snapshotId: UUID!): Boolean!
        internal void InvokeQueryIsAzureNativeSqlDatabaseSnapshotPersistent()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAzureNativeSqlDatabaseSnapshotPersistent",
                "($snapshotId: UUID!)",
                "System.Boolean"
                );
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (System.Boolean)this.Field;
            }
            string fieldSpecDoc = Query.IsAzureNativeSqlDatabaseSnapshotPersistent(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
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
        internal void InvokeQueryAzureNativeLiveMountDisks()
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
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeLiveMountDisks",
                "($first: Int,$after: String,$last: Int,$before: String,$cloudNativeObjectType: CloudNativeObjectType!,$liveMountFilters: [CloudNativeLiveMountFilter!],$sortBy: CloudNativeLiveMountSortByFields,$sortOrder: SortOrder)",
                "LiveMountDetailsConnection"
                );
            LiveMountDetailsConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (LiveMountDetailsConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureNativeLiveMountDisks(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureKeyVaultsByRegion(azureKeyVaultsInput: AzureKeyVaultsInput!): [AzureKeyVault!]!
        internal void InvokeQueryAllAzureKeyVaultsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureKeyVaultsInput", "AzureKeyVaultsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureKeyVaultsByRegion",
                "($azureKeyVaultsInput: AzureKeyVaultsInput!)",
                "List<AzureKeyVault>"
                );
            List<AzureKeyVault>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureKeyVault>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureKeyVaultsByRegion(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureEncryptionKeys(azureEncryptionKeysInput: AzureEncryptionKeysInput!): [AzureEncryptionKey!]!
        internal void InvokeQueryAllAzureEncryptionKeys()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureEncryptionKeysInput", "AzureEncryptionKeysInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureEncryptionKeys",
                "($azureEncryptionKeysInput: AzureEncryptionKeysInput!)",
                "List<AzureEncryptionKey>"
                );
            List<AzureEncryptionKey>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureEncryptionKey>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureEncryptionKeys(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureCloudAccountTenant(
        //     tenantId: UUID!
        //     feature: CloudAccountFeature!
        //     subscriptionStatusFilters: [CloudAccountStatus!]!
        //     subscriptionSearchText: String!
        //     subscriptionIdsFilter: [UUID!]
        //   ): AzureCloudAccountTenant!
        internal void InvokeQueryAzureCloudAccountTenant()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("subscriptionSearchText", "String!"),
                Tuple.Create("subscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountTenant",
                "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])",
                "AzureCloudAccountTenant"
                );
            AzureCloudAccountTenant? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureCloudAccountTenant)this.Field;
            }
            string fieldSpecDoc = Query.AzureCloudAccountTenant(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureCloudAccountTenantWithExoConfigs(
        //     tenantId: UUID!
        //     feature: CloudAccountFeature!
        //     subscriptionStatusFilters: [CloudAccountStatus!]!
        //     subscriptionSearchText: String!
        //     subscriptionIdsFilter: [UUID!]
        //   ): AzureCloudAccountTenantWithExoConfigs!
        internal void InvokeQueryAzureCloudAccountTenantWithExoConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("subscriptionSearchText", "String!"),
                Tuple.Create("subscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountTenantWithExoConfigs",
                "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])",
                "AzureCloudAccountTenantWithExoConfigs"
                );
            AzureCloudAccountTenantWithExoConfigs? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureCloudAccountTenantWithExoConfigs)this.Field;
            }
            string fieldSpecDoc = Query.AzureCloudAccountTenantWithExoConfigs(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountTenantsWithExoConfigs(features: [CloudAccountFeature!]!): [AzureCloudAccountTenantWithExoConfigs!]!
        internal void InvokeQueryAllAzureCloudAccountTenantsWithExoConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountTenantsWithExoConfigs",
                "($features: [CloudAccountFeature!]!)",
                "List<AzureCloudAccountTenantWithExoConfigs>"
                );
            List<AzureCloudAccountTenantWithExoConfigs>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureCloudAccountTenantWithExoConfigs>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureCloudAccountTenantsWithExoConfigs(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountTenants(features: [CloudAccountFeature!], feature: CloudAccountFeature!, includeSubscriptionDetails: Boolean!): [AzureCloudAccountTenant!]!
        internal void InvokeQueryAllAzureCloudAccountTenants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("includeSubscriptionDetails", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountTenants",
                "($features: [CloudAccountFeature!],$feature: CloudAccountFeature!,$includeSubscriptionDetails: Boolean!)",
                "List<AzureCloudAccountTenant>"
                );
            List<AzureCloudAccountTenant>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureCloudAccountTenant>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureCloudAccountTenants(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureCloudAccountSubscriptionWithFeatures(cloudAccountId: UUID!): AzureCloudAccountSubscriptionWithFeatures!
        internal void InvokeQueryAzureCloudAccountSubscriptionWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountSubscriptionWithFeatures",
                "($cloudAccountId: UUID!)",
                "AzureCloudAccountSubscriptionWithFeatures"
                );
            AzureCloudAccountSubscriptionWithFeatures? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureCloudAccountSubscriptionWithFeatures)this.Field;
            }
            string fieldSpecDoc = Query.AzureCloudAccountSubscriptionWithFeatures(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountSubscriptionsByFeature(feature: CloudAccountFeature!, subscriptionStatusFilters: [CloudAccountStatus!]!): [AzureSubscriptionWithFeaturesType!]!
        internal void InvokeQueryAllAzureCloudAccountSubscriptionsByFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountSubscriptionsByFeature",
                "($feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!)",
                "List<AzureSubscriptionWithFeaturesType>"
                );
            List<AzureSubscriptionWithFeaturesType>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureSubscriptionWithFeaturesType>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureCloudAccountSubscriptionsByFeature(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureSubscriptionWithExocomputeMappings(features: [CloudAccountFeature!], exocomputeSubscriptionIdsFilter: [UUID!]): [AzureSubscriptionWithExocomputeMapping!]!
        internal void InvokeQueryAllAzureSubscriptionWithExocomputeMappings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("exocomputeSubscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureSubscriptionWithExocomputeMappings",
                "($features: [CloudAccountFeature!],$exocomputeSubscriptionIdsFilter: [UUID!])",
                "List<AzureSubscriptionWithExocomputeMapping>"
                );
            List<AzureSubscriptionWithExocomputeMapping>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureSubscriptionWithExocomputeMapping>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureSubscriptionWithExocomputeMappings(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allResourceGroupsFromAzure(cloudAccountId: UUID!, azureSubscriptionNativeId: UUID!, feature: CloudAccountFeature!): [AzureResourceGroup!]!
        internal void InvokeQueryAllResourceGroupsFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureSubscriptionNativeId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllResourceGroupsFromAzure",
                "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$feature: CloudAccountFeature!)",
                "List<AzureResourceGroup>"
                );
            List<AzureResourceGroup>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureResourceGroup>)this.Field;
            }
            string fieldSpecDoc = Query.AllResourceGroupsFromAzure(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // doesAzureNativeResourceGroupExist(
        //     cloudAccountId: UUID!
        //     azureSubscriptionNativeId: UUID!
        //     resourceGroupName: String!
        //     feature: CloudAccountFeature!
        //   ): Boolean!
        internal void InvokeQueryDoesAzureNativeResourceGroupExist()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureSubscriptionNativeId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDoesAzureNativeResourceGroupExist",
                "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$resourceGroupName: String!,$feature: CloudAccountFeature!)",
                "System.Boolean"
                );
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (System.Boolean)this.Field;
            }
            string fieldSpecDoc = Query.DoesAzureNativeResourceGroupExist(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureNativeResourceGroupsInfoIfExist(input: AzureGetResourceGroupsInfoIfExistInput!): [AzureResourceGroupInfo!]!
        internal void InvokeQueryAllAzureNativeResourceGroupsInfoIfExist()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureGetResourceGroupsInfoIfExistInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeResourceGroupsInfoIfExist",
                "($input: AzureGetResourceGroupsInfoIfExistInput!)",
                "List<AzureResourceGroupInfo>"
                );
            List<AzureResourceGroupInfo>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureResourceGroupInfo>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureNativeResourceGroupsInfoIfExist(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountMissingPermissions(sessionId: String!, subscriptionIds: [UUID!]!, cloudAccountAction: CloudAccountAction!): [AzureSubscriptionMissingPermissions!]!
        internal void InvokeQueryAllAzureCloudAccountMissingPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sessionId", "String!"),
                Tuple.Create("subscriptionIds", "[UUID!]!"),
                Tuple.Create("cloudAccountAction", "CloudAccountAction!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountMissingPermissions",
                "($sessionId: String!,$subscriptionIds: [UUID!]!,$cloudAccountAction: CloudAccountAction!)",
                "List<AzureSubscriptionMissingPermissions>"
                );
            List<AzureSubscriptionMissingPermissions>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureSubscriptionMissingPermissions>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureCloudAccountMissingPermissions(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureCloudAccountPermissionConfig(feature: CloudAccountFeature!): AzureCloudAccountPermissionConfigResponse!
        internal void InvokeQueryAzureCloudAccountPermissionConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountPermissionConfig",
                "($feature: CloudAccountFeature!)",
                "AzureCloudAccountPermissionConfigResponse"
                );
            AzureCloudAccountPermissionConfigResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureCloudAccountPermissionConfigResponse)this.Field;
            }
            string fieldSpecDoc = Query.AzureCloudAccountPermissionConfig(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureCloudAccountGrantedPermissionsGroups(cloudAccountId: UUID!, feature: CloudAccountFeature!): AzureCloudAccountGrantedPermissionsGroupsReply!
        internal void InvokeQueryAzureCloudAccountGrantedPermissionsGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountGrantedPermissionsGroups",
                "($cloudAccountId: UUID!,$feature: CloudAccountFeature!)",
                "AzureCloudAccountGrantedPermissionsGroupsReply"
                );
            AzureCloudAccountGrantedPermissionsGroupsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureCloudAccountGrantedPermissionsGroupsReply)this.Field;
            }
            string fieldSpecDoc = Query.AzureCloudAccountGrantedPermissionsGroups(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureCloudAccountGrantedPermissionsGroupsForRecovery(cloudAccountId: UUID!, azureNativeSubscriptionId: UUID!, feature: CloudAccountFeature!): AzureCloudAccountGrantedPermissionsGroupsReply!
        internal void InvokeQueryAzureCloudAccountGrantedPermissionsGroupsForRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureNativeSubscriptionId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountGrantedPermissionsGroupsForRecovery",
                "($cloudAccountId: UUID!,$azureNativeSubscriptionId: UUID!,$feature: CloudAccountFeature!)",
                "AzureCloudAccountGrantedPermissionsGroupsReply"
                );
            AzureCloudAccountGrantedPermissionsGroupsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureCloudAccountGrantedPermissionsGroupsReply)this.Field;
            }
            string fieldSpecDoc = Query.AzureCloudAccountGrantedPermissionsGroupsForRecovery(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureCloudAccountCheckRefreshTokenExistsForRecovery(cloudAccountId: UUID!, azureNativeSubscriptionId: UUID!): AzureCloudAccountCheckRefreshTokenExistsReply!
        internal void InvokeQueryAzureCloudAccountCheckRefreshTokenExistsForRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureNativeSubscriptionId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountCheckRefreshTokenExistsForRecovery",
                "($cloudAccountId: UUID!,$azureNativeSubscriptionId: UUID!)",
                "AzureCloudAccountCheckRefreshTokenExistsReply"
                );
            AzureCloudAccountCheckRefreshTokenExistsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureCloudAccountCheckRefreshTokenExistsReply)this.Field;
            }
            string fieldSpecDoc = Query.AzureCloudAccountCheckRefreshTokenExistsForRecovery(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureExocomputeConfigsInAccount(azureExocomputeSearchQuery: String, cloudAccountIDs: [UUID!]): [AzureExocomputeConfigsInAccount!]!
        internal void InvokeQueryAllAzureExocomputeConfigsInAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureExocomputeSearchQuery", "String"),
                Tuple.Create("cloudAccountIDs", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureExocomputeConfigsInAccount",
                "($azureExocomputeSearchQuery: String,$cloudAccountIDs: [UUID!])",
                "List<AzureExocomputeConfigsInAccount>"
                );
            List<AzureExocomputeConfigsInAccount>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureExocomputeConfigsInAccount>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureExocomputeConfigsInAccount(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureCloudAccountSubnetsByRegion(cloudAccountId: UUID!, region: AzureCloudAccountRegion!): [AzureNativeSubnet!]!
        internal void InvokeQueryAllAzureCloudAccountSubnetsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("region", "AzureCloudAccountRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountSubnetsByRegion",
                "($cloudAccountId: UUID!,$region: AzureCloudAccountRegion!)",
                "List<AzureNativeSubnet>"
                );
            List<AzureNativeSubnet>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureNativeSubnet>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureCloudAccountSubnetsByRegion(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // validateAzureCloudAccountExocomputeConfigurations(input: ValidateAzureCloudAccountExocomputeConfigurationsInput!): ValidateAzureSubnetsForCloudAccountExocomputeReply!
        internal void InvokeQueryValidateAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAzureCloudAccountExocomputeConfigurations",
                "($input: ValidateAzureCloudAccountExocomputeConfigurationsInput!)",
                "ValidateAzureSubnetsForCloudAccountExocomputeReply"
                );
            ValidateAzureSubnetsForCloudAccountExocomputeReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ValidateAzureSubnetsForCloudAccountExocomputeReply)this.Field;
            }
            string fieldSpecDoc = Query.ValidateAzureCloudAccountExocomputeConfigurations(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureArmTemplatesByFeature(input: AzureArmTemplatesByFeatureInput!): [AzureArmTemplateByFeature!]!
        internal void InvokeQueryAllAzureArmTemplatesByFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureArmTemplatesByFeatureInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureArmTemplatesByFeature",
                "($input: AzureArmTemplatesByFeatureInput!)",
                "List<AzureArmTemplateByFeature>"
                );
            List<AzureArmTemplateByFeature>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureArmTemplateByFeature>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureArmTemplatesByFeature(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // checkAzurePersistentStorageSubscriptionCanUnmap(cloudAccountId: UUID!, feature: CloudAccountFeature!, unmappingValidationType: UnmappingValidationType!): CheckAzurePersistentStorageSubscriptionCanUnmapReply!
        internal void InvokeQueryCheckAzurePersistentStorageSubscriptionCanUnmap()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("unmappingValidationType", "UnmappingValidationType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCheckAzurePersistentStorageSubscriptionCanUnmap",
                "($cloudAccountId: UUID!,$feature: CloudAccountFeature!,$unmappingValidationType: UnmappingValidationType!)",
                "CheckAzurePersistentStorageSubscriptionCanUnmapReply"
                );
            CheckAzurePersistentStorageSubscriptionCanUnmapReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CheckAzurePersistentStorageSubscriptionCanUnmapReply)this.Field;
            }
            string fieldSpecDoc = Query.CheckAzurePersistentStorageSubscriptionCanUnmap(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureSubscriptions(tenantId: String!): AzureSubscriptionConnection!
        internal void InvokeQueryAzureSubscriptions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSubscriptions",
                "($tenantId: String!)",
                "AzureSubscriptionConnection"
                );
            AzureSubscriptionConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureSubscriptionConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureSubscriptions(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureRegions(tenantId: String!, subscriptionId: UUID!): RegionConnection!
        internal void InvokeQueryAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureRegions",
                "($tenantId: String!,$subscriptionId: UUID!)",
                "RegionConnection"
                );
            RegionConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RegionConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureRegions(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureResourceGroups(tenantId: String!, subscriptionId: UUID!): ResourceGroupConnection!
        internal void InvokeQueryAzureResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureResourceGroups",
                "($tenantId: String!,$subscriptionId: UUID!)",
                "ResourceGroupConnection"
                );
            ResourceGroupConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ResourceGroupConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureResourceGroups(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureVNets(tenantId: String!, subscriptionId: UUID!, regionName: String!): VnetConnection!
        internal void InvokeQueryAzureVnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureVnets",
                "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)",
                "VnetConnection"
                );
            VnetConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VnetConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureVnets(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureSubnets(tenantId: String!, subscriptionId: UUID!, vNetId: String!): SubnetConnection!
        internal void InvokeQueryAzureSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("vNetId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSubnets",
                "($tenantId: String!,$subscriptionId: UUID!,$vNetId: String!)",
                "SubnetConnection"
                );
            SubnetConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (SubnetConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureSubnets(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureStorageAccounts(tenantId: String!, subscriptionId: UUID!, regionName: String!): StorageAccountConnection!
        internal void InvokeQueryAzureStorageAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureStorageAccounts",
                "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)",
                "StorageAccountConnection"
                );
            StorageAccountConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (StorageAccountConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureStorageAccounts(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allHostedAzureRegions: AzureRegionsResp!
        internal void InvokeQueryAllHostedAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllHostedAzureRegions",
                "",
                "AzureRegionsResp"
                );
            AzureRegionsResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureRegionsResp)this.Field;
            }
            string fieldSpecDoc = Query.AllHostedAzureRegions(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureResourceGroups(cloudAccountId: String!, azureRegion: String!): [String!]!
        internal void InvokeQueryAllAzureResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
                Tuple.Create("azureRegion", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureResourceGroups",
                "($cloudAccountId: String!,$azureRegion: String!)",
                "List<System.String>"
                );
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<System.String>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureResourceGroups(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureVnets(vnetRequest: AzureVnetReq!): [String!]!
        internal void InvokeQueryAllAzureVnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("vnetRequest", "AzureVnetReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureVnets",
                "($vnetRequest: AzureVnetReq!)",
                "List<System.String>"
                );
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<System.String>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureVnets(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureSubnets(subnetRequest: AzureSubnetReq!): [String!]!
        internal void InvokeQueryAllAzureSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subnetRequest", "AzureSubnetReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureSubnets",
                "($subnetRequest: AzureSubnetReq!)",
                "List<System.String>"
                );
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<System.String>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureSubnets(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureCdmVersions(cdmVersionRequest: AzureCdmVersionReq!): [AzureCdmVersion!]!
        internal void InvokeQueryAllAzureCdmVersions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmVersionRequest", "AzureCdmVersionReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCdmVersions",
                "($cdmVersionRequest: AzureCdmVersionReq!)",
                "List<AzureCdmVersion>"
                );
            List<AzureCdmVersion>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureCdmVersion>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureCdmVersions(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureRegions(cloudAccountId: String!): [AzureCloudAccountRegion!]!
        internal void InvokeQueryAllAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureRegions",
                "($cloudAccountId: String!)",
                "List<AzureCloudAccountRegion>"
                );
            List<AzureCloudAccountRegion>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureCloudAccountRegion>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureRegions(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureNsgs(nsgRequest: AzureNsgRequest!): [String!]!
        internal void InvokeQueryAllAzureNsgs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("nsgRequest", "AzureNsgRequest!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNsgs",
                "($nsgRequest: AzureNsgRequest!)",
                "List<System.String>"
                );
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<System.String>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureNsgs(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureStorageAccounts(storageAccountsRequest: AzureStorageAccountsReq!): [String!]!
        internal void InvokeQueryAllAzureStorageAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("storageAccountsRequest", "AzureStorageAccountsReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureStorageAccounts",
                "($storageAccountsRequest: AzureStorageAccountsReq!)",
                "List<System.String>"
                );
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<System.String>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureStorageAccounts(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAzureManagedIdentities(managedIdentitiesRequest: AzureManagedIdentitiesRequest!): [AzureManagedIdentity!]!
        internal void InvokeQueryAllAzureManagedIdentities()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("managedIdentitiesRequest", "AzureManagedIdentitiesRequest!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureManagedIdentities",
                "($managedIdentitiesRequest: AzureManagedIdentitiesRequest!)",
                "List<AzureManagedIdentity>"
                );
            List<AzureManagedIdentity>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AzureManagedIdentity>)this.Field;
            }
            string fieldSpecDoc = Query.AllAzureManagedIdentities(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureAdDirectories(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): AzureAdDirectoryConnection!
        internal void InvokeQueryAzureAdDirectories()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureAdDirectories",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "AzureAdDirectoryConnection"
                );
            AzureAdDirectoryConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureAdDirectoryConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureAdDirectories(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureAdDirectory(workloadFid: UUID!): AzureAdDirectory!
        internal void InvokeQueryAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureAdDirectory",
                "($workloadFid: UUID!)",
                "AzureAdDirectory"
                );
            AzureAdDirectory? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureAdDirectory)this.Field;
            }
            string fieldSpecDoc = Query.AzureAdDirectory(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // azureAdObjectsByType(
        //     first: Int
        //     after: String
        //     sortByOption: [AzureAdObjectSearchType!]
        //     sortOrder: SortOrder
        //     input: AzureAdObjectTypeInput!
        //   ): AzureAdObjectConnection!
        internal void InvokeQueryAzureAdObjectsByType()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortByOption", "[AzureAdObjectSearchType!]"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("input", "AzureAdObjectTypeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureAdObjectsByType",
                "($first: Int,$after: String,$sortByOption: [AzureAdObjectSearchType!],$sortOrder: SortOrder,$input: AzureAdObjectTypeInput!)",
                "AzureAdObjectConnection"
                );
            AzureAdObjectConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AzureAdObjectConnection)this.Field;
            }
            string fieldSpecDoc = Query.AzureAdObjectsByType(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscQueryAzure
}