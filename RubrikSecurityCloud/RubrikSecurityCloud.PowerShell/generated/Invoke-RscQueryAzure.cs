// Invoke-RscQueryAzure.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
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
        // GraphQL operation: azureNativeRoot:AzureNativeRoot!
        //
        [Parameter(
            ParameterSetName = "NativeRoot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureNativeRoot:AzureNativeRoot!",
            Position = 0
        )]
        public SwitchParameter NativeRoot { get; set; }

        
        // -------------------------------------------------------------------
        // NativeSubscription parameter set
        //
        // GraphQL operation: azureNativeSubscription(azureSubscriptionRubrikId: UUID!):AzureNativeSubscription!
        //
        [Parameter(
            ParameterSetName = "NativeSubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureNativeSubscription(azureSubscriptionRubrikId: UUID!):AzureNativeSubscription!",
            Position = 0
        )]
        public SwitchParameter NativeSubscription { get; set; }

        [Parameter(
            ParameterSetName = "NativeSubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureSubscriptionRubrikId: UUID!"
        )]
        public System.String? AzureSubscriptionRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // NativeResourceGroup parameter set
        //
        // GraphQL operation: azureNativeResourceGroup(resourceGroupId: UUID!):AzureNativeResourceGroup!
        //
        [Parameter(
            ParameterSetName = "NativeResourceGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureNativeResourceGroup(resourceGroupId: UUID!):AzureNativeResourceGroup!",
            Position = 0
        )]
        public SwitchParameter NativeResourceGroup { get; set; }

        [Parameter(
            ParameterSetName = "NativeResourceGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument resourceGroupId: UUID!"
        )]
        public System.String? ResourceGroupId { get; set; }
        
        // -------------------------------------------------------------------
        // NativeVirtualMachine parameter set
        //
        // GraphQL operation: azureNativeVirtualMachine(azureVirtualMachineRubrikId: UUID!):AzureNativeVirtualMachine!
        //
        [Parameter(
            ParameterSetName = "NativeVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureNativeVirtualMachine(azureVirtualMachineRubrikId: UUID!):AzureNativeVirtualMachine!",
            Position = 0
        )]
        public SwitchParameter NativeVirtualMachine { get; set; }

        [Parameter(
            ParameterSetName = "NativeVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureVirtualMachineRubrikId: UUID!"
        )]
        public System.String? AzureVirtualMachineRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // NativeManagedDisk parameter set
        //
        // GraphQL operation: azureNativeManagedDisk(azureManagedDiskRubrikId: UUID!):AzureNativeManagedDisk!
        //
        [Parameter(
            ParameterSetName = "NativeManagedDisk",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureNativeManagedDisk(azureManagedDiskRubrikId: UUID!):AzureNativeManagedDisk!",
            Position = 0
        )]
        public SwitchParameter NativeManagedDisk { get; set; }

        [Parameter(
            ParameterSetName = "NativeManagedDisk",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureManagedDiskRubrikId: UUID!"
        )]
        public System.String? AzureManagedDiskRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // allNativeVirtualNetwork parameter set
        //
        // GraphQL operation: allAzureNativeVirtualNetworks(azureSubscriptionRubrikId: UUID):[AzureNativeVirtualNetwork!]!
        //
        [Parameter(
            ParameterSetName = "allNativeVirtualNetwork",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureNativeVirtualNetworks(azureSubscriptionRubrikId: UUID):[AzureNativeVirtualNetwork!]!",
            Position = 0
        )]
        public SwitchParameter allNativeVirtualNetwork { get; set; }

        
        // -------------------------------------------------------------------
        // allNativeSubnetsByRegionFromAzure parameter set
        //
        // GraphQL operation: allAzureNativeSubnetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!):[AzureNativeSubnet!]!
        //
        [Parameter(
            ParameterSetName = "allNativeSubnetsByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureNativeSubnetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!):[AzureNativeSubnet!]!",
            Position = 0
        )]
        public SwitchParameter allNativeSubnetsByRegionFromAzure { get; set; }

        
        // -------------------------------------------------------------------
        // allNativeSecurityGroupsByRegionFromAzure parameter set
        //
        // GraphQL operation: allAzureNativeSecurityGroupsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!):[AzureNativeSecurityGroup!]!
        //
        [Parameter(
            ParameterSetName = "allNativeSecurityGroupsByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureNativeSecurityGroupsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!):[AzureNativeSecurityGroup!]!",
            Position = 0
        )]
        public SwitchParameter allNativeSecurityGroupsByRegionFromAzure { get; set; }

        
        // -------------------------------------------------------------------
        // allDiskEncryptionSetsByRegion parameter set
        //
        // GraphQL operation: allAzureDiskEncryptionSetsByRegion(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!):[AzureNativeDiskEncryptionSet!]!
        //
        [Parameter(
            ParameterSetName = "allDiskEncryptionSetsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureDiskEncryptionSetsByRegion(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!):[AzureNativeDiskEncryptionSet!]!",
            Position = 0
        )]
        public SwitchParameter allDiskEncryptionSetsByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // allNativeAvailabilitySetsByRegionFromAzure parameter set
        //
        // GraphQL operation: allAzureNativeAvailabilitySetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, resourceGroupName: String!, region: AzureNativeRegion!):[AzureNativeAvailabilitySet!]!
        //
        [Parameter(
            ParameterSetName = "allNativeAvailabilitySetsByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureNativeAvailabilitySetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, resourceGroupName: String!, region: AzureNativeRegion!):[AzureNativeAvailabilitySet!]!",
            Position = 0
        )]
        public SwitchParameter allNativeAvailabilitySetsByRegionFromAzure { get; set; }

        [Parameter(
            ParameterSetName = "allNativeAvailabilitySetsByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument resourceGroupName: String!"
        )]
        public System.String? ResourceGroupName { get; set; }
        
        // -------------------------------------------------------------------
        // allNativeExportCompatibleVmSizesByRegionFromAzure parameter set
        //
        // GraphQL operation: allAzureNativeExportCompatibleVmSizesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!, vmSnapshotId: UUID!):[AzureNativeExportCompatibleVmSizes!]!
        //
        [Parameter(
            ParameterSetName = "allNativeExportCompatibleVmSizesByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureNativeExportCompatibleVmSizesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!, vmSnapshotId: UUID!):[AzureNativeExportCompatibleVmSizes!]!",
            Position = 0
        )]
        public SwitchParameter allNativeExportCompatibleVmSizesByRegionFromAzure { get; set; }

        [Parameter(
            ParameterSetName = "allNativeExportCompatibleVmSizesByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument vmSnapshotId: UUID!"
        )]
        public System.String? VmSnapshotId { get; set; }
        
        // -------------------------------------------------------------------
        // allNativeExportCompatibleDiskTypesByRegionFromAzure parameter set
        //
        // GraphQL operation: allAzureNativeExportCompatibleDiskTypesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!):[AzureNativeExportCompatibleDiskTypes!]!
        //
        [Parameter(
            ParameterSetName = "allNativeExportCompatibleDiskTypesByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureNativeExportCompatibleDiskTypesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!):[AzureNativeExportCompatibleDiskTypes!]!",
            Position = 0
        )]
        public SwitchParameter allNativeExportCompatibleDiskTypesByRegionFromAzure { get; set; }

        
        // -------------------------------------------------------------------
        // allNativeVirtualMachineSize parameter set
        //
        // GraphQL operation: allAzureNativeVirtualMachineSizes(azureSubscriptionRubrikId: UUID):[String!]!
        //
        [Parameter(
            ParameterSetName = "allNativeVirtualMachineSize",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureNativeVirtualMachineSizes(azureSubscriptionRubrikId: UUID):[String!]!",
            Position = 0
        )]
        public SwitchParameter allNativeVirtualMachineSize { get; set; }

        
        // -------------------------------------------------------------------
        // isNativeManagedDiskSnapshotRestorable parameter set
        //
        // GraphQL operation: isAzureNativeManagedDiskSnapshotRestorable(azureSubscriptionRubrikId: UUID!, diskSnapshotId: UUID!):Boolean!
        //
        [Parameter(
            ParameterSetName = "isNativeManagedDiskSnapshotRestorable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: isAzureNativeManagedDiskSnapshotRestorable(azureSubscriptionRubrikId: UUID!, diskSnapshotId: UUID!):Boolean!",
            Position = 0
        )]
        public SwitchParameter isNativeManagedDiskSnapshotRestorable { get; set; }

        [Parameter(
            ParameterSetName = "isNativeManagedDiskSnapshotRestorable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument diskSnapshotId: UUID!"
        )]
        public System.String? DiskSnapshotId { get; set; }
        
        // -------------------------------------------------------------------
        // isStorageAccountNameAvailable parameter set
        //
        // GraphQL operation: isAzureStorageAccountNameAvailable(azureSubscriptionRubrikId: UUID!, storageAccountName: String!):Boolean!
        //
        [Parameter(
            ParameterSetName = "isStorageAccountNameAvailable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: isAzureStorageAccountNameAvailable(azureSubscriptionRubrikId: UUID!, storageAccountName: String!):Boolean!",
            Position = 0
        )]
        public SwitchParameter isStorageAccountNameAvailable { get; set; }

        [Parameter(
            ParameterSetName = "isStorageAccountNameAvailable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument storageAccountName: String!"
        )]
        public System.String? StorageAccountName { get; set; }
        
        // -------------------------------------------------------------------
        // allNativeStorageAccountsFromAzure parameter set
        //
        // GraphQL operation: allAzureNativeStorageAccountsFromAzure(azureSubscriptionRubrikId: UUID!):[AzureNativeStorageAccount!]!
        //
        [Parameter(
            ParameterSetName = "allNativeStorageAccountsFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureNativeStorageAccountsFromAzure(azureSubscriptionRubrikId: UUID!):[AzureNativeStorageAccount!]!",
            Position = 0
        )]
        public SwitchParameter allNativeStorageAccountsFromAzure { get; set; }

        
        // -------------------------------------------------------------------
        // SqlDatabase parameter set
        //
        // GraphQL operation: azureSqlDatabase(azureSqlDatabaseRubrikId: UUID!):AzureSqlDatabaseDb!
        //
        [Parameter(
            ParameterSetName = "SqlDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureSqlDatabase(azureSqlDatabaseRubrikId: UUID!):AzureSqlDatabaseDb!",
            Position = 0
        )]
        public SwitchParameter SqlDatabase { get; set; }

        [Parameter(
            ParameterSetName = "SqlDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureSqlDatabaseRubrikId: UUID!"
        )]
        public System.String? AzureSqlDatabaseRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // SqlDatabaseServer parameter set
        //
        // GraphQL operation: azureSqlDatabaseServer(azureSqlDatabaseServerRubrikId: UUID!):AzureSqlDatabaseServer!
        //
        [Parameter(
            ParameterSetName = "SqlDatabaseServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureSqlDatabaseServer(azureSqlDatabaseServerRubrikId: UUID!):AzureSqlDatabaseServer!",
            Position = 0
        )]
        public SwitchParameter SqlDatabaseServer { get; set; }

        [Parameter(
            ParameterSetName = "SqlDatabaseServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureSqlDatabaseServerRubrikId: UUID!"
        )]
        public System.String? AzureSqlDatabaseServerRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // SqlManagedInstanceDatabase parameter set
        //
        // GraphQL operation: azureSqlManagedInstanceDatabase(azureSqlManagedInstanceDatabaseRubrikId: UUID!):AzureSqlManagedInstanceDatabase!
        //
        [Parameter(
            ParameterSetName = "SqlManagedInstanceDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureSqlManagedInstanceDatabase(azureSqlManagedInstanceDatabaseRubrikId: UUID!):AzureSqlManagedInstanceDatabase!",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceDatabase { get; set; }

        [Parameter(
            ParameterSetName = "SqlManagedInstanceDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureSqlManagedInstanceDatabaseRubrikId: UUID!"
        )]
        public System.String? AzureSqlManagedInstanceDatabaseRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // SqlManagedInstanceServer parameter set
        //
        // GraphQL operation: azureSqlManagedInstanceServer(azureSqlManagedInstanceServerRubrikId: UUID!):AzureSqlManagedInstanceServer!
        //
        [Parameter(
            ParameterSetName = "SqlManagedInstanceServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureSqlManagedInstanceServer(azureSqlManagedInstanceServerRubrikId: UUID!):AzureSqlManagedInstanceServer!",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceServer { get; set; }

        [Parameter(
            ParameterSetName = "SqlManagedInstanceServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureSqlManagedInstanceServerRubrikId: UUID!"
        )]
        public System.String? AzureSqlManagedInstanceServerRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // SqlDatabaseDbPointInTimeRestoreWindowFromAzure parameter set
        //
        // GraphQL operation: azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(,   subscriptionId: UUID!,   resourceGroupName: String!,   azureSqlDatabaseServerName: String!,   azureSqlDatabaseName: String!, ):AzureNativeSqlDatabasePointInTimeRestoreWindow!
        //
        [Parameter(
            ParameterSetName = "SqlDatabaseDbPointInTimeRestoreWindowFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(,   subscriptionId: UUID!,   resourceGroupName: String!,   azureSqlDatabaseServerName: String!,   azureSqlDatabaseName: String!, ):AzureNativeSqlDatabasePointInTimeRestoreWindow!",
            Position = 0
        )]
        public SwitchParameter SqlDatabaseDbPointInTimeRestoreWindowFromAzure { get; set; }

        [Parameter(
            ParameterSetName = "SqlDatabaseDbPointInTimeRestoreWindowFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument subscriptionId: UUID!"
        )]
        public System.String? SubscriptionId { get; set; }
        [Parameter(
            ParameterSetName = "SqlDatabaseDbPointInTimeRestoreWindowFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureSqlDatabaseServerName: String!"
        )]
        public System.String? AzureSqlDatabaseServerName { get; set; }
        [Parameter(
            ParameterSetName = "SqlDatabaseDbPointInTimeRestoreWindowFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureSqlDatabaseName: String!"
        )]
        public System.String? AzureSqlDatabaseName { get; set; }
        
        // -------------------------------------------------------------------
        // SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure parameter set
        //
        // GraphQL operation: azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(,   subscriptionId: UUID!,   resourceGroupName: String!,   azureSqlManagedInstanceName: String!,   azureSqlDatabaseName: String!, ):AzureNativeSqlDatabasePointInTimeRestoreWindow!
        //
        [Parameter(
            ParameterSetName = "SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(,   subscriptionId: UUID!,   resourceGroupName: String!,   azureSqlManagedInstanceName: String!,   azureSqlDatabaseName: String!, ):AzureNativeSqlDatabasePointInTimeRestoreWindow!",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure { get; set; }

        [Parameter(
            ParameterSetName = "SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureSqlManagedInstanceName: String!"
        )]
        public System.String? AzureSqlManagedInstanceName { get; set; }
        
        // -------------------------------------------------------------------
        // validateNativeSqlDatabaseDbNameForExport parameter set
        //
        // GraphQL operation: validateAzureNativeSqlDatabaseDbNameForExport(azureSqlDatabaseName: String!, azureSqlDatabaseServerRubrikId: UUID!):ValidateAzureNativeSqlDatabaseDbNameForExportReply!
        //
        [Parameter(
            ParameterSetName = "validateNativeSqlDatabaseDbNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: validateAzureNativeSqlDatabaseDbNameForExport(azureSqlDatabaseName: String!, azureSqlDatabaseServerRubrikId: UUID!):ValidateAzureNativeSqlDatabaseDbNameForExportReply!",
            Position = 0
        )]
        public SwitchParameter validateNativeSqlDatabaseDbNameForExport { get; set; }

        
        // -------------------------------------------------------------------
        // validateNativeSqlManagedInstanceDbNameForExport parameter set
        //
        // GraphQL operation: validateAzureNativeSqlManagedInstanceDbNameForExport(azureSqlDatabaseName: String!, azureSqlManagedInstanceServerRubrikId: UUID!):ValidateAzureNativeSqlManagedInstanceDbNameForExportReply!
        //
        [Parameter(
            ParameterSetName = "validateNativeSqlManagedInstanceDbNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: validateAzureNativeSqlManagedInstanceDbNameForExport(azureSqlDatabaseName: String!, azureSqlManagedInstanceServerRubrikId: UUID!):ValidateAzureNativeSqlManagedInstanceDbNameForExportReply!",
            Position = 0
        )]
        public SwitchParameter validateNativeSqlManagedInstanceDbNameForExport { get; set; }

        
        // -------------------------------------------------------------------
        // allSqlDatabaseServerElasticPool parameter set
        //
        // GraphQL operation: allAzureSqlDatabaseServerElasticPools(,   subscriptionId: UUID!,   resourceGroupName: String!,   azureSqlDatabaseServerName: String!,   azureSqlDatabaseServerRubrikId: UUID!, ):[AzureSqlDatabaseServerElasticPool!]!
        //
        [Parameter(
            ParameterSetName = "allSqlDatabaseServerElasticPool",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureSqlDatabaseServerElasticPools(,   subscriptionId: UUID!,   resourceGroupName: String!,   azureSqlDatabaseServerName: String!,   azureSqlDatabaseServerRubrikId: UUID!, ):[AzureSqlDatabaseServerElasticPool!]!",
            Position = 0
        )]
        public SwitchParameter allSqlDatabaseServerElasticPool { get; set; }

        
        // -------------------------------------------------------------------
        // isNativeSqlDatabaseSnapshotPersistent parameter set
        //
        // GraphQL operation: isAzureNativeSqlDatabaseSnapshotPersistent(snapshotId: UUID!):Boolean!
        //
        [Parameter(
            ParameterSetName = "isNativeSqlDatabaseSnapshotPersistent",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: isAzureNativeSqlDatabaseSnapshotPersistent(snapshotId: UUID!):Boolean!",
            Position = 0
        )]
        public SwitchParameter isNativeSqlDatabaseSnapshotPersistent { get; set; }

        [Parameter(
            ParameterSetName = "isNativeSqlDatabaseSnapshotPersistent",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument snapshotId: UUID!"
        )]
        public System.String? SnapshotId { get; set; }
        
        // -------------------------------------------------------------------
        // allKeyVaultsByRegion parameter set
        //
        // GraphQL operation: allAzureKeyVaultsByRegion(azureKeyVaultsInput: AzureKeyVaultsInput!):[AzureKeyVault!]!
        //
        [Parameter(
            ParameterSetName = "allKeyVaultsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureKeyVaultsByRegion(azureKeyVaultsInput: AzureKeyVaultsInput!):[AzureKeyVault!]!",
            Position = 0
        )]
        public SwitchParameter allKeyVaultsByRegion { get; set; }

        [Parameter(
            ParameterSetName = "allKeyVaultsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureKeyVaultsInput: AzureKeyVaultsInput!"
        )]
        public AzureKeyVaultsInput? AzureKeyVaultsInput { get; set; }
        
        // -------------------------------------------------------------------
        // allEncryptionKey parameter set
        //
        // GraphQL operation: allAzureEncryptionKeys(azureEncryptionKeysInput: AzureEncryptionKeysInput!):[AzureEncryptionKey!]!
        //
        [Parameter(
            ParameterSetName = "allEncryptionKey",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureEncryptionKeys(azureEncryptionKeysInput: AzureEncryptionKeysInput!):[AzureEncryptionKey!]!",
            Position = 0
        )]
        public SwitchParameter allEncryptionKey { get; set; }

        [Parameter(
            ParameterSetName = "allEncryptionKey",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureEncryptionKeysInput: AzureEncryptionKeysInput!"
        )]
        public AzureEncryptionKeysInput? AzureEncryptionKeysInput { get; set; }
        
        // -------------------------------------------------------------------
        // CloudAccountTenant parameter set
        //
        // GraphQL operation: azureCloudAccountTenant(,   tenantId: UUID!,   feature: CloudAccountFeature!,   subscriptionStatusFilters: [CloudAccountStatus!]!,   subscriptionSearchText: String!,   subscriptionIdsFilter: [UUID!], ):AzureCloudAccountTenant!
        //
        [Parameter(
            ParameterSetName = "CloudAccountTenant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureCloudAccountTenant(,   tenantId: UUID!,   feature: CloudAccountFeature!,   subscriptionStatusFilters: [CloudAccountStatus!]!,   subscriptionSearchText: String!,   subscriptionIdsFilter: [UUID!], ):AzureCloudAccountTenant!",
            Position = 0
        )]
        public SwitchParameter CloudAccountTenant { get; set; }

        [Parameter(
            ParameterSetName = "CloudAccountTenant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument tenantId: UUID!"
        )]
        public System.String? TenantId { get; set; }
        [Parameter(
            ParameterSetName = "CloudAccountTenant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument feature: CloudAccountFeature!"
        )]
        public CloudAccountFeature? Feature { get; set; }
        [Parameter(
            ParameterSetName = "CloudAccountTenant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument subscriptionStatusFilters: [CloudAccountStatus!]!"
        )]
        public List<CloudAccountStatus>? SubscriptionStatusFilters { get; set; }
        [Parameter(
            ParameterSetName = "CloudAccountTenant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument subscriptionSearchText: String!"
        )]
        public System.String? SubscriptionSearchText { get; set; }
        [Parameter(
            ParameterSetName = "CloudAccountTenant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument subscriptionIdsFilter: [UUID!]"
        )]
        public List<System.String>? SubscriptionIdsFilter { get; set; }
        
        // -------------------------------------------------------------------
        // CloudAccountTenantWithExoConfig parameter set
        //
        // GraphQL operation: azureCloudAccountTenantWithExoConfigs(,   tenantId: UUID!,   feature: CloudAccountFeature!,   subscriptionStatusFilters: [CloudAccountStatus!]!,   subscriptionSearchText: String!,   subscriptionIdsFilter: [UUID!], ):AzureCloudAccountTenantWithExoConfigs!
        //
        [Parameter(
            ParameterSetName = "CloudAccountTenantWithExoConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureCloudAccountTenantWithExoConfigs(,   tenantId: UUID!,   feature: CloudAccountFeature!,   subscriptionStatusFilters: [CloudAccountStatus!]!,   subscriptionSearchText: String!,   subscriptionIdsFilter: [UUID!], ):AzureCloudAccountTenantWithExoConfigs!",
            Position = 0
        )]
        public SwitchParameter CloudAccountTenantWithExoConfig { get; set; }

        
        // -------------------------------------------------------------------
        // allCloudAccountTenant parameter set
        //
        // GraphQL operation: allAzureCloudAccountTenants(features: [CloudAccountFeature!], feature: CloudAccountFeature!, includeSubscriptionDetails: Boolean!):[AzureCloudAccountTenant!]!
        //
        [Parameter(
            ParameterSetName = "allCloudAccountTenant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureCloudAccountTenants(features: [CloudAccountFeature!], feature: CloudAccountFeature!, includeSubscriptionDetails: Boolean!):[AzureCloudAccountTenant!]!",
            Position = 0
        )]
        public SwitchParameter allCloudAccountTenant { get; set; }

        [Parameter(
            ParameterSetName = "allCloudAccountTenant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument features: [CloudAccountFeature!]"
        )]
        public List<CloudAccountFeature>? Features { get; set; }
        [Parameter(
            ParameterSetName = "allCloudAccountTenant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument includeSubscriptionDetails: Boolean!"
        )]
        public System.Boolean? IncludeSubscriptionDetails { get; set; }
        
        // -------------------------------------------------------------------
        // CloudAccountSubscriptionWithFeature parameter set
        //
        // GraphQL operation: azureCloudAccountSubscriptionWithFeatures(cloudAccountId: UUID!):AzureCloudAccountSubscriptionWithFeatures!
        //
        [Parameter(
            ParameterSetName = "CloudAccountSubscriptionWithFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureCloudAccountSubscriptionWithFeatures(cloudAccountId: UUID!):AzureCloudAccountSubscriptionWithFeatures!",
            Position = 0
        )]
        public SwitchParameter CloudAccountSubscriptionWithFeature { get; set; }

        [Parameter(
            ParameterSetName = "CloudAccountSubscriptionWithFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument cloudAccountId: UUID!"
        )]
        public System.String? CloudAccountId { get; set; }
        
        // -------------------------------------------------------------------
        // allCloudAccountSubscriptionsByFeature parameter set
        //
        // GraphQL operation: allAzureCloudAccountSubscriptionsByFeature(feature: CloudAccountFeature!, subscriptionStatusFilters: [CloudAccountStatus!]!):[AzureSubscriptionWithFeaturesType!]!
        //
        [Parameter(
            ParameterSetName = "allCloudAccountSubscriptionsByFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureCloudAccountSubscriptionsByFeature(feature: CloudAccountFeature!, subscriptionStatusFilters: [CloudAccountStatus!]!):[AzureSubscriptionWithFeaturesType!]!",
            Position = 0
        )]
        public SwitchParameter allCloudAccountSubscriptionsByFeature { get; set; }

        
        // -------------------------------------------------------------------
        // allSubscriptionWithExocomputeMapping parameter set
        //
        // GraphQL operation: allAzureSubscriptionWithExocomputeMappings(features: [CloudAccountFeature!], exocomputeSubscriptionIdsFilter: [UUID!]):[AzureSubscriptionWithExocomputeMapping!]!
        //
        [Parameter(
            ParameterSetName = "allSubscriptionWithExocomputeMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureSubscriptionWithExocomputeMappings(features: [CloudAccountFeature!], exocomputeSubscriptionIdsFilter: [UUID!]):[AzureSubscriptionWithExocomputeMapping!]!",
            Position = 0
        )]
        public SwitchParameter allSubscriptionWithExocomputeMapping { get; set; }

        [Parameter(
            ParameterSetName = "allSubscriptionWithExocomputeMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument exocomputeSubscriptionIdsFilter: [UUID!]"
        )]
        public List<System.String>? ExocomputeSubscriptionIdsFilter { get; set; }
        
        // -------------------------------------------------------------------
        // allResourceGroupsFrom parameter set
        //
        // GraphQL operation: allResourceGroupsFromAzure(cloudAccountId: UUID!, azureSubscriptionNativeId: UUID!, feature: CloudAccountFeature!):[AzureResourceGroup!]!
        //
        [Parameter(
            ParameterSetName = "allResourceGroupsFrom",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allResourceGroupsFromAzure(cloudAccountId: UUID!, azureSubscriptionNativeId: UUID!, feature: CloudAccountFeature!):[AzureResourceGroup!]!",
            Position = 0
        )]
        public SwitchParameter allResourceGroupsFrom { get; set; }

        [Parameter(
            ParameterSetName = "allResourceGroupsFrom",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureSubscriptionNativeId: UUID!"
        )]
        public System.String? AzureSubscriptionNativeId { get; set; }
        
        // -------------------------------------------------------------------
        // doesNativeResourceGroupExist parameter set
        //
        // GraphQL operation: doesAzureNativeResourceGroupExist(,   cloudAccountId: UUID!,   azureSubscriptionNativeId: UUID!,   resourceGroupName: String!,   feature: CloudAccountFeature!, ):Boolean!
        //
        [Parameter(
            ParameterSetName = "doesNativeResourceGroupExist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: doesAzureNativeResourceGroupExist(,   cloudAccountId: UUID!,   azureSubscriptionNativeId: UUID!,   resourceGroupName: String!,   feature: CloudAccountFeature!, ):Boolean!",
            Position = 0
        )]
        public SwitchParameter doesNativeResourceGroupExist { get; set; }

        
        // -------------------------------------------------------------------
        // allNativeResourceGroupsInfoIfExist parameter set
        //
        // GraphQL operation: allAzureNativeResourceGroupsInfoIfExist(input: AzureGetResourceGroupsInfoIfExistInput!):[AzureResourceGroupInfo!]!
        //
        [Parameter(
            ParameterSetName = "allNativeResourceGroupsInfoIfExist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureNativeResourceGroupsInfoIfExist(input: AzureGetResourceGroupsInfoIfExistInput!):[AzureResourceGroupInfo!]!",
            Position = 0
        )]
        public SwitchParameter allNativeResourceGroupsInfoIfExist { get; set; }

        [Parameter(
            ParameterSetName = "allNativeResourceGroupsInfoIfExist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: AzureGetResourceGroupsInfoIfExistInput!"
        )]
        public AzureGetResourceGroupsInfoIfExistInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // allCloudAccountMissingPermission parameter set
        //
        // GraphQL operation: allAzureCloudAccountMissingPermissions(sessionId: String!, subscriptionIds: [UUID!]!, cloudAccountAction: CloudAccountAction!):[AzureSubscriptionMissingPermissions!]!
        //
        [Parameter(
            ParameterSetName = "allCloudAccountMissingPermission",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureCloudAccountMissingPermissions(sessionId: String!, subscriptionIds: [UUID!]!, cloudAccountAction: CloudAccountAction!):[AzureSubscriptionMissingPermissions!]!",
            Position = 0
        )]
        public SwitchParameter allCloudAccountMissingPermission { get; set; }

        [Parameter(
            ParameterSetName = "allCloudAccountMissingPermission",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sessionId: String!"
        )]
        public System.String? SessionId { get; set; }
        [Parameter(
            ParameterSetName = "allCloudAccountMissingPermission",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument subscriptionIds: [UUID!]!"
        )]
        public List<System.String>? SubscriptionIds { get; set; }
        [Parameter(
            ParameterSetName = "allCloudAccountMissingPermission",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument cloudAccountAction: CloudAccountAction!"
        )]
        public CloudAccountAction? CloudAccountAction { get; set; }
        
        // -------------------------------------------------------------------
        // CloudAccountPermissionConfig parameter set
        //
        // GraphQL operation: azureCloudAccountPermissionConfig(feature: CloudAccountFeature!):AzureCloudAccountPermissionConfigResponse!
        //
        [Parameter(
            ParameterSetName = "CloudAccountPermissionConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureCloudAccountPermissionConfig(feature: CloudAccountFeature!):AzureCloudAccountPermissionConfigResponse!",
            Position = 0
        )]
        public SwitchParameter CloudAccountPermissionConfig { get; set; }

        
        // -------------------------------------------------------------------
        // allExocomputeConfigsInAccount parameter set
        //
        // GraphQL operation: allAzureExocomputeConfigsInAccount(azureExocomputeSearchQuery: String, cloudAccountIDs: [UUID!]):[AzureExocomputeConfigsInAccount!]!
        //
        [Parameter(
            ParameterSetName = "allExocomputeConfigsInAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureExocomputeConfigsInAccount(azureExocomputeSearchQuery: String, cloudAccountIDs: [UUID!]):[AzureExocomputeConfigsInAccount!]!",
            Position = 0
        )]
        public SwitchParameter allExocomputeConfigsInAccount { get; set; }

        [Parameter(
            ParameterSetName = "allExocomputeConfigsInAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureExocomputeSearchQuery: String"
        )]
        public System.String? AzureExocomputeSearchQuery { get; set; }
        [Parameter(
            ParameterSetName = "allExocomputeConfigsInAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument cloudAccountIDs: [UUID!]"
        )]
        public List<System.String>? CloudAccountIds { get; set; }
        
        // -------------------------------------------------------------------
        // allCloudAccountSubnetsByRegion parameter set
        //
        // GraphQL operation: allAzureCloudAccountSubnetsByRegion(cloudAccountId: UUID!, region: AzureCloudAccountRegion!):[AzureNativeSubnet!]!
        //
        [Parameter(
            ParameterSetName = "allCloudAccountSubnetsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureCloudAccountSubnetsByRegion(cloudAccountId: UUID!, region: AzureCloudAccountRegion!):[AzureNativeSubnet!]!",
            Position = 0
        )]
        public SwitchParameter allCloudAccountSubnetsByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // validateCloudAccountExocomputeConfiguration parameter set
        //
        // GraphQL operation: validateAzureCloudAccountExocomputeConfigurations(input: ValidateAzureCloudAccountExocomputeConfigurationsInput!):ValidateAzureSubnetsForCloudAccountExocomputeReply!
        //
        [Parameter(
            ParameterSetName = "validateCloudAccountExocomputeConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: validateAzureCloudAccountExocomputeConfigurations(input: ValidateAzureCloudAccountExocomputeConfigurationsInput!):ValidateAzureSubnetsForCloudAccountExocomputeReply!",
            Position = 0
        )]
        public SwitchParameter validateCloudAccountExocomputeConfiguration { get; set; }

        
        // -------------------------------------------------------------------
        // allArmTemplatesByFeature parameter set
        //
        // GraphQL operation: allAzureArmTemplatesByFeature(input: AzureArmTemplatesByFeatureInput!):[AzureArmTemplateByFeature!]!
        //
        [Parameter(
            ParameterSetName = "allArmTemplatesByFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureArmTemplatesByFeature(input: AzureArmTemplatesByFeatureInput!):[AzureArmTemplateByFeature!]!",
            Position = 0
        )]
        public SwitchParameter allArmTemplatesByFeature { get; set; }

        
        // -------------------------------------------------------------------
        // Subscription parameter set
        //
        // GraphQL operation: azureSubscriptions(tenantId: String!):AzureSubscriptionConnection!
        //
        [Parameter(
            ParameterSetName = "Subscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureSubscriptions(tenantId: String!):AzureSubscriptionConnection!",
            Position = 0
        )]
        public SwitchParameter Subscription { get; set; }

        
        // -------------------------------------------------------------------
        // Region parameter set
        //
        // GraphQL operation: azureRegions(tenantId: String!, subscriptionId: UUID!):RegionConnection!
        //
        [Parameter(
            ParameterSetName = "Region",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureRegions(tenantId: String!, subscriptionId: UUID!):RegionConnection!",
            Position = 0
        )]
        public SwitchParameter Region { get; set; }

        
        // -------------------------------------------------------------------
        // ResourceGroup parameter set
        //
        // GraphQL operation: azureResourceGroups(tenantId: String!, subscriptionId: UUID!):ResourceGroupConnection!
        //
        [Parameter(
            ParameterSetName = "ResourceGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureResourceGroups(tenantId: String!, subscriptionId: UUID!):ResourceGroupConnection!",
            Position = 0
        )]
        public SwitchParameter ResourceGroup { get; set; }

        
        // -------------------------------------------------------------------
        // VNet parameter set
        //
        // GraphQL operation: azureVNets(tenantId: String!, subscriptionId: UUID!, regionName: String!):VnetConnection!
        //
        [Parameter(
            ParameterSetName = "VNet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureVNets(tenantId: String!, subscriptionId: UUID!, regionName: String!):VnetConnection!",
            Position = 0
        )]
        public SwitchParameter VNet { get; set; }

        [Parameter(
            ParameterSetName = "VNet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument regionName: String!"
        )]
        public System.String? RegionName { get; set; }
        
        // -------------------------------------------------------------------
        // Subnet parameter set
        //
        // GraphQL operation: azureSubnets(tenantId: String!, subscriptionId: UUID!, vNetId: String!):SubnetConnection!
        //
        [Parameter(
            ParameterSetName = "Subnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureSubnets(tenantId: String!, subscriptionId: UUID!, vNetId: String!):SubnetConnection!",
            Position = 0
        )]
        public SwitchParameter Subnet { get; set; }

        [Parameter(
            ParameterSetName = "Subnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument vNetId: String!"
        )]
        public System.String? VnetId { get; set; }
        
        // -------------------------------------------------------------------
        // StorageAccount parameter set
        //
        // GraphQL operation: azureStorageAccounts(tenantId: String!, subscriptionId: UUID!, regionName: String!):StorageAccountConnection!
        //
        [Parameter(
            ParameterSetName = "StorageAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureStorageAccounts(tenantId: String!, subscriptionId: UUID!, regionName: String!):StorageAccountConnection!",
            Position = 0
        )]
        public SwitchParameter StorageAccount { get; set; }

        
        // -------------------------------------------------------------------
        // allHostedRegion parameter set
        //
        // GraphQL operation: allHostedAzureRegions:AzureRegionsResp!
        //
        [Parameter(
            ParameterSetName = "allHostedRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allHostedAzureRegions:AzureRegionsResp!",
            Position = 0
        )]
        public SwitchParameter allHostedRegion { get; set; }

        
        // -------------------------------------------------------------------
        // allResourceGroup parameter set
        //
        // GraphQL operation: allAzureResourceGroups(cloudAccountId: String!, azureRegion: String!):[String!]!
        //
        [Parameter(
            ParameterSetName = "allResourceGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureResourceGroups(cloudAccountId: String!, azureRegion: String!):[String!]!",
            Position = 0
        )]
        public SwitchParameter allResourceGroup { get; set; }

        [Parameter(
            ParameterSetName = "allResourceGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument azureRegion: String!"
        )]
        public System.String? AzureRegion { get; set; }
        
        // -------------------------------------------------------------------
        // allVnet parameter set
        //
        // GraphQL operation: allAzureVnets(vnetRequest: AzureVnetReq!):[String!]!
        //
        [Parameter(
            ParameterSetName = "allVnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureVnets(vnetRequest: AzureVnetReq!):[String!]!",
            Position = 0
        )]
        public SwitchParameter allVnet { get; set; }

        [Parameter(
            ParameterSetName = "allVnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument vnetRequest: AzureVnetReq!"
        )]
        public AzureVnetReq? VnetRequest { get; set; }
        
        // -------------------------------------------------------------------
        // allSubnet parameter set
        //
        // GraphQL operation: allAzureSubnets(subnetRequest: AzureSubnetReq!):[String!]!
        //
        [Parameter(
            ParameterSetName = "allSubnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureSubnets(subnetRequest: AzureSubnetReq!):[String!]!",
            Position = 0
        )]
        public SwitchParameter allSubnet { get; set; }

        [Parameter(
            ParameterSetName = "allSubnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument subnetRequest: AzureSubnetReq!"
        )]
        public AzureSubnetReq? SubnetRequest { get; set; }
        
        // -------------------------------------------------------------------
        // allCdmVersion parameter set
        //
        // GraphQL operation: allAzureCdmVersions(cdmVersionRequest: AzureCdmVersionReq!):[AzureCdmVersion!]!
        //
        [Parameter(
            ParameterSetName = "allCdmVersion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureCdmVersions(cdmVersionRequest: AzureCdmVersionReq!):[AzureCdmVersion!]!",
            Position = 0
        )]
        public SwitchParameter allCdmVersion { get; set; }

        [Parameter(
            ParameterSetName = "allCdmVersion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument cdmVersionRequest: AzureCdmVersionReq!"
        )]
        public AzureCdmVersionReq? CdmVersionRequest { get; set; }
        
        // -------------------------------------------------------------------
        // allRegion parameter set
        //
        // GraphQL operation: allAzureRegions(cloudAccountId: String!):[AzureCloudAccountRegion!]!
        //
        [Parameter(
            ParameterSetName = "allRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureRegions(cloudAccountId: String!):[AzureCloudAccountRegion!]!",
            Position = 0
        )]
        public SwitchParameter allRegion { get; set; }

        
        // -------------------------------------------------------------------
        // allNsg parameter set
        //
        // GraphQL operation: allAzureNsgs(nsgRequest: AzureNsgRequest!):[String!]!
        //
        [Parameter(
            ParameterSetName = "allNsg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureNsgs(nsgRequest: AzureNsgRequest!):[String!]!",
            Position = 0
        )]
        public SwitchParameter allNsg { get; set; }

        [Parameter(
            ParameterSetName = "allNsg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument nsgRequest: AzureNsgRequest!"
        )]
        public AzureNsgRequest? NsgRequest { get; set; }
        
        // -------------------------------------------------------------------
        // allStorageAccount parameter set
        //
        // GraphQL operation: allAzureStorageAccounts(storageAccountsRequest: AzureStorageAccountsReq!):[String!]!
        //
        [Parameter(
            ParameterSetName = "allStorageAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAzureStorageAccounts(storageAccountsRequest: AzureStorageAccountsReq!):[String!]!",
            Position = 0
        )]
        public SwitchParameter allStorageAccount { get; set; }

        [Parameter(
            ParameterSetName = "allStorageAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument storageAccountsRequest: AzureStorageAccountsReq!"
        )]
        public AzureStorageAccountsReq? StorageAccountsRequest { get; set; }

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
                    case "allNativeVirtualNetwork":
                        this.ProcessRecord_allNativeVirtualNetwork();
                        break;
                    case "allNativeSubnetsByRegionFromAzure":
                        this.ProcessRecord_allNativeSubnetsByRegionFromAzure();
                        break;
                    case "allNativeSecurityGroupsByRegionFromAzure":
                        this.ProcessRecord_allNativeSecurityGroupsByRegionFromAzure();
                        break;
                    case "allDiskEncryptionSetsByRegion":
                        this.ProcessRecord_allDiskEncryptionSetsByRegion();
                        break;
                    case "allNativeAvailabilitySetsByRegionFromAzure":
                        this.ProcessRecord_allNativeAvailabilitySetsByRegionFromAzure();
                        break;
                    case "allNativeExportCompatibleVmSizesByRegionFromAzure":
                        this.ProcessRecord_allNativeExportCompatibleVmSizesByRegionFromAzure();
                        break;
                    case "allNativeExportCompatibleDiskTypesByRegionFromAzure":
                        this.ProcessRecord_allNativeExportCompatibleDiskTypesByRegionFromAzure();
                        break;
                    case "allNativeVirtualMachineSize":
                        this.ProcessRecord_allNativeVirtualMachineSize();
                        break;
                    case "isNativeManagedDiskSnapshotRestorable":
                        this.ProcessRecord_isNativeManagedDiskSnapshotRestorable();
                        break;
                    case "isStorageAccountNameAvailable":
                        this.ProcessRecord_isStorageAccountNameAvailable();
                        break;
                    case "allNativeStorageAccountsFromAzure":
                        this.ProcessRecord_allNativeStorageAccountsFromAzure();
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
                    case "validateNativeSqlDatabaseDbNameForExport":
                        this.ProcessRecord_validateNativeSqlDatabaseDbNameForExport();
                        break;
                    case "validateNativeSqlManagedInstanceDbNameForExport":
                        this.ProcessRecord_validateNativeSqlManagedInstanceDbNameForExport();
                        break;
                    case "allSqlDatabaseServerElasticPool":
                        this.ProcessRecord_allSqlDatabaseServerElasticPool();
                        break;
                    case "isNativeSqlDatabaseSnapshotPersistent":
                        this.ProcessRecord_isNativeSqlDatabaseSnapshotPersistent();
                        break;
                    case "allKeyVaultsByRegion":
                        this.ProcessRecord_allKeyVaultsByRegion();
                        break;
                    case "allEncryptionKey":
                        this.ProcessRecord_allEncryptionKey();
                        break;
                    case "CloudAccountTenant":
                        this.ProcessRecord_CloudAccountTenant();
                        break;
                    case "CloudAccountTenantWithExoConfig":
                        this.ProcessRecord_CloudAccountTenantWithExoConfig();
                        break;
                    case "allCloudAccountTenant":
                        this.ProcessRecord_allCloudAccountTenant();
                        break;
                    case "CloudAccountSubscriptionWithFeature":
                        this.ProcessRecord_CloudAccountSubscriptionWithFeature();
                        break;
                    case "allCloudAccountSubscriptionsByFeature":
                        this.ProcessRecord_allCloudAccountSubscriptionsByFeature();
                        break;
                    case "allSubscriptionWithExocomputeMapping":
                        this.ProcessRecord_allSubscriptionWithExocomputeMapping();
                        break;
                    case "allResourceGroupsFrom":
                        this.ProcessRecord_allResourceGroupsFrom();
                        break;
                    case "doesNativeResourceGroupExist":
                        this.ProcessRecord_doesNativeResourceGroupExist();
                        break;
                    case "allNativeResourceGroupsInfoIfExist":
                        this.ProcessRecord_allNativeResourceGroupsInfoIfExist();
                        break;
                    case "allCloudAccountMissingPermission":
                        this.ProcessRecord_allCloudAccountMissingPermission();
                        break;
                    case "CloudAccountPermissionConfig":
                        this.ProcessRecord_CloudAccountPermissionConfig();
                        break;
                    case "allExocomputeConfigsInAccount":
                        this.ProcessRecord_allExocomputeConfigsInAccount();
                        break;
                    case "allCloudAccountSubnetsByRegion":
                        this.ProcessRecord_allCloudAccountSubnetsByRegion();
                        break;
                    case "validateCloudAccountExocomputeConfiguration":
                        this.ProcessRecord_validateCloudAccountExocomputeConfiguration();
                        break;
                    case "allArmTemplatesByFeature":
                        this.ProcessRecord_allArmTemplatesByFeature();
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
                    case "allHostedRegion":
                        this.ProcessRecord_allHostedRegion();
                        break;
                    case "allResourceGroup":
                        this.ProcessRecord_allResourceGroup();
                        break;
                    case "allVnet":
                        this.ProcessRecord_allVnet();
                        break;
                    case "allSubnet":
                        this.ProcessRecord_allSubnet();
                        break;
                    case "allCdmVersion":
                        this.ProcessRecord_allCdmVersion();
                        break;
                    case "allRegion":
                        this.ProcessRecord_allRegion();
                        break;
                    case "allNsg":
                        this.ProcessRecord_allNsg();
                        break;
                    case "allStorageAccount":
                        this.ProcessRecord_allStorageAccount();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscQueryAzure",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
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
        protected void ProcessRecord_allNativeVirtualNetwork()
        {
            this._logger.name += " -allNativeVirtualNetwork";
            // Invoke graphql operation allAzureNativeVirtualNetworks
            InvokeQueryAllAzureNativeVirtualNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeSubnetsByRegionFromAzure.
        protected void ProcessRecord_allNativeSubnetsByRegionFromAzure()
        {
            this._logger.name += " -allNativeSubnetsByRegionFromAzure";
            // Invoke graphql operation allAzureNativeSubnetsByRegionFromAzure
            InvokeQueryAllAzureNativeSubnetsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeSecurityGroupsByRegionFromAzure.
        protected void ProcessRecord_allNativeSecurityGroupsByRegionFromAzure()
        {
            this._logger.name += " -allNativeSecurityGroupsByRegionFromAzure";
            // Invoke graphql operation allAzureNativeSecurityGroupsByRegionFromAzure
            InvokeQueryAllAzureNativeSecurityGroupsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureDiskEncryptionSetsByRegion.
        protected void ProcessRecord_allDiskEncryptionSetsByRegion()
        {
            this._logger.name += " -allDiskEncryptionSetsByRegion";
            // Invoke graphql operation allAzureDiskEncryptionSetsByRegion
            InvokeQueryAllAzureDiskEncryptionSetsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeAvailabilitySetsByRegionFromAzure.
        protected void ProcessRecord_allNativeAvailabilitySetsByRegionFromAzure()
        {
            this._logger.name += " -allNativeAvailabilitySetsByRegionFromAzure";
            // Invoke graphql operation allAzureNativeAvailabilitySetsByRegionFromAzure
            InvokeQueryAllAzureNativeAvailabilitySetsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeExportCompatibleVmSizesByRegionFromAzure.
        protected void ProcessRecord_allNativeExportCompatibleVmSizesByRegionFromAzure()
        {
            this._logger.name += " -allNativeExportCompatibleVmSizesByRegionFromAzure";
            // Invoke graphql operation allAzureNativeExportCompatibleVmSizesByRegionFromAzure
            InvokeQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeExportCompatibleDiskTypesByRegionFromAzure.
        protected void ProcessRecord_allNativeExportCompatibleDiskTypesByRegionFromAzure()
        {
            this._logger.name += " -allNativeExportCompatibleDiskTypesByRegionFromAzure";
            // Invoke graphql operation allAzureNativeExportCompatibleDiskTypesByRegionFromAzure
            InvokeQueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeVirtualMachineSizes.
        protected void ProcessRecord_allNativeVirtualMachineSize()
        {
            this._logger.name += " -allNativeVirtualMachineSize";
            // Invoke graphql operation allAzureNativeVirtualMachineSizes
            InvokeQueryAllAzureNativeVirtualMachineSizes();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureNativeManagedDiskSnapshotRestorable.
        protected void ProcessRecord_isNativeManagedDiskSnapshotRestorable()
        {
            this._logger.name += " -isNativeManagedDiskSnapshotRestorable";
            // Invoke graphql operation isAzureNativeManagedDiskSnapshotRestorable
            InvokeQueryIsAzureNativeManagedDiskSnapshotRestorable();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureStorageAccountNameAvailable.
        protected void ProcessRecord_isStorageAccountNameAvailable()
        {
            this._logger.name += " -isStorageAccountNameAvailable";
            // Invoke graphql operation isAzureStorageAccountNameAvailable
            InvokeQueryIsAzureStorageAccountNameAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeStorageAccountsFromAzure.
        protected void ProcessRecord_allNativeStorageAccountsFromAzure()
        {
            this._logger.name += " -allNativeStorageAccountsFromAzure";
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
        protected void ProcessRecord_validateNativeSqlDatabaseDbNameForExport()
        {
            this._logger.name += " -validateNativeSqlDatabaseDbNameForExport";
            // Invoke graphql operation validateAzureNativeSqlDatabaseDbNameForExport
            InvokeQueryValidateAzureNativeSqlDatabaseDbNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureNativeSqlManagedInstanceDbNameForExport.
        protected void ProcessRecord_validateNativeSqlManagedInstanceDbNameForExport()
        {
            this._logger.name += " -validateNativeSqlManagedInstanceDbNameForExport";
            // Invoke graphql operation validateAzureNativeSqlManagedInstanceDbNameForExport
            InvokeQueryValidateAzureNativeSqlManagedInstanceDbNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSqlDatabaseServerElasticPools.
        protected void ProcessRecord_allSqlDatabaseServerElasticPool()
        {
            this._logger.name += " -allSqlDatabaseServerElasticPool";
            // Invoke graphql operation allAzureSqlDatabaseServerElasticPools
            InvokeQueryAllAzureSqlDatabaseServerElasticPools();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureNativeSqlDatabaseSnapshotPersistent.
        protected void ProcessRecord_isNativeSqlDatabaseSnapshotPersistent()
        {
            this._logger.name += " -isNativeSqlDatabaseSnapshotPersistent";
            // Invoke graphql operation isAzureNativeSqlDatabaseSnapshotPersistent
            InvokeQueryIsAzureNativeSqlDatabaseSnapshotPersistent();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureKeyVaultsByRegion.
        protected void ProcessRecord_allKeyVaultsByRegion()
        {
            this._logger.name += " -allKeyVaultsByRegion";
            // Invoke graphql operation allAzureKeyVaultsByRegion
            InvokeQueryAllAzureKeyVaultsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureEncryptionKeys.
        protected void ProcessRecord_allEncryptionKey()
        {
            this._logger.name += " -allEncryptionKey";
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
        // allAzureCloudAccountTenants.
        protected void ProcessRecord_allCloudAccountTenant()
        {
            this._logger.name += " -allCloudAccountTenant";
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
        protected void ProcessRecord_allCloudAccountSubscriptionsByFeature()
        {
            this._logger.name += " -allCloudAccountSubscriptionsByFeature";
            // Invoke graphql operation allAzureCloudAccountSubscriptionsByFeature
            InvokeQueryAllAzureCloudAccountSubscriptionsByFeature();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSubscriptionWithExocomputeMappings.
        protected void ProcessRecord_allSubscriptionWithExocomputeMapping()
        {
            this._logger.name += " -allSubscriptionWithExocomputeMapping";
            // Invoke graphql operation allAzureSubscriptionWithExocomputeMappings
            InvokeQueryAllAzureSubscriptionWithExocomputeMappings();
        }

        // This parameter set invokes a single graphql operation:
        // allResourceGroupsFromAzure.
        protected void ProcessRecord_allResourceGroupsFrom()
        {
            this._logger.name += " -allResourceGroupsFrom";
            // Invoke graphql operation allResourceGroupsFromAzure
            InvokeQueryAllResourceGroupsFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // doesAzureNativeResourceGroupExist.
        protected void ProcessRecord_doesNativeResourceGroupExist()
        {
            this._logger.name += " -doesNativeResourceGroupExist";
            // Invoke graphql operation doesAzureNativeResourceGroupExist
            InvokeQueryDoesAzureNativeResourceGroupExist();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeResourceGroupsInfoIfExist.
        protected void ProcessRecord_allNativeResourceGroupsInfoIfExist()
        {
            this._logger.name += " -allNativeResourceGroupsInfoIfExist";
            // Invoke graphql operation allAzureNativeResourceGroupsInfoIfExist
            InvokeQueryAllAzureNativeResourceGroupsInfoIfExist();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountMissingPermissions.
        protected void ProcessRecord_allCloudAccountMissingPermission()
        {
            this._logger.name += " -allCloudAccountMissingPermission";
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
        protected void ProcessRecord_allExocomputeConfigsInAccount()
        {
            this._logger.name += " -allExocomputeConfigsInAccount";
            // Invoke graphql operation allAzureExocomputeConfigsInAccount
            InvokeQueryAllAzureExocomputeConfigsInAccount();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountSubnetsByRegion.
        protected void ProcessRecord_allCloudAccountSubnetsByRegion()
        {
            this._logger.name += " -allCloudAccountSubnetsByRegion";
            // Invoke graphql operation allAzureCloudAccountSubnetsByRegion
            InvokeQueryAllAzureCloudAccountSubnetsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureCloudAccountExocomputeConfigurations.
        protected void ProcessRecord_validateCloudAccountExocomputeConfiguration()
        {
            this._logger.name += " -validateCloudAccountExocomputeConfiguration";
            // Invoke graphql operation validateAzureCloudAccountExocomputeConfigurations
            InvokeQueryValidateAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureArmTemplatesByFeature.
        protected void ProcessRecord_allArmTemplatesByFeature()
        {
            this._logger.name += " -allArmTemplatesByFeature";
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
        protected void ProcessRecord_allHostedRegion()
        {
            this._logger.name += " -allHostedRegion";
            // Invoke graphql operation allHostedAzureRegions
            InvokeQueryAllHostedAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureResourceGroups.
        protected void ProcessRecord_allResourceGroup()
        {
            this._logger.name += " -allResourceGroup";
            // Invoke graphql operation allAzureResourceGroups
            InvokeQueryAllAzureResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureVnets.
        protected void ProcessRecord_allVnet()
        {
            this._logger.name += " -allVnet";
            // Invoke graphql operation allAzureVnets
            InvokeQueryAllAzureVnets();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSubnets.
        protected void ProcessRecord_allSubnet()
        {
            this._logger.name += " -allSubnet";
            // Invoke graphql operation allAzureSubnets
            InvokeQueryAllAzureSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCdmVersions.
        protected void ProcessRecord_allCdmVersion()
        {
            this._logger.name += " -allCdmVersion";
            // Invoke graphql operation allAzureCdmVersions
            InvokeQueryAllAzureCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureRegions.
        protected void ProcessRecord_allRegion()
        {
            this._logger.name += " -allRegion";
            // Invoke graphql operation allAzureRegions
            InvokeQueryAllAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNsgs.
        protected void ProcessRecord_allNsg()
        {
            this._logger.name += " -allNsg";
            // Invoke graphql operation allAzureNsgs
            InvokeQueryAllAzureNsgs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureStorageAccounts.
        protected void ProcessRecord_allStorageAccount()
        {
            this._logger.name += " -allStorageAccount";
            // Invoke graphql operation allAzureStorageAccounts
            InvokeQueryAllAzureStorageAccounts();
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureNativeRoot)psObject.BaseObject;
                } else {
                    fields = (AzureNativeRoot)this.Field;
                }
            }
            string document = Query.AzureNativeRoot(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureNativeRoot");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureNativeRoot" + parameters + "{" + document + "}",
                OperationName = "QueryAzureNativeRoot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<AzureNativeRoot> task = this._rbkClient.InvokeGenericCallAsync<AzureNativeRoot>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureNativeSubscription)psObject.BaseObject;
                } else {
                    fields = (AzureNativeSubscription)this.Field;
                }
            }
            string document = Query.AzureNativeSubscription(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureNativeSubscription");
            string parameters = "($azureSubscriptionRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureNativeSubscription" + parameters + "{" + document + "}",
                OperationName = "QueryAzureNativeSubscription",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureNativeSubscription> task = this._rbkClient.InvokeGenericCallAsync<AzureNativeSubscription>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureNativeResourceGroup)psObject.BaseObject;
                } else {
                    fields = (AzureNativeResourceGroup)this.Field;
                }
            }
            string document = Query.AzureNativeResourceGroup(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureNativeResourceGroup");
            string parameters = "($resourceGroupId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureNativeResourceGroup" + parameters + "{" + document + "}",
                OperationName = "QueryAzureNativeResourceGroup",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureNativeResourceGroup> task = this._rbkClient.InvokeGenericCallAsync<AzureNativeResourceGroup>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureNativeVirtualMachine)psObject.BaseObject;
                } else {
                    fields = (AzureNativeVirtualMachine)this.Field;
                }
            }
            string document = Query.AzureNativeVirtualMachine(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureNativeVirtualMachine");
            string parameters = "($azureVirtualMachineRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureNativeVirtualMachine" + parameters + "{" + document + "}",
                OperationName = "QueryAzureNativeVirtualMachine",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureNativeVirtualMachine> task = this._rbkClient.InvokeGenericCallAsync<AzureNativeVirtualMachine>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureNativeManagedDisk)psObject.BaseObject;
                } else {
                    fields = (AzureNativeManagedDisk)this.Field;
                }
            }
            string document = Query.AzureNativeManagedDisk(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureNativeManagedDisk");
            string parameters = "($azureManagedDiskRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureNativeManagedDisk" + parameters + "{" + document + "}",
                OperationName = "QueryAzureNativeManagedDisk",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureNativeManagedDisk> task = this._rbkClient.InvokeGenericCallAsync<AzureNativeManagedDisk>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureNativeVirtualNetwork>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeVirtualNetwork>)this.Field;
                }
            }
            string document = Query.AllAzureNativeVirtualNetworks(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeVirtualNetworks");
            string parameters = "($azureSubscriptionRubrikId: UUID)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeVirtualNetworks" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeVirtualNetworks",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureNativeVirtualNetwork>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureNativeVirtualNetwork>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureNativeSubnet>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeSubnet>)this.Field;
                }
            }
            string document = Query.AllAzureNativeSubnetsByRegionFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeSubnetsByRegionFromAzure");
            string parameters = "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeSubnetsByRegionFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeSubnetsByRegionFromAzure",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureNativeSubnet>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureNativeSubnet>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureNativeSecurityGroup>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeSecurityGroup>)this.Field;
                }
            }
            string document = Query.AllAzureNativeSecurityGroupsByRegionFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeSecurityGroupsByRegionFromAzure");
            string parameters = "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeSecurityGroupsByRegionFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeSecurityGroupsByRegionFromAzure",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureNativeSecurityGroup>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureNativeSecurityGroup>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureNativeDiskEncryptionSet>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeDiskEncryptionSet>)this.Field;
                }
            }
            string document = Query.AllAzureDiskEncryptionSetsByRegion(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureDiskEncryptionSetsByRegion");
            string parameters = "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureDiskEncryptionSetsByRegion" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureDiskEncryptionSetsByRegion",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureNativeDiskEncryptionSet>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureNativeDiskEncryptionSet>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureNativeAvailabilitySet>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeAvailabilitySet>)this.Field;
                }
            }
            string document = Query.AllAzureNativeAvailabilitySetsByRegionFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeAvailabilitySetsByRegionFromAzure");
            string parameters = "($azureSubscriptionRubrikId: UUID!,$resourceGroupName: String!,$region: AzureNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeAvailabilitySetsByRegionFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeAvailabilitySetsByRegionFromAzure",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureNativeAvailabilitySet>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureNativeAvailabilitySet>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureNativeExportCompatibleVmSizes>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeExportCompatibleVmSizes>)this.Field;
                }
            }
            string document = Query.AllAzureNativeExportCompatibleVmSizesByRegionFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeExportCompatibleVmSizesByRegionFromAzure");
            string parameters = "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!,$vmSnapshotId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureNativeExportCompatibleVmSizes>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureNativeExportCompatibleVmSizes>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureNativeExportCompatibleDiskTypes>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeExportCompatibleDiskTypes>)this.Field;
                }
            }
            string document = Query.AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure");
            string parameters = "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureNativeExportCompatibleDiskTypes>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureNativeExportCompatibleDiskTypes>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAzureNativeVirtualMachineSizes(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeVirtualMachineSizes");
            string parameters = "($azureSubscriptionRubrikId: UUID)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeVirtualMachineSizes" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeVirtualMachineSizes",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<System.String>> task = this._rbkClient.InvokeGenericCallAsync<List<System.String>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Query.IsAzureNativeManagedDiskSnapshotRestorable(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsAzureNativeManagedDiskSnapshotRestorable");
            string parameters = "($azureSubscriptionRubrikId: UUID!,$diskSnapshotId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAzureNativeManagedDiskSnapshotRestorable" + parameters + "{" + document + "}",
                OperationName = "QueryIsAzureNativeManagedDiskSnapshotRestorable",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Query.IsAzureStorageAccountNameAvailable(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsAzureStorageAccountNameAvailable");
            string parameters = "($azureSubscriptionRubrikId: UUID!,$storageAccountName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAzureStorageAccountNameAvailable" + parameters + "{" + document + "}",
                OperationName = "QueryIsAzureStorageAccountNameAvailable",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureNativeStorageAccount>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeStorageAccount>)this.Field;
                }
            }
            string document = Query.AllAzureNativeStorageAccountsFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeStorageAccountsFromAzure");
            string parameters = "($azureSubscriptionRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeStorageAccountsFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeStorageAccountsFromAzure",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureNativeStorageAccount>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureNativeStorageAccount>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureSqlDatabaseDb)psObject.BaseObject;
                } else {
                    fields = (AzureSqlDatabaseDb)this.Field;
                }
            }
            string document = Query.AzureSqlDatabase(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSqlDatabase");
            string parameters = "($azureSqlDatabaseRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSqlDatabase" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSqlDatabase",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureSqlDatabaseDb> task = this._rbkClient.InvokeGenericCallAsync<AzureSqlDatabaseDb>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureSqlDatabaseServer)psObject.BaseObject;
                } else {
                    fields = (AzureSqlDatabaseServer)this.Field;
                }
            }
            string document = Query.AzureSqlDatabaseServer(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSqlDatabaseServer");
            string parameters = "($azureSqlDatabaseServerRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSqlDatabaseServer" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSqlDatabaseServer",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureSqlDatabaseServer> task = this._rbkClient.InvokeGenericCallAsync<AzureSqlDatabaseServer>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureSqlManagedInstanceDatabase)psObject.BaseObject;
                } else {
                    fields = (AzureSqlManagedInstanceDatabase)this.Field;
                }
            }
            string document = Query.AzureSqlManagedInstanceDatabase(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSqlManagedInstanceDatabase");
            string parameters = "($azureSqlManagedInstanceDatabaseRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSqlManagedInstanceDatabase" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSqlManagedInstanceDatabase",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureSqlManagedInstanceDatabase> task = this._rbkClient.InvokeGenericCallAsync<AzureSqlManagedInstanceDatabase>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureSqlManagedInstanceServer)psObject.BaseObject;
                } else {
                    fields = (AzureSqlManagedInstanceServer)this.Field;
                }
            }
            string document = Query.AzureSqlManagedInstanceServer(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSqlManagedInstanceServer");
            string parameters = "($azureSqlManagedInstanceServerRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSqlManagedInstanceServer" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSqlManagedInstanceServer",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureSqlManagedInstanceServer> task = this._rbkClient.InvokeGenericCallAsync<AzureSqlManagedInstanceServer>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureNativeSqlDatabasePointInTimeRestoreWindow)psObject.BaseObject;
                } else {
                    fields = (AzureNativeSqlDatabasePointInTimeRestoreWindow)this.Field;
                }
            }
            string document = Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure");
            string parameters = "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureNativeSqlDatabasePointInTimeRestoreWindow> task = this._rbkClient.InvokeGenericCallAsync<AzureNativeSqlDatabasePointInTimeRestoreWindow>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureNativeSqlDatabasePointInTimeRestoreWindow)psObject.BaseObject;
                } else {
                    fields = (AzureNativeSqlDatabasePointInTimeRestoreWindow)this.Field;
                }
            }
            string document = Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure");
            string parameters = "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlManagedInstanceName: String!,$azureSqlDatabaseName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureNativeSqlDatabasePointInTimeRestoreWindow> task = this._rbkClient.InvokeGenericCallAsync<AzureNativeSqlDatabasePointInTimeRestoreWindow>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ValidateAzureNativeSqlDatabaseDbNameForExportReply)psObject.BaseObject;
                } else {
                    fields = (ValidateAzureNativeSqlDatabaseDbNameForExportReply)this.Field;
                }
            }
            string document = Query.ValidateAzureNativeSqlDatabaseDbNameForExport(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ValidateAzureNativeSqlDatabaseDbNameForExport");
            string parameters = "($azureSqlDatabaseName: String!,$azureSqlDatabaseServerRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryValidateAzureNativeSqlDatabaseDbNameForExport" + parameters + "{" + document + "}",
                OperationName = "QueryValidateAzureNativeSqlDatabaseDbNameForExport",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ValidateAzureNativeSqlDatabaseDbNameForExportReply> task = this._rbkClient.InvokeGenericCallAsync<ValidateAzureNativeSqlDatabaseDbNameForExportReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ValidateAzureNativeSqlManagedInstanceDbNameForExportReply)psObject.BaseObject;
                } else {
                    fields = (ValidateAzureNativeSqlManagedInstanceDbNameForExportReply)this.Field;
                }
            }
            string document = Query.ValidateAzureNativeSqlManagedInstanceDbNameForExport(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ValidateAzureNativeSqlManagedInstanceDbNameForExport");
            string parameters = "($azureSqlDatabaseName: String!,$azureSqlManagedInstanceServerRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryValidateAzureNativeSqlManagedInstanceDbNameForExport" + parameters + "{" + document + "}",
                OperationName = "QueryValidateAzureNativeSqlManagedInstanceDbNameForExport",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ValidateAzureNativeSqlManagedInstanceDbNameForExportReply> task = this._rbkClient.InvokeGenericCallAsync<ValidateAzureNativeSqlManagedInstanceDbNameForExportReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureSqlDatabaseServerElasticPool>)psObject.BaseObject;
                } else {
                    fields = (List<AzureSqlDatabaseServerElasticPool>)this.Field;
                }
            }
            string document = Query.AllAzureSqlDatabaseServerElasticPools(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureSqlDatabaseServerElasticPools");
            string parameters = "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseServerRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureSqlDatabaseServerElasticPools" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureSqlDatabaseServerElasticPools",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureSqlDatabaseServerElasticPool>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureSqlDatabaseServerElasticPool>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Query.IsAzureNativeSqlDatabaseSnapshotPersistent(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsAzureNativeSqlDatabaseSnapshotPersistent");
            string parameters = "($snapshotId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAzureNativeSqlDatabaseSnapshotPersistent" + parameters + "{" + document + "}",
                OperationName = "QueryIsAzureNativeSqlDatabaseSnapshotPersistent",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureKeyVault>)psObject.BaseObject;
                } else {
                    fields = (List<AzureKeyVault>)this.Field;
                }
            }
            string document = Query.AllAzureKeyVaultsByRegion(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureKeyVaultsByRegion");
            string parameters = "($azureKeyVaultsInput: AzureKeyVaultsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureKeyVaultsByRegion" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureKeyVaultsByRegion",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureKeyVault>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureKeyVault>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureEncryptionKey>)psObject.BaseObject;
                } else {
                    fields = (List<AzureEncryptionKey>)this.Field;
                }
            }
            string document = Query.AllAzureEncryptionKeys(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureEncryptionKeys");
            string parameters = "($azureEncryptionKeysInput: AzureEncryptionKeysInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureEncryptionKeys" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureEncryptionKeys",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureEncryptionKey>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureEncryptionKey>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureCloudAccountTenant)psObject.BaseObject;
                } else {
                    fields = (AzureCloudAccountTenant)this.Field;
                }
            }
            string document = Query.AzureCloudAccountTenant(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureCloudAccountTenant");
            string parameters = "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureCloudAccountTenant" + parameters + "{" + document + "}",
                OperationName = "QueryAzureCloudAccountTenant",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureCloudAccountTenant> task = this._rbkClient.InvokeGenericCallAsync<AzureCloudAccountTenant>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureCloudAccountTenantWithExoConfigs)psObject.BaseObject;
                } else {
                    fields = (AzureCloudAccountTenantWithExoConfigs)this.Field;
                }
            }
            string document = Query.AzureCloudAccountTenantWithExoConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureCloudAccountTenantWithExoConfigs");
            string parameters = "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureCloudAccountTenantWithExoConfigs" + parameters + "{" + document + "}",
                OperationName = "QueryAzureCloudAccountTenantWithExoConfigs",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureCloudAccountTenantWithExoConfigs> task = this._rbkClient.InvokeGenericCallAsync<AzureCloudAccountTenantWithExoConfigs>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureCloudAccountTenant>)psObject.BaseObject;
                } else {
                    fields = (List<AzureCloudAccountTenant>)this.Field;
                }
            }
            string document = Query.AllAzureCloudAccountTenants(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureCloudAccountTenants");
            string parameters = "($features: [CloudAccountFeature!],$feature: CloudAccountFeature!,$includeSubscriptionDetails: Boolean!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureCloudAccountTenants" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureCloudAccountTenants",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureCloudAccountTenant>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureCloudAccountTenant>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureCloudAccountSubscriptionWithFeatures)psObject.BaseObject;
                } else {
                    fields = (AzureCloudAccountSubscriptionWithFeatures)this.Field;
                }
            }
            string document = Query.AzureCloudAccountSubscriptionWithFeatures(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureCloudAccountSubscriptionWithFeatures");
            string parameters = "($cloudAccountId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureCloudAccountSubscriptionWithFeatures" + parameters + "{" + document + "}",
                OperationName = "QueryAzureCloudAccountSubscriptionWithFeatures",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureCloudAccountSubscriptionWithFeatures> task = this._rbkClient.InvokeGenericCallAsync<AzureCloudAccountSubscriptionWithFeatures>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureSubscriptionWithFeaturesType>)psObject.BaseObject;
                } else {
                    fields = (List<AzureSubscriptionWithFeaturesType>)this.Field;
                }
            }
            string document = Query.AllAzureCloudAccountSubscriptionsByFeature(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureCloudAccountSubscriptionsByFeature");
            string parameters = "($feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureCloudAccountSubscriptionsByFeature" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureCloudAccountSubscriptionsByFeature",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureSubscriptionWithFeaturesType>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureSubscriptionWithFeaturesType>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureSubscriptionWithExocomputeMapping>)psObject.BaseObject;
                } else {
                    fields = (List<AzureSubscriptionWithExocomputeMapping>)this.Field;
                }
            }
            string document = Query.AllAzureSubscriptionWithExocomputeMappings(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureSubscriptionWithExocomputeMappings");
            string parameters = "($features: [CloudAccountFeature!],$exocomputeSubscriptionIdsFilter: [UUID!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureSubscriptionWithExocomputeMappings" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureSubscriptionWithExocomputeMappings",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureSubscriptionWithExocomputeMapping>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureSubscriptionWithExocomputeMapping>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureResourceGroup>)psObject.BaseObject;
                } else {
                    fields = (List<AzureResourceGroup>)this.Field;
                }
            }
            string document = Query.AllResourceGroupsFromAzure(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllResourceGroupsFromAzure");
            string parameters = "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$feature: CloudAccountFeature!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllResourceGroupsFromAzure" + parameters + "{" + document + "}",
                OperationName = "QueryAllResourceGroupsFromAzure",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureResourceGroup>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureResourceGroup>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Query.DoesAzureNativeResourceGroupExist(ref fields);
            this._input.Initialize(argDefs, fields, "Query.DoesAzureNativeResourceGroupExist");
            string parameters = "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$resourceGroupName: String!,$feature: CloudAccountFeature!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryDoesAzureNativeResourceGroupExist" + parameters + "{" + document + "}",
                OperationName = "QueryDoesAzureNativeResourceGroupExist",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureResourceGroupInfo>)psObject.BaseObject;
                } else {
                    fields = (List<AzureResourceGroupInfo>)this.Field;
                }
            }
            string document = Query.AllAzureNativeResourceGroupsInfoIfExist(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNativeResourceGroupsInfoIfExist");
            string parameters = "($input: AzureGetResourceGroupsInfoIfExistInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNativeResourceGroupsInfoIfExist" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNativeResourceGroupsInfoIfExist",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureResourceGroupInfo>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureResourceGroupInfo>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureSubscriptionMissingPermissions>)psObject.BaseObject;
                } else {
                    fields = (List<AzureSubscriptionMissingPermissions>)this.Field;
                }
            }
            string document = Query.AllAzureCloudAccountMissingPermissions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureCloudAccountMissingPermissions");
            string parameters = "($sessionId: String!,$subscriptionIds: [UUID!]!,$cloudAccountAction: CloudAccountAction!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureCloudAccountMissingPermissions" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureCloudAccountMissingPermissions",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureSubscriptionMissingPermissions>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureSubscriptionMissingPermissions>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureCloudAccountPermissionConfigResponse)psObject.BaseObject;
                } else {
                    fields = (AzureCloudAccountPermissionConfigResponse)this.Field;
                }
            }
            string document = Query.AzureCloudAccountPermissionConfig(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureCloudAccountPermissionConfig");
            string parameters = "($feature: CloudAccountFeature!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureCloudAccountPermissionConfig" + parameters + "{" + document + "}",
                OperationName = "QueryAzureCloudAccountPermissionConfig",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureCloudAccountPermissionConfigResponse> task = this._rbkClient.InvokeGenericCallAsync<AzureCloudAccountPermissionConfigResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureExocomputeConfigsInAccount>)psObject.BaseObject;
                } else {
                    fields = (List<AzureExocomputeConfigsInAccount>)this.Field;
                }
            }
            string document = Query.AllAzureExocomputeConfigsInAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureExocomputeConfigsInAccount");
            string parameters = "($azureExocomputeSearchQuery: String,$cloudAccountIDs: [UUID!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureExocomputeConfigsInAccount" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureExocomputeConfigsInAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureExocomputeConfigsInAccount>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureExocomputeConfigsInAccount>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureNativeSubnet>)psObject.BaseObject;
                } else {
                    fields = (List<AzureNativeSubnet>)this.Field;
                }
            }
            string document = Query.AllAzureCloudAccountSubnetsByRegion(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureCloudAccountSubnetsByRegion");
            string parameters = "($cloudAccountId: UUID!,$region: AzureCloudAccountRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureCloudAccountSubnetsByRegion" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureCloudAccountSubnetsByRegion",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureNativeSubnet>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureNativeSubnet>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ValidateAzureSubnetsForCloudAccountExocomputeReply)psObject.BaseObject;
                } else {
                    fields = (ValidateAzureSubnetsForCloudAccountExocomputeReply)this.Field;
                }
            }
            string document = Query.ValidateAzureCloudAccountExocomputeConfigurations(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ValidateAzureCloudAccountExocomputeConfigurations");
            string parameters = "($input: ValidateAzureCloudAccountExocomputeConfigurationsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryValidateAzureCloudAccountExocomputeConfigurations" + parameters + "{" + document + "}",
                OperationName = "QueryValidateAzureCloudAccountExocomputeConfigurations",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ValidateAzureSubnetsForCloudAccountExocomputeReply> task = this._rbkClient.InvokeGenericCallAsync<ValidateAzureSubnetsForCloudAccountExocomputeReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureArmTemplateByFeature>)psObject.BaseObject;
                } else {
                    fields = (List<AzureArmTemplateByFeature>)this.Field;
                }
            }
            string document = Query.AllAzureArmTemplatesByFeature(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureArmTemplatesByFeature");
            string parameters = "($input: AzureArmTemplatesByFeatureInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureArmTemplatesByFeature" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureArmTemplatesByFeature",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureArmTemplateByFeature>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureArmTemplateByFeature>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureSubscriptionConnection)psObject.BaseObject;
                } else {
                    fields = (AzureSubscriptionConnection)this.Field;
                }
            }
            string document = Query.AzureSubscriptions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSubscriptions");
            string parameters = "($tenantId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSubscriptions" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSubscriptions",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureSubscriptionConnection> task = this._rbkClient.InvokeGenericCallAsync<AzureSubscriptionConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RegionConnection)psObject.BaseObject;
                } else {
                    fields = (RegionConnection)this.Field;
                }
            }
            string document = Query.AzureRegions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureRegions");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureRegions" + parameters + "{" + document + "}",
                OperationName = "QueryAzureRegions",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RegionConnection> task = this._rbkClient.InvokeGenericCallAsync<RegionConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ResourceGroupConnection)psObject.BaseObject;
                } else {
                    fields = (ResourceGroupConnection)this.Field;
                }
            }
            string document = Query.AzureResourceGroups(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureResourceGroups");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureResourceGroups" + parameters + "{" + document + "}",
                OperationName = "QueryAzureResourceGroups",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ResourceGroupConnection> task = this._rbkClient.InvokeGenericCallAsync<ResourceGroupConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VnetConnection)psObject.BaseObject;
                } else {
                    fields = (VnetConnection)this.Field;
                }
            }
            string document = Query.AzureVnets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureVnets");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureVnets" + parameters + "{" + document + "}",
                OperationName = "QueryAzureVnets",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VnetConnection> task = this._rbkClient.InvokeGenericCallAsync<VnetConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (SubnetConnection)psObject.BaseObject;
                } else {
                    fields = (SubnetConnection)this.Field;
                }
            }
            string document = Query.AzureSubnets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureSubnets");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!,$vNetId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureSubnets" + parameters + "{" + document + "}",
                OperationName = "QueryAzureSubnets",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<SubnetConnection> task = this._rbkClient.InvokeGenericCallAsync<SubnetConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (StorageAccountConnection)psObject.BaseObject;
                } else {
                    fields = (StorageAccountConnection)this.Field;
                }
            }
            string document = Query.AzureStorageAccounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureStorageAccounts");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureStorageAccounts" + parameters + "{" + document + "}",
                OperationName = "QueryAzureStorageAccounts",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<StorageAccountConnection> task = this._rbkClient.InvokeGenericCallAsync<StorageAccountConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureRegionsResp)psObject.BaseObject;
                } else {
                    fields = (AzureRegionsResp)this.Field;
                }
            }
            string document = Query.AllHostedAzureRegions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllHostedAzureRegions");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllHostedAzureRegions" + parameters + "{" + document + "}",
                OperationName = "QueryAllHostedAzureRegions",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<AzureRegionsResp> task = this._rbkClient.InvokeGenericCallAsync<AzureRegionsResp>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAzureResourceGroups(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureResourceGroups");
            string parameters = "($cloudAccountId: String!,$azureRegion: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureResourceGroups" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureResourceGroups",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<System.String>> task = this._rbkClient.InvokeGenericCallAsync<List<System.String>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAzureVnets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureVnets");
            string parameters = "($vnetRequest: AzureVnetReq!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureVnets" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureVnets",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<System.String>> task = this._rbkClient.InvokeGenericCallAsync<List<System.String>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAzureSubnets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureSubnets");
            string parameters = "($subnetRequest: AzureSubnetReq!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureSubnets" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureSubnets",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<System.String>> task = this._rbkClient.InvokeGenericCallAsync<List<System.String>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureCdmVersion>)psObject.BaseObject;
                } else {
                    fields = (List<AzureCdmVersion>)this.Field;
                }
            }
            string document = Query.AllAzureCdmVersions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureCdmVersions");
            string parameters = "($cdmVersionRequest: AzureCdmVersionReq!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureCdmVersions" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureCdmVersions",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureCdmVersion>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureCdmVersion>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AzureCloudAccountRegion>)psObject.BaseObject;
                } else {
                    fields = (List<AzureCloudAccountRegion>)this.Field;
                }
            }
            string document = Query.AllAzureRegions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureRegions");
            string parameters = "($cloudAccountId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureRegions" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureRegions",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AzureCloudAccountRegion>> task = this._rbkClient.InvokeGenericCallAsync<List<AzureCloudAccountRegion>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAzureNsgs(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureNsgs");
            string parameters = "($nsgRequest: AzureNsgRequest!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureNsgs" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureNsgs",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<System.String>> task = this._rbkClient.InvokeGenericCallAsync<List<System.String>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAzureStorageAccounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAzureStorageAccounts");
            string parameters = "($storageAccountsRequest: AzureStorageAccountsReq!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAzureStorageAccounts" + parameters + "{" + document + "}",
                OperationName = "QueryAllAzureStorageAccounts",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<System.String>> task = this._rbkClient.InvokeGenericCallAsync<List<System.String>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscQueryAzure
}