// New-RscMutationGcpNative.cs
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
    /// Create a new RscQuery object for any of the 6
    /// operations in the 'Google Cloud Platform Native' API domain:
    /// DisableProject, ExcludeDisksFromInstanceSnapshot, ExportDisk, ExportGceInstance, RefreshProjects, or RestoreGceInstance.
    /// </summary>
    /// <description>
    /// New-RscMutationGcpNative creates a new
    /// mutation object for operations
    /// in the 'Google Cloud Platform Native' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 6 operations
    /// in the 'Google Cloud Platform Native' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: DisableProject, ExcludeDisksFromInstanceSnapshot, ExportDisk, ExportGceInstance, RefreshProjects, or RestoreGceInstance.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationGcpNative -DisableProject).Info().
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
    /// (New-RscMutationGcpNative -DisableProject).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the DisableProject operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: DisableProject
    /// 
    /// $query = New-RscMutationGcpNative -Operation DisableProject
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	projectId = $someString
    /// 	# REQUIRED
    /// 	shouldDeleteNativeSnapshots = $someBoolean
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
    /// Runs the ExcludeDisksFromInstanceSnapshot operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: ExcludeDisksFromInstanceSnapshot
    /// 
    /// $query = New-RscMutationGcpNative -Operation ExcludeDisksFromInstanceSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	instanceId = $someString
    /// 	# REQUIRED
    /// 	diskIdToIsExcluded = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			diskId = $someString
    /// 			# REQUIRED
    /// 			isExcluded = $someBoolean
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
    /// Runs the ExportDisk operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: ExportDisk
    /// 
    /// $query = New-RscMutationGcpNative -Operation ExportDisk
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	targetRegion = $someString
    /// 	# OPTIONAL
    /// 	targetZone = $someString
    /// 	# REQUIRED
    /// 	targetDiskName = $someString
    /// 	# REQUIRED
    /// 	targetDiskType = $someString
    /// 	# REQUIRED
    /// 	targetDiskSizeGb = $someInt
    /// 	# REQUIRED
    /// 	replaceAttached = $someBoolean
    /// 	# OPTIONAL
    /// 	replicaZones = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	shouldCopyLabels = $someBoolean
    /// 	# REQUIRED
    /// 	shouldAddRubrikLabels = $someBoolean
    /// 	# REQUIRED
    /// 	diskEncryptionType = $someDiskEncryptionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiskEncryptionType]) for enum values.
    /// 	# OPTIONAL
    /// 	kmsCryptoKey = @{
    /// 		# OPTIONAL
    /// 		projectNativeId = $someString
    /// 		# OPTIONAL
    /// 		location = $someString
    /// 		# OPTIONAL
    /// 		keyRing = $someString
    /// 		# OPTIONAL
    /// 		key = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	kmsCryptoKeyResourceId = $someString
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
    /// Runs the ExportGceInstance operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: ExportGceInstance
    /// 
    /// $query = New-RscMutationGcpNative -Operation ExportGceInstance
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	targetZone = $someString
    /// 	# REQUIRED
    /// 	targetInstanceName = $someString
    /// 	# REQUIRED
    /// 	targetMachineType = $someString
    /// 	# REQUIRED
    /// 	targetSubnetName = $someString
    /// 	# OPTIONAL
    /// 	targetNetworkTags = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	shouldPowerOff = $someBoolean
    /// 	# REQUIRED
    /// 	shouldCopyLabels = $someBoolean
    /// 	# REQUIRED
    /// 	shouldAddRubrikLabels = $someBoolean
    /// 	# OPTIONAL
    /// 	sharedVpcHostProjectNativeId = $someString
    /// 	# REQUIRED
    /// 	diskEncryptionType = $someDiskEncryptionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiskEncryptionType]) for enum values.
    /// 	# OPTIONAL
    /// 	kmsCryptoKey = @{
    /// 		# OPTIONAL
    /// 		projectNativeId = $someString
    /// 		# OPTIONAL
    /// 		location = $someString
    /// 		# OPTIONAL
    /// 		keyRing = $someString
    /// 		# OPTIONAL
    /// 		key = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	kmsCryptoKeyResourceId = $someString
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
    /// Runs the RefreshProjects operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: RefreshProjects
    /// 
    /// $query = New-RscMutationGcpNative -Operation RefreshProjects
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	projectIds = @(
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
    /// Runs the RestoreGceInstance operation
    /// of the 'Google Cloud Platform Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    GcpNative
    /// # API Operation: RestoreGceInstance
    /// 
    /// $query = New-RscMutationGcpNative -Operation RestoreGceInstance
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	shouldAddRubrikLabels = $someBoolean
    /// 	# REQUIRED
    /// 	shouldRestoreLabels = $someBoolean
    /// 	# REQUIRED
    /// 	shouldStartRestoredInstance = $someBoolean
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
        "RscMutationGcpNative",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationGcpNative : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "DisableProject",
                "ExcludeDisksFromInstanceSnapshot",
                "ExportDisk",
                "ExportGceInstance",
                "RefreshProjects",
                "RestoreGceInstance",
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
                    case "DisableProject":
                        this.ProcessRecord_DisableProject();
                        break;
                    case "ExcludeDisksFromInstanceSnapshot":
                        this.ProcessRecord_ExcludeDisksFromInstanceSnapshot();
                        break;
                    case "ExportDisk":
                        this.ProcessRecord_ExportDisk();
                        break;
                    case "ExportGceInstance":
                        this.ProcessRecord_ExportGceInstance();
                        break;
                    case "RefreshProjects":
                        this.ProcessRecord_RefreshProjects();
                        break;
                    case "RestoreGceInstance":
                        this.ProcessRecord_RestoreGceInstance();
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
        // gcpNativeDisableProject.
        internal void ProcessRecord_DisableProject()
        {
            this._logger.name += " -DisableProject";
            // Create new graphql operation gcpNativeDisableProject
            InitMutationGcpNativeDisableProject();
        }

        // This parameter set invokes a single graphql operation:
        // gcpNativeExcludeDisksFromInstanceSnapshot.
        internal void ProcessRecord_ExcludeDisksFromInstanceSnapshot()
        {
            this._logger.name += " -ExcludeDisksFromInstanceSnapshot";
            // Create new graphql operation gcpNativeExcludeDisksFromInstanceSnapshot
            InitMutationGcpNativeExcludeDisksFromInstanceSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // gcpNativeExportDisk.
        internal void ProcessRecord_ExportDisk()
        {
            this._logger.name += " -ExportDisk";
            // Create new graphql operation gcpNativeExportDisk
            InitMutationGcpNativeExportDisk();
        }

        // This parameter set invokes a single graphql operation:
        // gcpNativeExportGceInstance.
        internal void ProcessRecord_ExportGceInstance()
        {
            this._logger.name += " -ExportGceInstance";
            // Create new graphql operation gcpNativeExportGceInstance
            InitMutationGcpNativeExportGceInstance();
        }

        // This parameter set invokes a single graphql operation:
        // gcpNativeRefreshProjects.
        internal void ProcessRecord_RefreshProjects()
        {
            this._logger.name += " -RefreshProjects";
            // Create new graphql operation gcpNativeRefreshProjects
            InitMutationGcpNativeRefreshProjects();
        }

        // This parameter set invokes a single graphql operation:
        // gcpNativeRestoreGceInstance.
        internal void ProcessRecord_RestoreGceInstance()
        {
            this._logger.name += " -RestoreGceInstance";
            // Create new graphql operation gcpNativeRestoreGceInstance
            InitMutationGcpNativeRestoreGceInstance();
        }


        // Create new GraphQL Mutation:
        // gcpNativeDisableProject(input: GcpNativeDisableProjectInput!): AsyncJobStatus!
        internal void InitMutationGcpNativeDisableProject()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpNativeDisableProjectInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpNativeDisableProject",
                "($input: GcpNativeDisableProjectInput!)",
                "AsyncJobStatus",
                Mutation.GcpNativeDisableProject,
                Mutation.GcpNativeDisableProjectFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	projectId = $someString
	# REQUIRED
	shouldDeleteNativeSnapshots = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // gcpNativeExcludeDisksFromInstanceSnapshot(input: GcpNativeExcludeDisksFromInstanceSnapshotInput!): Void
        internal void InitMutationGcpNativeExcludeDisksFromInstanceSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpNativeExcludeDisksFromInstanceSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpNativeExcludeDisksFromInstanceSnapshot",
                "($input: GcpNativeExcludeDisksFromInstanceSnapshotInput!)",
                "System.String",
                Mutation.GcpNativeExcludeDisksFromInstanceSnapshot,
                Mutation.GcpNativeExcludeDisksFromInstanceSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	instanceId = $someString
	# REQUIRED
	diskIdToIsExcluded = @(
		@{
			# REQUIRED
			diskId = $someString
			# REQUIRED
			isExcluded = $someBoolean
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // gcpNativeExportDisk(input: GcpNativeExportDiskInput!): AsyncJobStatus!
        internal void InitMutationGcpNativeExportDisk()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpNativeExportDiskInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpNativeExportDisk",
                "($input: GcpNativeExportDiskInput!)",
                "AsyncJobStatus",
                Mutation.GcpNativeExportDisk,
                Mutation.GcpNativeExportDiskFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	targetRegion = $someString
	# OPTIONAL
	targetZone = $someString
	# REQUIRED
	targetDiskName = $someString
	# REQUIRED
	targetDiskType = $someString
	# REQUIRED
	targetDiskSizeGb = $someInt
	# REQUIRED
	replaceAttached = $someBoolean
	# OPTIONAL
	replicaZones = @(
		$someString
	)
	# REQUIRED
	shouldCopyLabels = $someBoolean
	# REQUIRED
	shouldAddRubrikLabels = $someBoolean
	# REQUIRED
	diskEncryptionType = $someDiskEncryptionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiskEncryptionType]) for enum values.
	# OPTIONAL
	kmsCryptoKey = @{
		# OPTIONAL
		projectNativeId = $someString
		# OPTIONAL
		location = $someString
		# OPTIONAL
		keyRing = $someString
		# OPTIONAL
		key = $someString
	}
	# OPTIONAL
	kmsCryptoKeyResourceId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // gcpNativeExportGceInstance(input: GcpNativeExportGceInstanceInput!): AsyncJobStatus!
        internal void InitMutationGcpNativeExportGceInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpNativeExportGceInstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpNativeExportGceInstance",
                "($input: GcpNativeExportGceInstanceInput!)",
                "AsyncJobStatus",
                Mutation.GcpNativeExportGceInstance,
                Mutation.GcpNativeExportGceInstanceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	targetZone = $someString
	# REQUIRED
	targetInstanceName = $someString
	# REQUIRED
	targetMachineType = $someString
	# REQUIRED
	targetSubnetName = $someString
	# OPTIONAL
	targetNetworkTags = @(
		$someString
	)
	# REQUIRED
	shouldPowerOff = $someBoolean
	# REQUIRED
	shouldCopyLabels = $someBoolean
	# REQUIRED
	shouldAddRubrikLabels = $someBoolean
	# OPTIONAL
	sharedVpcHostProjectNativeId = $someString
	# REQUIRED
	diskEncryptionType = $someDiskEncryptionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiskEncryptionType]) for enum values.
	# OPTIONAL
	kmsCryptoKey = @{
		# OPTIONAL
		projectNativeId = $someString
		# OPTIONAL
		location = $someString
		# OPTIONAL
		keyRing = $someString
		# OPTIONAL
		key = $someString
	}
	# OPTIONAL
	kmsCryptoKeyResourceId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // gcpNativeRefreshProjects(input: GcpNativeRefreshProjectsInput!): BatchAsyncJobStatus!
        internal void InitMutationGcpNativeRefreshProjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpNativeRefreshProjectsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpNativeRefreshProjects",
                "($input: GcpNativeRefreshProjectsInput!)",
                "BatchAsyncJobStatus",
                Mutation.GcpNativeRefreshProjects,
                Mutation.GcpNativeRefreshProjectsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	projectIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // gcpNativeRestoreGceInstance(input: GcpNativeRestoreGceInstanceInput!): AsyncJobStatus!
        internal void InitMutationGcpNativeRestoreGceInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GcpNativeRestoreGceInstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGcpNativeRestoreGceInstance",
                "($input: GcpNativeRestoreGceInstanceInput!)",
                "AsyncJobStatus",
                Mutation.GcpNativeRestoreGceInstance,
                Mutation.GcpNativeRestoreGceInstanceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	shouldAddRubrikLabels = $someBoolean
	# REQUIRED
	shouldRestoreLabels = $someBoolean
	# REQUIRED
	shouldStartRestoredInstance = $someBoolean
}"
            );
        }


    } // class New_RscMutationGcpNative
}