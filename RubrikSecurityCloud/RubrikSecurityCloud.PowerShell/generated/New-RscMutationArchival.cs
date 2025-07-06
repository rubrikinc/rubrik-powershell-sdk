// New-RscMutationArchival.cs
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
    /// Create a new RscQuery object for any of the 17
    /// operations in the 'Archival' API domain:
    /// CreateGlacierReaderTarget, CreateManualTargetMapping, CreateS3CompatibleReaderTarget, CreateS3CompatibleTarget, DeleteTarget, DeleteTargetMapping, DisableTarget, EnableTarget, FilesetDownloadSnapshotFilesFromLocation, PauseTarget, PromoteReaderTarget, RefreshReaderTarget, ResumeTarget, UpdateGlacierTarget, UpdateManualTargetMapping, UpdateS3CompatibleTarget, or UpgradeCdmManagedTarget.
    /// </summary>
    /// <description>
    /// New-RscMutationArchival creates a new
    /// mutation object for operations
    /// in the 'Archival' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 17 operations
    /// in the 'Archival' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CreateGlacierReaderTarget, CreateManualTargetMapping, CreateS3CompatibleReaderTarget, CreateS3CompatibleTarget, DeleteTarget, DeleteTargetMapping, DisableTarget, EnableTarget, FilesetDownloadSnapshotFilesFromLocation, PauseTarget, PromoteReaderTarget, RefreshReaderTarget, ResumeTarget, UpdateGlacierTarget, UpdateManualTargetMapping, UpdateS3CompatibleTarget, or UpgradeCdmManagedTarget.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationArchival -CreateGlacierReaderTarget).Info().
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
    /// (New-RscMutationArchival -CreateGlacierReaderTarget).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CreateGlacierReaderTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: CreateGlacierReaderTarget
    /// 
    /// $query = New-RscMutationArchival -Operation CreateGlacierReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	vaultName = $someString
    /// 	# REQUIRED
    /// 	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	encryptionPassword = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	retrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
    /// 	# REQUIRED
    /// 	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateManualTargetMapping operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: CreateManualTargetMapping
    /// 
    /// $query = New-RscMutationArchival -Operation CreateManualTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	type = $someTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TargetType]) for enum values.
    /// 	# OPTIONAL
    /// 	archivalLocationClusterMappings = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			locationId = $someString
    /// 			# OPTIONAL
    /// 			clusterUuid = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TargetMapping
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateS3CompatibleReaderTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: CreateS3CompatibleReaderTarget
    /// 
    /// $query = New-RscMutationArchival -Operation CreateS3CompatibleReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	accessKey = $someString
    /// 	# REQUIRED
    /// 	secretKey = $someString
    /// 	# REQUIRED
    /// 	endpoint = $someString
    /// 	# REQUIRED
    /// 	bucketPrefix = $someString
    /// 	# REQUIRED
    /// 	numberOfBuckets = $someInt
    /// 	# REQUIRED
    /// 	encryptionKeyInDer = $someString
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# REQUIRED
    /// 	useSystemProxy = $someBoolean
    /// 	# REQUIRED
    /// 	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
    /// 	# OPTIONAL
    /// 	subType = $someS3CompatibleSubType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.S3CompatibleSubType]) for enum values.
    /// 	# OPTIONAL
    /// 	encryptionPassword = $someString
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		bucketLockDurationDays = $someInt
    /// 		# OPTIONAL
    /// 		isObjectLockEnabled = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	ibmDetails = @{
    /// 		# OPTIONAL
    /// 		provisioningCode = $someString
    /// 		# OPTIONAL
    /// 		deploymentType = $someIbmDeploymentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IbmDeploymentType]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateS3CompatibleTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: CreateS3CompatibleTarget
    /// 
    /// $query = New-RscMutationArchival -Operation CreateS3CompatibleTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	accessKey = $someString
    /// 	# REQUIRED
    /// 	secretKey = $someString
    /// 	# REQUIRED
    /// 	endpoint = $someString
    /// 	# REQUIRED
    /// 	bucketPrefix = $someString
    /// 	# REQUIRED
    /// 	numberOfBuckets = $someInt
    /// 	# REQUIRED
    /// 	encryptionKeyInDer = $someString
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# REQUIRED
    /// 	useSystemProxy = $someBoolean
    /// 	# OPTIONAL
    /// 	subType = $someS3CompatibleSubType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.S3CompatibleSubType]) for enum values.
    /// 	# OPTIONAL
    /// 	encryptionPassword = $someString
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		bucketLockDurationDays = $someInt
    /// 		# OPTIONAL
    /// 		isObjectLockEnabled = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	ibmDetails = @{
    /// 		# OPTIONAL
    /// 		provisioningCode = $someString
    /// 		# OPTIONAL
    /// 		deploymentType = $someIbmDeploymentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IbmDeploymentType]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: DeleteTarget
    /// 
    /// $query = New-RscMutationArchival -Operation DeleteTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
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
    /// Runs the DeleteTargetMapping operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: DeleteTargetMapping
    /// 
    /// $query = New-RscMutationArchival -Operation DeleteTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
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
    /// Runs the DisableTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: DisableTarget
    /// 
    /// $query = New-RscMutationArchival -Operation DisableTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DisableTargetReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EnableTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: EnableTarget
    /// 
    /// $query = New-RscMutationArchival -Operation EnableTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: EnableTargetReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FilesetDownloadSnapshotFilesFromLocation operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: FilesetDownloadSnapshotFilesFromLocation
    /// 
    /// $query = New-RscMutationArchival -Operation FilesetDownloadSnapshotFilesFromLocation
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	nextSnapshotId = $someString
    /// 	# OPTIONAL
    /// 	userNote = $someString
    /// 	# OPTIONAL
    /// 	zipPassword = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		zipPassword = $someString
    /// 		# OPTIONAL
    /// 		legalHoldDownloadConfig = @{
    /// 			# REQUIRED
    /// 			isLegalHoldDownload = $someBoolean
    /// 		}
    /// 		# REQUIRED
    /// 		sourceDirs = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	deltaTypeFilter = @(
    /// 		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	locationId = $someString
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
    /// Runs the PauseTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: PauseTarget
    /// 
    /// $query = New-RscMutationArchival -Operation PauseTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PauseTargetReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PromoteReaderTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: PromoteReaderTarget
    /// 
    /// $query = New-RscMutationArchival -Operation PromoteReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	locationId = $someString
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
    /// Runs the RefreshReaderTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: RefreshReaderTarget
    /// 
    /// $query = New-RscMutationArchival -Operation RefreshReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	localDataSourceIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	archivalDataSourceIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	locationId = $someString
    /// 	# OPTIONAL
    /// 	externalLocationId = $someString
    /// 	# OPTIONAL
    /// 	clusterId = $someString
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
    /// Runs the ResumeTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: ResumeTarget
    /// 
    /// $query = New-RscMutationArchival -Operation ResumeTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResumeTargetReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateGlacierTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: UpdateGlacierTarget
    /// 
    /// $query = New-RscMutationArchival -Operation UpdateGlacierTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	retrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateManualTargetMapping operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: UpdateManualTargetMapping
    /// 
    /// $query = New-RscMutationArchival -Operation UpdateManualTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	archivalLocationClusterMappings = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			locationId = $someString
    /// 			# OPTIONAL
    /// 			clusterUuid = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TargetMapping
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateS3CompatibleTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: UpdateS3CompatibleTarget
    /// 
    /// $query = New-RscMutationArchival -Operation UpdateS3CompatibleTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	accessKey = $someString
    /// 	# OPTIONAL
    /// 	secretKey = $someString
    /// 	# OPTIONAL
    /// 	endpoint = $someString
    /// 	# OPTIONAL
    /// 	numberOfBuckets = $someInt
    /// 	# OPTIONAL
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	useSystemProxy = $someBoolean
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		bucketLockDurationDays = $someInt
    /// 		# OPTIONAL
    /// 		isObjectLockEnabled = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpgradeCdmManagedTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: UpgradeCdmManagedTarget
    /// 
    /// $query = New-RscMutationArchival -Operation UpgradeCdmManagedTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	fids = @(
    /// 		$someString
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationArchival",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationArchival : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CreateGlacierReaderTarget",
                "CreateManualTargetMapping",
                "CreateS3CompatibleReaderTarget",
                "CreateS3CompatibleTarget",
                "DeleteTarget",
                "DeleteTargetMapping",
                "DisableTarget",
                "EnableTarget",
                "FilesetDownloadSnapshotFilesFromLocation",
                "PauseTarget",
                "PromoteReaderTarget",
                "RefreshReaderTarget",
                "ResumeTarget",
                "UpdateGlacierTarget",
                "UpdateManualTargetMapping",
                "UpdateS3CompatibleTarget",
                "UpgradeCdmManagedTarget",
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
                    case "CreateGlacierReaderTarget":
                        this.ProcessRecord_CreateGlacierReaderTarget();
                        break;
                    case "CreateManualTargetMapping":
                        this.ProcessRecord_CreateManualTargetMapping();
                        break;
                    case "CreateS3CompatibleReaderTarget":
                        this.ProcessRecord_CreateS3CompatibleReaderTarget();
                        break;
                    case "CreateS3CompatibleTarget":
                        this.ProcessRecord_CreateS3CompatibleTarget();
                        break;
                    case "DeleteTarget":
                        this.ProcessRecord_DeleteTarget();
                        break;
                    case "DeleteTargetMapping":
                        this.ProcessRecord_DeleteTargetMapping();
                        break;
                    case "DisableTarget":
                        this.ProcessRecord_DisableTarget();
                        break;
                    case "EnableTarget":
                        this.ProcessRecord_EnableTarget();
                        break;
                    case "FilesetDownloadSnapshotFilesFromLocation":
                        this.ProcessRecord_FilesetDownloadSnapshotFilesFromLocation();
                        break;
                    case "PauseTarget":
                        this.ProcessRecord_PauseTarget();
                        break;
                    case "PromoteReaderTarget":
                        this.ProcessRecord_PromoteReaderTarget();
                        break;
                    case "RefreshReaderTarget":
                        this.ProcessRecord_RefreshReaderTarget();
                        break;
                    case "ResumeTarget":
                        this.ProcessRecord_ResumeTarget();
                        break;
                    case "UpdateGlacierTarget":
                        this.ProcessRecord_UpdateGlacierTarget();
                        break;
                    case "UpdateManualTargetMapping":
                        this.ProcessRecord_UpdateManualTargetMapping();
                        break;
                    case "UpdateS3CompatibleTarget":
                        this.ProcessRecord_UpdateS3CompatibleTarget();
                        break;
                    case "UpgradeCdmManagedTarget":
                        this.ProcessRecord_UpgradeCdmManagedTarget();
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
        // createGlacierReaderTarget.
        internal void ProcessRecord_CreateGlacierReaderTarget()
        {
            this._logger.name += " -CreateGlacierReaderTarget";
            // Create new graphql operation createGlacierReaderTarget
            InitMutationCreateGlacierReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createManualTargetMapping.
        internal void ProcessRecord_CreateManualTargetMapping()
        {
            this._logger.name += " -CreateManualTargetMapping";
            // Create new graphql operation createManualTargetMapping
            InitMutationCreateManualTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createS3CompatibleReaderTarget.
        internal void ProcessRecord_CreateS3CompatibleReaderTarget()
        {
            this._logger.name += " -CreateS3CompatibleReaderTarget";
            // Create new graphql operation createS3CompatibleReaderTarget
            InitMutationCreateS3CompatibleReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createS3CompatibleTarget.
        internal void ProcessRecord_CreateS3CompatibleTarget()
        {
            this._logger.name += " -CreateS3CompatibleTarget";
            // Create new graphql operation createS3CompatibleTarget
            InitMutationCreateS3CompatibleTarget();
        }

        // This parameter set invokes a single graphql operation:
        // deleteTarget.
        internal void ProcessRecord_DeleteTarget()
        {
            this._logger.name += " -DeleteTarget";
            // Create new graphql operation deleteTarget
            InitMutationDeleteTarget();
        }

        // This parameter set invokes a single graphql operation:
        // deleteTargetMapping.
        internal void ProcessRecord_DeleteTargetMapping()
        {
            this._logger.name += " -DeleteTargetMapping";
            // Create new graphql operation deleteTargetMapping
            InitMutationDeleteTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // disableTarget.
        internal void ProcessRecord_DisableTarget()
        {
            this._logger.name += " -DisableTarget";
            // Create new graphql operation disableTarget
            InitMutationDisableTarget();
        }

        // This parameter set invokes a single graphql operation:
        // enableTarget.
        internal void ProcessRecord_EnableTarget()
        {
            this._logger.name += " -EnableTarget";
            // Create new graphql operation enableTarget
            InitMutationEnableTarget();
        }

        // This parameter set invokes a single graphql operation:
        // filesetDownloadSnapshotFilesFromArchivalLocation.
        internal void ProcessRecord_FilesetDownloadSnapshotFilesFromLocation()
        {
            this._logger.name += " -FilesetDownloadSnapshotFilesFromLocation";
            // Create new graphql operation filesetDownloadSnapshotFilesFromArchivalLocation
            InitMutationFilesetDownloadSnapshotFilesFromArchivalLocation();
        }

        // This parameter set invokes a single graphql operation:
        // pauseTarget.
        internal void ProcessRecord_PauseTarget()
        {
            this._logger.name += " -PauseTarget";
            // Create new graphql operation pauseTarget
            InitMutationPauseTarget();
        }

        // This parameter set invokes a single graphql operation:
        // promoteReaderTarget.
        internal void ProcessRecord_PromoteReaderTarget()
        {
            this._logger.name += " -PromoteReaderTarget";
            // Create new graphql operation promoteReaderTarget
            InitMutationPromoteReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // refreshReaderTarget.
        internal void ProcessRecord_RefreshReaderTarget()
        {
            this._logger.name += " -RefreshReaderTarget";
            // Create new graphql operation refreshReaderTarget
            InitMutationRefreshReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // resumeTarget.
        internal void ProcessRecord_ResumeTarget()
        {
            this._logger.name += " -ResumeTarget";
            // Create new graphql operation resumeTarget
            InitMutationResumeTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateGlacierTarget.
        internal void ProcessRecord_UpdateGlacierTarget()
        {
            this._logger.name += " -UpdateGlacierTarget";
            // Create new graphql operation updateGlacierTarget
            InitMutationUpdateGlacierTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateManualTargetMapping.
        internal void ProcessRecord_UpdateManualTargetMapping()
        {
            this._logger.name += " -UpdateManualTargetMapping";
            // Create new graphql operation updateManualTargetMapping
            InitMutationUpdateManualTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateS3CompatibleTarget.
        internal void ProcessRecord_UpdateS3CompatibleTarget()
        {
            this._logger.name += " -UpdateS3CompatibleTarget";
            // Create new graphql operation updateS3CompatibleTarget
            InitMutationUpdateS3CompatibleTarget();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeCdmManagedTarget.
        internal void ProcessRecord_UpgradeCdmManagedTarget()
        {
            this._logger.name += " -UpgradeCdmManagedTarget";
            // Create new graphql operation upgradeCdmManagedTarget
            InitMutationUpgradeCdmManagedTarget();
        }


        // Create new GraphQL Mutation:
        // createGlacierReaderTarget(input: CreateGlacierReaderTargetInput!): Target!
        internal void InitMutationCreateGlacierReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateGlacierReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateGlacierReaderTarget",
                "($input: CreateGlacierReaderTargetInput!)",
                "Target",
                Mutation.CreateGlacierReaderTarget,
                Mutation.CreateGlacierReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	vaultName = $someString
	# REQUIRED
	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	encryptionPassword = $someString
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	retrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
	# REQUIRED
	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createManualTargetMapping(input: CreateManualTargetMappingInput!): TargetMapping!
        internal void InitMutationCreateManualTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateManualTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateManualTargetMapping",
                "($input: CreateManualTargetMappingInput!)",
                "TargetMapping",
                Mutation.CreateManualTargetMapping,
                Mutation.CreateManualTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	name = $someString
	# OPTIONAL
	type = $someTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TargetType]) for enum values.
	# OPTIONAL
	archivalLocationClusterMappings = @(
		@{
			# OPTIONAL
			locationId = $someString
			# OPTIONAL
			clusterUuid = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createS3CompatibleReaderTarget(input: CreateS3CompatibleReaderTargetInput!): Target!
        internal void InitMutationCreateS3CompatibleReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateS3CompatibleReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateS3CompatibleReaderTarget",
                "($input: CreateS3CompatibleReaderTargetInput!)",
                "Target",
                Mutation.CreateS3CompatibleReaderTarget,
                Mutation.CreateS3CompatibleReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	accessKey = $someString
	# REQUIRED
	secretKey = $someString
	# REQUIRED
	endpoint = $someString
	# REQUIRED
	bucketPrefix = $someString
	# REQUIRED
	numberOfBuckets = $someInt
	# REQUIRED
	encryptionKeyInDer = $someString
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# REQUIRED
	useSystemProxy = $someBoolean
	# REQUIRED
	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
	# OPTIONAL
	subType = $someS3CompatibleSubType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.S3CompatibleSubType]) for enum values.
	# OPTIONAL
	encryptionPassword = $someString
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		bucketLockDurationDays = $someInt
		# OPTIONAL
		isObjectLockEnabled = $someBoolean
	}
	# OPTIONAL
	ibmDetails = @{
		# OPTIONAL
		provisioningCode = $someString
		# OPTIONAL
		deploymentType = $someIbmDeploymentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IbmDeploymentType]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createS3CompatibleTarget(input: CreateS3CompatibleTargetInput!): Target!
        internal void InitMutationCreateS3CompatibleTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateS3CompatibleTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateS3CompatibleTarget",
                "($input: CreateS3CompatibleTargetInput!)",
                "Target",
                Mutation.CreateS3CompatibleTarget,
                Mutation.CreateS3CompatibleTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	accessKey = $someString
	# REQUIRED
	secretKey = $someString
	# REQUIRED
	endpoint = $someString
	# REQUIRED
	bucketPrefix = $someString
	# REQUIRED
	numberOfBuckets = $someInt
	# REQUIRED
	encryptionKeyInDer = $someString
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# REQUIRED
	useSystemProxy = $someBoolean
	# OPTIONAL
	subType = $someS3CompatibleSubType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.S3CompatibleSubType]) for enum values.
	# OPTIONAL
	encryptionPassword = $someString
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		bucketLockDurationDays = $someInt
		# OPTIONAL
		isObjectLockEnabled = $someBoolean
	}
	# OPTIONAL
	ibmDetails = @{
		# OPTIONAL
		provisioningCode = $someString
		# OPTIONAL
		deploymentType = $someIbmDeploymentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IbmDeploymentType]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteTarget(input: DeleteTargetInput!): Void
        internal void InitMutationDeleteTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteTarget",
                "($input: DeleteTargetInput!)",
                "System.String",
                Mutation.DeleteTarget,
                Mutation.DeleteTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteTargetMapping(input: DeleteTargetMappingInput!): Void
        internal void InitMutationDeleteTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteTargetMapping",
                "($input: DeleteTargetMappingInput!)",
                "System.String",
                Mutation.DeleteTargetMapping,
                Mutation.DeleteTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // disableTarget(input: DisableTargetInput!): DisableTargetReply!
        internal void InitMutationDisableTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DisableTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDisableTarget",
                "($input: DisableTargetInput!)",
                "DisableTargetReply",
                Mutation.DisableTarget,
                Mutation.DisableTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // enableTarget(input: EnableTargetInput!): EnableTargetReply!
        internal void InitMutationEnableTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableTarget",
                "($input: EnableTargetInput!)",
                "EnableTargetReply",
                Mutation.EnableTarget,
                Mutation.EnableTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // filesetDownloadSnapshotFilesFromArchivalLocation(input: FilesetDownloadSnapshotFilesFromArchivalLocationInput!): AsyncRequestStatus!
        internal void InitMutationFilesetDownloadSnapshotFilesFromArchivalLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "FilesetDownloadSnapshotFilesFromArchivalLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationFilesetDownloadSnapshotFilesFromArchivalLocation",
                "($input: FilesetDownloadSnapshotFilesFromArchivalLocationInput!)",
                "AsyncRequestStatus",
                Mutation.FilesetDownloadSnapshotFilesFromArchivalLocation,
                Mutation.FilesetDownloadSnapshotFilesFromArchivalLocationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	nextSnapshotId = $someString
	# OPTIONAL
	userNote = $someString
	# OPTIONAL
	zipPassword = $someString
	# REQUIRED
	config = @{
		# OPTIONAL
		zipPassword = $someString
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = $someBoolean
		}
		# REQUIRED
		sourceDirs = @(
			$someString
		)
	}
	# OPTIONAL
	deltaTypeFilter = @(
		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
	)
	# REQUIRED
	locationId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // pauseTarget(input: PauseTargetInput!): PauseTargetReply!
        internal void InitMutationPauseTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PauseTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPauseTarget",
                "($input: PauseTargetInput!)",
                "PauseTargetReply",
                Mutation.PauseTarget,
                Mutation.PauseTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // promoteReaderTarget(input: PromoteReaderTargetInput!): Void
        internal void InitMutationPromoteReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PromoteReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPromoteReaderTarget",
                "($input: PromoteReaderTargetInput!)",
                "System.String",
                Mutation.PromoteReaderTarget,
                Mutation.PromoteReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	locationId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshReaderTarget(input: RefreshReaderTargetInput!): Void
        internal void InitMutationRefreshReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshReaderTarget",
                "($input: RefreshReaderTargetInput!)",
                "System.String",
                Mutation.RefreshReaderTarget,
                Mutation.RefreshReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	localDataSourceIds = @(
		$someString
	)
	# OPTIONAL
	archivalDataSourceIds = @(
		$someString
	)
	# OPTIONAL
	locationId = $someString
	# OPTIONAL
	externalLocationId = $someString
	# OPTIONAL
	clusterId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // resumeTarget(input: ResumeTargetInput!): ResumeTargetReply!
        internal void InitMutationResumeTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ResumeTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationResumeTarget",
                "($input: ResumeTargetInput!)",
                "ResumeTargetReply",
                Mutation.ResumeTarget,
                Mutation.ResumeTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateGlacierTarget(input: UpdateGlacierTargetInput!): Target!
        internal void InitMutationUpdateGlacierTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateGlacierTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateGlacierTarget",
                "($input: UpdateGlacierTargetInput!)",
                "Target",
                Mutation.UpdateGlacierTarget,
                Mutation.UpdateGlacierTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	retrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
	# OPTIONAL
	cloudAccountId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateManualTargetMapping(input: UpdateManualTargetMappingInput!): TargetMapping!
        internal void InitMutationUpdateManualTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateManualTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateManualTargetMapping",
                "($input: UpdateManualTargetMappingInput!)",
                "TargetMapping",
                Mutation.UpdateManualTargetMapping,
                Mutation.UpdateManualTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	archivalLocationClusterMappings = @(
		@{
			# OPTIONAL
			locationId = $someString
			# OPTIONAL
			clusterUuid = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateS3CompatibleTarget(input: UpdateS3CompatibleTargetInput!): Target!
        internal void InitMutationUpdateS3CompatibleTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateS3CompatibleTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateS3CompatibleTarget",
                "($input: UpdateS3CompatibleTargetInput!)",
                "Target",
                Mutation.UpdateS3CompatibleTarget,
                Mutation.UpdateS3CompatibleTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	accessKey = $someString
	# OPTIONAL
	secretKey = $someString
	# OPTIONAL
	endpoint = $someString
	# OPTIONAL
	numberOfBuckets = $someInt
	# OPTIONAL
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	useSystemProxy = $someBoolean
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		bucketLockDurationDays = $someInt
		# OPTIONAL
		isObjectLockEnabled = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // upgradeCdmManagedTarget(input: UpgradeCdmManagedTargetInput!): Void
        internal void InitMutationUpgradeCdmManagedTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeCdmManagedTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeCdmManagedTarget",
                "($input: UpgradeCdmManagedTargetInput!)",
                "System.String",
                Mutation.UpgradeCdmManagedTarget,
                Mutation.UpgradeCdmManagedTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	fids = @(
		$someString
	)
}"
            );
        }


    } // class New_RscMutationArchival
}