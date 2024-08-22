// New-RscMutationFileset.cs
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
    /// operations in the 'Fileset' API domain:
    /// BulkCreate, BulkCreateTemplates, BulkDelete, BulkDeleteTemplate, BulkUpdateTemplate, or RecoverFiles.
    /// </summary>
    /// <description>
    /// New-RscMutationFileset creates a new
    /// mutation object for operations
    /// in the 'Fileset' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 6 operations
    /// in the 'Fileset' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BulkCreate, BulkCreateTemplates, BulkDelete, BulkDeleteTemplate, BulkUpdateTemplate, or RecoverFiles.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationFileset -BulkCreate).Info().
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
    /// (New-RscMutationFileset -BulkCreate).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BulkCreate operation
    /// of the 'Fileset' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Fileset
    /// # API Operation: BulkCreate
    /// 
    /// $query = New-RscMutationFileset -BulkCreate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	definitions = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			hostId = $someString
    /// 			# OPTIONAL
    /// 			isPassthrough = $someBoolean
    /// 			# OPTIONAL
    /// 			shareId = $someString
    /// 			# OPTIONAL
    /// 			enableHardlinkSupport = $someBoolean
    /// 			# OPTIONAL
    /// 			enableSymlinkResolution = $someBoolean
    /// 			# OPTIONAL
    /// 			failoverClusterAppId = $someString
    /// 			# OPTIONAL
    /// 			snapMirrorLabelForFullBackup = $someString
    /// 			# OPTIONAL
    /// 			snapMirrorLabelForIncrementalBackup = $someString
    /// 			# OPTIONAL
    /// 			isManagedByPolaris = $someBoolean
    /// 			# OPTIONAL
    /// 			isPolarisNasModel = $someBoolean
    /// 			# OPTIONAL
    /// 			arraySpec = @{
    /// 				# OPTIONAL
    /// 				proxyHostId = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			templateId = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkCreateFilesetsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkCreateTemplates operation
    /// of the 'Fileset' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Fileset
    /// # API Operation: BulkCreateTemplates
    /// 
    /// $query = New-RscMutationFileset -BulkCreateTemplates
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	definitions = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			backupScriptErrorHandling = $someString
    /// 			# OPTIONAL
    /// 			backupScriptTimeout = $someInt64
    /// 			# OPTIONAL
    /// 			exceptions = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			excludes = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			isArrayEnabled = $someBoolean
    /// 			# OPTIONAL
    /// 			postBackupScript = $someString
    /// 			# OPTIONAL
    /// 			preBackupScript = $someString
    /// 			# OPTIONAL
    /// 			isCreatedByKupr = $someBoolean
    /// 			# OPTIONAL
    /// 			isCreatedByPolarisNas = $someBoolean
    /// 			# OPTIONAL
    /// 			operatingSystemType = $someFilesetTemplateCreateOperatingSystemType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplateCreateOperatingSystemType]) for enum values.
    /// 			# OPTIONAL
    /// 			shareType = $someFilesetTemplateCreateShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplateCreateShareType]) for enum values.
    /// 			# OPTIONAL
    /// 			filesetOptions = @{
    /// 				# OPTIONAL
    /// 				allowBackupHiddenFoldersInNetworkMounts = $someBoolean
    /// 				# OPTIONAL
    /// 				allowBackupNetworkMounts = $someBoolean
    /// 				# OPTIONAL
    /// 				useWindowsVss = $someBoolean
    /// 			}
    /// 			# REQUIRED
    /// 			includes = @(
    /// 				$someString
    /// 			)
    /// 			# REQUIRED
    /// 			name = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkCreateFilesetTemplatesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkDelete operation
    /// of the 'Fileset' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Fileset
    /// # API Operation: BulkDelete
    /// 
    /// $query = New-RscMutationFileset -BulkDelete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	preserveSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	ids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkDeleteTemplate operation
    /// of the 'Fileset' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Fileset
    /// # API Operation: BulkDeleteTemplate
    /// 
    /// $query = New-RscMutationFileset -BulkDeleteTemplate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	preserveSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	ids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkUpdateTemplate operation
    /// of the 'Fileset' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Fileset
    /// # API Operation: BulkUpdateTemplate
    /// 
    /// $query = New-RscMutationFileset -BulkUpdateTemplate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	definitions = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			backupScriptErrorHandling = $someString
    /// 			# OPTIONAL
    /// 			backupScriptTimeout = $someInt64
    /// 			# OPTIONAL
    /// 			exceptions = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			excludes = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			includes = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			name = $someString
    /// 			# OPTIONAL
    /// 			postBackupScript = $someString
    /// 			# OPTIONAL
    /// 			preBackupScript = $someString
    /// 			# OPTIONAL
    /// 			isCreatedByKupr = $someBoolean
    /// 			# OPTIONAL
    /// 			isCreatedByPolarisNas = $someBoolean
    /// 			# OPTIONAL
    /// 			operatingSystemType = $someFilesetTemplatePatchOperatingSystemType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplatePatchOperatingSystemType]) for enum values.
    /// 			# OPTIONAL
    /// 			shareType = $someFilesetTemplatePatchShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplatePatchShareType]) for enum values.
    /// 			# OPTIONAL
    /// 			filesetOptions = @{
    /// 				# OPTIONAL
    /// 				allowBackupHiddenFoldersInNetworkMounts = $someBoolean
    /// 				# OPTIONAL
    /// 				allowBackupNetworkMounts = $someBoolean
    /// 				# OPTIONAL
    /// 				useWindowsVss = $someBoolean
    /// 			}
    /// 			# REQUIRED
    /// 			id = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkUpdateFilesetTemplateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverFiles operation
    /// of the 'Fileset' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Fileset
    /// # API Operation: RecoverFiles
    /// 
    /// $query = New-RscMutationFileset -RecoverFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotFid = $someString
    /// 	# OPTIONAL
    /// 	nextSnapshotFid = $someString
    /// 	# REQUIRED
    /// 	restorePathPairList = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			path = $someString
    /// 			# OPTIONAL
    /// 			restorePath = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	deltaTypeFilter = @(
    /// 		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		ignoreErrors = $someBoolean
    /// 		# OPTIONAL
    /// 		excludePaths = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		shouldRecreateDirectoryStructure = $someBoolean
    /// 		# REQUIRED
    /// 		restoreConfig = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				restorePathPair = @{
    /// 					# OPTIONAL
    /// 					restorePath = $someString
    /// 					# REQUIRED
    /// 					path = $someString
    /// 				}
    /// 			}
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	shareType = $someShareTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ShareTypeEnum]) for enum values.
    /// 	# REQUIRED
    /// 	osType = $someGuestOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GuestOsType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
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
        "RscMutationFileset",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationFileset : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BulkCreate",
                "BulkCreateTemplates",
                "BulkDelete",
                "BulkDeleteTemplate",
                "BulkUpdateTemplate",
                "RecoverFiles",
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
                    case "BulkCreate":
                        this.ProcessRecord_BulkCreate();
                        break;
                    case "BulkCreateTemplates":
                        this.ProcessRecord_BulkCreateTemplates();
                        break;
                    case "BulkDelete":
                        this.ProcessRecord_BulkDelete();
                        break;
                    case "BulkDeleteTemplate":
                        this.ProcessRecord_BulkDeleteTemplate();
                        break;
                    case "BulkUpdateTemplate":
                        this.ProcessRecord_BulkUpdateTemplate();
                        break;
                    case "RecoverFiles":
                        this.ProcessRecord_RecoverFiles();
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
        // bulkCreateFilesets.
        internal void ProcessRecord_BulkCreate()
        {
            this._logger.name += " -BulkCreate";
            // Create new graphql operation bulkCreateFilesets
            InitMutationBulkCreateFilesets();
        }

        // This parameter set invokes a single graphql operation:
        // bulkCreateFilesetTemplates.
        internal void ProcessRecord_BulkCreateTemplates()
        {
            this._logger.name += " -BulkCreateTemplates";
            // Create new graphql operation bulkCreateFilesetTemplates
            InitMutationBulkCreateFilesetTemplates();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteFileset.
        internal void ProcessRecord_BulkDelete()
        {
            this._logger.name += " -BulkDelete";
            // Create new graphql operation bulkDeleteFileset
            InitMutationBulkDeleteFileset();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteFilesetTemplate.
        internal void ProcessRecord_BulkDeleteTemplate()
        {
            this._logger.name += " -BulkDeleteTemplate";
            // Create new graphql operation bulkDeleteFilesetTemplate
            InitMutationBulkDeleteFilesetTemplate();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateFilesetTemplate.
        internal void ProcessRecord_BulkUpdateTemplate()
        {
            this._logger.name += " -BulkUpdateTemplate";
            // Create new graphql operation bulkUpdateFilesetTemplate
            InitMutationBulkUpdateFilesetTemplate();
        }

        // This parameter set invokes a single graphql operation:
        // filesetRecoverFiles.
        internal void ProcessRecord_RecoverFiles()
        {
            this._logger.name += " -RecoverFiles";
            // Create new graphql operation filesetRecoverFiles
            InitMutationFilesetRecoverFiles();
        }


        // Create new GraphQL Mutation:
        // bulkCreateFilesets(input: BulkCreateFilesetsInput!): BulkCreateFilesetsReply!
        internal void InitMutationBulkCreateFilesets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkCreateFilesetsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkCreateFilesets",
                "($input: BulkCreateFilesetsInput!)",
                "BulkCreateFilesetsReply",
                Mutation.BulkCreateFilesets,
                Mutation.BulkCreateFilesetsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	definitions = @(
		@{
			# OPTIONAL
			hostId = $someString
			# OPTIONAL
			isPassthrough = $someBoolean
			# OPTIONAL
			shareId = $someString
			# OPTIONAL
			enableHardlinkSupport = $someBoolean
			# OPTIONAL
			enableSymlinkResolution = $someBoolean
			# OPTIONAL
			failoverClusterAppId = $someString
			# OPTIONAL
			snapMirrorLabelForFullBackup = $someString
			# OPTIONAL
			snapMirrorLabelForIncrementalBackup = $someString
			# OPTIONAL
			isManagedByPolaris = $someBoolean
			# OPTIONAL
			isPolarisNasModel = $someBoolean
			# OPTIONAL
			arraySpec = @{
				# OPTIONAL
				proxyHostId = $someString
			}
			# REQUIRED
			templateId = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkCreateFilesetTemplates(input: BulkCreateFilesetTemplatesInput!): BulkCreateFilesetTemplatesReply!
        internal void InitMutationBulkCreateFilesetTemplates()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkCreateFilesetTemplatesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkCreateFilesetTemplates",
                "($input: BulkCreateFilesetTemplatesInput!)",
                "BulkCreateFilesetTemplatesReply",
                Mutation.BulkCreateFilesetTemplates,
                Mutation.BulkCreateFilesetTemplatesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	definitions = @(
		@{
			# OPTIONAL
			backupScriptErrorHandling = $someString
			# OPTIONAL
			backupScriptTimeout = $someInt64
			# OPTIONAL
			exceptions = @(
				$someString
			)
			# OPTIONAL
			excludes = @(
				$someString
			)
			# OPTIONAL
			isArrayEnabled = $someBoolean
			# OPTIONAL
			postBackupScript = $someString
			# OPTIONAL
			preBackupScript = $someString
			# OPTIONAL
			isCreatedByKupr = $someBoolean
			# OPTIONAL
			isCreatedByPolarisNas = $someBoolean
			# OPTIONAL
			operatingSystemType = $someFilesetTemplateCreateOperatingSystemType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplateCreateOperatingSystemType]) for enum values.
			# OPTIONAL
			shareType = $someFilesetTemplateCreateShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplateCreateShareType]) for enum values.
			# OPTIONAL
			filesetOptions = @{
				# OPTIONAL
				allowBackupHiddenFoldersInNetworkMounts = $someBoolean
				# OPTIONAL
				allowBackupNetworkMounts = $someBoolean
				# OPTIONAL
				useWindowsVss = $someBoolean
			}
			# REQUIRED
			includes = @(
				$someString
			)
			# REQUIRED
			name = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkDeleteFileset(input: BulkDeleteFilesetInput!): ResponseSuccess!
        internal void InitMutationBulkDeleteFileset()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteFilesetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteFileset",
                "($input: BulkDeleteFilesetInput!)",
                "ResponseSuccess",
                Mutation.BulkDeleteFileset,
                Mutation.BulkDeleteFilesetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	preserveSnapshots = $someBoolean
	# REQUIRED
	ids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkDeleteFilesetTemplate(input: BulkDeleteFilesetTemplateInput!): ResponseSuccess!
        internal void InitMutationBulkDeleteFilesetTemplate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteFilesetTemplateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteFilesetTemplate",
                "($input: BulkDeleteFilesetTemplateInput!)",
                "ResponseSuccess",
                Mutation.BulkDeleteFilesetTemplate,
                Mutation.BulkDeleteFilesetTemplateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	preserveSnapshots = $someBoolean
	# REQUIRED
	ids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkUpdateFilesetTemplate(input: BulkUpdateFilesetTemplateInput!): BulkUpdateFilesetTemplateReply!
        internal void InitMutationBulkUpdateFilesetTemplate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateFilesetTemplateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateFilesetTemplate",
                "($input: BulkUpdateFilesetTemplateInput!)",
                "BulkUpdateFilesetTemplateReply",
                Mutation.BulkUpdateFilesetTemplate,
                Mutation.BulkUpdateFilesetTemplateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	definitions = @(
		@{
			# OPTIONAL
			backupScriptErrorHandling = $someString
			# OPTIONAL
			backupScriptTimeout = $someInt64
			# OPTIONAL
			exceptions = @(
				$someString
			)
			# OPTIONAL
			excludes = @(
				$someString
			)
			# OPTIONAL
			includes = @(
				$someString
			)
			# OPTIONAL
			name = $someString
			# OPTIONAL
			postBackupScript = $someString
			# OPTIONAL
			preBackupScript = $someString
			# OPTIONAL
			isCreatedByKupr = $someBoolean
			# OPTIONAL
			isCreatedByPolarisNas = $someBoolean
			# OPTIONAL
			operatingSystemType = $someFilesetTemplatePatchOperatingSystemType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplatePatchOperatingSystemType]) for enum values.
			# OPTIONAL
			shareType = $someFilesetTemplatePatchShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplatePatchShareType]) for enum values.
			# OPTIONAL
			filesetOptions = @{
				# OPTIONAL
				allowBackupHiddenFoldersInNetworkMounts = $someBoolean
				# OPTIONAL
				allowBackupNetworkMounts = $someBoolean
				# OPTIONAL
				useWindowsVss = $someBoolean
			}
			# REQUIRED
			id = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // filesetRecoverFiles(input: FilesetRecoverFilesInput!): AsyncRequestStatus!
        internal void InitMutationFilesetRecoverFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "FilesetRecoverFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationFilesetRecoverFiles",
                "($input: FilesetRecoverFilesInput!)",
                "AsyncRequestStatus",
                Mutation.FilesetRecoverFiles,
                Mutation.FilesetRecoverFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotFid = $someString
	# OPTIONAL
	nextSnapshotFid = $someString
	# REQUIRED
	restorePathPairList = @(
		@{
			# OPTIONAL
			path = $someString
			# OPTIONAL
			restorePath = $someString
		}
	)
	# OPTIONAL
	deltaTypeFilter = @(
		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
	)
	# REQUIRED
	config = @{
		# OPTIONAL
		ignoreErrors = $someBoolean
		# OPTIONAL
		excludePaths = @(
			$someString
		)
		# OPTIONAL
		shouldRecreateDirectoryStructure = $someBoolean
		# REQUIRED
		restoreConfig = @(
			@{
				# OPTIONAL
				restorePathPair = @{
					# OPTIONAL
					restorePath = $someString
					# REQUIRED
					path = $someString
				}
			}
		)
	}
	# REQUIRED
	shareType = $someShareTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ShareTypeEnum]) for enum values.
	# REQUIRED
	osType = $someGuestOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GuestOsType]) for enum values.
}"
            );
        }


    } // class New_RscMutationFileset
}