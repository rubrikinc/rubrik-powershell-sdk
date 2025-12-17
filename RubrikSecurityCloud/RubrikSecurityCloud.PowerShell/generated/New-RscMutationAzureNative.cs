// New-RscMutationAzureNative.cs
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
    /// Create a new RscQuery object for any of the 9
    /// operations in the 'Azure Native' API domain:
    /// ExcludeManagedDisksFromSnapshot, StartCreateManagedDiskSnapshotsJob, StartCreateVirtualMachineSnapshotsJob, StartDisableSubscriptionProtectionJob, StartExportManagedDiskJob, StartExportVirtualMachineJob, StartRecoverStorageAccountJob, StartRefreshSubscriptionsJob, or StartRestoreVirtualMachineJob.
    /// </summary>
    /// <description>
    /// New-RscMutationAzureNative creates a new
    /// mutation object for operations
    /// in the 'Azure Native' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 9 operations
    /// in the 'Azure Native' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ExcludeManagedDisksFromSnapshot, StartCreateManagedDiskSnapshotsJob, StartCreateVirtualMachineSnapshotsJob, StartDisableSubscriptionProtectionJob, StartExportManagedDiskJob, StartExportVirtualMachineJob, StartRecoverStorageAccountJob, StartRefreshSubscriptionsJob, or StartRestoreVirtualMachineJob.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationAzureNative -ExcludeManagedDisksFromSnapshot).Info().
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
    /// (New-RscMutationAzureNative -ExcludeManagedDisksFromSnapshot).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ExcludeManagedDisksFromSnapshot operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: ExcludeManagedDisksFromSnapshot
    /// 
    /// $query = New-RscMutationAzureNative -Operation ExcludeManagedDisksFromSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	virtualMachineRubrikId = $someString
    /// 	# REQUIRED
    /// 	managedDiskExclusions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			managedDiskRubrikId = $someString
    /// 			# REQUIRED
    /// 			isExcludedFromSnapshot = $someBoolean
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartCreateManagedDiskSnapshotsJob operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: StartCreateManagedDiskSnapshotsJob
    /// 
    /// $query = New-RscMutationAzureNative -Operation StartCreateManagedDiskSnapshotsJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	managedDiskRubrikIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	retentionSlaId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartCreateVirtualMachineSnapshotsJob operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: StartCreateVirtualMachineSnapshotsJob
    /// 
    /// $query = New-RscMutationAzureNative -Operation StartCreateVirtualMachineSnapshotsJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	virtualMachineRubrikIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	retentionSlaId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartDisableSubscriptionProtectionJob operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: StartDisableSubscriptionProtectionJob
    /// 
    /// $query = New-RscMutationAzureNative -Operation StartDisableSubscriptionProtectionJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	azureSubscriptionRubrikId = $someString
    /// 	# REQUIRED
    /// 	shouldDeleteNativeSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	azureNativeProtectionFeature = $someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartExportManagedDiskJob operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: StartExportManagedDiskJob
    /// 
    /// $query = New-RscMutationAzureNative -Operation StartExportManagedDiskJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	diskName = $someString
    /// 	# OPTIONAL
    /// 	diskEncryptionSetNativeId = $someString
    /// 	# REQUIRED
    /// 	diskStorageTier = $someAzureNativeManagedDiskType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeManagedDiskType]) for enum values.
    /// 	# REQUIRED
    /// 	diskSize = $someInt
    /// 	# REQUIRED
    /// 	resourceGroup = $someString
    /// 	# REQUIRED
    /// 	destinationRegion = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	destinationAvailabilityZone = $someString
    /// 	# OPTIONAL
    /// 	destinationSubscriptionRubrikId = $someString
    /// 	# REQUIRED
    /// 	shouldExportTags = $someBoolean
    /// 	# REQUIRED
    /// 	shouldReplaceAttachedManagedDisk = $someBoolean
    /// 	# OPTIONAL
    /// 	shouldUseReplica = $someBoolean
    /// 	# OPTIONAL
    /// 	snapshotType = $someAzureSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSnapshotType]) for enum values.
    /// 	# OPTIONAL
    /// 	archivedSnapshotId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartExportVirtualMachineJob operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: StartExportVirtualMachineJob
    /// 
    /// $query = New-RscMutationAzureNative -Operation StartExportVirtualMachineJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	virtualMachineName = $someString
    /// 	# OPTIONAL
    /// 	diskEncryptionSetNativeId = $someString
    /// 	# REQUIRED
    /// 	resourceGroupName = $someString
    /// 	# REQUIRED
    /// 	destinationRegion = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	destinationAvailabilityZone = $someString
    /// 	# OPTIONAL
    /// 	destinationSubscriptionRubrikId = $someString
    /// 	# REQUIRED
    /// 	virtualMachineSize = $someString
    /// 	# REQUIRED
    /// 	subnetNativeId = $someString
    /// 	# OPTIONAL
    /// 	networkSecurityGroupNativeId = $someString
    /// 	# REQUIRED
    /// 	shouldExportTags = $someBoolean
    /// 	# REQUIRED
    /// 	shouldPowerOff = $someBoolean
    /// 	# OPTIONAL
    /// 	shouldUseReplica = $someBoolean
    /// 	# OPTIONAL
    /// 	availabilitySetNativeId = $someString
    /// 	# OPTIONAL
    /// 	shouldEnableAcceleratedNetworking = $someBoolean
    /// 	# OPTIONAL
    /// 	snapshotType = $someAzureSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSnapshotType]) for enum values.
    /// 	# OPTIONAL
    /// 	recoveryDiskIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	archivedSnapshotId = $someString
    /// 	# OPTIONAL
    /// 	destinationKeyVaultName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartRecoverStorageAccountJob operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: StartRecoverStorageAccountJob
    /// 
    /// $query = New-RscMutationAzureNative -Operation StartRecoverStorageAccountJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# OPTIONAL
    /// 	destinationSubscriptionRubrikId = $someString
    /// 	# REQUIRED
    /// 	shouldExportTags = $someBoolean
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	resourceGroupName = $someString
    /// 	# OPTIONAL
    /// 	objectKeys = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	tier = $someAzureStorageAccessTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageAccessTier]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartRefreshSubscriptionsJob operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: StartRefreshSubscriptionsJob
    /// 
    /// $query = New-RscMutationAzureNative -Operation StartRefreshSubscriptionsJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	azureSubscriptionRubrikIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartRestoreVirtualMachineJob operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: StartRestoreVirtualMachineJob
    /// 
    /// $query = New-RscMutationAzureNative -Operation StartRestoreVirtualMachineJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	shouldPowerOn = $someBoolean
    /// 	# REQUIRED
    /// 	shouldRestoreTags = $someBoolean
    /// 	# OPTIONAL
    /// 	snapshotTypeToUseIfSourceExpired = $someSnapshotTypeForRestoreIfSourceExpired # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeForRestoreIfSourceExpired]) for enum values.
    /// 	# OPTIONAL
    /// 	recoveryDiskIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	archivedSnapshotId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
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
        "RscMutationAzureNative",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationAzureNative : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "ExcludeManagedDisksFromSnapshot",
                "StartCreateManagedDiskSnapshotsJob",
                "StartCreateVirtualMachineSnapshotsJob",
                "StartDisableSubscriptionProtectionJob",
                "StartExportManagedDiskJob",
                "StartExportVirtualMachineJob",
                "StartRecoverStorageAccountJob",
                "StartRefreshSubscriptionsJob",
                "StartRestoreVirtualMachineJob",
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
                    case "ExcludeManagedDisksFromSnapshot":
                        this.ProcessRecord_ExcludeManagedDisksFromSnapshot();
                        break;
                    case "StartCreateManagedDiskSnapshotsJob":
                        this.ProcessRecord_StartCreateManagedDiskSnapshotsJob();
                        break;
                    case "StartCreateVirtualMachineSnapshotsJob":
                        this.ProcessRecord_StartCreateVirtualMachineSnapshotsJob();
                        break;
                    case "StartDisableSubscriptionProtectionJob":
                        this.ProcessRecord_StartDisableSubscriptionProtectionJob();
                        break;
                    case "StartExportManagedDiskJob":
                        this.ProcessRecord_StartExportManagedDiskJob();
                        break;
                    case "StartExportVirtualMachineJob":
                        this.ProcessRecord_StartExportVirtualMachineJob();
                        break;
                    case "StartRecoverStorageAccountJob":
                        this.ProcessRecord_StartRecoverStorageAccountJob();
                        break;
                    case "StartRefreshSubscriptionsJob":
                        this.ProcessRecord_StartRefreshSubscriptionsJob();
                        break;
                    case "StartRestoreVirtualMachineJob":
                        this.ProcessRecord_StartRestoreVirtualMachineJob();
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
        // excludeAzureNativeManagedDisksFromSnapshot.
        internal void ProcessRecord_ExcludeManagedDisksFromSnapshot()
        {
            this._logger.name += " -ExcludeManagedDisksFromSnapshot";
            // Create new graphql operation excludeAzureNativeManagedDisksFromSnapshot
            InitMutationExcludeAzureNativeManagedDisksFromSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeManagedDiskSnapshotsJob.
        internal void ProcessRecord_StartCreateManagedDiskSnapshotsJob()
        {
            this._logger.name += " -StartCreateManagedDiskSnapshotsJob";
            // Create new graphql operation startCreateAzureNativeManagedDiskSnapshotsJob
            InitMutationStartCreateAzureNativeManagedDiskSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob.
        internal void ProcessRecord_StartCreateVirtualMachineSnapshotsJob()
        {
            this._logger.name += " -StartCreateVirtualMachineSnapshotsJob";
            // Create new graphql operation startCreateAzureNativeVirtualMachineSnapshotsJob
            InitMutationStartCreateAzureNativeVirtualMachineSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureNativeSubscriptionProtectionJob.
        internal void ProcessRecord_StartDisableSubscriptionProtectionJob()
        {
            this._logger.name += " -StartDisableSubscriptionProtectionJob";
            // Create new graphql operation startDisableAzureNativeSubscriptionProtectionJob
            InitMutationStartDisableAzureNativeSubscriptionProtectionJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeManagedDiskJob.
        internal void ProcessRecord_StartExportManagedDiskJob()
        {
            this._logger.name += " -StartExportManagedDiskJob";
            // Create new graphql operation startExportAzureNativeManagedDiskJob
            InitMutationStartExportAzureNativeManagedDiskJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeVirtualMachineJob.
        internal void ProcessRecord_StartExportVirtualMachineJob()
        {
            this._logger.name += " -StartExportVirtualMachineJob";
            // Create new graphql operation startExportAzureNativeVirtualMachineJob
            InitMutationStartExportAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRecoverAzureNativeStorageAccountJob.
        internal void ProcessRecord_StartRecoverStorageAccountJob()
        {
            this._logger.name += " -StartRecoverStorageAccountJob";
            // Create new graphql operation startRecoverAzureNativeStorageAccountJob
            InitMutationStartRecoverAzureNativeStorageAccountJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRefreshAzureNativeSubscriptionsJob.
        internal void ProcessRecord_StartRefreshSubscriptionsJob()
        {
            this._logger.name += " -StartRefreshSubscriptionsJob";
            // Create new graphql operation startRefreshAzureNativeSubscriptionsJob
            InitMutationStartRefreshAzureNativeSubscriptionsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRestoreAzureNativeVirtualMachineJob.
        internal void ProcessRecord_StartRestoreVirtualMachineJob()
        {
            this._logger.name += " -StartRestoreVirtualMachineJob";
            // Create new graphql operation startRestoreAzureNativeVirtualMachineJob
            InitMutationStartRestoreAzureNativeVirtualMachineJob();
        }


        // Create new GraphQL Mutation:
        // excludeAzureNativeManagedDisksFromSnapshot(input: ExcludeAzureNativeManagedDisksFromSnapshotInput!): Void
        internal void InitMutationExcludeAzureNativeManagedDisksFromSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeAzureNativeManagedDisksFromSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExcludeAzureNativeManagedDisksFromSnapshot",
                "($input: ExcludeAzureNativeManagedDisksFromSnapshotInput!)",
                "System.String",
                Mutation.ExcludeAzureNativeManagedDisksFromSnapshot,
                Mutation.ExcludeAzureNativeManagedDisksFromSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	virtualMachineRubrikId = $someString
	# REQUIRED
	managedDiskExclusions = @(
		@{
			# REQUIRED
			managedDiskRubrikId = $someString
			# REQUIRED
			isExcludedFromSnapshot = $someBoolean
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startCreateAzureNativeManagedDiskSnapshotsJob(input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartCreateAzureNativeManagedDiskSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeManagedDiskSnapshotsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCreateAzureNativeManagedDiskSnapshotsJob",
                "($input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartCreateAzureNativeManagedDiskSnapshotsJob,
                Mutation.StartCreateAzureNativeManagedDiskSnapshotsJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	managedDiskRubrikIds = @(
		$someString
	)
	# OPTIONAL
	retentionSlaId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob(input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartCreateAzureNativeVirtualMachineSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeVirtualMachineSnapshotsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCreateAzureNativeVirtualMachineSnapshotsJob",
                "($input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJob,
                Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	virtualMachineRubrikIds = @(
		$someString
	)
	# OPTIONAL
	retentionSlaId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startDisableAzureNativeSubscriptionProtectionJob(input: StartDisableAzureNativeSubscriptionProtectionJobInput!): AsyncJobStatus!
        internal void InitMutationStartDisableAzureNativeSubscriptionProtectionJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureNativeSubscriptionProtectionJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartDisableAzureNativeSubscriptionProtectionJob",
                "($input: StartDisableAzureNativeSubscriptionProtectionJobInput!)",
                "AsyncJobStatus",
                Mutation.StartDisableAzureNativeSubscriptionProtectionJob,
                Mutation.StartDisableAzureNativeSubscriptionProtectionJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	azureSubscriptionRubrikId = $someString
	# REQUIRED
	shouldDeleteNativeSnapshots = $someBoolean
	# REQUIRED
	azureNativeProtectionFeature = $someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAzureNativeManagedDiskJob(input: StartExportAzureNativeManagedDiskJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAzureNativeManagedDiskJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeManagedDiskJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureNativeManagedDiskJob",
                "($input: StartExportAzureNativeManagedDiskJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureNativeManagedDiskJob,
                Mutation.StartExportAzureNativeManagedDiskJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	diskName = $someString
	# OPTIONAL
	diskEncryptionSetNativeId = $someString
	# REQUIRED
	diskStorageTier = $someAzureNativeManagedDiskType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeManagedDiskType]) for enum values.
	# REQUIRED
	diskSize = $someInt
	# REQUIRED
	resourceGroup = $someString
	# REQUIRED
	destinationRegion = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
	# OPTIONAL
	destinationAvailabilityZone = $someString
	# OPTIONAL
	destinationSubscriptionRubrikId = $someString
	# REQUIRED
	shouldExportTags = $someBoolean
	# REQUIRED
	shouldReplaceAttachedManagedDisk = $someBoolean
	# OPTIONAL
	shouldUseReplica = $someBoolean
	# OPTIONAL
	snapshotType = $someAzureSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSnapshotType]) for enum values.
	# OPTIONAL
	archivedSnapshotId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAzureNativeVirtualMachineJob(input: StartExportAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAzureNativeVirtualMachineJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeVirtualMachineJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureNativeVirtualMachineJob",
                "($input: StartExportAzureNativeVirtualMachineJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureNativeVirtualMachineJob,
                Mutation.StartExportAzureNativeVirtualMachineJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	virtualMachineName = $someString
	# OPTIONAL
	diskEncryptionSetNativeId = $someString
	# REQUIRED
	resourceGroupName = $someString
	# REQUIRED
	destinationRegion = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
	# OPTIONAL
	destinationAvailabilityZone = $someString
	# OPTIONAL
	destinationSubscriptionRubrikId = $someString
	# REQUIRED
	virtualMachineSize = $someString
	# REQUIRED
	subnetNativeId = $someString
	# OPTIONAL
	networkSecurityGroupNativeId = $someString
	# REQUIRED
	shouldExportTags = $someBoolean
	# REQUIRED
	shouldPowerOff = $someBoolean
	# OPTIONAL
	shouldUseReplica = $someBoolean
	# OPTIONAL
	availabilitySetNativeId = $someString
	# OPTIONAL
	shouldEnableAcceleratedNetworking = $someBoolean
	# OPTIONAL
	snapshotType = $someAzureSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSnapshotType]) for enum values.
	# OPTIONAL
	recoveryDiskIds = @(
		$someString
	)
	# OPTIONAL
	archivedSnapshotId = $someString
	# OPTIONAL
	destinationKeyVaultName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startRecoverAzureNativeStorageAccountJob(input: StartRecoverAzureNativeStorageAccountJobInput!): AsyncJobStatus!
        internal void InitMutationStartRecoverAzureNativeStorageAccountJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRecoverAzureNativeStorageAccountJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartRecoverAzureNativeStorageAccountJob",
                "($input: StartRecoverAzureNativeStorageAccountJobInput!)",
                "AsyncJobStatus",
                Mutation.StartRecoverAzureNativeStorageAccountJob,
                Mutation.StartRecoverAzureNativeStorageAccountJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# OPTIONAL
	destinationSubscriptionRubrikId = $someString
	# REQUIRED
	shouldExportTags = $someBoolean
	# OPTIONAL
	name = $someString
	# OPTIONAL
	region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
	# OPTIONAL
	resourceGroupName = $someString
	# OPTIONAL
	objectKeys = @(
		$someString
	)
	# REQUIRED
	tier = $someAzureStorageAccessTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageAccessTier]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startRefreshAzureNativeSubscriptionsJob(input: StartRefreshAzureNativeSubscriptionsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartRefreshAzureNativeSubscriptionsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRefreshAzureNativeSubscriptionsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartRefreshAzureNativeSubscriptionsJob",
                "($input: StartRefreshAzureNativeSubscriptionsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartRefreshAzureNativeSubscriptionsJob,
                Mutation.StartRefreshAzureNativeSubscriptionsJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startRestoreAzureNativeVirtualMachineJob(input: StartRestoreAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        internal void InitMutationStartRestoreAzureNativeVirtualMachineJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRestoreAzureNativeVirtualMachineJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartRestoreAzureNativeVirtualMachineJob",
                "($input: StartRestoreAzureNativeVirtualMachineJobInput!)",
                "AsyncJobStatus",
                Mutation.StartRestoreAzureNativeVirtualMachineJob,
                Mutation.StartRestoreAzureNativeVirtualMachineJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	shouldPowerOn = $someBoolean
	# REQUIRED
	shouldRestoreTags = $someBoolean
	# OPTIONAL
	snapshotTypeToUseIfSourceExpired = $someSnapshotTypeForRestoreIfSourceExpired # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeForRestoreIfSourceExpired]) for enum values.
	# OPTIONAL
	recoveryDiskIds = @(
		$someString
	)
	# OPTIONAL
	archivedSnapshotId = $someString
}"
            );
        }


    } // class New_RscMutationAzureNative
}