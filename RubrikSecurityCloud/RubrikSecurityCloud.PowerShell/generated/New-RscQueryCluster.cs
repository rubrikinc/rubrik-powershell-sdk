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
    /// Create a new RscQuery object for any of the 43
    /// operations in the 'Cluster' API domain:
    /// CanIgnoreClusterRemovalPrechecks, CloudClusterInstanceProperties, CloudClusterNodesInstanceProperties, CloudClusterRecoveryValidation, CloudDirectClusterEndpoints, CloudDirectClusterLambdaConfig, Cluster, ClusterList, ComputeClusterStatus, Connected, Count, DefaultGateway, Dns, EncryptionInfo, ExocomputeGetClusterConnectionInfo, FloatingIps, GetCdmReleaseDetailsForClusterFromSupportPortal, GetGroupCountByCdmClusterStatus, GroupByList, Ipmi, Ipv6Mode, IsCloudClusterDiskUpgradeAvailable, IsRemoveClusterTprConfigured, IsTotpAckNecessary, LicensesForClusterProductSummary, List, Missing, NetworkInterfaces, Nodes, NtpServers, OperationJobProgress, Proxy, RadarClusterList, RegistrationProductInfo, ReplicationTargets, Routes, TotpAckStatus, TypeList, ValidateClusterLicenseCapacity, Vlans, WebCertsAndIpmis, Windows, or WithUpgradesInfo.
    /// </summary>
    /// <description>
    /// New-RscQueryCluster creates a new
    /// query object for operations
    /// in the 'Cluster' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 43 operations
    /// in the 'Cluster' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CanIgnoreClusterRemovalPrechecks, CloudClusterInstanceProperties, CloudClusterNodesInstanceProperties, CloudClusterRecoveryValidation, CloudDirectClusterEndpoints, CloudDirectClusterLambdaConfig, Cluster, ClusterList, ComputeClusterStatus, Connected, Count, DefaultGateway, Dns, EncryptionInfo, ExocomputeGetClusterConnectionInfo, FloatingIps, GetCdmReleaseDetailsForClusterFromSupportPortal, GetGroupCountByCdmClusterStatus, GroupByList, Ipmi, Ipv6Mode, IsCloudClusterDiskUpgradeAvailable, IsRemoveClusterTprConfigured, IsTotpAckNecessary, LicensesForClusterProductSummary, List, Missing, NetworkInterfaces, Nodes, NtpServers, OperationJobProgress, Proxy, RadarClusterList, RegistrationProductInfo, ReplicationTargets, Routes, TotpAckStatus, TypeList, ValidateClusterLicenseCapacity, Vlans, WebCertsAndIpmis, Windows, or WithUpgradesInfo.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryCluster -CanIgnoreClusterRemovalPrechecks).Info().
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
    /// (New-RscQueryCluster -CanIgnoreClusterRemovalPrechecks).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CanIgnoreClusterRemovalPrechecks operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: CanIgnoreClusterRemovalPrechecks
    /// 
    /// $query = New-RscQueryCluster -Operation CanIgnoreClusterRemovalPrechecks
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: IgnoreClusterRemovalPrecheckReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudClusterInstanceProperties operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: CloudClusterInstanceProperties
    /// 
    /// $query = New-RscQueryCluster -Operation CloudClusterInstanceProperties
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	vendor = $someVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VendorType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: InstancePropertiesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudClusterNodesInstanceProperties operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: CloudClusterNodesInstanceProperties
    /// 
    /// $query = New-RscQueryCluster -Operation CloudClusterNodesInstanceProperties
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	vendor = $someVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VendorType]) for enum values.
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterNodesInstancePropertiesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudClusterRecoveryValidation operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: CloudClusterRecoveryValidation
    /// 
    /// $query = New-RscQueryCluster -Operation CloudClusterRecoveryValidation
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidationRecoveryReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudDirectClusterEndpoints operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: CloudDirectClusterEndpoints
    /// 
    /// $query = New-RscQueryCluster -Operation CloudDirectClusterEndpoints
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterEndpoints
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudDirectClusterLambdaConfig operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: CloudDirectClusterLambdaConfig
    /// 
    /// $query = New-RscQueryCluster -Operation CloudDirectClusterLambdaConfig
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
    /// 	# OPTIONAL
    /// 	cyberEventLockdownMode = @(
    /// 		$someClusterCyberEventLockdownMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCyberEventLockdownMode]) for enum values.
    /// 	)
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
    /// Write-Host $result.GetType().Name # prints: ThreatHuntCloudDirectClusterConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
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
    /// $query = New-RscQueryCluster -Operation Cluster
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
    /// Runs the ClusterList operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: ClusterList
    /// 
    /// $query = New-RscQueryCluster -Operation ClusterList
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
    /// 	# OPTIONAL
    /// 	cyberEventLockdownMode = @(
    /// 		$someClusterCyberEventLockdownMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCyberEventLockdownMode]) for enum values.
    /// 	)
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
    /// Runs the ComputeClusterStatus operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: ComputeClusterStatus
    /// 
    /// $query = New-RscQueryCluster -Operation ComputeClusterStatus
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
    /// Write-Host $result.GetType().Name # prints: ComputeClusterDetail
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
    /// $query = New-RscQueryCluster -Operation Connected
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
    /// Runs the Count operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: Count
    /// 
    /// $query = New-RscQueryCluster -Operation Count
    /// 
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
    /// 	# OPTIONAL
    /// 	cyberEventLockdownMode = @(
    /// 		$someClusterCyberEventLockdownMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCyberEventLockdownMode]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CountClustersReply
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
    /// $query = New-RscQueryCluster -Operation DefaultGateway
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
    /// $query = New-RscQueryCluster -Operation Dns
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
    /// Runs the EncryptionInfo operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: EncryptionInfo
    /// 
    /// $query = New-RscQueryCluster -Operation EncryptionInfo
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
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.clusterName = $someString
    /// # REQUIRED
    /// $query.Var.encryptionStatusFilter = @(
    /// 	$someClusterEncryptionStatusFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterEncryptionStatusFilter]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.keyProtection = @(
    /// 	$someClusterKeyProtection # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterKeyProtection]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.clusters = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.encryptionTypes = @(
    /// 	$someClusterEncryptionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterEncryptionType]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterEncryptionInfoConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExocomputeGetClusterConnectionInfo operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: ExocomputeGetClusterConnectionInfo
    /// 
    /// $query = New-RscQueryCluster -Operation ExocomputeGetClusterConnectionInfo
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterName = $someString
    /// 	# REQUIRED
    /// 	exocomputeConfigId = $someString
    /// 	# REQUIRED
    /// 	cloudType = $someCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ExocomputeGetClusterConnectionInfoReply
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
    /// $query = New-RscQueryCluster -Operation FloatingIps
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
    /// Runs the GetCdmReleaseDetailsForClusterFromSupportPortal operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: GetCdmReleaseDetailsForClusterFromSupportPortal
    /// 
    /// $query = New-RscQueryCluster -Operation GetCdmReleaseDetailsForClusterFromSupportPortal
    /// 
    /// # REQUIRED
    /// $query.Var.listClusterUuid = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.filterVersion = $someString
    /// # REQUIRED
    /// $query.Var.fetchLinks = $someBoolean
    /// # REQUIRED
    /// $query.Var.filterUpgradeable = $someBoolean
    /// # REQUIRED
    /// $query.Var.shouldShowAll = $someBoolean
    /// # REQUIRED
    /// $query.Var.filterAfterSource = $someBoolean
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CdmUpgradeReleaseDetailsFromSupportPortalReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetGroupCountByCdmClusterStatus operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: GetGroupCountByCdmClusterStatus
    /// 
    /// $query = New-RscQueryCluster -Operation GetGroupCountByCdmClusterStatus
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GroupCountListWithTotal
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
    /// $query = New-RscQueryCluster -Operation GroupByList
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
    /// 	# OPTIONAL
    /// 	cyberEventLockdownMode = @(
    /// 		$someClusterCyberEventLockdownMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCyberEventLockdownMode]) for enum values.
    /// 	)
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
    /// $query = New-RscQueryCluster -Operation Ipmi
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
    /// $query = New-RscQueryCluster -Operation Ipv6Mode
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
    /// Runs the IsCloudClusterDiskUpgradeAvailable operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: IsCloudClusterDiskUpgradeAvailable
    /// 
    /// $query = New-RscQueryCluster -Operation IsCloudClusterDiskUpgradeAvailable
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	vendor = $someCcpVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpVendorType]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	batchSize = $someInt
    /// 	# OPTIONAL
    /// 	newNodeCount = $someInt
    /// 	# OPTIONAL
    /// 	newInstanceType = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: IsCloudClusterDiskUpgradeAvailableReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsRemoveClusterTprConfigured operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: IsRemoveClusterTprConfigured
    /// 
    /// $query = New-RscQueryCluster -Operation IsRemoveClusterTprConfigured
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
    /// $query = New-RscQueryCluster -Operation IsTotpAckNecessary
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
    /// Runs the LicensesForClusterProductSummary operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: LicensesForClusterProductSummary
    /// 
    /// $query = New-RscQueryCluster -Operation LicensesForClusterProductSummary
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	product = $someProduct # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Product]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: LicensesForClusterProductReply
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
    /// $query = New-RscQueryCluster -Operation List
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
    /// 	# OPTIONAL
    /// 	cyberEventLockdownMode = @(
    /// 		$someClusterCyberEventLockdownMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCyberEventLockdownMode]) for enum values.
    /// 	)
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
    /// Runs the Missing operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: Missing
    /// 
    /// $query = New-RscQueryCluster -Operation Missing
    /// 
    /// # OPTIONAL
    /// $query.Var.connectionStatus = $someMissingClusterConnectionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MissingClusterConnectionStatus]) for enum values.
    /// # OPTIONAL
    /// $query.Var.isExcluded = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MissingClusterConnection
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
    /// $query = New-RscQueryCluster -Operation NetworkInterfaces
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	interface = $someString
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
    /// $query = New-RscQueryCluster -Operation Nodes
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
    /// $query = New-RscQueryCluster -Operation NtpServers
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
    /// $query = New-RscQueryCluster -Operation OperationJobProgress
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
    /// $query = New-RscQueryCluster -Operation Proxy
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
    /// Runs the RadarClusterList operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: RadarClusterList
    /// 
    /// $query = New-RscQueryCluster -Operation RadarClusterList
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
    /// 	# OPTIONAL
    /// 	cyberEventLockdownMode = @(
    /// 		$someClusterCyberEventLockdownMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCyberEventLockdownMode]) for enum values.
    /// 	)
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
    /// $query = New-RscQueryCluster -Operation RegistrationProductInfo
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
    /// $query = New-RscQueryCluster -Operation ReplicationTargets
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
    /// Runs the Routes operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: Routes
    /// 
    /// $query = New-RscQueryCluster -Operation Routes
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterRoutesReply
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
    /// $query = New-RscQueryCluster -Operation TotpAckStatus
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
    /// $query = New-RscQueryCluster -Operation TypeList
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
    /// Runs the ValidateClusterLicenseCapacity operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: ValidateClusterLicenseCapacity
    /// 
    /// $query = New-RscQueryCluster -Operation ValidateClusterLicenseCapacity
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	nodes = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			id = $someString
    /// 			# OPTIONAL
    /// 			manufactureTime = $someDateTime
    /// 			# OPTIONAL
    /// 			serial = $someString
    /// 			# OPTIONAL
    /// 			systemUuid = $someString
    /// 			# OPTIONAL
    /// 			teleportToken = $someString
    /// 			# OPTIONAL
    /// 			clusterUuid = $someString
    /// 			# OPTIONAL
    /// 			platform = $someString
    /// 			# OPTIONAL
    /// 			capacity = $someString
    /// 			# OPTIONAL
    /// 			isEntitled = $someBoolean
    /// 			# OPTIONAL
    /// 			version = $someString
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	managedByRubrik = $someManagedByRubrik # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedByRubrik]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterLicenseCapacityValidations
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
    /// $query = New-RscQueryCluster -Operation Vlans
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	vlan = $someInt
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
    /// $query = New-RscQueryCluster -Operation WebCertsAndIpmis
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
    /// $query = New-RscQueryCluster -Operation Windows
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
    /// $query = New-RscQueryCluster -Operation WithUpgradesInfo
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
    /// 	# OPTIONAL
    /// 	upgradeStatusCategory = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	eosStatus = @(
    /// 		$someClusterEosStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterEosStatus]) for enum values.
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
                "CanIgnoreClusterRemovalPrechecks",
                "CloudClusterInstanceProperties",
                "CloudClusterNodesInstanceProperties",
                "CloudClusterRecoveryValidation",
                "CloudDirectClusterEndpoints",
                "CloudDirectClusterLambdaConfig",
                "Cluster",
                "ClusterList",
                "ComputeClusterStatus",
                "Connected",
                "Count",
                "DefaultGateway",
                "Dns",
                "EncryptionInfo",
                "ExocomputeGetClusterConnectionInfo",
                "FloatingIps",
                "GetCdmReleaseDetailsForClusterFromSupportPortal",
                "GetGroupCountByCdmClusterStatus",
                "GroupByList",
                "Ipmi",
                "Ipv6Mode",
                "IsCloudClusterDiskUpgradeAvailable",
                "IsRemoveClusterTprConfigured",
                "IsTotpAckNecessary",
                "LicensesForClusterProductSummary",
                "List",
                "Missing",
                "NetworkInterfaces",
                "Nodes",
                "NtpServers",
                "OperationJobProgress",
                "Proxy",
                "RadarClusterList",
                "RegistrationProductInfo",
                "ReplicationTargets",
                "Routes",
                "TotpAckStatus",
                "TypeList",
                "ValidateClusterLicenseCapacity",
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
                    case "CanIgnoreClusterRemovalPrechecks":
                        this.ProcessRecord_CanIgnoreClusterRemovalPrechecks();
                        break;
                    case "CloudClusterInstanceProperties":
                        this.ProcessRecord_CloudClusterInstanceProperties();
                        break;
                    case "CloudClusterNodesInstanceProperties":
                        this.ProcessRecord_CloudClusterNodesInstanceProperties();
                        break;
                    case "CloudClusterRecoveryValidation":
                        this.ProcessRecord_CloudClusterRecoveryValidation();
                        break;
                    case "CloudDirectClusterEndpoints":
                        this.ProcessRecord_CloudDirectClusterEndpoints();
                        break;
                    case "CloudDirectClusterLambdaConfig":
                        this.ProcessRecord_CloudDirectClusterLambdaConfig();
                        break;
                    case "Cluster":
                        this.ProcessRecord_Cluster();
                        break;
                    case "ClusterList":
                        this.ProcessRecord_ClusterList();
                        break;
                    case "ComputeClusterStatus":
                        this.ProcessRecord_ComputeClusterStatus();
                        break;
                    case "Connected":
                        this.ProcessRecord_Connected();
                        break;
                    case "Count":
                        this.ProcessRecord_Count();
                        break;
                    case "DefaultGateway":
                        this.ProcessRecord_DefaultGateway();
                        break;
                    case "Dns":
                        this.ProcessRecord_Dns();
                        break;
                    case "EncryptionInfo":
                        this.ProcessRecord_EncryptionInfo();
                        break;
                    case "ExocomputeGetClusterConnectionInfo":
                        this.ProcessRecord_ExocomputeGetClusterConnectionInfo();
                        break;
                    case "FloatingIps":
                        this.ProcessRecord_FloatingIps();
                        break;
                    case "GetCdmReleaseDetailsForClusterFromSupportPortal":
                        this.ProcessRecord_GetCdmReleaseDetailsForClusterFromSupportPortal();
                        break;
                    case "GetGroupCountByCdmClusterStatus":
                        this.ProcessRecord_GetGroupCountByCdmClusterStatus();
                        break;
                    case "GroupByList":
                        this.ProcessRecord_GroupByList();
                        break;
                    case "Ipmi":
                        this.ProcessRecord_Ipmi();
                        break;
                    case "Ipv6Mode":
                        this.ProcessRecord_Ipv6Mode();
                        break;
                    case "IsCloudClusterDiskUpgradeAvailable":
                        this.ProcessRecord_IsCloudClusterDiskUpgradeAvailable();
                        break;
                    case "IsRemoveClusterTprConfigured":
                        this.ProcessRecord_IsRemoveClusterTprConfigured();
                        break;
                    case "IsTotpAckNecessary":
                        this.ProcessRecord_IsTotpAckNecessary();
                        break;
                    case "LicensesForClusterProductSummary":
                        this.ProcessRecord_LicensesForClusterProductSummary();
                        break;
                    case "List":
                        this.ProcessRecord_List();
                        break;
                    case "Missing":
                        this.ProcessRecord_Missing();
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
                    case "RadarClusterList":
                        this.ProcessRecord_RadarClusterList();
                        break;
                    case "RegistrationProductInfo":
                        this.ProcessRecord_RegistrationProductInfo();
                        break;
                    case "ReplicationTargets":
                        this.ProcessRecord_ReplicationTargets();
                        break;
                    case "Routes":
                        this.ProcessRecord_Routes();
                        break;
                    case "TotpAckStatus":
                        this.ProcessRecord_TotpAckStatus();
                        break;
                    case "TypeList":
                        this.ProcessRecord_TypeList();
                        break;
                    case "ValidateClusterLicenseCapacity":
                        this.ProcessRecord_ValidateClusterLicenseCapacity();
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
        // canIgnoreClusterRemovalPrechecks.
        internal void ProcessRecord_CanIgnoreClusterRemovalPrechecks()
        {
            this._logger.name += " -CanIgnoreClusterRemovalPrechecks";
            // Create new graphql operation canIgnoreClusterRemovalPrechecks
            InitQueryCanIgnoreClusterRemovalPrechecks();
        }

        // This parameter set invokes a single graphql operation:
        // cloudClusterInstanceProperties.
        internal void ProcessRecord_CloudClusterInstanceProperties()
        {
            this._logger.name += " -CloudClusterInstanceProperties";
            // Create new graphql operation cloudClusterInstanceProperties
            InitQueryCloudClusterInstanceProperties();
        }

        // This parameter set invokes a single graphql operation:
        // cloudClusterNodesInstanceProperties.
        internal void ProcessRecord_CloudClusterNodesInstanceProperties()
        {
            this._logger.name += " -CloudClusterNodesInstanceProperties";
            // Create new graphql operation cloudClusterNodesInstanceProperties
            InitQueryCloudClusterNodesInstanceProperties();
        }

        // This parameter set invokes a single graphql operation:
        // cloudClusterRecoveryValidation.
        internal void ProcessRecord_CloudClusterRecoveryValidation()
        {
            this._logger.name += " -CloudClusterRecoveryValidation";
            // Create new graphql operation cloudClusterRecoveryValidation
            InitQueryCloudClusterRecoveryValidation();
        }

        // This parameter set invokes a single graphql operation:
        // cloudDirectClusterEndpoints.
        internal void ProcessRecord_CloudDirectClusterEndpoints()
        {
            this._logger.name += " -CloudDirectClusterEndpoints";
            // Create new graphql operation cloudDirectClusterEndpoints
            InitQueryCloudDirectClusterEndpoints();
        }

        // This parameter set invokes a single graphql operation:
        // cloudDirectClusterLambdaConfig.
        internal void ProcessRecord_CloudDirectClusterLambdaConfig()
        {
            this._logger.name += " -CloudDirectClusterLambdaConfig";
            // Create new graphql operation cloudDirectClusterLambdaConfig
            InitQueryCloudDirectClusterLambdaConfig();
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
        // allClusterConnection.
        internal void ProcessRecord_ClusterList()
        {
            this._logger.name += " -ClusterList";
            // Create new graphql operation allClusterConnection
            InitQueryAllClusterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // computeClusterStatus.
        internal void ProcessRecord_ComputeClusterStatus()
        {
            this._logger.name += " -ComputeClusterStatus";
            // Create new graphql operation computeClusterStatus
            InitQueryComputeClusterStatus();
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
        // countClusters.
        internal void ProcessRecord_Count()
        {
            this._logger.name += " -Count";
            // Create new graphql operation countClusters
            InitQueryCountClusters();
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
        // clusterEncryptionInfo.
        internal void ProcessRecord_EncryptionInfo()
        {
            this._logger.name += " -EncryptionInfo";
            // Create new graphql operation clusterEncryptionInfo
            InitQueryClusterEncryptionInfo();
        }

        // This parameter set invokes a single graphql operation:
        // exocomputeGetClusterConnectionInfo.
        internal void ProcessRecord_ExocomputeGetClusterConnectionInfo()
        {
            this._logger.name += " -ExocomputeGetClusterConnectionInfo";
            // Create new graphql operation exocomputeGetClusterConnectionInfo
            InitQueryExocomputeGetClusterConnectionInfo();
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
        // getCdmReleaseDetailsForClusterFromSupportPortal.
        internal void ProcessRecord_GetCdmReleaseDetailsForClusterFromSupportPortal()
        {
            this._logger.name += " -GetCdmReleaseDetailsForClusterFromSupportPortal";
            // Create new graphql operation getCdmReleaseDetailsForClusterFromSupportPortal
            InitQueryGetCdmReleaseDetailsForClusterFromSupportPortal();
        }

        // This parameter set invokes a single graphql operation:
        // getGroupCountByCdmClusterStatus.
        internal void ProcessRecord_GetGroupCountByCdmClusterStatus()
        {
            this._logger.name += " -GetGroupCountByCdmClusterStatus";
            // Create new graphql operation getGroupCountByCdmClusterStatus
            InitQueryGetGroupCountByCdmClusterStatus();
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
        // isCloudClusterDiskUpgradeAvailable.
        internal void ProcessRecord_IsCloudClusterDiskUpgradeAvailable()
        {
            this._logger.name += " -IsCloudClusterDiskUpgradeAvailable";
            // Create new graphql operation isCloudClusterDiskUpgradeAvailable
            InitQueryIsCloudClusterDiskUpgradeAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // isRemoveClusterTprConfigured.
        internal void ProcessRecord_IsRemoveClusterTprConfigured()
        {
            this._logger.name += " -IsRemoveClusterTprConfigured";
            // Create new graphql operation isRemoveClusterTprConfigured
            InitQueryIsRemoveClusterTprConfigured();
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
        // licensesForClusterProductSummary.
        internal void ProcessRecord_LicensesForClusterProductSummary()
        {
            this._logger.name += " -LicensesForClusterProductSummary";
            // Create new graphql operation licensesForClusterProductSummary
            InitQueryLicensesForClusterProductSummary();
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
        // allMissingClusters.
        internal void ProcessRecord_Missing()
        {
            this._logger.name += " -Missing";
            // Create new graphql operation allMissingClusters
            InitQueryAllMissingClusters();
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
        // radarClusterConnection.
        internal void ProcessRecord_RadarClusterList()
        {
            this._logger.name += " -RadarClusterList";
            // Create new graphql operation radarClusterConnection
            InitQueryRadarClusterConnection();
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
        // clusterRoutes.
        internal void ProcessRecord_Routes()
        {
            this._logger.name += " -Routes";
            // Create new graphql operation clusterRoutes
            InitQueryClusterRoutes();
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
        // validateClusterLicenseCapacity.
        internal void ProcessRecord_ValidateClusterLicenseCapacity()
        {
            this._logger.name += " -ValidateClusterLicenseCapacity";
            // Create new graphql operation validateClusterLicenseCapacity
            InitQueryValidateClusterLicenseCapacity();
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
        // canIgnoreClusterRemovalPrechecks(clusterUuid: UUID!): IgnoreClusterRemovalPrecheckReply!
        internal void InitQueryCanIgnoreClusterRemovalPrechecks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCanIgnoreClusterRemovalPrechecks",
                "($clusterUuid: UUID!)",
                "IgnoreClusterRemovalPrecheckReply",
                Query.CanIgnoreClusterRemovalPrechecks,
                Query.CanIgnoreClusterRemovalPrechecksFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // cloudClusterInstanceProperties(input: InstancePropertiesReq!): InstancePropertiesReply!
        internal void InitQueryCloudClusterInstanceProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstancePropertiesReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudClusterInstanceProperties",
                "($input: InstancePropertiesReq!)",
                "InstancePropertiesReply",
                Query.CloudClusterInstanceProperties,
                Query.CloudClusterInstancePropertiesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	vendor = $someVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VendorType]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // cloudClusterNodesInstanceProperties(input: ClusterNodesInstancePropertiesReq!): ClusterNodesInstancePropertiesReply!
        internal void InitQueryCloudClusterNodesInstanceProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterNodesInstancePropertiesReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudClusterNodesInstanceProperties",
                "($input: ClusterNodesInstancePropertiesReq!)",
                "ClusterNodesInstancePropertiesReply",
                Query.CloudClusterNodesInstanceProperties,
                Query.CloudClusterNodesInstancePropertiesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	vendor = $someVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VendorType]) for enum values.
	# OPTIONAL
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // cloudClusterRecoveryValidation(clusterUuid: String!): ValidationRecoveryReply!
        internal void InitQueryCloudClusterRecoveryValidation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudClusterRecoveryValidation",
                "($clusterUuid: String!)",
                "ValidationRecoveryReply",
                Query.CloudClusterRecoveryValidation,
                Query.CloudClusterRecoveryValidationFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // cloudDirectClusterEndpoints(clusterUuid: UUID!): ClusterEndpoints!
        internal void InitQueryCloudDirectClusterEndpoints()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudDirectClusterEndpoints",
                "($clusterUuid: UUID!)",
                "ClusterEndpoints",
                Query.CloudDirectClusterEndpoints,
                Query.CloudDirectClusterEndpointsFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // cloudDirectClusterLambdaConfig(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: ClusterFilterInput
        //     sortOrder: SortOrder = DESC
        //     sortBy: ClusterSortByEnum = ClusterType
        //   ): ThreatHuntCloudDirectClusterConnection!
        internal void InitQueryCloudDirectClusterLambdaConfig()
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
                "QueryCloudDirectClusterLambdaConfig",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: ClusterFilterInput,$sortOrder: SortOrder,$sortBy: ClusterSortByEnum)",
                "ThreatHuntCloudDirectClusterConnection",
                Query.CloudDirectClusterLambdaConfig,
                Query.CloudDirectClusterLambdaConfigFieldSpec,
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
	# OPTIONAL
	cyberEventLockdownMode = @(
		$someClusterCyberEventLockdownMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCyberEventLockdownMode]) for enum values.
	)
}
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someClusterSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSortByEnum]) for enum values."
            );
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
                Query.Cluster,
                Query.ClusterFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // allClusterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: ClusterFilterInput
        //     sortOrder: SortOrder = DESC
        //     sortBy: ClusterSortByEnum = ClusterType
        //   ): ClusterConnection!
        internal void InitQueryAllClusterConnection()
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
                "QueryAllClusterConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: ClusterFilterInput,$sortOrder: SortOrder,$sortBy: ClusterSortByEnum)",
                "ClusterConnection",
                Query.AllClusterConnection,
                Query.AllClusterConnectionFieldSpec,
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
	# OPTIONAL
	cyberEventLockdownMode = @(
		$someClusterCyberEventLockdownMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCyberEventLockdownMode]) for enum values.
	)
}
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someClusterSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSortByEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // computeClusterStatus(input: GetComputeClusterInput!): ComputeClusterDetail!
        internal void InitQueryComputeClusterStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetComputeClusterInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryComputeClusterStatus",
                "($input: GetComputeClusterInput!)",
                "ComputeClusterDetail",
                Query.ComputeClusterStatus,
                Query.ComputeClusterStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
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
                Query.AllConnectedClusters,
                Query.AllConnectedClustersFieldSpec,
                @"# OPTIONAL
