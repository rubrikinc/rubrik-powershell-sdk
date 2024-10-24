// New-RscQueryOracle.cs
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
    /// operations in the 'Oracle' API domain:
    /// AcoExampleDownloadLink, AcoParameters, DataGuardGroup, Database, DatabaseAsyncRequestDetails, DatabaseLogBackupConfig, Databases, Host, HostLogBackupConfig, LiveMounts, MissedRecoverableRanges, MissedSnapshots, PdbDetails, Rac, RacLogBackupConfig, RecoverableRanges, or TopLevelDescendants.
    /// </summary>
    /// <description>
    /// New-RscQueryOracle creates a new
    /// query object for operations
    /// in the 'Oracle' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 17 operations
    /// in the 'Oracle' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AcoExampleDownloadLink, AcoParameters, DataGuardGroup, Database, DatabaseAsyncRequestDetails, DatabaseLogBackupConfig, Databases, Host, HostLogBackupConfig, LiveMounts, MissedRecoverableRanges, MissedSnapshots, PdbDetails, Rac, RacLogBackupConfig, RecoverableRanges, or TopLevelDescendants.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryOracle -AcoExampleDownloadLink).Info().
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
    /// (New-RscQueryOracle -AcoExampleDownloadLink).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AcoExampleDownloadLink operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: AcoExampleDownloadLink
    /// 
    /// $query = New-RscQueryOracle -Operation AcoExampleDownloadLink
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	dbId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OracleFileDownloadLink
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AcoParameters operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: AcoParameters
    /// 
    /// $query = New-RscQueryOracle -Operation AcoParameters
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	dbId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OracleAcoParameterList
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DataGuardGroup operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: DataGuardGroup
    /// 
    /// $query = New-RscQueryOracle -Operation DataGuardGroup
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OracleDataGuardGroup
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Database operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: Database
    /// 
    /// $query = New-RscQueryOracle -Operation Database
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OracleDatabase
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatabaseAsyncRequestDetails operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: DatabaseAsyncRequestDetails
    /// 
    /// $query = New-RscQueryOracle -Operation DatabaseAsyncRequestDetails
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
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
    /// Runs the DatabaseLogBackupConfig operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: DatabaseLogBackupConfig
    /// 
    /// $query = New-RscQueryOracle -Operation DatabaseLogBackupConfig
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
    /// Write-Host $result.GetType().Name # prints: OracleLogBackupConfig
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Databases operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: Databases
    /// 
    /// $query = New-RscQueryOracle -Operation Databases
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OracleDatabaseConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Host operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: Host
    /// 
    /// $query = New-RscQueryOracle -Operation Host
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OracleHost
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HostLogBackupConfig operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: HostLogBackupConfig
    /// 
    /// $query = New-RscQueryOracle -Operation HostLogBackupConfig
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
    /// Write-Host $result.GetType().Name # prints: OracleLogBackupConfig
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LiveMounts operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: LiveMounts
    /// 
    /// $query = New-RscQueryOracle -Operation LiveMounts
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someOracleLiveMountFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OracleLiveMountFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someOracleLiveMountSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OracleLiveMountSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OracleLiveMountConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MissedRecoverableRanges operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: MissedRecoverableRanges
    /// 
    /// $query = New-RscQueryOracle -Operation MissedRecoverableRanges
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	afterTime = $someDateTime
    /// 	# OPTIONAL
    /// 	beforeTime = $someDateTime
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OracleMissedRecoverableRangeListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MissedSnapshots operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: MissedSnapshots
    /// 
    /// $query = New-RscQueryOracle -Operation MissedSnapshots
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	afterTime = $someDateTime
    /// 	# OPTIONAL
    /// 	beforeTime = $someDateTime
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MissedSnapshotListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PdbDetails operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: PdbDetails
    /// 
    /// $query = New-RscQueryOracle -Operation PdbDetails
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	pdbDetailsRequest = @{
    /// 		# REQUIRED
    /// 		recoveryPoint = @{
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
    /// 			# OPTIONAL
    /// 			scn = $someInt64
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OraclePdbDetails
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Rac operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: Rac
    /// 
    /// $query = New-RscQueryOracle -Operation Rac
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OracleRac
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RacLogBackupConfig operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: RacLogBackupConfig
    /// 
    /// $query = New-RscQueryOracle -Operation RacLogBackupConfig
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
    /// Write-Host $result.GetType().Name # prints: OracleLogBackupConfig
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverableRanges operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: RecoverableRanges
    /// 
    /// $query = New-RscQueryOracle -Operation RecoverableRanges
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	afterTime = $someDateTime
    /// 	# OPTIONAL
    /// 	beforeTime = $someDateTime
    /// 	# OPTIONAL
    /// 	shouldIncludeDbSnapshotSummaries = $someBoolean
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OracleRecoverableRangeListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TopLevelDescendants operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: TopLevelDescendants
    /// 
    /// $query = New-RscQueryOracle -Operation TopLevelDescendants
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.typeFilter = @(
    /// 	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OracleTopLevelDescendantTypeConnection
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
        "RscQueryOracle",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryOracle : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AcoExampleDownloadLink",
                "AcoParameters",
                "DataGuardGroup",
                "Database",
                "DatabaseAsyncRequestDetails",
                "DatabaseLogBackupConfig",
                "Databases",
                "Host",
                "HostLogBackupConfig",
                "LiveMounts",
                "MissedRecoverableRanges",
                "MissedSnapshots",
                "PdbDetails",
                "Rac",
                "RacLogBackupConfig",
                "RecoverableRanges",
                "TopLevelDescendants",
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
                    case "AcoExampleDownloadLink":
                        this.ProcessRecord_AcoExampleDownloadLink();
                        break;
                    case "AcoParameters":
                        this.ProcessRecord_AcoParameters();
                        break;
                    case "DataGuardGroup":
                        this.ProcessRecord_DataGuardGroup();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "DatabaseAsyncRequestDetails":
                        this.ProcessRecord_DatabaseAsyncRequestDetails();
                        break;
                    case "DatabaseLogBackupConfig":
                        this.ProcessRecord_DatabaseLogBackupConfig();
                        break;
                    case "Databases":
                        this.ProcessRecord_Databases();
                        break;
                    case "Host":
                        this.ProcessRecord_Host();
                        break;
                    case "HostLogBackupConfig":
                        this.ProcessRecord_HostLogBackupConfig();
                        break;
                    case "LiveMounts":
                        this.ProcessRecord_LiveMounts();
                        break;
                    case "MissedRecoverableRanges":
                        this.ProcessRecord_MissedRecoverableRanges();
                        break;
                    case "MissedSnapshots":
                        this.ProcessRecord_MissedSnapshots();
                        break;
                    case "PdbDetails":
                        this.ProcessRecord_PdbDetails();
                        break;
                    case "Rac":
                        this.ProcessRecord_Rac();
                        break;
                    case "RacLogBackupConfig":
                        this.ProcessRecord_RacLogBackupConfig();
                        break;
                    case "RecoverableRanges":
                        this.ProcessRecord_RecoverableRanges();
                        break;
                    case "TopLevelDescendants":
                        this.ProcessRecord_TopLevelDescendants();
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
        // oracleAcoExampleDownloadLink.
        internal void ProcessRecord_AcoExampleDownloadLink()
        {
            this._logger.name += " -AcoExampleDownloadLink";
            // Create new graphql operation oracleAcoExampleDownloadLink
            InitQueryOracleAcoExampleDownloadLink();
        }

        // This parameter set invokes a single graphql operation:
        // oracleAcoParameters.
        internal void ProcessRecord_AcoParameters()
        {
            this._logger.name += " -AcoParameters";
            // Create new graphql operation oracleAcoParameters
            InitQueryOracleAcoParameters();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDataGuardGroup.
        internal void ProcessRecord_DataGuardGroup()
        {
            this._logger.name += " -DataGuardGroup";
            // Create new graphql operation oracleDataGuardGroup
            InitQueryOracleDataGuardGroup();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDatabase.
        internal void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Create new graphql operation oracleDatabase
            InitQueryOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDatabaseAsyncRequestDetails.
        internal void ProcessRecord_DatabaseAsyncRequestDetails()
        {
            this._logger.name += " -DatabaseAsyncRequestDetails";
            // Create new graphql operation oracleDatabaseAsyncRequestDetails
            InitQueryOracleDatabaseAsyncRequestDetails();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDatabaseLogBackupConfig.
        internal void ProcessRecord_DatabaseLogBackupConfig()
        {
            this._logger.name += " -DatabaseLogBackupConfig";
            // Create new graphql operation oracleDatabaseLogBackupConfig
            InitQueryOracleDatabaseLogBackupConfig();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDatabases.
        internal void ProcessRecord_Databases()
        {
            this._logger.name += " -Databases";
            // Create new graphql operation oracleDatabases
            InitQueryOracleDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // oracleHost.
        internal void ProcessRecord_Host()
        {
            this._logger.name += " -Host";
            // Create new graphql operation oracleHost
            InitQueryOracleHost();
        }

        // This parameter set invokes a single graphql operation:
        // oracleHostLogBackupConfig.
        internal void ProcessRecord_HostLogBackupConfig()
        {
            this._logger.name += " -HostLogBackupConfig";
            // Create new graphql operation oracleHostLogBackupConfig
            InitQueryOracleHostLogBackupConfig();
        }

        // This parameter set invokes a single graphql operation:
        // oracleLiveMounts.
        internal void ProcessRecord_LiveMounts()
        {
            this._logger.name += " -LiveMounts";
            // Create new graphql operation oracleLiveMounts
            InitQueryOracleLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // oracleMissedRecoverableRanges.
        internal void ProcessRecord_MissedRecoverableRanges()
        {
            this._logger.name += " -MissedRecoverableRanges";
            // Create new graphql operation oracleMissedRecoverableRanges
            InitQueryOracleMissedRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // oracleMissedSnapshots.
        internal void ProcessRecord_MissedSnapshots()
        {
            this._logger.name += " -MissedSnapshots";
            // Create new graphql operation oracleMissedSnapshots
            InitQueryOracleMissedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // oraclePdbDetails.
        internal void ProcessRecord_PdbDetails()
        {
            this._logger.name += " -PdbDetails";
            // Create new graphql operation oraclePdbDetails
            InitQueryOraclePdbDetails();
        }

        // This parameter set invokes a single graphql operation:
        // oracleRac.
        internal void ProcessRecord_Rac()
        {
            this._logger.name += " -Rac";
            // Create new graphql operation oracleRac
            InitQueryOracleRac();
        }

        // This parameter set invokes a single graphql operation:
        // oracleRacLogBackupConfig.
        internal void ProcessRecord_RacLogBackupConfig()
        {
            this._logger.name += " -RacLogBackupConfig";
            // Create new graphql operation oracleRacLogBackupConfig
            InitQueryOracleRacLogBackupConfig();
        }

        // This parameter set invokes a single graphql operation:
        // oracleRecoverableRanges.
        internal void ProcessRecord_RecoverableRanges()
        {
            this._logger.name += " -RecoverableRanges";
            // Create new graphql operation oracleRecoverableRanges
            InitQueryOracleRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // oracleTopLevelDescendants.
        internal void ProcessRecord_TopLevelDescendants()
        {
            this._logger.name += " -TopLevelDescendants";
            // Create new graphql operation oracleTopLevelDescendants
            InitQueryOracleTopLevelDescendants();
        }


        // Create new GraphQL Query:
        // oracleAcoExampleDownloadLink(input: ClusterUuidWithDbIdInput!): OracleFileDownloadLink!
        internal void InitQueryOracleAcoExampleDownloadLink()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterUuidWithDbIdInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleAcoExampleDownloadLink",
                "($input: ClusterUuidWithDbIdInput!)",
                "OracleFileDownloadLink",
                Query.OracleAcoExampleDownloadLink,
                Query.OracleAcoExampleDownloadLinkFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	dbId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // oracleAcoParameters(input: ClusterUuidWithDbIdInput!): OracleAcoParameterList!
        internal void InitQueryOracleAcoParameters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterUuidWithDbIdInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleAcoParameters",
                "($input: ClusterUuidWithDbIdInput!)",
                "OracleAcoParameterList",
                Query.OracleAcoParameters,
                Query.OracleAcoParametersFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	dbId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // oracleDataGuardGroup(fid: UUID!): OracleDataGuardGroup!
        internal void InitQueryOracleDataGuardGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleDataGuardGroup",
                "($fid: UUID!)",
                "OracleDataGuardGroup",
                Query.OracleDataGuardGroup,
                Query.OracleDataGuardGroupFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // oracleDatabase(fid: UUID!): OracleDatabase!
        internal void InitQueryOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleDatabase",
                "($fid: UUID!)",
                "OracleDatabase",
                Query.OracleDatabase,
                Query.OracleDatabaseFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // oracleDatabaseAsyncRequestDetails(input: GetOracleAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InitQueryOracleDatabaseAsyncRequestDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetOracleAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleDatabaseAsyncRequestDetails",
                "($input: GetOracleAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.OracleDatabaseAsyncRequestDetails,
                Query.OracleDatabaseAsyncRequestDetailsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // oracleDatabaseLogBackupConfig(input: OracleDbInput!): OracleLogBackupConfig!
        internal void InitQueryOracleDatabaseLogBackupConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleDbInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleDatabaseLogBackupConfig",
                "($input: OracleDbInput!)",
                "OracleLogBackupConfig",
                Query.OracleDatabaseLogBackupConfig,
                Query.OracleDatabaseLogBackupConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // oracleDatabases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): OracleDatabaseConnection!
        internal void InitQueryOracleDatabases()
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
                "QueryOracleDatabases",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "OracleDatabaseConnection",
                Query.OracleDatabases,
                Query.OracleDatabasesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // oracleHost(fid: UUID!): OracleHost!
        internal void InitQueryOracleHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleHost",
                "($fid: UUID!)",
                "OracleHost",
                Query.OracleHost,
                Query.OracleHostFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // oracleHostLogBackupConfig(input: OracleHostInput!): OracleLogBackupConfig!
        internal void InitQueryOracleHostLogBackupConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleHostInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleHostLogBackupConfig",
                "($input: OracleHostInput!)",
                "OracleLogBackupConfig",
                Query.OracleHostLogBackupConfig,
                Query.OracleHostLogBackupConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // oracleLiveMounts(
        //     first: Int
        //     after: String
        //     filters: [OracleLiveMountFilterInput!]
        //     sortBy: OracleLiveMountSortBy
        //   ): OracleLiveMountConnection!
        internal void InitQueryOracleLiveMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[OracleLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "OracleLiveMountSortBy"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleLiveMounts",
                "($first: Int,$after: String,$filters: [OracleLiveMountFilterInput!],$sortBy: OracleLiveMountSortBy)",
                "OracleLiveMountConnection",
                Query.OracleLiveMounts,
                Query.OracleLiveMountsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.filters = @(
	@{
		# OPTIONAL
		field = $someOracleLiveMountFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OracleLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someOracleLiveMountSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OracleLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // oracleMissedRecoverableRanges(input: GetOracleDbMissedRecoverableRangesInput!): OracleMissedRecoverableRangeListResponse!
        internal void InitQueryOracleMissedRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetOracleDbMissedRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleMissedRecoverableRanges",
                "($input: GetOracleDbMissedRecoverableRangesInput!)",
                "OracleMissedRecoverableRangeListResponse",
                Query.OracleMissedRecoverableRanges,
                Query.OracleMissedRecoverableRangesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	afterTime = $someDateTime
	# OPTIONAL
	beforeTime = $someDateTime
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // oracleMissedSnapshots(input: GetMissedOracleDbSnapshotsInput!): MissedSnapshotListResponse!
        internal void InitQueryOracleMissedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMissedOracleDbSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleMissedSnapshots",
                "($input: GetMissedOracleDbSnapshotsInput!)",
                "MissedSnapshotListResponse",
                Query.OracleMissedSnapshots,
                Query.OracleMissedSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	afterTime = $someDateTime
	# OPTIONAL
	beforeTime = $someDateTime
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // oraclePdbDetails(input: OraclePdbDetailsInput!): OraclePdbDetails!
        internal void InitQueryOraclePdbDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OraclePdbDetailsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOraclePdbDetails",
                "($input: OraclePdbDetailsInput!)",
                "OraclePdbDetails",
                Query.OraclePdbDetails,
                Query.OraclePdbDetailsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	pdbDetailsRequest = @{
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = $someString
			# OPTIONAL
			timestampMs = $someInt64
			# OPTIONAL
			scn = $someInt64
		}
	}
}"
            );
        }

        // Create new GraphQL Query:
        // oracleRac(fid: UUID!): OracleRac!
        internal void InitQueryOracleRac()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleRac",
                "($fid: UUID!)",
                "OracleRac",
                Query.OracleRac,
                Query.OracleRacFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // oracleRacLogBackupConfig(input: OracleRacInput!): OracleLogBackupConfig!
        internal void InitQueryOracleRacLogBackupConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleRacInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleRacLogBackupConfig",
                "($input: OracleRacInput!)",
                "OracleLogBackupConfig",
                Query.OracleRacLogBackupConfig,
                Query.OracleRacLogBackupConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // oracleRecoverableRanges(input: GetOracleDbRecoverableRangesInput!): OracleRecoverableRangeListResponse!
        internal void InitQueryOracleRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetOracleDbRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleRecoverableRanges",
                "($input: GetOracleDbRecoverableRangesInput!)",
                "OracleRecoverableRangeListResponse",
                Query.OracleRecoverableRanges,
                Query.OracleRecoverableRangesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	afterTime = $someDateTime
	# OPTIONAL
	beforeTime = $someDateTime
	# OPTIONAL
	shouldIncludeDbSnapshotSummaries = $someBoolean
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // oracleTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): OracleTopLevelDescendantTypeConnection!
        internal void InitQueryOracleTopLevelDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleTopLevelDescendants",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                "OracleTopLevelDescendantTypeConnection",
                Query.OracleTopLevelDescendants,
                Query.OracleTopLevelDescendantsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.typeFilter = @(
	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }


    } // class New_RscQueryOracle
}