// New-RscMutationCloudNative.cs
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
    /// Create a new RscQuery object for any of the 13
    /// operations in the 'Cloud Native' API domain:
    /// AddSqlServerBackupCredentials, CheckRbaConnectivity, ClearSqlServerBackupCredentials, CreateLabelRule, CreateTagRule, DeleteLabelRule, DeleteTagRule, DownloadFiles, SetupSqlServerBackup, StartSnapshotsIndexJob, UpdateIndexingStatus, UpdateLabelRule, or UpdateTagRule.
    /// </summary>
    /// <description>
    /// New-RscMutationCloudNative creates a new
    /// mutation object for operations
    /// in the 'Cloud Native' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 13 operations
    /// in the 'Cloud Native' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddSqlServerBackupCredentials, CheckRbaConnectivity, ClearSqlServerBackupCredentials, CreateLabelRule, CreateTagRule, DeleteLabelRule, DeleteTagRule, DownloadFiles, SetupSqlServerBackup, StartSnapshotsIndexJob, UpdateIndexingStatus, UpdateLabelRule, or UpdateTagRule.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationCloudNative -AddSqlServerBackupCredentials).Info().
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
    /// (New-RscMutationCloudNative -AddSqlServerBackupCredentials).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddSqlServerBackupCredentials operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: AddSqlServerBackupCredentials
    /// 
    /// $query = New-RscMutationCloudNative -AddSqlServerBackupCredentials
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	objectIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	workloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 	# REQUIRED
    /// 	backupCredentials = @{
    /// 		# REQUIRED
    /// 		login = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	logicAppName = $someString
    /// 	# OPTIONAL
    /// 	logicAppApiKey = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddCloudNativeSqlServerBackupCredentialsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckRbaConnectivity operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: CheckRbaConnectivity
    /// 
    /// $query = New-RscMutationCloudNative -CheckRbaConnectivity
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudNativeCheckRbaConnectivityReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClearSqlServerBackupCredentials operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: ClearSqlServerBackupCredentials
    /// 
    /// $query = New-RscMutationCloudNative -ClearSqlServerBackupCredentials
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	objectIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	workloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClearCloudNativeSqlServerBackupCredentialsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateLabelRule operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: CreateLabelRule
    /// 
    /// $query = New-RscMutationCloudNative -CreateLabelRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	objectType = $someCloudNativeLabelObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLabelObjectType]) for enum values.
    /// 	# REQUIRED
    /// 	labelRuleName = $someString
    /// 	# REQUIRED
    /// 	label = @{
    /// 		# REQUIRED
    /// 		labelKey = $someString
    /// 		# REQUIRED
    /// 		labelValue = $someString
    /// 		# REQUIRED
    /// 		matchAllValues = $someBoolean
    /// 	}
    /// 	# REQUIRED
    /// 	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
    /// 	# OPTIONAL
    /// 	slaId = $someString
    /// 	# OPTIONAL
    /// 	cloudNativeAccountIds = @{
    /// 		# OPTIONAL
    /// 		awsNativeAccountIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		azureNativeSubscriptionIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		gcpNativeProjectIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	applyToAllCloudAccounts = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateCloudNativeLabelRuleReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateTagRule operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: CreateTagRule
    /// 
    /// $query = New-RscMutationCloudNative -CreateTagRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	objectType = $someCloudNativeTagObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagObjectType]) for enum values.
    /// 	# REQUIRED
    /// 	tagRuleName = $someString
    /// 	# REQUIRED
    /// 	tag = @{
    /// 		# REQUIRED
    /// 		tagKey = $someString
    /// 		# REQUIRED
    /// 		tagValue = $someString
    /// 		# REQUIRED
    /// 		matchAllValues = $someBoolean
    /// 	}
    /// 	# REQUIRED
    /// 	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
    /// 	# OPTIONAL
    /// 	slaId = $someString
    /// 	# OPTIONAL
    /// 	cloudNativeAccountIds = @{
    /// 		# OPTIONAL
    /// 		awsNativeAccountIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		azureNativeSubscriptionIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		gcpNativeProjectIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	applyToAllCloudAccounts = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateCloudNativeTagRuleReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteLabelRule operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: DeleteLabelRule
    /// 
    /// $query = New-RscMutationCloudNative -DeleteLabelRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	ruleId = $someString
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
    /// Runs the DeleteTagRule operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: DeleteTagRule
    /// 
    /// $query = New-RscMutationCloudNative -DeleteTagRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	ruleId = $someString
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
    /// Runs the DownloadFiles operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: DownloadFiles
    /// 
    /// $query = New-RscMutationCloudNative -DownloadFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	filePaths = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	snapshotType = $someSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
    /// 	# REQUIRED
    /// 	fileRecoveryLocationDetails = @{
    /// 		# OPTIONAL
    /// 		cloudDownloadLocationDetails = @{
    /// 			# REQUIRED
    /// 			downloadLocation = $someString
    /// 			# REQUIRED
    /// 			createDownloadLocation = $someBoolean
    /// 			# OPTIONAL
    /// 			tags = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					tagKey = $someString
    /// 					# REQUIRED
    /// 					tagValue = $someString
    /// 					# REQUIRED
    /// 					matchAllValues = $someBoolean
    /// 				}
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		vmDownloadLocationDetails = @{
    /// 			# REQUIRED
    /// 			id = $someString
    /// 			# OPTIONAL
    /// 			pathToRecover = $someString
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	downloadType = $someFileDownloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileDownloadType]) for enum values.
    /// 	# OPTIONAL
    /// 	exocomputeCloudNativeAccountId = $someString
    /// 	# OPTIONAL
    /// 	exocomputeRegion = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadFilesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetupSqlServerBackup operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: SetupSqlServerBackup
    /// 
    /// $query = New-RscMutationCloudNative -SetupSqlServerBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	databaseIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	adminCredentials = @{
    /// 		# REQUIRED
    /// 		login = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	authMechanism = $someSqlAuthenticationMechanism # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
    /// 	# OPTIONAL
    /// 	sessionId = $someString
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
    /// Runs the StartSnapshotsIndexJob operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: StartSnapshotsIndexJob
    /// 
    /// $query = New-RscMutationCloudNative -StartSnapshotsIndexJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotIds = @(
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
    /// Runs the UpdateIndexingStatus operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: UpdateIndexingStatus
    /// 
    /// $query = New-RscMutationCloudNative -UpdateIndexingStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	isIndexingEnabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateCloudNativeIndexingStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateLabelRule operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: UpdateLabelRule
    /// 
    /// $query = New-RscMutationCloudNative -UpdateLabelRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	labelRuleId = $someString
    /// 	# REQUIRED
    /// 	labelRuleName = $someString
    /// 	# REQUIRED
    /// 	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
    /// 	# OPTIONAL
    /// 	slaId = $someString
    /// 	# OPTIONAL
    /// 	cloudNativeAccountIds = @{
    /// 		# OPTIONAL
    /// 		awsNativeAccountIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		azureNativeSubscriptionIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		gcpNativeProjectIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	applyToAllCloudAccounts = $someBoolean
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
    /// Runs the UpdateTagRule operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: UpdateTagRule
    /// 
    /// $query = New-RscMutationCloudNative -UpdateTagRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	tagRuleId = $someString
    /// 	# REQUIRED
    /// 	tagRuleName = $someString
    /// 	# REQUIRED
    /// 	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
    /// 	# OPTIONAL
    /// 	slaId = $someString
    /// 	# OPTIONAL
    /// 	cloudNativeAccountIds = @{
    /// 		# OPTIONAL
    /// 		awsNativeAccountIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		azureNativeSubscriptionIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		gcpNativeProjectIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	applyToAllCloudAccounts = $someBoolean
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationCloudNative",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationCloudNative : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddSqlServerBackupCredentials",
                "CheckRbaConnectivity",
                "ClearSqlServerBackupCredentials",
                "CreateLabelRule",
                "CreateTagRule",
                "DeleteLabelRule",
                "DeleteTagRule",
                "DownloadFiles",
                "SetupSqlServerBackup",
                "StartSnapshotsIndexJob",
                "UpdateIndexingStatus",
                "UpdateLabelRule",
                "UpdateTagRule",
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
                    case "AddSqlServerBackupCredentials":
                        this.ProcessRecord_AddSqlServerBackupCredentials();
                        break;
                    case "CheckRbaConnectivity":
                        this.ProcessRecord_CheckRbaConnectivity();
                        break;
                    case "ClearSqlServerBackupCredentials":
                        this.ProcessRecord_ClearSqlServerBackupCredentials();
                        break;
                    case "CreateLabelRule":
                        this.ProcessRecord_CreateLabelRule();
                        break;
                    case "CreateTagRule":
                        this.ProcessRecord_CreateTagRule();
                        break;
                    case "DeleteLabelRule":
                        this.ProcessRecord_DeleteLabelRule();
                        break;
                    case "DeleteTagRule":
                        this.ProcessRecord_DeleteTagRule();
                        break;
                    case "DownloadFiles":
                        this.ProcessRecord_DownloadFiles();
                        break;
                    case "SetupSqlServerBackup":
                        this.ProcessRecord_SetupSqlServerBackup();
                        break;
                    case "StartSnapshotsIndexJob":
                        this.ProcessRecord_StartSnapshotsIndexJob();
                        break;
                    case "UpdateIndexingStatus":
                        this.ProcessRecord_UpdateIndexingStatus();
                        break;
                    case "UpdateLabelRule":
                        this.ProcessRecord_UpdateLabelRule();
                        break;
                    case "UpdateTagRule":
                        this.ProcessRecord_UpdateTagRule();
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
        // addCloudNativeSqlServerBackupCredentials.
        internal void ProcessRecord_AddSqlServerBackupCredentials()
        {
            this._logger.name += " -AddSqlServerBackupCredentials";
            // Create new graphql operation addCloudNativeSqlServerBackupCredentials
            InitMutationAddCloudNativeSqlServerBackupCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeCheckRbaConnectivity.
        internal void ProcessRecord_CheckRbaConnectivity()
        {
            this._logger.name += " -CheckRbaConnectivity";
            // Create new graphql operation cloudNativeCheckRbaConnectivity
            InitMutationCloudNativeCheckRbaConnectivity();
        }

        // This parameter set invokes a single graphql operation:
        // clearCloudNativeSqlServerBackupCredentials.
        internal void ProcessRecord_ClearSqlServerBackupCredentials()
        {
            this._logger.name += " -ClearSqlServerBackupCredentials";
            // Create new graphql operation clearCloudNativeSqlServerBackupCredentials
            InitMutationClearCloudNativeSqlServerBackupCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeLabelRule.
        internal void ProcessRecord_CreateLabelRule()
        {
            this._logger.name += " -CreateLabelRule";
            // Create new graphql operation createCloudNativeLabelRule
            InitMutationCreateCloudNativeLabelRule();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeTagRule.
        internal void ProcessRecord_CreateTagRule()
        {
            this._logger.name += " -CreateTagRule";
            // Create new graphql operation createCloudNativeTagRule
            InitMutationCreateCloudNativeTagRule();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCloudNativeLabelRule.
        internal void ProcessRecord_DeleteLabelRule()
        {
            this._logger.name += " -DeleteLabelRule";
            // Create new graphql operation deleteCloudNativeLabelRule
            InitMutationDeleteCloudNativeLabelRule();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCloudNativeTagRule.
        internal void ProcessRecord_DeleteTagRule()
        {
            this._logger.name += " -DeleteTagRule";
            // Create new graphql operation deleteCloudNativeTagRule
            InitMutationDeleteCloudNativeTagRule();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeDownloadFiles.
        internal void ProcessRecord_DownloadFiles()
        {
            this._logger.name += " -DownloadFiles";
            // Create new graphql operation cloudNativeDownloadFiles
            InitMutationCloudNativeDownloadFiles();
        }

        // This parameter set invokes a single graphql operation:
        // setupCloudNativeSqlServerBackup.
        internal void ProcessRecord_SetupSqlServerBackup()
        {
            this._logger.name += " -SetupSqlServerBackup";
            // Create new graphql operation setupCloudNativeSqlServerBackup
            InitMutationSetupCloudNativeSqlServerBackup();
        }

        // This parameter set invokes a single graphql operation:
        // startCloudNativeSnapshotsIndexJob.
        internal void ProcessRecord_StartSnapshotsIndexJob()
        {
            this._logger.name += " -StartSnapshotsIndexJob";
            // Create new graphql operation startCloudNativeSnapshotsIndexJob
            InitMutationStartCloudNativeSnapshotsIndexJob();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeIndexingStatus.
        internal void ProcessRecord_UpdateIndexingStatus()
        {
            this._logger.name += " -UpdateIndexingStatus";
            // Create new graphql operation updateCloudNativeIndexingStatus
            InitMutationUpdateCloudNativeIndexingStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeLabelRule.
        internal void ProcessRecord_UpdateLabelRule()
        {
            this._logger.name += " -UpdateLabelRule";
            // Create new graphql operation updateCloudNativeLabelRule
            InitMutationUpdateCloudNativeLabelRule();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeTagRule.
        internal void ProcessRecord_UpdateTagRule()
        {
            this._logger.name += " -UpdateTagRule";
            // Create new graphql operation updateCloudNativeTagRule
            InitMutationUpdateCloudNativeTagRule();
        }


        // Create new GraphQL Mutation:
        // addCloudNativeSqlServerBackupCredentials(input: AddCloudNativeSqlServerBackupCredentialsInput!): AddCloudNativeSqlServerBackupCredentialsReply!
        internal void InitMutationAddCloudNativeSqlServerBackupCredentials()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddCloudNativeSqlServerBackupCredentialsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddCloudNativeSqlServerBackupCredentials",
                "($input: AddCloudNativeSqlServerBackupCredentialsInput!)",
                "AddCloudNativeSqlServerBackupCredentialsReply",
                Mutation.AddCloudNativeSqlServerBackupCredentials,
                Mutation.AddCloudNativeSqlServerBackupCredentialsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	objectIds = @(
		$someString
	)
	# REQUIRED
	workloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
	# REQUIRED
	backupCredentials = @{
		# REQUIRED
		login = $someString
		# REQUIRED
		password = $someString
	}
	# OPTIONAL
	logicAppName = $someString
	# OPTIONAL
	logicAppApiKey = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // cloudNativeCheckRbaConnectivity(input: CloudNativeCheckRbaConnectivityInput!): CloudNativeCheckRbaConnectivityReply!
        internal void InitMutationCloudNativeCheckRbaConnectivity()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CloudNativeCheckRbaConnectivityInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCloudNativeCheckRbaConnectivity",
                "($input: CloudNativeCheckRbaConnectivityInput!)",
                "CloudNativeCheckRbaConnectivityReply",
                Mutation.CloudNativeCheckRbaConnectivity,
                Mutation.CloudNativeCheckRbaConnectivityFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // clearCloudNativeSqlServerBackupCredentials(input: ClearCloudNativeSqlServerBackupCredentialsInput!): ClearCloudNativeSqlServerBackupCredentialsReply!
        internal void InitMutationClearCloudNativeSqlServerBackupCredentials()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClearCloudNativeSqlServerBackupCredentialsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationClearCloudNativeSqlServerBackupCredentials",
                "($input: ClearCloudNativeSqlServerBackupCredentialsInput!)",
                "ClearCloudNativeSqlServerBackupCredentialsReply",
                Mutation.ClearCloudNativeSqlServerBackupCredentials,
                Mutation.ClearCloudNativeSqlServerBackupCredentialsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	objectIds = @(
		$someString
	)
	# REQUIRED
	workloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCloudNativeLabelRule(input: CreateCloudNativeLabelRuleInput!): CreateCloudNativeLabelRuleReply!
        internal void InitMutationCreateCloudNativeLabelRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeLabelRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeLabelRule",
                "($input: CreateCloudNativeLabelRuleInput!)",
                "CreateCloudNativeLabelRuleReply",
                Mutation.CreateCloudNativeLabelRule,
                Mutation.CreateCloudNativeLabelRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	objectType = $someCloudNativeLabelObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLabelObjectType]) for enum values.
	# REQUIRED
	labelRuleName = $someString
	# REQUIRED
	label = @{
		# REQUIRED
		labelKey = $someString
		# REQUIRED
		labelValue = $someString
		# REQUIRED
		matchAllValues = $someBoolean
	}
	# REQUIRED
	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
	# OPTIONAL
	slaId = $someString
	# OPTIONAL
	cloudNativeAccountIds = @{
		# OPTIONAL
		awsNativeAccountIds = @(
			$someString
		)
		# OPTIONAL
		azureNativeSubscriptionIds = @(
			$someString
		)
		# OPTIONAL
		gcpNativeProjectIds = @(
			$someString
		)
	}
	# OPTIONAL
	applyToAllCloudAccounts = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCloudNativeTagRule(input: CreateCloudNativeTagRuleInput!): CreateCloudNativeTagRuleReply!
        internal void InitMutationCreateCloudNativeTagRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeTagRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeTagRule",
                "($input: CreateCloudNativeTagRuleInput!)",
                "CreateCloudNativeTagRuleReply",
                Mutation.CreateCloudNativeTagRule,
                Mutation.CreateCloudNativeTagRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	objectType = $someCloudNativeTagObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagObjectType]) for enum values.
	# REQUIRED
	tagRuleName = $someString
	# REQUIRED
	tag = @{
		# REQUIRED
		tagKey = $someString
		# REQUIRED
		tagValue = $someString
		# REQUIRED
		matchAllValues = $someBoolean
	}
	# REQUIRED
	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
	# OPTIONAL
	slaId = $someString
	# OPTIONAL
	cloudNativeAccountIds = @{
		# OPTIONAL
		awsNativeAccountIds = @(
			$someString
		)
		# OPTIONAL
		azureNativeSubscriptionIds = @(
			$someString
		)
		# OPTIONAL
		gcpNativeProjectIds = @(
			$someString
		)
	}
	# OPTIONAL
	applyToAllCloudAccounts = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteCloudNativeLabelRule(input: DeleteCloudNativeLabelRuleInput!): Void
        internal void InitMutationDeleteCloudNativeLabelRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteCloudNativeLabelRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCloudNativeLabelRule",
                "($input: DeleteCloudNativeLabelRuleInput!)",
                "System.String",
                Mutation.DeleteCloudNativeLabelRule,
                Mutation.DeleteCloudNativeLabelRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	ruleId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteCloudNativeTagRule(input: DeleteCloudNativeTagRuleInput!): Void
        internal void InitMutationDeleteCloudNativeTagRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteCloudNativeTagRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCloudNativeTagRule",
                "($input: DeleteCloudNativeTagRuleInput!)",
                "System.String",
                Mutation.DeleteCloudNativeTagRule,
                Mutation.DeleteCloudNativeTagRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	ruleId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // cloudNativeDownloadFiles(input: CloudNativeDownloadFilesInput!): DownloadFilesReply!
        internal void InitMutationCloudNativeDownloadFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CloudNativeDownloadFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCloudNativeDownloadFiles",
                "($input: CloudNativeDownloadFilesInput!)",
                "DownloadFilesReply",
                Mutation.CloudNativeDownloadFiles,
                Mutation.CloudNativeDownloadFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	filePaths = @(
		$someString
	)
	# OPTIONAL
	snapshotType = $someSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
	# REQUIRED
	fileRecoveryLocationDetails = @{
		# OPTIONAL
		cloudDownloadLocationDetails = @{
			# REQUIRED
			downloadLocation = $someString
			# REQUIRED
			createDownloadLocation = $someBoolean
			# OPTIONAL
			tags = @(
				@{
					# REQUIRED
					tagKey = $someString
					# REQUIRED
					tagValue = $someString
					# REQUIRED
					matchAllValues = $someBoolean
				}
			)
		}
		# OPTIONAL
		vmDownloadLocationDetails = @{
			# REQUIRED
			id = $someString
			# OPTIONAL
			pathToRecover = $someString
		}
	}
	# REQUIRED
	downloadType = $someFileDownloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileDownloadType]) for enum values.
	# OPTIONAL
	exocomputeCloudNativeAccountId = $someString
	# OPTIONAL
	exocomputeRegion = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // setupCloudNativeSqlServerBackup(input: SetupCloudNativeSqlServerBackupInput!): BatchAsyncJobStatus!
        internal void InitMutationSetupCloudNativeSqlServerBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetupCloudNativeSqlServerBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetupCloudNativeSqlServerBackup",
                "($input: SetupCloudNativeSqlServerBackupInput!)",
                "BatchAsyncJobStatus",
                Mutation.SetupCloudNativeSqlServerBackup,
                Mutation.SetupCloudNativeSqlServerBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	databaseIds = @(
		$someString
	)
	# OPTIONAL
	adminCredentials = @{
		# REQUIRED
		login = $someString
		# REQUIRED
		password = $someString
	}
	# OPTIONAL
	authMechanism = $someSqlAuthenticationMechanism # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
	# OPTIONAL
	sessionId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startCloudNativeSnapshotsIndexJob(input: StartCloudNativeSnapshotsIndexJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartCloudNativeSnapshotsIndexJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCloudNativeSnapshotsIndexJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCloudNativeSnapshotsIndexJob",
                "($input: StartCloudNativeSnapshotsIndexJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartCloudNativeSnapshotsIndexJob,
                Mutation.StartCloudNativeSnapshotsIndexJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeIndexingStatus(input: UpdateCloudNativeIndexingStatusInput!): UpdateCloudNativeIndexingStatusReply!
        internal void InitMutationUpdateCloudNativeIndexingStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeIndexingStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeIndexingStatus",
                "($input: UpdateCloudNativeIndexingStatusInput!)",
                "UpdateCloudNativeIndexingStatusReply",
                Mutation.UpdateCloudNativeIndexingStatus,
                Mutation.UpdateCloudNativeIndexingStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadIds = @(
		$someString
	)
	# REQUIRED
	isIndexingEnabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeLabelRule(input: UpdateCloudNativeLabelRuleInput!): Void
        internal void InitMutationUpdateCloudNativeLabelRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeLabelRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeLabelRule",
                "($input: UpdateCloudNativeLabelRuleInput!)",
                "System.String",
                Mutation.UpdateCloudNativeLabelRule,
                Mutation.UpdateCloudNativeLabelRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	labelRuleId = $someString
	# REQUIRED
	labelRuleName = $someString
	# REQUIRED
	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
	# OPTIONAL
	slaId = $someString
	# OPTIONAL
	cloudNativeAccountIds = @{
		# OPTIONAL
		awsNativeAccountIds = @(
			$someString
		)
		# OPTIONAL
		azureNativeSubscriptionIds = @(
			$someString
		)
		# OPTIONAL
		gcpNativeProjectIds = @(
			$someString
		)
	}
	# OPTIONAL
	applyToAllCloudAccounts = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeTagRule(input: UpdateCloudNativeTagRuleInput!): Void
        internal void InitMutationUpdateCloudNativeTagRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeTagRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeTagRule",
                "($input: UpdateCloudNativeTagRuleInput!)",
                "System.String",
                Mutation.UpdateCloudNativeTagRule,
                Mutation.UpdateCloudNativeTagRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	tagRuleId = $someString
	# REQUIRED
	tagRuleName = $someString
	# REQUIRED
	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
	# OPTIONAL
	slaId = $someString
	# OPTIONAL
	cloudNativeAccountIds = @{
		# OPTIONAL
		awsNativeAccountIds = @(
			$someString
		)
		# OPTIONAL
		azureNativeSubscriptionIds = @(
			$someString
		)
		# OPTIONAL
		gcpNativeProjectIds = @(
			$someString
		)
	}
	# OPTIONAL
	applyToAllCloudAccounts = $someBoolean
}"
            );
        }


    } // class New_RscMutationCloudNative
}