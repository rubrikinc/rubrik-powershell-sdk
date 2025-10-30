// New-RscMutationSapHana.cs
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
    /// Create a new RscQuery object for any of the 15
    /// operations in the 'SAP HANA' API domain:
    /// AddSystem, BulkRecoverDatabases, ConfigureRestore, CreateOnDemandBackup, CreateOnDemandDataBackup, CreateOnDemandStorageSnapshot, CreateSystemRefresh, DeleteDbSnapshot, DeleteSystem, ExpireDownloadedSnapshots, PatchSystem, RecoverDatabaseToFullBackup, RecoverDatabaseToPointInTime, RestoreSystemStorage, or UnconfigureRestore.
    /// </summary>
    /// <description>
    /// New-RscMutationSapHana creates a new
    /// mutation object for operations
    /// in the 'SAP HANA' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 15 operations
    /// in the 'SAP HANA' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddSystem, BulkRecoverDatabases, ConfigureRestore, CreateOnDemandBackup, CreateOnDemandDataBackup, CreateOnDemandStorageSnapshot, CreateSystemRefresh, DeleteDbSnapshot, DeleteSystem, ExpireDownloadedSnapshots, PatchSystem, RecoverDatabaseToFullBackup, RecoverDatabaseToPointInTime, RestoreSystemStorage, or UnconfigureRestore.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationSapHana -AddSystem).Info().
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
    /// (New-RscMutationSapHana -AddSystem).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddSystem operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: AddSystem
    /// 
    /// $query = New-RscMutationSapHana -Operation AddSystem
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sapHanaSystem = @{
    /// 		# REQUIRED
    /// 		hostIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		instanceNumber = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 		# REQUIRED
    /// 		sid = $someString
    /// 		# REQUIRED
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		dataPathSpec = @{
    /// 			# OPTIONAL
    /// 			dataPathType = $someSapHanaDataPathType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaDataPathType]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		sslInfo = @{
    /// 			# REQUIRED
    /// 			encryptionProvider = $someSapHanaSslInfoEncryptionProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaSslInfoEncryptionProvider]) for enum values.
    /// 			# REQUIRED
    /// 			keyStorePath = $someString
    /// 			# OPTIONAL
    /// 			cryptoLibPath = $someString
    /// 			# OPTIONAL
    /// 			hostNameInCertificate = $someString
    /// 			# OPTIONAL
    /// 			shouldEncrypt = $someBoolean
    /// 			# OPTIONAL
    /// 			shouldValidateCertificate = $someBoolean
    /// 			# OPTIONAL
    /// 			trustStorePath = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		backupTriggerType = $someSapHanaSystemConfigBackupTriggerType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaSystemConfigBackupTriggerType]) for enum values.
    /// 		# OPTIONAL
    /// 		authTypeSpec = @{
    /// 			# REQUIRED
    /// 			authType = $someSapHanaSystemAuthTypeSpecAuthType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaSystemAuthTypeSpecAuthType]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		azureFeatureId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddSapHanaSystemReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkRecoverDatabases operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: BulkRecoverDatabases
    /// 
    /// $query = New-RscMutationSapHana -Operation BulkRecoverDatabases
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		dbIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		sapHanaSystemCopyMap = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				sourceDbId = $someString
    /// 				# REQUIRED
    /// 				targetDbId = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		shouldInitializeLogArea = $someBoolean
    /// 		# OPTIONAL
    /// 		recoveryPoint = $someDateTime
    /// 		# REQUIRED
    /// 		isAfter = $someBoolean
    /// 	}
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
    /// <example>
    /// Runs the ConfigureRestore operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: ConfigureRestore
    /// 
    /// $query = New-RscMutationSapHana -Operation ConfigureRestore
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sourceConfig = @{
    /// 		# OPTIONAL
    /// 		snappableId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
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
    /// <example>
    /// Runs the CreateOnDemandBackup operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: CreateOnDemandBackup
    /// 
    /// $query = New-RscMutationSapHana -Operation CreateOnDemandBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
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
    /// <example>
    /// Runs the CreateOnDemandDataBackup operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: CreateOnDemandDataBackup
    /// 
    /// $query = New-RscMutationSapHana -Operation CreateOnDemandDataBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		baseOnDemandSnapshotConfig = @{
    /// 			# OPTIONAL
    /// 			slaId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		backupType = $someSapHanaOnDemandBackupConfigBackupType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaOnDemandBackupConfigBackupType]) for enum values.
    /// 	}
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
    /// <example>
    /// Runs the CreateOnDemandStorageSnapshot operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: CreateOnDemandStorageSnapshot
    /// 
    /// $query = New-RscMutationSapHana -Operation CreateOnDemandStorageSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
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
    /// <example>
    /// Runs the CreateSystemRefresh operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: CreateSystemRefresh
    /// 
    /// $query = New-RscMutationSapHana -Operation CreateSystemRefresh
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
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
    /// <example>
    /// Runs the DeleteDbSnapshot operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: DeleteDbSnapshot
    /// 
    /// $query = New-RscMutationSapHana -Operation DeleteDbSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
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
    /// Runs the DeleteSystem operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: DeleteSystem
    /// 
    /// $query = New-RscMutationSapHana -Operation DeleteSystem
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
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
    /// <example>
    /// Runs the ExpireDownloadedSnapshots operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: ExpireDownloadedSnapshots
    /// 
    /// $query = New-RscMutationSapHana -Operation ExpireDownloadedSnapshots
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	afterTime = $someDateTime
    /// 	# OPTIONAL
    /// 	beforeTime = $someDateTime
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	shouldExpireLogsOnly = $someBoolean
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
    /// <example>
    /// Runs the PatchSystem operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: PatchSystem
    /// 
    /// $query = New-RscMutationSapHana -Operation PatchSystem
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	updateProperties = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# OPTIONAL
    /// 		hostIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		instanceNumber = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		sid = $someString
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		sslInfo = @{
    /// 			# REQUIRED
    /// 			encryptionProvider = $someSapHanaSslInfoEncryptionProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaSslInfoEncryptionProvider]) for enum values.
    /// 			# REQUIRED
    /// 			keyStorePath = $someString
    /// 			# OPTIONAL
    /// 			cryptoLibPath = $someString
    /// 			# OPTIONAL
    /// 			hostNameInCertificate = $someString
    /// 			# OPTIONAL
    /// 			shouldEncrypt = $someBoolean
    /// 			# OPTIONAL
    /// 			shouldValidateCertificate = $someBoolean
    /// 			# OPTIONAL
    /// 			trustStorePath = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		backupTriggerType = $someSapHanaSystemPatchBackupTriggerType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaSystemPatchBackupTriggerType]) for enum values.
    /// 		# OPTIONAL
    /// 		authTypeSpec = @{
    /// 			# REQUIRED
    /// 			authType = $someSapHanaSystemAuthTypeSpecAuthType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaSystemAuthTypeSpecAuthType]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		azureFeatureId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PatchSapHanaSystemReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverDatabaseToFullBackup operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: RecoverDatabaseToFullBackup
    /// 
    /// $query = New-RscMutationSapHana -Operation RecoverDatabaseToFullBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		remoteLocationId = $someString
    /// 		# OPTIONAL
    /// 		sourceDbConfig = @{
    /// 			# OPTIONAL
    /// 			snappableId = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		dbId = $someString
    /// 		# REQUIRED
    /// 		fullSnapshotId = $someString
    /// 	}
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
    /// <example>
    /// Runs the RecoverDatabaseToPointInTime operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: RecoverDatabaseToPointInTime
    /// 
    /// $query = New-RscMutationSapHana -Operation RecoverDatabaseToPointInTime
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		sourceDbConfig = @{
    /// 			# OPTIONAL
    /// 			snappableId = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		shouldInitializeLogArea = $someBoolean
    /// 		# OPTIONAL
    /// 		recoveryPoint = $someDateTime
    /// 		# REQUIRED
    /// 		dbId = $someString
    /// 	}
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
    /// <example>
    /// Runs the RestoreSystemStorage operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: RestoreSystemStorage
    /// 
    /// $query = New-RscMutationSapHana -Operation RestoreSystemStorage
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		snapshotId = $someString
    /// 	}
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
    /// <example>
    /// Runs the UnconfigureRestore operation
    /// of the 'SAP HANA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    SapHana
    /// # API Operation: UnconfigureRestore
    /// 
    /// $query = New-RscMutationSapHana -Operation UnconfigureRestore
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
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
        "RscMutationSapHana",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationSapHana : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddSystem",
                "BulkRecoverDatabases",
                "ConfigureRestore",
                "CreateOnDemandBackup",
                "CreateOnDemandDataBackup",
                "CreateOnDemandStorageSnapshot",
                "CreateSystemRefresh",
                "DeleteDbSnapshot",
                "DeleteSystem",
                "ExpireDownloadedSnapshots",
                "PatchSystem",
                "RecoverDatabaseToFullBackup",
                "RecoverDatabaseToPointInTime",
                "RestoreSystemStorage",
                "UnconfigureRestore",
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
                    case "AddSystem":
                        this.ProcessRecord_AddSystem();
                        break;
                    case "BulkRecoverDatabases":
                        this.ProcessRecord_BulkRecoverDatabases();
                        break;
                    case "ConfigureRestore":
                        this.ProcessRecord_ConfigureRestore();
                        break;
                    case "CreateOnDemandBackup":
                        this.ProcessRecord_CreateOnDemandBackup();
                        break;
                    case "CreateOnDemandDataBackup":
                        this.ProcessRecord_CreateOnDemandDataBackup();
                        break;
                    case "CreateOnDemandStorageSnapshot":
                        this.ProcessRecord_CreateOnDemandStorageSnapshot();
                        break;
                    case "CreateSystemRefresh":
                        this.ProcessRecord_CreateSystemRefresh();
                        break;
                    case "DeleteDbSnapshot":
                        this.ProcessRecord_DeleteDbSnapshot();
                        break;
                    case "DeleteSystem":
                        this.ProcessRecord_DeleteSystem();
                        break;
                    case "ExpireDownloadedSnapshots":
                        this.ProcessRecord_ExpireDownloadedSnapshots();
                        break;
                    case "PatchSystem":
                        this.ProcessRecord_PatchSystem();
                        break;
                    case "RecoverDatabaseToFullBackup":
                        this.ProcessRecord_RecoverDatabaseToFullBackup();
                        break;
                    case "RecoverDatabaseToPointInTime":
                        this.ProcessRecord_RecoverDatabaseToPointInTime();
                        break;
                    case "RestoreSystemStorage":
                        this.ProcessRecord_RestoreSystemStorage();
                        break;
                    case "UnconfigureRestore":
                        this.ProcessRecord_UnconfigureRestore();
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
        // addSapHanaSystem.
        internal void ProcessRecord_AddSystem()
        {
            this._logger.name += " -AddSystem";
            // Create new graphql operation addSapHanaSystem
            InitMutationAddSapHanaSystem();
        }

        // This parameter set invokes a single graphql operation:
        // bulkRecoverSapHanaDatabases.
        internal void ProcessRecord_BulkRecoverDatabases()
        {
            this._logger.name += " -BulkRecoverDatabases";
            // Create new graphql operation bulkRecoverSapHanaDatabases
            InitMutationBulkRecoverSapHanaDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // configureSapHanaRestore.
        internal void ProcessRecord_ConfigureRestore()
        {
            this._logger.name += " -ConfigureRestore";
            // Create new graphql operation configureSapHanaRestore
            InitMutationConfigureSapHanaRestore();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandSapHanaBackup.
        internal void ProcessRecord_CreateOnDemandBackup()
        {
            this._logger.name += " -CreateOnDemandBackup";
            // Create new graphql operation createOnDemandSapHanaBackup
            InitMutationCreateOnDemandSapHanaBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandSapHanaDataBackup.
        internal void ProcessRecord_CreateOnDemandDataBackup()
        {
            this._logger.name += " -CreateOnDemandDataBackup";
            // Create new graphql operation createOnDemandSapHanaDataBackup
            InitMutationCreateOnDemandSapHanaDataBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandSapHanaStorageSnapshot.
        internal void ProcessRecord_CreateOnDemandStorageSnapshot()
        {
            this._logger.name += " -CreateOnDemandStorageSnapshot";
            // Create new graphql operation createOnDemandSapHanaStorageSnapshot
            InitMutationCreateOnDemandSapHanaStorageSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // createSapHanaSystemRefresh.
        internal void ProcessRecord_CreateSystemRefresh()
        {
            this._logger.name += " -CreateSystemRefresh";
            // Create new graphql operation createSapHanaSystemRefresh
            InitMutationCreateSapHanaSystemRefresh();
        }

        // This parameter set invokes a single graphql operation:
        // deleteSapHanaDbSnapshot.
        internal void ProcessRecord_DeleteDbSnapshot()
        {
            this._logger.name += " -DeleteDbSnapshot";
            // Create new graphql operation deleteSapHanaDbSnapshot
            InitMutationDeleteSapHanaDbSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteSapHanaSystem.
        internal void ProcessRecord_DeleteSystem()
        {
            this._logger.name += " -DeleteSystem";
            // Create new graphql operation deleteSapHanaSystem
            InitMutationDeleteSapHanaSystem();
        }

        // This parameter set invokes a single graphql operation:
        // expireDownloadedSapHanaSnapshots.
        internal void ProcessRecord_ExpireDownloadedSnapshots()
        {
            this._logger.name += " -ExpireDownloadedSnapshots";
            // Create new graphql operation expireDownloadedSapHanaSnapshots
            InitMutationExpireDownloadedSapHanaSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // patchSapHanaSystem.
        internal void ProcessRecord_PatchSystem()
        {
            this._logger.name += " -PatchSystem";
            // Create new graphql operation patchSapHanaSystem
            InitMutationPatchSapHanaSystem();
        }

        // This parameter set invokes a single graphql operation:
        // recoverSapHanaDatabaseToFullBackup.
        internal void ProcessRecord_RecoverDatabaseToFullBackup()
        {
            this._logger.name += " -RecoverDatabaseToFullBackup";
            // Create new graphql operation recoverSapHanaDatabaseToFullBackup
            InitMutationRecoverSapHanaDatabaseToFullBackup();
        }

        // This parameter set invokes a single graphql operation:
        // recoverSapHanaDatabaseToPointInTime.
        internal void ProcessRecord_RecoverDatabaseToPointInTime()
        {
            this._logger.name += " -RecoverDatabaseToPointInTime";
            // Create new graphql operation recoverSapHanaDatabaseToPointInTime
            InitMutationRecoverSapHanaDatabaseToPointInTime();
        }

        // This parameter set invokes a single graphql operation:
        // restoreSapHanaSystemStorage.
        internal void ProcessRecord_RestoreSystemStorage()
        {
            this._logger.name += " -RestoreSystemStorage";
            // Create new graphql operation restoreSapHanaSystemStorage
            InitMutationRestoreSapHanaSystemStorage();
        }

        // This parameter set invokes a single graphql operation:
        // unconfigureSapHanaRestore.
        internal void ProcessRecord_UnconfigureRestore()
        {
            this._logger.name += " -UnconfigureRestore";
            // Create new graphql operation unconfigureSapHanaRestore
            InitMutationUnconfigureSapHanaRestore();
        }


        // Create new GraphQL Mutation:
        // addSapHanaSystem(input: AddSapHanaSystemInput!): AddSapHanaSystemReply!
        internal void InitMutationAddSapHanaSystem()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddSapHanaSystemInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddSapHanaSystem",
                "($input: AddSapHanaSystemInput!)",
                "AddSapHanaSystemReply",
                Mutation.AddSapHanaSystem,
                Mutation.AddSapHanaSystemFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sapHanaSystem = @{
		# REQUIRED
		hostIds = @(
			$someString
		)
		# REQUIRED
		instanceNumber = $someString
		# REQUIRED
		password = $someString
		# REQUIRED
		sid = $someString
		# REQUIRED
		username = $someString
		# OPTIONAL
		dataPathSpec = @{
			# OPTIONAL
			dataPathType = $someSapHanaDataPathType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaDataPathType]) for enum values.
		}
		# OPTIONAL
		sslInfo = @{
			# REQUIRED
			encryptionProvider = $someSapHanaSslInfoEncryptionProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaSslInfoEncryptionProvider]) for enum values.
			# REQUIRED
			keyStorePath = $someString
			# OPTIONAL
			cryptoLibPath = $someString
			# OPTIONAL
			hostNameInCertificate = $someString
			# OPTIONAL
			shouldEncrypt = $someBoolean
			# OPTIONAL
			shouldValidateCertificate = $someBoolean
			# OPTIONAL
			trustStorePath = $someString
		}
		# OPTIONAL
		backupTriggerType = $someSapHanaSystemConfigBackupTriggerType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaSystemConfigBackupTriggerType]) for enum values.
		# OPTIONAL
		authTypeSpec = @{
			# REQUIRED
			authType = $someSapHanaSystemAuthTypeSpecAuthType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaSystemAuthTypeSpecAuthType]) for enum values.
		}
		# OPTIONAL
		azureFeatureId = $someString
	}
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkRecoverSapHanaDatabases(input: BulkRecoverSapHanaDatabasesInput!): AsyncRequestStatus!
        internal void InitMutationBulkRecoverSapHanaDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkRecoverSapHanaDatabasesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkRecoverSapHanaDatabases",
                "($input: BulkRecoverSapHanaDatabasesInput!)",
                "AsyncRequestStatus",
                Mutation.BulkRecoverSapHanaDatabases,
                Mutation.BulkRecoverSapHanaDatabasesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		dbIds = @(
			$someString
		)
		# OPTIONAL
		sapHanaSystemCopyMap = @(
			@{
				# REQUIRED
				sourceDbId = $someString
				# REQUIRED
				targetDbId = $someString
			}
		)
		# REQUIRED
		shouldInitializeLogArea = $someBoolean
		# OPTIONAL
		recoveryPoint = $someDateTime
		# REQUIRED
		isAfter = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // configureSapHanaRestore(input: ConfigureSapHanaRestoreInput!): AsyncRequestStatus!
        internal void InitMutationConfigureSapHanaRestore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ConfigureSapHanaRestoreInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationConfigureSapHanaRestore",
                "($input: ConfigureSapHanaRestoreInput!)",
                "AsyncRequestStatus",
                Mutation.ConfigureSapHanaRestore,
                Mutation.ConfigureSapHanaRestoreFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sourceConfig = @{
		# OPTIONAL
		snappableId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOnDemandSapHanaBackup(input: CreateOnDemandSapHanaBackupInput!): AsyncRequestStatus!
        internal void InitMutationCreateOnDemandSapHanaBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandSapHanaBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandSapHanaBackup",
                "($input: CreateOnDemandSapHanaBackupInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOnDemandSapHanaBackup,
                Mutation.CreateOnDemandSapHanaBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOnDemandSapHanaDataBackup(input: CreateOnDemandSapHanaDataBackupInput!): AsyncRequestStatus!
        internal void InitMutationCreateOnDemandSapHanaDataBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandSapHanaDataBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandSapHanaDataBackup",
                "($input: CreateOnDemandSapHanaDataBackupInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOnDemandSapHanaDataBackup,
                Mutation.CreateOnDemandSapHanaDataBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	config = @{
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = $someString
		}
		# OPTIONAL
		backupType = $someSapHanaOnDemandBackupConfigBackupType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaOnDemandBackupConfigBackupType]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOnDemandSapHanaStorageSnapshot(input: CreateOnDemandSapHanaStorageSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationCreateOnDemandSapHanaStorageSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandSapHanaStorageSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandSapHanaStorageSnapshot",
                "($input: CreateOnDemandSapHanaStorageSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOnDemandSapHanaStorageSnapshot,
                Mutation.CreateOnDemandSapHanaStorageSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createSapHanaSystemRefresh(input: CreateSapHanaSystemRefreshInput!): AsyncRequestStatus!
        internal void InitMutationCreateSapHanaSystemRefresh()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateSapHanaSystemRefreshInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateSapHanaSystemRefresh",
                "($input: CreateSapHanaSystemRefreshInput!)",
                "AsyncRequestStatus",
                Mutation.CreateSapHanaSystemRefresh,
                Mutation.CreateSapHanaSystemRefreshFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteSapHanaDbSnapshot(input: DeleteSapHanaDbSnapshotInput!): ResponseSuccess!
        internal void InitMutationDeleteSapHanaDbSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteSapHanaDbSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteSapHanaDbSnapshot",
                "($input: DeleteSapHanaDbSnapshotInput!)",
                "ResponseSuccess",
                Mutation.DeleteSapHanaDbSnapshot,
                Mutation.DeleteSapHanaDbSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteSapHanaSystem(input: DeleteSapHanaSystemInput!): AsyncRequestStatus!
        internal void InitMutationDeleteSapHanaSystem()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteSapHanaSystemInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteSapHanaSystem",
                "($input: DeleteSapHanaSystemInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteSapHanaSystem,
                Mutation.DeleteSapHanaSystemFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // expireDownloadedSapHanaSnapshots(input: ExpireDownloadedSapHanaSnapshotsInput!): AsyncRequestStatus!
        internal void InitMutationExpireDownloadedSapHanaSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExpireDownloadedSapHanaSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExpireDownloadedSapHanaSnapshots",
                "($input: ExpireDownloadedSapHanaSnapshotsInput!)",
                "AsyncRequestStatus",
                Mutation.ExpireDownloadedSapHanaSnapshots,
                Mutation.ExpireDownloadedSapHanaSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	afterTime = $someDateTime
	# OPTIONAL
	beforeTime = $someDateTime
	# REQUIRED
	id = $someString
	# OPTIONAL
	shouldExpireLogsOnly = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // patchSapHanaSystem(input: PatchSapHanaSystemInput!): PatchSapHanaSystemReply!
        internal void InitMutationPatchSapHanaSystem()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchSapHanaSystemInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchSapHanaSystem",
                "($input: PatchSapHanaSystemInput!)",
                "PatchSapHanaSystemReply",
                Mutation.PatchSapHanaSystem,
                Mutation.PatchSapHanaSystemFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# OPTIONAL
		hostIds = @(
			$someString
		)
		# OPTIONAL
		instanceNumber = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		sid = $someString
		# OPTIONAL
		username = $someString
		# OPTIONAL
		sslInfo = @{
			# REQUIRED
			encryptionProvider = $someSapHanaSslInfoEncryptionProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaSslInfoEncryptionProvider]) for enum values.
			# REQUIRED
			keyStorePath = $someString
			# OPTIONAL
			cryptoLibPath = $someString
			# OPTIONAL
			hostNameInCertificate = $someString
			# OPTIONAL
			shouldEncrypt = $someBoolean
			# OPTIONAL
			shouldValidateCertificate = $someBoolean
			# OPTIONAL
			trustStorePath = $someString
		}
		# OPTIONAL
		backupTriggerType = $someSapHanaSystemPatchBackupTriggerType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaSystemPatchBackupTriggerType]) for enum values.
		# OPTIONAL
		authTypeSpec = @{
			# REQUIRED
			authType = $someSapHanaSystemAuthTypeSpecAuthType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SapHanaSystemAuthTypeSpecAuthType]) for enum values.
		}
		# OPTIONAL
		azureFeatureId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // recoverSapHanaDatabaseToFullBackup(input: RecoverSapHanaDatabaseToFullBackupInput!): AsyncRequestStatus!
        internal void InitMutationRecoverSapHanaDatabaseToFullBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverSapHanaDatabaseToFullBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverSapHanaDatabaseToFullBackup",
                "($input: RecoverSapHanaDatabaseToFullBackupInput!)",
                "AsyncRequestStatus",
                Mutation.RecoverSapHanaDatabaseToFullBackup,
                Mutation.RecoverSapHanaDatabaseToFullBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		remoteLocationId = $someString
		# OPTIONAL
		sourceDbConfig = @{
			# OPTIONAL
			snappableId = $someString
		}
		# REQUIRED
		dbId = $someString
		# REQUIRED
		fullSnapshotId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // recoverSapHanaDatabaseToPointInTime(input: RecoverSapHanaDatabaseToPointInTimeInput!): AsyncRequestStatus!
        internal void InitMutationRecoverSapHanaDatabaseToPointInTime()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverSapHanaDatabaseToPointInTimeInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverSapHanaDatabaseToPointInTime",
                "($input: RecoverSapHanaDatabaseToPointInTimeInput!)",
                "AsyncRequestStatus",
                Mutation.RecoverSapHanaDatabaseToPointInTime,
                Mutation.RecoverSapHanaDatabaseToPointInTimeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		sourceDbConfig = @{
			# OPTIONAL
			snappableId = $someString
		}
		# REQUIRED
		shouldInitializeLogArea = $someBoolean
		# OPTIONAL
		recoveryPoint = $someDateTime
		# REQUIRED
		dbId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreSapHanaSystemStorage(input: RestoreSapHanaSystemStorageInput!): AsyncRequestStatus!
        internal void InitMutationRestoreSapHanaSystemStorage()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreSapHanaSystemStorageInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreSapHanaSystemStorage",
                "($input: RestoreSapHanaSystemStorageInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreSapHanaSystemStorage,
                Mutation.RestoreSapHanaSystemStorageFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	config = @{
		# REQUIRED
		snapshotId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // unconfigureSapHanaRestore(input: UnconfigureSapHanaRestoreInput!): AsyncRequestStatus!
        internal void InitMutationUnconfigureSapHanaRestore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnconfigureSapHanaRestoreInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUnconfigureSapHanaRestore",
                "($input: UnconfigureSapHanaRestoreInput!)",
                "AsyncRequestStatus",
                Mutation.UnconfigureSapHanaRestore,
                Mutation.UnconfigureSapHanaRestoreFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscMutationSapHana
}