$query.Var.clusterFilterArg = $someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // countClusters(filter: ClusterFilterInput): CountClustersReply!
        internal void InitQueryCountClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "ClusterFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCountClusters",
                "($filter: ClusterFilterInput)",
                "CountClustersReply",
                Query.CountClusters,
                Query.CountClustersFieldSpec,
                @"# OPTIONAL
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
	# OPTIONAL
	cyberEventLockdownMode = @(
		$someClusterCyberEventLockdownMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCyberEventLockdownMode]) for enum values.
	)
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
                Query.ClusterDefaultGateway,
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
                Query.ClusterDns,
                Query.ClusterDnsFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterEncryptionInfo(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     clusterName: String
        //     encryptionStatusFilter: [ClusterEncryptionStatusFilter!]! = []
        //     keyProtection: [ClusterKeyProtection!]! = []
        //     clusters: [UUID!]! = []
        //     encryptionTypes: [ClusterEncryptionType!]! = []
        //   ): ClusterEncryptionInfoConnection!
        internal void InitQueryClusterEncryptionInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("clusterName", "String"),
                Tuple.Create("encryptionStatusFilter", "[ClusterEncryptionStatusFilter!]!"),
                Tuple.Create("keyProtection", "[ClusterKeyProtection!]!"),
                Tuple.Create("clusters", "[UUID!]!"),
                Tuple.Create("encryptionTypes", "[ClusterEncryptionType!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterEncryptionInfo",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$clusterName: String,$encryptionStatusFilter: [ClusterEncryptionStatusFilter!]!,$keyProtection: [ClusterKeyProtection!]!,$clusters: [UUID!]!,$encryptionTypes: [ClusterEncryptionType!]!)",
                "ClusterEncryptionInfoConnection",
                Query.ClusterEncryptionInfo,
                Query.ClusterEncryptionInfoFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.clusterName = $someString
# REQUIRED
$query.Var.encryptionStatusFilter = @(
	$someClusterEncryptionStatusFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterEncryptionStatusFilter]) for enum values.
)
# REQUIRED
$query.Var.keyProtection = @(
	$someClusterKeyProtection # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterKeyProtection]) for enum values.
)
# REQUIRED
$query.Var.clusters = @(
	$someString
)
# REQUIRED
$query.Var.encryptionTypes = @(
	$someClusterEncryptionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterEncryptionType]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // exocomputeGetClusterConnectionInfo(input: ExocomputeGetClusterConnectionInput!): ExocomputeGetClusterConnectionInfoReply!
        internal void InitQueryExocomputeGetClusterConnectionInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExocomputeGetClusterConnectionInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryExocomputeGetClusterConnectionInfo",
                "($input: ExocomputeGetClusterConnectionInput!)",
                "ExocomputeGetClusterConnectionInfoReply",
                Query.ExocomputeGetClusterConnectionInfo,
                Query.ExocomputeGetClusterConnectionInfoFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterName = $someString
	# REQUIRED
	exocomputeConfigId = $someString
	# REQUIRED
	cloudType = $someCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudType]) for enum values.
}"
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
                Query.ClusterFloatingIps,
                Query.ClusterFloatingIpsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // getCdmReleaseDetailsForClusterFromSupportPortal(
        //     listClusterUuid: [UUID!]!
        //     filterVersion: String! = ""
        //     fetchLinks: Boolean! = false
        //     filterUpgradeable: Boolean! = true
        //     shouldShowAll: Boolean! = true
        //     filterAfterSource: Boolean! = false
        //     sortOrder: SortOrder = DESC
        //   ): CdmUpgradeReleaseDetailsFromSupportPortalReply!
        internal void InitQueryGetCdmReleaseDetailsForClusterFromSupportPortal()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("listClusterUuid", "[UUID!]!"),
                Tuple.Create("filterVersion", "String!"),
                Tuple.Create("fetchLinks", "Boolean!"),
                Tuple.Create("filterUpgradeable", "Boolean!"),
                Tuple.Create("shouldShowAll", "Boolean!"),
                Tuple.Create("filterAfterSource", "Boolean!"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGetCdmReleaseDetailsForClusterFromSupportPortal",
                "($listClusterUuid: [UUID!]!,$filterVersion: String!,$fetchLinks: Boolean!,$filterUpgradeable: Boolean!,$shouldShowAll: Boolean!,$filterAfterSource: Boolean!,$sortOrder: SortOrder)",
                "CdmUpgradeReleaseDetailsFromSupportPortalReply",
                Query.GetCdmReleaseDetailsForClusterFromSupportPortal,
                Query.GetCdmReleaseDetailsForClusterFromSupportPortalFieldSpec,
                @"# REQUIRED
$query.Var.listClusterUuid = @(
	$someString
)
# REQUIRED
$query.Var.filterVersion = $someString
# REQUIRED
$query.Var.fetchLinks = $someBoolean
# REQUIRED
$query.Var.filterUpgradeable = $someBoolean
# REQUIRED
$query.Var.shouldShowAll = $someBoolean
# REQUIRED
$query.Var.filterAfterSource = $someBoolean
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // getGroupCountByCdmClusterStatus: GroupCountListWithTotal!
        internal void InitQueryGetGroupCountByCdmClusterStatus()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryGetGroupCountByCdmClusterStatus",
                "",
                "GroupCountListWithTotal",
                Query.GetGroupCountByCdmClusterStatus,
                Query.GetGroupCountByCdmClusterStatusFieldSpec,
                @""
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
                Query.ClusterGroupByConnection,
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
	# OPTIONAL
	cyberEventLockdownMode = @(
		$someClusterCyberEventLockdownMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCyberEventLockdownMode]) for enum values.
	)
}
# OPTIONAL
$query.Var.timezoneOffset = $someSingle"
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
                Query.ClusterIpmi,
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
                Query.ClusterIpv6Mode,
                Query.ClusterIpv6ModeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // isCloudClusterDiskUpgradeAvailable(input: IsCloudClusterDiskUpgradeAvailableInput!): IsCloudClusterDiskUpgradeAvailableReply!
        internal void InitQueryIsCloudClusterDiskUpgradeAvailable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "IsCloudClusterDiskUpgradeAvailableInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsCloudClusterDiskUpgradeAvailable",
                "($input: IsCloudClusterDiskUpgradeAvailableInput!)",
                "IsCloudClusterDiskUpgradeAvailableReply",
                Query.IsCloudClusterDiskUpgradeAvailable,
                Query.IsCloudClusterDiskUpgradeAvailableFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	vendor = $someCcpVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpVendorType]) for enum values.
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	batchSize = $someInt
	# OPTIONAL
	newNodeCount = $someInt
	# OPTIONAL
	newInstanceType = $someInt
}"
            );
        }

        // Create new GraphQL Query:
        // isRemoveClusterTprConfigured(clusterUuid: UUID!): Boolean!
        internal void InitQueryIsRemoveClusterTprConfigured()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsRemoveClusterTprConfigured",
                "($clusterUuid: UUID!)",
                "System.Boolean",
                Query.IsRemoveClusterTprConfigured,
                Query.IsRemoveClusterTprConfiguredFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
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
                Query.IsTotpAckNecessaryForCluster,
                Query.IsTotpAckNecessaryForClusterFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // licensesForClusterProductSummary(input: LicensesForClusterProductSummaryInput!): LicensesForClusterProductReply!
        internal void InitQueryLicensesForClusterProductSummary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "LicensesForClusterProductSummaryInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryLicensesForClusterProductSummary",
                "($input: LicensesForClusterProductSummaryInput!)",
                "LicensesForClusterProductReply",
                Query.LicensesForClusterProductSummary,
                Query.LicensesForClusterProductSummaryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	product = $someProduct # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Product]) for enum values.
}"
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
                Query.ClusterConnection,
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
	# OPTIONAL
	cyberEventLockdownMode = @(
		$someClusterCyberEventLockdownMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCyberEventLockdownMode]) for enum values.
	)
}
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someClusterSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSortByEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allMissingClusters(connectionStatus: MissingClusterConnectionStatus, isExcluded: Boolean): MissingClusterConnection!
        internal void InitQueryAllMissingClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("connectionStatus", "MissingClusterConnectionStatus"),
                Tuple.Create("isExcluded", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllMissingClusters",
                "($connectionStatus: MissingClusterConnectionStatus,$isExcluded: Boolean)",
                "MissingClusterConnection",
                Query.AllMissingClusters,
                Query.AllMissingClustersFieldSpec,
                @"# OPTIONAL
$query.Var.connectionStatus = $someMissingClusterConnectionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MissingClusterConnectionStatus]) for enum values.
# OPTIONAL
$query.Var.isExcluded = $someBoolean"
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
                Query.ClusterNetworkInterfaces,
                Query.ClusterNetworkInterfacesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	interface = $someString
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
                Query.ClusterNodes,
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
                Query.ClusterNtpServers,
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
                Query.ClusterOperationJobProgress,
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
                Query.ClusterProxy,
                Query.ClusterProxyFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // radarClusterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: ClusterFilterInput
        //     sortOrder: SortOrder = DESC
        //     sortBy: ClusterSortByEnum = ClusterType
        //   ): ClusterConnection!
        internal void InitQueryRadarClusterConnection()
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
                "QueryRadarClusterConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: ClusterFilterInput,$sortOrder: SortOrder,$sortBy: ClusterSortByEnum)",
                "ClusterConnection",
                Query.RadarClusterConnection,
                Query.RadarClusterConnectionFieldSpec,
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
	# OPTIONAL
	cyberEventLockdownMode = @(
		$someClusterCyberEventLockdownMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCyberEventLockdownMode]) for enum values.
	)
}
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someClusterSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSortByEnum]) for enum values."
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
                Query.ClusterRegistrationProductInfo,
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
                Query.AllClusterReplicationTargets,
                Query.AllClusterReplicationTargetsFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterRoutes(clusterUuid: UUID!): ClusterRoutesReply!
        internal void InitQueryClusterRoutes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterRoutes",
                "($clusterUuid: UUID!)",
                "ClusterRoutesReply",
                Query.ClusterRoutes,
                Query.ClusterRoutesFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
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
                Query.AllClustersTotpAckStatus,
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
                Query.ClusterTypeList,
                Query.ClusterTypeListFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // validateClusterLicenseCapacity(input: ValidateClusterLicenseCapacityInput!): ClusterLicenseCapacityValidations!
        internal void InitQueryValidateClusterLicenseCapacity()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateClusterLicenseCapacityInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateClusterLicenseCapacity",
                "($input: ValidateClusterLicenseCapacityInput!)",
                "ClusterLicenseCapacityValidations",
                Query.ValidateClusterLicenseCapacity,
                Query.ValidateClusterLicenseCapacityFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	nodes = @(
		@{
			# OPTIONAL
			id = $someString
			# OPTIONAL
			manufactureTime = $someDateTime
			# OPTIONAL
			serial = $someString
			# OPTIONAL
			systemUuid = $someString
			# OPTIONAL
			teleportToken = $someString
			# OPTIONAL
			clusterUuid = $someString
			# OPTIONAL
			platform = $someString
			# OPTIONAL
			capacity = $someString
			# OPTIONAL
			isEntitled = $someBoolean
			# OPTIONAL
			version = $someString
		}
	)
	# REQUIRED
	managedByRubrik = $someManagedByRubrik # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedByRubrik]) for enum values.
}"
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
                Query.ClusterVlans,
                Query.ClusterVlansFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	vlan = $someInt
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
                Query.AllClusterWebCertsAndIpmis,
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
                Query.WindowsCluster,
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
                Query.ClusterWithUpgradesInfo,
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
	# OPTIONAL
	upgradeStatusCategory = @(
		$someString
	)
	# OPTIONAL
	eosStatus = @(
		$someClusterEosStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterEosStatus]) for enum values.
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