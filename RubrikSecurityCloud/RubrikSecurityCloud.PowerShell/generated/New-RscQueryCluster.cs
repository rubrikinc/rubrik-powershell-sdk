// New-RscQueryCluster.cs
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
    /// Create a new RscQuery object for any of the 29
    /// operations in the 'Cluster' API domain:
    /// Cluster, Connected, DatabaseLogReport, DatabaseLogReportingProperties, DefaultGateway, Dns, FloatingIps, GroupByList, HostFailover, Ipmi, Ipv6Mode, IsTotpAckNecessary, List, NetworkInterfaces, Nodes, NtpServers, OperationJobProgress, Proxy, RegistrationProductInfo, ReplicationTargets, ReportMigrationCount, ReportMigrationJobStatus, ReportMigrationStatus, TotpAckStatus, TypeList, Vlans, WebCertsAndIpmis, Windows, or WithUpgradesInfo.
    /// </summary>
    /// <description>
    /// New-RscQueryCluster creates a new
    /// query object for operations
    /// in the 'Cluster' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 29 operations
    /// in the 'Cluster' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Cluster, Connected, DatabaseLogReport, DatabaseLogReportingProperties, DefaultGateway, Dns, FloatingIps, GroupByList, HostFailover, Ipmi, Ipv6Mode, IsTotpAckNecessary, List, NetworkInterfaces, Nodes, NtpServers, OperationJobProgress, Proxy, RegistrationProductInfo, ReplicationTargets, ReportMigrationCount, ReportMigrationJobStatus, ReportMigrationStatus, TotpAckStatus, TypeList, Vlans, WebCertsAndIpmis, Windows, or WithUpgradesInfo.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryCluster -Cluster).Info().
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
    /// (New-RscQueryCluster -Cluster).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Cluster operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: Cluster
    /// 
    /// $query = New-RscQueryCluster -Cluster
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Cluster
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Connected operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: Connected
    /// 
    /// $query = New-RscQueryCluster -Connected
    /// 
    /// # OPTIONAL
    /// $query.Var.clusterFilterArg = $someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;DataLocationSupportedCluster&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatabaseLogReport operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: DatabaseLogReport
    /// 
    /// $query = New-RscQueryCluster -DatabaseLogReport
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	logBackupDelay = $someInt
    /// 	# OPTIONAL
    /// 	limit = $someInt
    /// 	# OPTIONAL
    /// 	offset = $someInt
    /// 	# OPTIONAL
    /// 	effectiveSlaDomainId = $someString
    /// 	# OPTIONAL
    /// 	databaseType = $someString
    /// 	# OPTIONAL
    /// 	location = $someString
    /// 	# OPTIONAL
    /// 	sortBy = $someV1QueryLogReportRequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortBy]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someV1QueryLogReportRequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortOrder]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DbLogReportSummaryListReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatabaseLogReportingProperties operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: DatabaseLogReportingProperties
    /// 
    /// $query = New-RscQueryCluster -DatabaseLogReportingProperties
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
    /// Write-Host $result.GetType().Name # prints: DbLogReportProperties
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DefaultGateway operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: DefaultGateway
    /// 
    /// $query = New-RscQueryCluster -DefaultGateway
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
    /// Write-Host $result.GetType().Name # prints: InternalGetDefaultGatewayResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Dns operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: Dns
    /// 
    /// $query = New-RscQueryCluster -Dns
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterDnsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FloatingIps operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: FloatingIps
    /// 
    /// $query = New-RscQueryCluster -FloatingIps
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
    /// Write-Host $result.GetType().Name # prints: InternalGetClusterIpsResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GroupByList operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: GroupByList
    /// 
    /// $query = New-RscQueryCluster -GroupByList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.groupBy = $someClusterGroupByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterGroupByEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	id = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	name = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	type = @(
    /// 		$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	objectType = @(
    /// 		$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	registrationTime_gt = $someDateTime
    /// 	# OPTIONAL
    /// 	registrationTime_lt = $someDateTime
    /// 	# OPTIONAL
    /// 	minSoftwareVersion = $someString
    /// 	# OPTIONAL
    /// 	clusterLocation = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	excludeEmptyCluster = $someBoolean
    /// 	# OPTIONAL
    /// 	productType = @(
    /// 		$someClusterProductEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	registeredMode = @(
    /// 		$someClusterRegistrationMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterRegistrationMode]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	product = $someProduct # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Product]) for enum values.
    /// 	# OPTIONAL
    /// 	orgId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	productFilters = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			productType = $someClusterProductEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
    /// 			# OPTIONAL
    /// 			minSoftwareVersion = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	excludeId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	systemStatus = @(
    /// 		$someClusterSystemStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSystemStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	connectionState = @(
    /// 		$someClusterStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	isInFatalOrDisconnectedState = $someBoolean
    /// }
    /// # OPTIONAL
    /// $query.Var.timezoneOffset = $someSingle
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterGroupByConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HostFailover operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: HostFailover
    /// 
    /// $query = New-RscQueryCluster -HostFailover
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HostFailoverCluster
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Ipmi operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: Ipmi
    /// 
    /// $query = New-RscQueryCluster -Ipmi
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
    /// Write-Host $result.GetType().Name # prints: ModifyIpmiReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Ipv6Mode operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: Ipv6Mode
    /// 
    /// $query = New-RscQueryCluster -Ipv6Mode
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
    /// Write-Host $result.GetType().Name # prints: ClusterIpv6ModeReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsTotpAckNecessary operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: IsTotpAckNecessary
    /// 
    /// $query = New-RscQueryCluster -IsTotpAckNecessary
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the List operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: List
    /// 
    /// $query = New-RscQueryCluster -List
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	id = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	name = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	type = @(
    /// 		$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	objectType = @(
    /// 		$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	registrationTime_gt = $someDateTime
    /// 	# OPTIONAL
    /// 	registrationTime_lt = $someDateTime
    /// 	# OPTIONAL
    /// 	minSoftwareVersion = $someString
    /// 	# OPTIONAL
    /// 	clusterLocation = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	excludeEmptyCluster = $someBoolean
    /// 	# OPTIONAL
    /// 	productType = @(
    /// 		$someClusterProductEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	registeredMode = @(
    /// 		$someClusterRegistrationMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterRegistrationMode]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	product = $someProduct # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Product]) for enum values.
    /// 	# OPTIONAL
    /// 	orgId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	productFilters = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			productType = $someClusterProductEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
    /// 			# OPTIONAL
    /// 			minSoftwareVersion = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	excludeId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	systemStatus = @(
    /// 		$someClusterSystemStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSystemStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	connectionState = @(
    /// 		$someClusterStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	isInFatalOrDisconnectedState = $someBoolean
    /// }
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someClusterSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSortByEnum]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NetworkInterfaces operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: NetworkInterfaces
    /// 
    /// $query = New-RscQueryCluster -NetworkInterfaces
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	interface = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: NetworkInterfaceListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Nodes operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: Nodes
    /// 
    /// $query = New-RscQueryCluster -Nodes
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
    /// Write-Host $result.GetType().Name # prints: NodeStatusListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NtpServers operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: NtpServers
    /// 
    /// $query = New-RscQueryCluster -NtpServers
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
    /// Write-Host $result.GetType().Name # prints: NtpServerConfigurationListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OperationJobProgress operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: OperationJobProgress
    /// 
    /// $query = New-RscQueryCluster -OperationJobProgress
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	jobType = $someCcpJobType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpJobType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterOperationJobProgress
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Proxy operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: Proxy
    /// 
    /// $query = New-RscQueryCluster -Proxy
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterProxyReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RegistrationProductInfo operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: RegistrationProductInfo
    /// 
    /// $query = New-RscQueryCluster -RegistrationProductInfo
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterRegistrationProductInfoType
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ReplicationTargets operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: ReplicationTargets
    /// 
    /// $query = New-RscQueryCluster -ReplicationTargets
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;ClusterReplicationTarget&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ReportMigrationCount operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: ReportMigrationCount
    /// 
    /// $query = New-RscQueryCluster -ReportMigrationCount
    /// 
    /// # OPTIONAL
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.status = @(
    /// 	$someCdmReportMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReportsMigrationCount
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ReportMigrationJobStatus operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: ReportMigrationJobStatus
    /// 
    /// $query = New-RscQueryCluster -ReportMigrationJobStatus
    /// 
    /// # OPTIONAL
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterReportMigrationJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ReportMigrationStatus operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: ReportMigrationStatus
    /// 
    /// $query = New-RscQueryCluster -ReportMigrationStatus
    /// 
    /// # OPTIONAL
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.status = @(
    /// 	$someCdmReportMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReportMigrationStatusConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TotpAckStatus operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: TotpAckStatus
    /// 
    /// $query = New-RscQueryCluster -TotpAckStatus
    /// 
    /// # REQUIRED
    /// $query.Var.listClusterUuid = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.Boolean&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TypeList operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: TypeList
    /// 
    /// $query = New-RscQueryCluster -TypeList
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GroupCount&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Vlans operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: Vlans
    /// 
    /// $query = New-RscQueryCluster -Vlans
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	vlan = $someInt
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VlanConfigListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the WebCertsAndIpmis operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: WebCertsAndIpmis
    /// 
    /// $query = New-RscQueryCluster -WebCertsAndIpmis
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;ClusterWebCertAndIpmi&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Windows operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: Windows
    /// 
    /// $query = New-RscQueryCluster -Windows
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: WindowsCluster
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the WithUpgradesInfo operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: WithUpgradesInfo
    /// 
    /// $query = New-RscQueryCluster -WithUpgradesInfo
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.upgradeFilter = @{
    /// 	# OPTIONAL
    /// 	id = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	name = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	type = @(
    /// 		$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	registrationTime_gt = $someDateTime
    /// 	# OPTIONAL
    /// 	registrationTime_lt = $someDateTime
    /// 	# OPTIONAL
    /// 	minSoftwareVersion = $someString
    /// 	# OPTIONAL
    /// 	downloadedVersion = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	installedVersion = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	upgradeJobStatus = @(
    /// 		$someClusterJobStatusTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterJobStatusTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterLocation = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	versionStatus = @(
    /// 		$someVersionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VersionStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	prechecksStatus = @(
    /// 		$somePrechecksStatusTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrechecksStatusTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	connectionState = @(
    /// 		$someClusterStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	upgradeScheduled = $someBoolean
    /// 	# OPTIONAL
    /// 	productType = @(
    /// 		$someClusterProductEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someUpgradeInfoSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UpgradeInfoSortByEnum]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterConnection
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
        "RscQueryCluster",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryCluster : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Cluster",
                "Connected",
                "DatabaseLogReport",
                "DatabaseLogReportingProperties",
                "DefaultGateway",
                "Dns",
                "FloatingIps",
                "GroupByList",
                "HostFailover",
                "Ipmi",
                "Ipv6Mode",
                "IsTotpAckNecessary",
                "List",
                "NetworkInterfaces",
                "Nodes",
                "NtpServers",
                "OperationJobProgress",
                "Proxy",
                "RegistrationProductInfo",
                "ReplicationTargets",
                "ReportMigrationCount",
                "ReportMigrationJobStatus",
                "ReportMigrationStatus",
                "TotpAckStatus",
                "TypeList",
                "Vlans",
                "WebCertsAndIpmis",
                "Windows",
                "WithUpgradesInfo",
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
                    case "Cluster":
                        this.ProcessRecord_Cluster();
                        break;
                    case "Connected":
                        this.ProcessRecord_Connected();
                        break;
                    case "DatabaseLogReport":
                        this.ProcessRecord_DatabaseLogReport();
                        break;
                    case "DatabaseLogReportingProperties":
                        this.ProcessRecord_DatabaseLogReportingProperties();
                        break;
                    case "DefaultGateway":
                        this.ProcessRecord_DefaultGateway();
                        break;
                    case "Dns":
                        this.ProcessRecord_Dns();
                        break;
                    case "FloatingIps":
                        this.ProcessRecord_FloatingIps();
                        break;
                    case "GroupByList":
                        this.ProcessRecord_GroupByList();
                        break;
                    case "HostFailover":
                        this.ProcessRecord_HostFailover();
                        break;
                    case "Ipmi":
                        this.ProcessRecord_Ipmi();
                        break;
                    case "Ipv6Mode":
                        this.ProcessRecord_Ipv6Mode();
                        break;
                    case "IsTotpAckNecessary":
                        this.ProcessRecord_IsTotpAckNecessary();
                        break;
                    case "List":
                        this.ProcessRecord_List();
                        break;
                    case "NetworkInterfaces":
                        this.ProcessRecord_NetworkInterfaces();
                        break;
                    case "Nodes":
                        this.ProcessRecord_Nodes();
                        break;
                    case "NtpServers":
                        this.ProcessRecord_NtpServers();
                        break;
                    case "OperationJobProgress":
                        this.ProcessRecord_OperationJobProgress();
                        break;
                    case "Proxy":
                        this.ProcessRecord_Proxy();
                        break;
                    case "RegistrationProductInfo":
                        this.ProcessRecord_RegistrationProductInfo();
                        break;
                    case "ReplicationTargets":
                        this.ProcessRecord_ReplicationTargets();
                        break;
                    case "ReportMigrationCount":
                        this.ProcessRecord_ReportMigrationCount();
                        break;
                    case "ReportMigrationJobStatus":
                        this.ProcessRecord_ReportMigrationJobStatus();
                        break;
                    case "ReportMigrationStatus":
                        this.ProcessRecord_ReportMigrationStatus();
                        break;
                    case "TotpAckStatus":
                        this.ProcessRecord_TotpAckStatus();
                        break;
                    case "TypeList":
                        this.ProcessRecord_TypeList();
                        break;
                    case "Vlans":
                        this.ProcessRecord_Vlans();
                        break;
                    case "WebCertsAndIpmis":
                        this.ProcessRecord_WebCertsAndIpmis();
                        break;
                    case "Windows":
                        this.ProcessRecord_Windows();
                        break;
                    case "WithUpgradesInfo":
                        this.ProcessRecord_WithUpgradesInfo();
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
        // cluster.
        internal void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Create new graphql operation cluster
            InitQueryCluster();
        }

        // This parameter set invokes a single graphql operation:
        // allConnectedClusters.
        internal void ProcessRecord_Connected()
        {
            this._logger.name += " -Connected";
            // Create new graphql operation allConnectedClusters
            InitQueryAllConnectedClusters();
        }

        // This parameter set invokes a single graphql operation:
        // databaseLogReportForCluster.
        internal void ProcessRecord_DatabaseLogReport()
        {
            this._logger.name += " -DatabaseLogReport";
            // Create new graphql operation databaseLogReportForCluster
            InitQueryDatabaseLogReportForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // databaseLogReportingPropertiesForCluster.
        internal void ProcessRecord_DatabaseLogReportingProperties()
        {
            this._logger.name += " -DatabaseLogReportingProperties";
            // Create new graphql operation databaseLogReportingPropertiesForCluster
            InitQueryDatabaseLogReportingPropertiesForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // clusterDefaultGateway.
        internal void ProcessRecord_DefaultGateway()
        {
            this._logger.name += " -DefaultGateway";
            // Create new graphql operation clusterDefaultGateway
            InitQueryClusterDefaultGateway();
        }

        // This parameter set invokes a single graphql operation:
        // clusterDns.
        internal void ProcessRecord_Dns()
        {
            this._logger.name += " -Dns";
            // Create new graphql operation clusterDns
            InitQueryClusterDns();
        }

        // This parameter set invokes a single graphql operation:
        // clusterFloatingIps.
        internal void ProcessRecord_FloatingIps()
        {
            this._logger.name += " -FloatingIps";
            // Create new graphql operation clusterFloatingIps
            InitQueryClusterFloatingIps();
        }

        // This parameter set invokes a single graphql operation:
        // clusterGroupByConnection.
        internal void ProcessRecord_GroupByList()
        {
            this._logger.name += " -GroupByList";
            // Create new graphql operation clusterGroupByConnection
            InitQueryClusterGroupByConnection();
        }

        // This parameter set invokes a single graphql operation:
        // hostFailoverCluster.
        internal void ProcessRecord_HostFailover()
        {
            this._logger.name += " -HostFailover";
            // Create new graphql operation hostFailoverCluster
            InitQueryHostFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // clusterIpmi.
        internal void ProcessRecord_Ipmi()
        {
            this._logger.name += " -Ipmi";
            // Create new graphql operation clusterIpmi
            InitQueryClusterIpmi();
        }

        // This parameter set invokes a single graphql operation:
        // clusterIpv6Mode.
        internal void ProcessRecord_Ipv6Mode()
        {
            this._logger.name += " -Ipv6Mode";
            // Create new graphql operation clusterIpv6Mode
            InitQueryClusterIpv6Mode();
        }

        // This parameter set invokes a single graphql operation:
        // isTotpAckNecessaryForCluster.
        internal void ProcessRecord_IsTotpAckNecessary()
        {
            this._logger.name += " -IsTotpAckNecessary";
            // Create new graphql operation isTotpAckNecessaryForCluster
            InitQueryIsTotpAckNecessaryForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // clusterConnection.
        internal void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Create new graphql operation clusterConnection
            InitQueryClusterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // clusterNetworkInterfaces.
        internal void ProcessRecord_NetworkInterfaces()
        {
            this._logger.name += " -NetworkInterfaces";
            // Create new graphql operation clusterNetworkInterfaces
            InitQueryClusterNetworkInterfaces();
        }

        // This parameter set invokes a single graphql operation:
        // clusterNodes.
        internal void ProcessRecord_Nodes()
        {
            this._logger.name += " -Nodes";
            // Create new graphql operation clusterNodes
            InitQueryClusterNodes();
        }

        // This parameter set invokes a single graphql operation:
        // clusterNtpServers.
        internal void ProcessRecord_NtpServers()
        {
            this._logger.name += " -NtpServers";
            // Create new graphql operation clusterNtpServers
            InitQueryClusterNtpServers();
        }

        // This parameter set invokes a single graphql operation:
        // clusterOperationJobProgress.
        internal void ProcessRecord_OperationJobProgress()
        {
            this._logger.name += " -OperationJobProgress";
            // Create new graphql operation clusterOperationJobProgress
            InitQueryClusterOperationJobProgress();
        }

        // This parameter set invokes a single graphql operation:
        // clusterProxy.
        internal void ProcessRecord_Proxy()
        {
            this._logger.name += " -Proxy";
            // Create new graphql operation clusterProxy
            InitQueryClusterProxy();
        }

        // This parameter set invokes a single graphql operation:
        // clusterRegistrationProductInfo.
        internal void ProcessRecord_RegistrationProductInfo()
        {
            this._logger.name += " -RegistrationProductInfo";
            // Create new graphql operation clusterRegistrationProductInfo
            InitQueryClusterRegistrationProductInfo();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterReplicationTargets.
        internal void ProcessRecord_ReplicationTargets()
        {
            this._logger.name += " -ReplicationTargets";
            // Create new graphql operation allClusterReplicationTargets
            InitQueryAllClusterReplicationTargets();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationCount.
        internal void ProcessRecord_ReportMigrationCount()
        {
            this._logger.name += " -ReportMigrationCount";
            // Create new graphql operation clusterReportMigrationCount
            InitQueryClusterReportMigrationCount();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationJobStatus.
        internal void ProcessRecord_ReportMigrationJobStatus()
        {
            this._logger.name += " -ReportMigrationJobStatus";
            // Create new graphql operation clusterReportMigrationJobStatus
            InitQueryClusterReportMigrationJobStatus();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationStatus.
        internal void ProcessRecord_ReportMigrationStatus()
        {
            this._logger.name += " -ReportMigrationStatus";
            // Create new graphql operation clusterReportMigrationStatus
            InitQueryClusterReportMigrationStatus();
        }

        // This parameter set invokes a single graphql operation:
        // allClustersTotpAckStatus.
        internal void ProcessRecord_TotpAckStatus()
        {
            this._logger.name += " -TotpAckStatus";
            // Create new graphql operation allClustersTotpAckStatus
            InitQueryAllClustersTotpAckStatus();
        }

        // This parameter set invokes a single graphql operation:
        // clusterTypeList.
        internal void ProcessRecord_TypeList()
        {
            this._logger.name += " -TypeList";
            // Create new graphql operation clusterTypeList
            InitQueryClusterTypeList();
        }

        // This parameter set invokes a single graphql operation:
        // clusterVlans.
        internal void ProcessRecord_Vlans()
        {
            this._logger.name += " -Vlans";
            // Create new graphql operation clusterVlans
            InitQueryClusterVlans();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterWebCertsAndIpmis.
        internal void ProcessRecord_WebCertsAndIpmis()
        {
            this._logger.name += " -WebCertsAndIpmis";
            // Create new graphql operation allClusterWebCertsAndIpmis
            InitQueryAllClusterWebCertsAndIpmis();
        }

        // This parameter set invokes a single graphql operation:
        // windowsCluster.
        internal void ProcessRecord_Windows()
        {
            this._logger.name += " -Windows";
            // Create new graphql operation windowsCluster
            InitQueryWindowsCluster();
        }

        // This parameter set invokes a single graphql operation:
        // clusterWithUpgradesInfo.
        internal void ProcessRecord_WithUpgradesInfo()
        {
            this._logger.name += " -WithUpgradesInfo";
            // Create new graphql operation clusterWithUpgradesInfo
            InitQueryClusterWithUpgradesInfo();
        }


        // Create new GraphQL Query:
        // cluster(clusterUuid: UUID!): Cluster!
        internal void InitQueryCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCluster",
                "($clusterUuid: UUID!)",
                "Cluster",
                Query.Cluster_ObjectFieldSpec,
                Query.ClusterFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // allConnectedClusters(clusterFilterArg: ClusterTypeEnum): [DataLocationSupportedCluster!]!
        internal void InitQueryAllConnectedClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterFilterArg", "ClusterTypeEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllConnectedClusters",
                "($clusterFilterArg: ClusterTypeEnum)",
                "List<DataLocationSupportedCluster>",
                Query.AllConnectedClusters_ObjectFieldSpec,
                Query.AllConnectedClustersFieldSpec,
                @"# OPTIONAL
$query.Var.clusterFilterArg = $someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // databaseLogReportForCluster(input: QueryLogReportInput!): DbLogReportSummaryListReply!
        internal void InitQueryDatabaseLogReportForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryLogReportInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDatabaseLogReportForCluster",
                "($input: QueryLogReportInput!)",
                "DbLogReportSummaryListReply",
                Query.DatabaseLogReportForCluster_ObjectFieldSpec,
                Query.DatabaseLogReportForClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	name = $someString
	# OPTIONAL
	logBackupDelay = $someInt
	# OPTIONAL
	limit = $someInt
	# OPTIONAL
	offset = $someInt
	# OPTIONAL
	effectiveSlaDomainId = $someString
	# OPTIONAL
	databaseType = $someString
	# OPTIONAL
	location = $someString
	# OPTIONAL
	sortBy = $someV1QueryLogReportRequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = $someV1QueryLogReportRequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // databaseLogReportingPropertiesForCluster(input: QueryReportPropertiesInput!): DbLogReportProperties!
        internal void InitQueryDatabaseLogReportingPropertiesForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryReportPropertiesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDatabaseLogReportingPropertiesForCluster",
                "($input: QueryReportPropertiesInput!)",
                "DbLogReportProperties",
                Query.DatabaseLogReportingPropertiesForCluster_ObjectFieldSpec,
                Query.DatabaseLogReportingPropertiesForClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // clusterDefaultGateway(input: GetDefaultGatewayInput!): InternalGetDefaultGatewayResponse!
        internal void InitQueryClusterDefaultGateway()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetDefaultGatewayInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterDefaultGateway",
                "($input: GetDefaultGatewayInput!)",
                "InternalGetDefaultGatewayResponse",
                Query.ClusterDefaultGateway_ObjectFieldSpec,
                Query.ClusterDefaultGatewayFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // clusterDns(clusterUuid: UUID!): ClusterDnsReply!
        internal void InitQueryClusterDns()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterDns",
                "($clusterUuid: UUID!)",
                "ClusterDnsReply",
                Query.ClusterDns_ObjectFieldSpec,
                Query.ClusterDnsFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterFloatingIps(input: GetClusterIpsInput!): InternalGetClusterIpsResponse!
        internal void InitQueryClusterFloatingIps()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterIpsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterFloatingIps",
                "($input: GetClusterIpsInput!)",
                "InternalGetClusterIpsResponse",
                Query.ClusterFloatingIps_ObjectFieldSpec,
                Query.ClusterFloatingIpsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // clusterGroupByConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     groupBy: ClusterGroupByEnum!
        //     filter: ClusterFilterInput
        //     timezoneOffset: Float = 0.0
        //   ): ClusterGroupByConnection!
        internal void InitQueryClusterGroupByConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("groupBy", "ClusterGroupByEnum!"),
                Tuple.Create("filter", "ClusterFilterInput"),
                Tuple.Create("timezoneOffset", "Float"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterGroupByConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$groupBy: ClusterGroupByEnum!,$filter: ClusterFilterInput,$timezoneOffset: Float)",
                "ClusterGroupByConnection",
                Query.ClusterGroupByConnection_ObjectFieldSpec,
                Query.ClusterGroupByConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.groupBy = $someClusterGroupByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterGroupByEnum]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	id = @(
		$someString
	)
	# OPTIONAL
	name = @(
		$someString
	)
	# OPTIONAL
	type = @(
		$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
	)
	# OPTIONAL
	objectType = @(
		$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
	)
	# OPTIONAL
	registrationTime_gt = $someDateTime
	# OPTIONAL
	registrationTime_lt = $someDateTime
	# OPTIONAL
	minSoftwareVersion = $someString
	# OPTIONAL
	clusterLocation = @(
		$someString
	)
	# OPTIONAL
	excludeEmptyCluster = $someBoolean
	# OPTIONAL
	productType = @(
		$someClusterProductEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
	)
	# OPTIONAL
	registeredMode = @(
		$someClusterRegistrationMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterRegistrationMode]) for enum values.
	)
	# OPTIONAL
	product = $someProduct # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Product]) for enum values.
	# OPTIONAL
	orgId = @(
		$someString
	)
	# OPTIONAL
	productFilters = @(
		@{
			# REQUIRED
			productType = $someClusterProductEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
			# OPTIONAL
			minSoftwareVersion = $someString
		}
	)
	# OPTIONAL
	excludeId = @(
		$someString
	)
	# OPTIONAL
	systemStatus = @(
		$someClusterSystemStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSystemStatus]) for enum values.
	)
	# OPTIONAL
	connectionState = @(
		$someClusterStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
	)
	# OPTIONAL
	isInFatalOrDisconnectedState = $someBoolean
}
# OPTIONAL
$query.Var.timezoneOffset = $someSingle"
            );
        }

        // Create new GraphQL Query:
        // hostFailoverCluster(fid: UUID!): HostFailoverCluster!
        internal void InitQueryHostFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHostFailoverCluster",
                "($fid: UUID!)",
                "HostFailoverCluster",
                Query.HostFailoverCluster_ObjectFieldSpec,
                Query.HostFailoverClusterFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterIpmi(input: GetIpmiInput!): ModifyIpmiReply!
        internal void InitQueryClusterIpmi()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetIpmiInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterIpmi",
                "($input: GetIpmiInput!)",
                "ModifyIpmiReply",
                Query.ClusterIpmi_ObjectFieldSpec,
                Query.ClusterIpmiFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // clusterIpv6Mode(input: ClusterIpv6ModeInput!): ClusterIpv6ModeReply!
        internal void InitQueryClusterIpv6Mode()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterIpv6ModeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterIpv6Mode",
                "($input: ClusterIpv6ModeInput!)",
                "ClusterIpv6ModeReply",
                Query.ClusterIpv6Mode_ObjectFieldSpec,
                Query.ClusterIpv6ModeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // isTotpAckNecessaryForCluster(clusterUuid: UUID!): Boolean!
        internal void InitQueryIsTotpAckNecessaryForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsTotpAckNecessaryForCluster",
                "($clusterUuid: UUID!)",
                "System.Boolean",
                Query.IsTotpAckNecessaryForCluster_ObjectFieldSpec,
                Query.IsTotpAckNecessaryForClusterFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: ClusterFilterInput
        //     sortOrder: SortOrder = DESC
        //     sortBy: ClusterSortByEnum = ClusterType
        //   ): ClusterConnection!
        internal void InitQueryClusterConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "ClusterFilterInput"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "ClusterSortByEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: ClusterFilterInput,$sortOrder: SortOrder,$sortBy: ClusterSortByEnum)",
                "ClusterConnection",
                Query.ClusterConnection_ObjectFieldSpec,
                Query.ClusterConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	id = @(
		$someString
	)
	# OPTIONAL
	name = @(
		$someString
	)
	# OPTIONAL
	type = @(
		$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
	)
	# OPTIONAL
	objectType = @(
		$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
	)
	# OPTIONAL
	registrationTime_gt = $someDateTime
	# OPTIONAL
	registrationTime_lt = $someDateTime
	# OPTIONAL
	minSoftwareVersion = $someString
	# OPTIONAL
	clusterLocation = @(
		$someString
	)
	# OPTIONAL
	excludeEmptyCluster = $someBoolean
	# OPTIONAL
	productType = @(
		$someClusterProductEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
	)
	# OPTIONAL
	registeredMode = @(
		$someClusterRegistrationMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterRegistrationMode]) for enum values.
	)
	# OPTIONAL
	product = $someProduct # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Product]) for enum values.
	# OPTIONAL
	orgId = @(
		$someString
	)
	# OPTIONAL
	productFilters = @(
		@{
			# REQUIRED
			productType = $someClusterProductEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
			# OPTIONAL
			minSoftwareVersion = $someString
		}
	)
	# OPTIONAL
	excludeId = @(
		$someString
	)
	# OPTIONAL
	systemStatus = @(
		$someClusterSystemStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSystemStatus]) for enum values.
	)
	# OPTIONAL
	connectionState = @(
		$someClusterStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
	)
	# OPTIONAL
	isInFatalOrDisconnectedState = $someBoolean
}
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someClusterSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSortByEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // clusterNetworkInterfaces(input: GetNetworkInterfaceInput!): NetworkInterfaceListResponse!
        internal void InitQueryClusterNetworkInterfaces()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNetworkInterfaceInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterNetworkInterfaces",
                "($input: GetNetworkInterfaceInput!)",
                "NetworkInterfaceListResponse",
                Query.ClusterNetworkInterfaces_ObjectFieldSpec,
                Query.ClusterNetworkInterfacesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	interface = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // clusterNodes(input: GetNodesInput!): NodeStatusListResponse!
        internal void InitQueryClusterNodes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNodesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterNodes",
                "($input: GetNodesInput!)",
                "NodeStatusListResponse",
                Query.ClusterNodes_ObjectFieldSpec,
                Query.ClusterNodesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // clusterNtpServers(input: GetClusterNtpServersInput!): NtpServerConfigurationListResponse!
        internal void InitQueryClusterNtpServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterNtpServersInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterNtpServers",
                "($input: GetClusterNtpServersInput!)",
                "NtpServerConfigurationListResponse",
                Query.ClusterNtpServers_ObjectFieldSpec,
                Query.ClusterNtpServersFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // clusterOperationJobProgress(input: ClusterOperationJobProgressInput!): ClusterOperationJobProgress!
        internal void InitQueryClusterOperationJobProgress()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterOperationJobProgressInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterOperationJobProgress",
                "($input: ClusterOperationJobProgressInput!)",
                "ClusterOperationJobProgress",
                Query.ClusterOperationJobProgress_ObjectFieldSpec,
                Query.ClusterOperationJobProgressFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterUuid = $someString
	# REQUIRED
	jobType = $someCcpJobType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpJobType]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // clusterProxy(clusterUuid: UUID!): ClusterProxyReply!
        internal void InitQueryClusterProxy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterProxy",
                "($clusterUuid: UUID!)",
                "ClusterProxyReply",
                Query.ClusterProxy_ObjectFieldSpec,
                Query.ClusterProxyFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterRegistrationProductInfo: ClusterRegistrationProductInfoType!
        internal void InitQueryClusterRegistrationProductInfo()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterRegistrationProductInfo",
                "",
                "ClusterRegistrationProductInfoType",
                Query.ClusterRegistrationProductInfo_ObjectFieldSpec,
                Query.ClusterRegistrationProductInfoFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allClusterReplicationTargets(clusterUuid: UUID!): [ClusterReplicationTarget!]!
        internal void InitQueryAllClusterReplicationTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClusterReplicationTargets",
                "($clusterUuid: UUID!)",
                "List<ClusterReplicationTarget>",
                Query.AllClusterReplicationTargets_ObjectFieldSpec,
                Query.AllClusterReplicationTargetsFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterReportMigrationCount(clusterUuid: UUID, status: [CdmReportMigrationStatus!]!): ReportsMigrationCount!
        internal void InitQueryClusterReportMigrationCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("status", "[CdmReportMigrationStatus!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationCount",
                "($clusterUuid: UUID,$status: [CdmReportMigrationStatus!]!)",
                "ReportsMigrationCount",
                Query.ClusterReportMigrationCount_ObjectFieldSpec,
                Query.ClusterReportMigrationCountFieldSpec,
                @"# OPTIONAL
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.status = @(
	$someCdmReportMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // clusterReportMigrationJobStatus(clusterUuid: UUID): ClusterReportMigrationJobStatus!
        internal void InitQueryClusterReportMigrationJobStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationJobStatus",
                "($clusterUuid: UUID)",
                "ClusterReportMigrationJobStatus",
                Query.ClusterReportMigrationJobStatus_ObjectFieldSpec,
                Query.ClusterReportMigrationJobStatusFieldSpec,
                @"# OPTIONAL
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterReportMigrationStatus(
        //     clusterUuid: UUID
        //     status: [CdmReportMigrationStatus!]!
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ReportMigrationStatusConnection!
        internal void InitQueryClusterReportMigrationStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("status", "[CdmReportMigrationStatus!]!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationStatus",
                "($clusterUuid: UUID,$status: [CdmReportMigrationStatus!]!,$first: Int,$after: String,$last: Int,$before: String)",
                "ReportMigrationStatusConnection",
                Query.ClusterReportMigrationStatus_ObjectFieldSpec,
                Query.ClusterReportMigrationStatusFieldSpec,
                @"# OPTIONAL
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.status = @(
	$someCdmReportMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // allClustersTotpAckStatus(listClusterUuid: [UUID!]!): [Boolean!]!
        internal void InitQueryAllClustersTotpAckStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("listClusterUuid", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClustersTotpAckStatus",
                "($listClusterUuid: [UUID!]!)",
                "List<System.Boolean>",
                Query.AllClustersTotpAckStatus_ObjectFieldSpec,
                Query.AllClustersTotpAckStatusFieldSpec,
                @"# REQUIRED
$query.Var.listClusterUuid = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // clusterTypeList: [GroupCount!]!
        internal void InitQueryClusterTypeList()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterTypeList",
                "",
                "List<GroupCount>",
                Query.ClusterTypeList_ObjectFieldSpec,
                Query.ClusterTypeListFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // clusterVlans(input: GetVlanInput!): VlanConfigListResponse!
        internal void InitQueryClusterVlans()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVlanInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterVlans",
                "($input: GetVlanInput!)",
                "VlanConfigListResponse",
                Query.ClusterVlans_ObjectFieldSpec,
                Query.ClusterVlansFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	vlan = $someInt
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allClusterWebCertsAndIpmis(input: BulkClusterWebCertAndIpmiInput!): [ClusterWebCertAndIpmi!]!
        internal void InitQueryAllClusterWebCertsAndIpmis()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkClusterWebCertAndIpmiInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClusterWebCertsAndIpmis",
                "($input: BulkClusterWebCertAndIpmiInput!)",
                "List<ClusterWebCertAndIpmi>",
                Query.AllClusterWebCertsAndIpmis_ObjectFieldSpec,
                Query.AllClusterWebCertsAndIpmisFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Query:
        // windowsCluster(fid: UUID!): WindowsCluster!
        internal void InitQueryWindowsCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryWindowsCluster",
                "($fid: UUID!)",
                "WindowsCluster",
                Query.WindowsCluster_ObjectFieldSpec,
                Query.WindowsClusterFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterWithUpgradesInfo(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     upgradeFilter: CdmUpgradeInfoFilterInput
        //     sortOrder: SortOrder = DESC
        //     sortBy: UpgradeInfoSortByEnum = ClusterType
        //   ): ClusterConnection!
        internal void InitQueryClusterWithUpgradesInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("upgradeFilter", "CdmUpgradeInfoFilterInput"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "UpgradeInfoSortByEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterWithUpgradesInfo",
                "($first: Int,$after: String,$last: Int,$before: String,$upgradeFilter: CdmUpgradeInfoFilterInput,$sortOrder: SortOrder,$sortBy: UpgradeInfoSortByEnum)",
                "ClusterConnection",
                Query.ClusterWithUpgradesInfo_ObjectFieldSpec,
                Query.ClusterWithUpgradesInfoFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.upgradeFilter = @{
	# OPTIONAL
	id = @(
		$someString
	)
	# OPTIONAL
	name = @(
		$someString
	)
	# OPTIONAL
	type = @(
		$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
	)
	# OPTIONAL
	registrationTime_gt = $someDateTime
	# OPTIONAL
	registrationTime_lt = $someDateTime
	# OPTIONAL
	minSoftwareVersion = $someString
	# OPTIONAL
	downloadedVersion = @(
		$someString
	)
	# OPTIONAL
	installedVersion = @(
		$someString
	)
	# OPTIONAL
	upgradeJobStatus = @(
		$someClusterJobStatusTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterJobStatusTypeEnum]) for enum values.
	)
	# OPTIONAL
	clusterLocation = @(
		$someString
	)
	# OPTIONAL
	versionStatus = @(
		$someVersionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VersionStatus]) for enum values.
	)
	# OPTIONAL
	prechecksStatus = @(
		$somePrechecksStatusTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrechecksStatusTypeEnum]) for enum values.
	)
	# OPTIONAL
	connectionState = @(
		$someClusterStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
	)
	# OPTIONAL
	upgradeScheduled = $someBoolean
	# OPTIONAL
	productType = @(
		$someClusterProductEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
	)
}
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someUpgradeInfoSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UpgradeInfoSortByEnum]) for enum values."
            );
        }


    } // class New_RscQueryCluster
}