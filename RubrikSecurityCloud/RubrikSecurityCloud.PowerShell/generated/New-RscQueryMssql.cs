// New-RscQueryMssql.cs
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
    /// operations in the 'Microsoft SQL Server' API domain:
    /// AvailabilityGroup, CdmLogShippingTarget, CdmLogShippingTargets, CompatibleInstances, Database, DatabaseLiveMounts, DatabaseMissedRecoverableRanges, DatabaseMissedSnapshots, DatabaseRestoreEstimate, DatabaseRestoreFiles, Databases, DefaultProperties, DefaultPropertiesOnCluster, Instance, LogShippingTargets, RecoverableRanges, or TopLevelDescendants.
    /// </summary>
    /// <description>
    /// New-RscQueryMssql creates a new
    /// query object for operations
    /// in the 'Microsoft SQL Server' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 17 operations
    /// in the 'Microsoft SQL Server' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AvailabilityGroup, CdmLogShippingTarget, CdmLogShippingTargets, CompatibleInstances, Database, DatabaseLiveMounts, DatabaseMissedRecoverableRanges, DatabaseMissedSnapshots, DatabaseRestoreEstimate, DatabaseRestoreFiles, Databases, DefaultProperties, DefaultPropertiesOnCluster, Instance, LogShippingTargets, RecoverableRanges, or TopLevelDescendants.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryMssql -AvailabilityGroup).Info().
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
    /// (New-RscQueryMssql -AvailabilityGroup).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AvailabilityGroup operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: AvailabilityGroup
    /// 
    /// $query = New-RscQueryMssql -AvailabilityGroup
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MssqlAvailabilityGroup
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CdmLogShippingTarget operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: CdmLogShippingTarget
    /// 
    /// $query = New-RscQueryMssql -CdmLogShippingTarget
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MssqlLogShippingTarget
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CdmLogShippingTargets operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: CdmLogShippingTargets
    /// 
    /// $query = New-RscQueryMssql -CdmLogShippingTargets
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someMssqlLogShippingTargetSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingTargetSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someMssqlLogShippingTargetFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MssqlLogShippingTargetConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CompatibleInstances operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: CompatibleInstances
    /// 
    /// $query = New-RscQueryMssql -CompatibleInstances
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	recoveryTime = $someDateTime
    /// 	# REQUIRED
    /// 	recoveryType = $someV1GetCompatibleMssqlInstancesV1RequestRecoveryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1GetCompatibleMssqlInstancesV1RequestRecoveryType]) for enum values.
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someMssqlCompatibleInstancesSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlCompatibleInstancesSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someMssqlCompatibleInstancesFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlCompatibleInstancesFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MssqlInstanceSummaryListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Database operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: Database
    /// 
    /// $query = New-RscQueryMssql -Database
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MssqlDatabase
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatabaseLiveMounts operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: DatabaseLiveMounts
    /// 
    /// $query = New-RscQueryMssql -DatabaseLiveMounts
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someMssqlDatabaseLiveMountSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseLiveMountSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someMssqlDatabaseLiveMountFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MssqlDatabaseLiveMountConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatabaseMissedRecoverableRanges operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: DatabaseMissedRecoverableRanges
    /// 
    /// $query = New-RscQueryMssql -DatabaseMissedRecoverableRanges
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
    /// Write-Host $result.GetType().Name # prints: MssqlMissedRecoverableRangeListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatabaseMissedSnapshots operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: DatabaseMissedSnapshots
    /// 
    /// $query = New-RscQueryMssql -DatabaseMissedSnapshots
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
    /// Runs the DatabaseRestoreEstimate operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: DatabaseRestoreEstimate
    /// 
    /// $query = New-RscQueryMssql -DatabaseRestoreEstimate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	lsn = $someString
    /// 	# OPTIONAL
    /// 	recoveryForkGuid = $someString
    /// 	# OPTIONAL
    /// 	time = $someDateTime
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MssqlRestoreEstimateResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatabaseRestoreFiles operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: DatabaseRestoreFiles
    /// 
    /// $query = New-RscQueryMssql -DatabaseRestoreFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	lsn = $someString
    /// 	# OPTIONAL
    /// 	recoveryForkGuid = $someString
    /// 	# OPTIONAL
    /// 	time = $someDateTime
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: V1MssqlGetRestoreFilesV1Response
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Databases operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: Databases
    /// 
    /// $query = New-RscQueryMssql -Databases
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
    /// Write-Host $result.GetType().Name # prints: MssqlDatabaseConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DefaultProperties operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: DefaultProperties
    /// 
    /// $query = New-RscQueryMssql -DefaultProperties
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateMssqlDefaultPropertiesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DefaultPropertiesOnCluster operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: DefaultPropertiesOnCluster
    /// 
    /// $query = New-RscQueryMssql -DefaultPropertiesOnCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	mssqlObjectId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MssqlDefaultPropertiesOnClusterReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Instance operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: Instance
    /// 
    /// $query = New-RscQueryMssql -Instance
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MssqlInstance
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LogShippingTargets operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: LogShippingTargets
    /// 
    /// $query = New-RscQueryMssql -LogShippingTargets
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	limit = $someInt
    /// 	# OPTIONAL
    /// 	location = $someString
    /// 	# OPTIONAL
    /// 	offset = $someInt
    /// 	# OPTIONAL
    /// 	primaryDatabaseId = $someString
    /// 	# OPTIONAL
    /// 	primaryDatabaseName = $someString
    /// 	# OPTIONAL
    /// 	secondaryDatabaseName = $someString
    /// 	# OPTIONAL
    /// 	sortBy = $someV2QueryLogShippingConfigurationsV2RequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestSortBy]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someV2QueryLogShippingConfigurationsV2RequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestSortOrder]) for enum values.
    /// 	# OPTIONAL
    /// 	status = $someV2QueryLogShippingConfigurationsV2RequestStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestStatus]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MssqlLogShippingSummaryV2ListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverableRanges operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: RecoverableRanges
    /// 
    /// $query = New-RscQueryMssql -RecoverableRanges
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
    /// Write-Host $result.GetType().Name # prints: MssqlRecoverableRangeListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TopLevelDescendants operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: TopLevelDescendants
    /// 
    /// $query = New-RscQueryMssql -TopLevelDescendants
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
    /// Write-Host $result.GetType().Name # prints: MssqlTopLevelDescendantTypeConnection
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
        "RscQueryMssql",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryMssql : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AvailabilityGroup",
                "CdmLogShippingTarget",
                "CdmLogShippingTargets",
                "CompatibleInstances",
                "Database",
                "DatabaseLiveMounts",
                "DatabaseMissedRecoverableRanges",
                "DatabaseMissedSnapshots",
                "DatabaseRestoreEstimate",
                "DatabaseRestoreFiles",
                "Databases",
                "DefaultProperties",
                "DefaultPropertiesOnCluster",
                "Instance",
                "LogShippingTargets",
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
                    case "AvailabilityGroup":
                        this.ProcessRecord_AvailabilityGroup();
                        break;
                    case "CdmLogShippingTarget":
                        this.ProcessRecord_CdmLogShippingTarget();
                        break;
                    case "CdmLogShippingTargets":
                        this.ProcessRecord_CdmLogShippingTargets();
                        break;
                    case "CompatibleInstances":
                        this.ProcessRecord_CompatibleInstances();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "DatabaseLiveMounts":
                        this.ProcessRecord_DatabaseLiveMounts();
                        break;
                    case "DatabaseMissedRecoverableRanges":
                        this.ProcessRecord_DatabaseMissedRecoverableRanges();
                        break;
                    case "DatabaseMissedSnapshots":
                        this.ProcessRecord_DatabaseMissedSnapshots();
                        break;
                    case "DatabaseRestoreEstimate":
                        this.ProcessRecord_DatabaseRestoreEstimate();
                        break;
                    case "DatabaseRestoreFiles":
                        this.ProcessRecord_DatabaseRestoreFiles();
                        break;
                    case "Databases":
                        this.ProcessRecord_Databases();
                        break;
                    case "DefaultProperties":
                        this.ProcessRecord_DefaultProperties();
                        break;
                    case "DefaultPropertiesOnCluster":
                        this.ProcessRecord_DefaultPropertiesOnCluster();
                        break;
                    case "Instance":
                        this.ProcessRecord_Instance();
                        break;
                    case "LogShippingTargets":
                        this.ProcessRecord_LogShippingTargets();
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
        // mssqlAvailabilityGroup.
        internal void ProcessRecord_AvailabilityGroup()
        {
            this._logger.name += " -AvailabilityGroup";
            // Create new graphql operation mssqlAvailabilityGroup
            InitQueryMssqlAvailabilityGroup();
        }

        // This parameter set invokes a single graphql operation:
        // cdmMssqlLogShippingTarget.
        internal void ProcessRecord_CdmLogShippingTarget()
        {
            this._logger.name += " -CdmLogShippingTarget";
            // Create new graphql operation cdmMssqlLogShippingTarget
            InitQueryCdmMssqlLogShippingTarget();
        }

        // This parameter set invokes a single graphql operation:
        // cdmMssqlLogShippingTargets.
        internal void ProcessRecord_CdmLogShippingTargets()
        {
            this._logger.name += " -CdmLogShippingTargets";
            // Create new graphql operation cdmMssqlLogShippingTargets
            InitQueryCdmMssqlLogShippingTargets();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlCompatibleInstances.
        internal void ProcessRecord_CompatibleInstances()
        {
            this._logger.name += " -CompatibleInstances";
            // Create new graphql operation mssqlCompatibleInstances
            InitQueryMssqlCompatibleInstances();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabase.
        internal void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Create new graphql operation mssqlDatabase
            InitQueryMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseLiveMounts.
        internal void ProcessRecord_DatabaseLiveMounts()
        {
            this._logger.name += " -DatabaseLiveMounts";
            // Create new graphql operation mssqlDatabaseLiveMounts
            InitQueryMssqlDatabaseLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseMissedRecoverableRanges.
        internal void ProcessRecord_DatabaseMissedRecoverableRanges()
        {
            this._logger.name += " -DatabaseMissedRecoverableRanges";
            // Create new graphql operation mssqlDatabaseMissedRecoverableRanges
            InitQueryMssqlDatabaseMissedRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseMissedSnapshots.
        internal void ProcessRecord_DatabaseMissedSnapshots()
        {
            this._logger.name += " -DatabaseMissedSnapshots";
            // Create new graphql operation mssqlDatabaseMissedSnapshots
            InitQueryMssqlDatabaseMissedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseRestoreEstimate.
        internal void ProcessRecord_DatabaseRestoreEstimate()
        {
            this._logger.name += " -DatabaseRestoreEstimate";
            // Create new graphql operation mssqlDatabaseRestoreEstimate
            InitQueryMssqlDatabaseRestoreEstimate();
        }

        // This parameter set invokes a single graphql operation:
        // allMssqlDatabaseRestoreFiles.
        internal void ProcessRecord_DatabaseRestoreFiles()
        {
            this._logger.name += " -DatabaseRestoreFiles";
            // Create new graphql operation allMssqlDatabaseRestoreFiles
            InitQueryAllMssqlDatabaseRestoreFiles();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabases.
        internal void ProcessRecord_Databases()
        {
            this._logger.name += " -Databases";
            // Create new graphql operation mssqlDatabases
            InitQueryMssqlDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDefaultProperties.
        internal void ProcessRecord_DefaultProperties()
        {
            this._logger.name += " -DefaultProperties";
            // Create new graphql operation mssqlDefaultProperties
            InitQueryMssqlDefaultProperties();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDefaultPropertiesOnCluster.
        internal void ProcessRecord_DefaultPropertiesOnCluster()
        {
            this._logger.name += " -DefaultPropertiesOnCluster";
            // Create new graphql operation mssqlDefaultPropertiesOnCluster
            InitQueryMssqlDefaultPropertiesOnCluster();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlInstance.
        internal void ProcessRecord_Instance()
        {
            this._logger.name += " -Instance";
            // Create new graphql operation mssqlInstance
            InitQueryMssqlInstance();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlLogShippingTargets.
        internal void ProcessRecord_LogShippingTargets()
        {
            this._logger.name += " -LogShippingTargets";
            // Create new graphql operation mssqlLogShippingTargets
            InitQueryMssqlLogShippingTargets();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlRecoverableRanges.
        internal void ProcessRecord_RecoverableRanges()
        {
            this._logger.name += " -RecoverableRanges";
            // Create new graphql operation mssqlRecoverableRanges
            InitQueryMssqlRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlTopLevelDescendants.
        internal void ProcessRecord_TopLevelDescendants()
        {
            this._logger.name += " -TopLevelDescendants";
            // Create new graphql operation mssqlTopLevelDescendants
            InitQueryMssqlTopLevelDescendants();
        }


        // Create new GraphQL Query:
        // mssqlAvailabilityGroup(fid: UUID!): MssqlAvailabilityGroup!
        internal void InitQueryMssqlAvailabilityGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlAvailabilityGroup",
                "($fid: UUID!)",
                "MssqlAvailabilityGroup",
                Query.MssqlAvailabilityGroup_ObjectFieldSpec,
                Query.MssqlAvailabilityGroupFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // cdmMssqlLogShippingTarget(fid: UUID!): MssqlLogShippingTarget
        internal void InitQueryCdmMssqlLogShippingTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCdmMssqlLogShippingTarget",
                "($fid: UUID!)",
                "MssqlLogShippingTarget",
                Query.CdmMssqlLogShippingTarget_ObjectFieldSpec,
                Query.CdmMssqlLogShippingTargetFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // cdmMssqlLogShippingTargets(
        //     first: Int
        //     after: String
        //     sortBy: MssqlLogShippingTargetSortByInput
        //     filters: [MssqlLogShippingTargetFilterInput!]
        //   ): MssqlLogShippingTargetConnection!
        internal void InitQueryCdmMssqlLogShippingTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "MssqlLogShippingTargetSortByInput"),
                Tuple.Create("filters", "[MssqlLogShippingTargetFilterInput!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCdmMssqlLogShippingTargets",
                "($first: Int,$after: String,$sortBy: MssqlLogShippingTargetSortByInput,$filters: [MssqlLogShippingTargetFilterInput!])",
                "MssqlLogShippingTargetConnection",
                Query.CdmMssqlLogShippingTargets_ObjectFieldSpec,
                Query.CdmMssqlLogShippingTargetsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someMssqlLogShippingTargetSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingTargetSortByField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$query.Var.filters = @(
	@{
		# OPTIONAL
		field = $someMssqlLogShippingTargetFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // mssqlCompatibleInstances(
        //     first: Int
        //     after: String
        //     input: GetCompatibleMssqlInstancesV1Input!
        //     sortBy: MssqlCompatibleInstancesSortByInput
        //     filters: [MssqlCompatibleInstancesFilterInput!]
        //   ): MssqlInstanceSummaryListResponse!
        internal void InitQueryMssqlCompatibleInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("input", "GetCompatibleMssqlInstancesV1Input!"),
                Tuple.Create("sortBy", "MssqlCompatibleInstancesSortByInput"),
                Tuple.Create("filters", "[MssqlCompatibleInstancesFilterInput!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlCompatibleInstances",
                "($first: Int,$after: String,$input: GetCompatibleMssqlInstancesV1Input!,$sortBy: MssqlCompatibleInstancesSortByInput,$filters: [MssqlCompatibleInstancesFilterInput!])",
                "MssqlInstanceSummaryListResponse",
                Query.MssqlCompatibleInstances_ObjectFieldSpec,
                Query.MssqlCompatibleInstancesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	recoveryTime = $someDateTime
	# REQUIRED
	recoveryType = $someV1GetCompatibleMssqlInstancesV1RequestRecoveryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1GetCompatibleMssqlInstancesV1RequestRecoveryType]) for enum values.
	# REQUIRED
	id = $someString
}
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someMssqlCompatibleInstancesSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlCompatibleInstancesSortByField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$query.Var.filters = @(
	@{
		# OPTIONAL
		field = $someMssqlCompatibleInstancesFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlCompatibleInstancesFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // mssqlDatabase(fid: UUID!): MssqlDatabase!
        internal void InitQueryMssqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabase",
                "($fid: UUID!)",
                "MssqlDatabase",
                Query.MssqlDatabase_ObjectFieldSpec,
                Query.MssqlDatabaseFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // mssqlDatabaseLiveMounts(
        //     first: Int
        //     after: String
        //     sortBy: MssqlDatabaseLiveMountSortByInput
        //     filters: [MssqlDatabaseLiveMountFilterInput!]
        //   ): MssqlDatabaseLiveMountConnection!
        internal void InitQueryMssqlDatabaseLiveMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "MssqlDatabaseLiveMountSortByInput"),
                Tuple.Create("filters", "[MssqlDatabaseLiveMountFilterInput!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabaseLiveMounts",
                "($first: Int,$after: String,$sortBy: MssqlDatabaseLiveMountSortByInput,$filters: [MssqlDatabaseLiveMountFilterInput!])",
                "MssqlDatabaseLiveMountConnection",
                Query.MssqlDatabaseLiveMounts_ObjectFieldSpec,
                Query.MssqlDatabaseLiveMountsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someMssqlDatabaseLiveMountSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$query.Var.filters = @(
	@{
		# OPTIONAL
		field = $someMssqlDatabaseLiveMountFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // mssqlDatabaseMissedRecoverableRanges(input: GetMssqlDbMissedRecoverableRangesInput!): MssqlMissedRecoverableRangeListResponse!
        internal void InitQueryMssqlDatabaseMissedRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMssqlDbMissedRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabaseMissedRecoverableRanges",
                "($input: GetMssqlDbMissedRecoverableRangesInput!)",
                "MssqlMissedRecoverableRangeListResponse",
                Query.MssqlDatabaseMissedRecoverableRanges_ObjectFieldSpec,
                Query.MssqlDatabaseMissedRecoverableRangesFieldSpec,
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
        // mssqlDatabaseMissedSnapshots(input: GetMissedMssqlDbSnapshotsInput!): MissedSnapshotListResponse!
        internal void InitQueryMssqlDatabaseMissedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMissedMssqlDbSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabaseMissedSnapshots",
                "($input: GetMissedMssqlDbSnapshotsInput!)",
                "MissedSnapshotListResponse",
                Query.MssqlDatabaseMissedSnapshots_ObjectFieldSpec,
                Query.MssqlDatabaseMissedSnapshotsFieldSpec,
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
        // mssqlDatabaseRestoreEstimate(input: MssqlRestoreEstimateV1Input!): MssqlRestoreEstimateResult!
        internal void InitQueryMssqlDatabaseRestoreEstimate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MssqlRestoreEstimateV1Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabaseRestoreEstimate",
                "($input: MssqlRestoreEstimateV1Input!)",
                "MssqlRestoreEstimateResult",
                Query.MssqlDatabaseRestoreEstimate_ObjectFieldSpec,
                Query.MssqlDatabaseRestoreEstimateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	lsn = $someString
	# OPTIONAL
	recoveryForkGuid = $someString
	# OPTIONAL
	time = $someDateTime
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allMssqlDatabaseRestoreFiles(input: MssqlGetRestoreFilesV1Input!): V1MssqlGetRestoreFilesV1Response!
        internal void InitQueryAllMssqlDatabaseRestoreFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MssqlGetRestoreFilesV1Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllMssqlDatabaseRestoreFiles",
                "($input: MssqlGetRestoreFilesV1Input!)",
                "V1MssqlGetRestoreFilesV1Response",
                Query.AllMssqlDatabaseRestoreFiles_ObjectFieldSpec,
                Query.AllMssqlDatabaseRestoreFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	lsn = $someString
	# OPTIONAL
	recoveryForkGuid = $someString
	# OPTIONAL
	time = $someDateTime
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // mssqlDatabases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MssqlDatabaseConnection!
        internal void InitQueryMssqlDatabases()
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
                "QueryMssqlDatabases",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "MssqlDatabaseConnection",
                Query.MssqlDatabases_ObjectFieldSpec,
                Query.MssqlDatabasesFieldSpec,
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
        // mssqlDefaultProperties(input: GetDefaultDbPropertiesV1Input!): UpdateMssqlDefaultPropertiesReply!
        internal void InitQueryMssqlDefaultProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetDefaultDbPropertiesV1Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDefaultProperties",
                "($input: GetDefaultDbPropertiesV1Input!)",
                "UpdateMssqlDefaultPropertiesReply",
                Query.MssqlDefaultProperties_ObjectFieldSpec,
                Query.MssqlDefaultPropertiesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // mssqlDefaultPropertiesOnCluster(input: ClusterUuidWithMssqlObjectIdInput!): MssqlDefaultPropertiesOnClusterReply!
        internal void InitQueryMssqlDefaultPropertiesOnCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterUuidWithMssqlObjectIdInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDefaultPropertiesOnCluster",
                "($input: ClusterUuidWithMssqlObjectIdInput!)",
                "MssqlDefaultPropertiesOnClusterReply",
                Query.MssqlDefaultPropertiesOnCluster_ObjectFieldSpec,
                Query.MssqlDefaultPropertiesOnClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	mssqlObjectId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // mssqlInstance(fid: UUID!): MssqlInstance!
        internal void InitQueryMssqlInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlInstance",
                "($fid: UUID!)",
                "MssqlInstance",
                Query.MssqlInstance_ObjectFieldSpec,
                Query.MssqlInstanceFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // mssqlLogShippingTargets(input: QueryLogShippingConfigurationsV2Input!): MssqlLogShippingSummaryV2ListResponse
        internal void InitQueryMssqlLogShippingTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryLogShippingConfigurationsV2Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlLogShippingTargets",
                "($input: QueryLogShippingConfigurationsV2Input!)",
                "MssqlLogShippingSummaryV2ListResponse",
                Query.MssqlLogShippingTargets_ObjectFieldSpec,
                Query.MssqlLogShippingTargetsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	limit = $someInt
	# OPTIONAL
	location = $someString
	# OPTIONAL
	offset = $someInt
	# OPTIONAL
	primaryDatabaseId = $someString
	# OPTIONAL
	primaryDatabaseName = $someString
	# OPTIONAL
	secondaryDatabaseName = $someString
	# OPTIONAL
	sortBy = $someV2QueryLogShippingConfigurationsV2RequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = $someV2QueryLogShippingConfigurationsV2RequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestSortOrder]) for enum values.
	# OPTIONAL
	status = $someV2QueryLogShippingConfigurationsV2RequestStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestStatus]) for enum values.
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // mssqlRecoverableRanges(input: GetMssqlDbRecoverableRangesInput!): MssqlRecoverableRangeListResponse!
        internal void InitQueryMssqlRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMssqlDbRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlRecoverableRanges",
                "($input: GetMssqlDbRecoverableRangesInput!)",
                "MssqlRecoverableRangeListResponse",
                Query.MssqlRecoverableRanges_ObjectFieldSpec,
                Query.MssqlRecoverableRangesFieldSpec,
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
        // mssqlTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): MssqlTopLevelDescendantTypeConnection!
        internal void InitQueryMssqlTopLevelDescendants()
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
                "QueryMssqlTopLevelDescendants",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                "MssqlTopLevelDescendantTypeConnection",
                Query.MssqlTopLevelDescendants_ObjectFieldSpec,
                Query.MssqlTopLevelDescendantsFieldSpec,
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


    } // class New_RscQueryMssql
}