// New-RscQueryVcenter.cs
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
    /// operations in the 'VMware vSphere vCenter' API domain:
    /// AdvancedTagPreview, AsyncRequestStatus, ConnectivityStatus, HotAddBandwidth, HotAddNetwork, HotAddProxy, HotAddProxyVmsV2, List, MissingPrivilegeSummary, MissingPrivileges, MissingPrivilegesV2, Networks, NumProxiesNeeded, PreAddInfo, RequiredPrivileges, UniqueCount, or Vcenter.
    /// </summary>
    /// <description>
    /// New-RscQueryVcenter creates a new
    /// query object for operations
    /// in the 'VMware vSphere vCenter' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 17 operations
    /// in the 'VMware vSphere vCenter' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AdvancedTagPreview, AsyncRequestStatus, ConnectivityStatus, HotAddBandwidth, HotAddNetwork, HotAddProxy, HotAddProxyVmsV2, List, MissingPrivilegeSummary, MissingPrivileges, MissingPrivilegesV2, Networks, NumProxiesNeeded, PreAddInfo, RequiredPrivileges, UniqueCount, or Vcenter.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryVcenter -AdvancedTagPreview).Info().
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
    /// (New-RscQueryVcenter -AdvancedTagPreview).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AdvancedTagPreview operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: AdvancedTagPreview
    /// 
    /// $query = New-RscQueryVcenter -AdvancedTagPreview
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	limit = $someInt
    /// 	# OPTIONAL
    /// 	offset = $someInt
    /// 	# REQUIRED
    /// 	filterCondition = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VcenterAdvancedTagPreviewReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AsyncRequestStatus operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: AsyncRequestStatus
    /// 
    /// $query = New-RscQueryVcenter -AsyncRequestStatus
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
    /// Runs the ConnectivityStatus operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: ConnectivityStatus
    /// 
    /// $query = New-RscQueryVcenter -ConnectivityStatus
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
    /// Write-Host $result.GetType().Name # prints: VcenterConnectivityStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HotAddBandwidth operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: HotAddBandwidth
    /// 
    /// $query = New-RscQueryVcenter -HotAddBandwidth
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
    /// Write-Host $result.GetType().Name # prints: HotAddBandwidthInfo
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HotAddNetwork operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: HotAddNetwork
    /// 
    /// $query = New-RscQueryVcenter -HotAddNetwork
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
    /// Write-Host $result.GetType().Name # prints: HotAddNetworkConfigWithName
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HotAddProxy operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: HotAddProxy
    /// 
    /// $query = New-RscQueryVcenter -HotAddProxy
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;VcenterHotAddProxyVmInfo&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HotAddProxyVmsV2 operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: HotAddProxyVmsV2
    /// 
    /// $query = New-RscQueryVcenter -HotAddProxyVmsV2
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someVcenterProxyVmsFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterProxyVmsFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # REQUIRED
    /// $query.Var.clusterUuids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereProxyVmInfoConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the List operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: List
    /// 
    /// $query = New-RscQueryVcenter -List
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
    /// Write-Host $result.GetType().Name # prints: VsphereVcenterConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MissingPrivilegeSummary operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: MissingPrivilegeSummary
    /// 
    /// $query = New-RscQueryVcenter -MissingPrivilegeSummary
    /// 
    /// # REQUIRED
    /// $query.Var.vcenterId = $someString
    /// # REQUIRED
    /// $query.Var.jobId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;VcenterEntitySummary&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MissingPrivileges operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: MissingPrivileges
    /// 
    /// $query = New-RscQueryVcenter -MissingPrivileges
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	limit = $someInt
    /// 	# OPTIONAL
    /// 	offset = $someInt
    /// 	# REQUIRED
    /// 	entityType = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MissingEntityPrivilegesList
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MissingPrivilegesV2 operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: MissingPrivilegesV2
    /// 
    /// $query = New-RscQueryVcenter -MissingPrivilegesV2
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.vcenterId = $someString
    /// # REQUIRED
    /// $query.Var.jobId = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someVcenterMissingPrivilegeFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterMissingPrivilegeFilterField]) for enum values.
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
    /// Write-Host $result.GetType().Name # prints: VcenterEntityConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Networks operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: Networks
    /// 
    /// $query = New-RscQueryVcenter -Networks
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
    /// Write-Host $result.GetType().Name # prints: NetworkInfoListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NumProxiesNeeded operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: NumProxiesNeeded
    /// 
    /// $query = New-RscQueryVcenter -NumProxiesNeeded
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
    /// Write-Host $result.GetType().Name # prints: System.Int32
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PreAddInfo operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: PreAddInfo
    /// 
    /// $query = New-RscQueryVcenter -PreAddInfo
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	vcenterConfig = @{
    /// 		# OPTIONAL
    /// 		id = $someString
    /// 		# OPTIONAL
    /// 		connectionConfig = @{
    /// 			# OPTIONAL
    /// 			caCerts = $someString
    /// 			# REQUIRED
    /// 			hostname = $someString
    /// 			# REQUIRED
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VcenterPreAddInfo
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RequiredPrivileges operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: RequiredPrivileges
    /// 
    /// $query = New-RscQueryVcenter -RequiredPrivileges
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
    /// Write-Host $result.GetType().Name # prints: RequiredEntityPrivilegeListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UniqueCount operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: UniqueCount
    /// 
    /// $query = New-RscQueryVcenter -UniqueCount
    /// 
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
    /// Write-Host $result.GetType().Name # prints: System.Int32
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Vcenter operation
    /// of the 'VMware vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vcenter
    /// # API Operation: Vcenter
    /// 
    /// $query = New-RscQueryVcenter -Vcenter
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereVcenter
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
        "RscQueryVcenter",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryVcenter : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AdvancedTagPreview",
                "AsyncRequestStatus",
                "ConnectivityStatus",
                "HotAddBandwidth",
                "HotAddNetwork",
                "HotAddProxy",
                "HotAddProxyVmsV2",
                "List",
                "MissingPrivilegeSummary",
                "MissingPrivileges",
                "MissingPrivilegesV2",
                "Networks",
                "NumProxiesNeeded",
                "PreAddInfo",
                "RequiredPrivileges",
                "UniqueCount",
                "Vcenter",
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
                    case "AdvancedTagPreview":
                        this.ProcessRecord_AdvancedTagPreview();
                        break;
                    case "AsyncRequestStatus":
                        this.ProcessRecord_AsyncRequestStatus();
                        break;
                    case "ConnectivityStatus":
                        this.ProcessRecord_ConnectivityStatus();
                        break;
                    case "HotAddBandwidth":
                        this.ProcessRecord_HotAddBandwidth();
                        break;
                    case "HotAddNetwork":
                        this.ProcessRecord_HotAddNetwork();
                        break;
                    case "HotAddProxy":
                        this.ProcessRecord_HotAddProxy();
                        break;
                    case "HotAddProxyVmsV2":
                        this.ProcessRecord_HotAddProxyVmsV2();
                        break;
                    case "List":
                        this.ProcessRecord_List();
                        break;
                    case "MissingPrivilegeSummary":
                        this.ProcessRecord_MissingPrivilegeSummary();
                        break;
                    case "MissingPrivileges":
                        this.ProcessRecord_MissingPrivileges();
                        break;
                    case "MissingPrivilegesV2":
                        this.ProcessRecord_MissingPrivilegesV2();
                        break;
                    case "Networks":
                        this.ProcessRecord_Networks();
                        break;
                    case "NumProxiesNeeded":
                        this.ProcessRecord_NumProxiesNeeded();
                        break;
                    case "PreAddInfo":
                        this.ProcessRecord_PreAddInfo();
                        break;
                    case "RequiredPrivileges":
                        this.ProcessRecord_RequiredPrivileges();
                        break;
                    case "UniqueCount":
                        this.ProcessRecord_UniqueCount();
                        break;
                    case "Vcenter":
                        this.ProcessRecord_Vcenter();
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
        // vCenterAdvancedTagPreview.
        internal void ProcessRecord_AdvancedTagPreview()
        {
            this._logger.name += " -AdvancedTagPreview";
            // Create new graphql operation vCenterAdvancedTagPreview
            InitQueryVcenterAdvancedTagPreview();
        }

        // This parameter set invokes a single graphql operation:
        // vcenterAsyncRequestStatus.
        internal void ProcessRecord_AsyncRequestStatus()
        {
            this._logger.name += " -AsyncRequestStatus";
            // Create new graphql operation vcenterAsyncRequestStatus
            InitQueryVcenterAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterConnectivityStatus.
        internal void ProcessRecord_ConnectivityStatus()
        {
            this._logger.name += " -ConnectivityStatus";
            // Create new graphql operation vCenterConnectivityStatus
            InitQueryVcenterConnectivityStatus();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterHotAddBandwidth.
        internal void ProcessRecord_HotAddBandwidth()
        {
            this._logger.name += " -HotAddBandwidth";
            // Create new graphql operation vCenterHotAddBandwidth
            InitQueryVcenterHotAddBandwidth();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterHotAddNetwork.
        internal void ProcessRecord_HotAddNetwork()
        {
            this._logger.name += " -HotAddNetwork";
            // Create new graphql operation vCenterHotAddNetwork
            InitQueryVcenterHotAddNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // allVcenterHotAddProxyVms.
        internal void ProcessRecord_HotAddProxy()
        {
            this._logger.name += " -HotAddProxy";
            // Create new graphql operation allVcenterHotAddProxyVms
            InitQueryAllVcenterHotAddProxyVms();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterHotAddProxyVmsV2.
        internal void ProcessRecord_HotAddProxyVmsV2()
        {
            this._logger.name += " -HotAddProxyVmsV2";
            // Create new graphql operation vCenterHotAddProxyVmsV2
            InitQueryVcenterHotAddProxyVmsV2();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVCenterConnection.
        internal void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Create new graphql operation vSphereVCenterConnection
            InitQueryVsphereVcenterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // allVcenterMissingPrivilegeSummary.
        internal void ProcessRecord_MissingPrivilegeSummary()
        {
            this._logger.name += " -MissingPrivilegeSummary";
            // Create new graphql operation allVcenterMissingPrivilegeSummary
            InitQueryAllVcenterMissingPrivilegeSummary();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterMissingPrivileges.
        internal void ProcessRecord_MissingPrivileges()
        {
            this._logger.name += " -MissingPrivileges";
            // Create new graphql operation vCenterMissingPrivileges
            InitQueryVcenterMissingPrivileges();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterMissingPrivilegesV2.
        internal void ProcessRecord_MissingPrivilegesV2()
        {
            this._logger.name += " -MissingPrivilegesV2";
            // Create new graphql operation vCenterMissingPrivilegesV2
            InitQueryVcenterMissingPrivilegesV2();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterNetworks.
        internal void ProcessRecord_Networks()
        {
            this._logger.name += " -Networks";
            // Create new graphql operation vCenterNetworks
            InitQueryVcenterNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterNumProxiesNeeded.
        internal void ProcessRecord_NumProxiesNeeded()
        {
            this._logger.name += " -NumProxiesNeeded";
            // Create new graphql operation vCenterNumProxiesNeeded
            InitQueryVcenterNumProxiesNeeded();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterPreAddInfo.
        internal void ProcessRecord_PreAddInfo()
        {
            this._logger.name += " -PreAddInfo";
            // Create new graphql operation vCenterPreAddInfo
            InitQueryVcenterPreAddInfo();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterRequiredPrivileges.
        internal void ProcessRecord_RequiredPrivileges()
        {
            this._logger.name += " -RequiredPrivileges";
            // Create new graphql operation vCenterRequiredPrivileges
            InitQueryVcenterRequiredPrivileges();
        }

        // This parameter set invokes a single graphql operation:
        // uniqueVSphereVCenterCount.
        internal void ProcessRecord_UniqueCount()
        {
            this._logger.name += " -UniqueCount";
            // Create new graphql operation uniqueVSphereVCenterCount
            InitQueryUniqueVsphereVcenterCount();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVCenter.
        internal void ProcessRecord_Vcenter()
        {
            this._logger.name += " -Vcenter";
            // Create new graphql operation vSphereVCenter
            InitQueryVsphereVcenter();
        }


        // Create new GraphQL Query:
        // vCenterAdvancedTagPreview(input: PreviewFilterInput!): VcenterAdvancedTagPreviewReply!
        internal void InitQueryVcenterAdvancedTagPreview()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PreviewFilterInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterAdvancedTagPreview",
                "($input: PreviewFilterInput!)",
                "VcenterAdvancedTagPreviewReply",
                Query.VcenterAdvancedTagPreview,
                Query.VcenterAdvancedTagPreviewFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	limit = $someInt
	# OPTIONAL
	offset = $someInt
	# REQUIRED
	filterCondition = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // vcenterAsyncRequestStatus(input: VcenterAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InitQueryVcenterAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VcenterAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterAsyncRequestStatus",
                "($input: VcenterAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.VcenterAsyncRequestStatus,
                Query.VcenterAsyncRequestStatusFieldSpec,
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
        // vCenterConnectivityStatus(input: VcenterConnectivityStatusInput!): VcenterConnectivityStatus!
        internal void InitQueryVcenterConnectivityStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VcenterConnectivityStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterConnectivityStatus",
                "($input: VcenterConnectivityStatusInput!)",
                "VcenterConnectivityStatus",
                Query.VcenterConnectivityStatus,
                Query.VcenterConnectivityStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // vCenterHotAddBandwidth(input: GetHotAddBandwidthInput!): HotAddBandwidthInfo!
        internal void InitQueryVcenterHotAddBandwidth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHotAddBandwidthInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterHotAddBandwidth",
                "($input: GetHotAddBandwidthInput!)",
                "HotAddBandwidthInfo",
                Query.VcenterHotAddBandwidth,
                Query.VcenterHotAddBandwidthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // vCenterHotAddNetwork(input: GetHotAddNetworkInput!): HotAddNetworkConfigWithName!
        internal void InitQueryVcenterHotAddNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHotAddNetworkInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterHotAddNetwork",
                "($input: GetHotAddNetworkInput!)",
                "HotAddNetworkConfigWithName",
                Query.VcenterHotAddNetwork,
                Query.VcenterHotAddNetworkFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allVcenterHotAddProxyVms(clusterUuids: [UUID!]!): [VcenterHotAddProxyVmInfo!]!
        internal void InitQueryAllVcenterHotAddProxyVms()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllVcenterHotAddProxyVms",
                "($clusterUuids: [UUID!]!)",
                "List<VcenterHotAddProxyVmInfo>",
                Query.AllVcenterHotAddProxyVms,
                Query.AllVcenterHotAddProxyVmsFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // vCenterHotAddProxyVmsV2(
        //     first: Int
        //     after: String
        //     filter: [VcenterProxyVmsFilterInput!]
        //     clusterUuids: [UUID!]!
        //   ): VsphereProxyVmInfoConnection!
        internal void InitQueryVcenterHotAddProxyVmsV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filter", "[VcenterProxyVmsFilterInput!]"),
                Tuple.Create("clusterUuids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterHotAddProxyVmsV2",
                "($first: Int,$after: String,$filter: [VcenterProxyVmsFilterInput!],$clusterUuids: [UUID!]!)",
                "VsphereProxyVmInfoConnection",
                Query.VcenterHotAddProxyVmsV2,
                Query.VcenterHotAddProxyVmsV2FieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someVcenterProxyVmsFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterProxyVmsFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)
# REQUIRED
$query.Var.clusterUuids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // vSphereVCenterConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereVcenterConnection!
        internal void InitQueryVsphereVcenterConnection()
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
                "QueryVsphereVcenterConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereVcenterConnection",
                Query.VsphereVcenterConnection,
                Query.VsphereVcenterConnectionFieldSpec,
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
        // allVcenterMissingPrivilegeSummary(vcenterId: UUID!, jobId: String!): [vCenterEntitySummary!]!
        internal void InitQueryAllVcenterMissingPrivilegeSummary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("vcenterId", "UUID!"),
                Tuple.Create("jobId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllVcenterMissingPrivilegeSummary",
                "($vcenterId: UUID!,$jobId: String!)",
                "List<VcenterEntitySummary>",
                Query.AllVcenterMissingPrivilegeSummary,
                Query.AllVcenterMissingPrivilegeSummaryFieldSpec,
                @"# REQUIRED
$query.Var.vcenterId = $someString
# REQUIRED
$query.Var.jobId = $someString"
            );
        }

        // Create new GraphQL Query:
        // vCenterMissingPrivileges(input: VcenterMissingPrivilegesInput!): MissingEntityPrivilegesList!
        internal void InitQueryVcenterMissingPrivileges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VcenterMissingPrivilegesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterMissingPrivileges",
                "($input: VcenterMissingPrivilegesInput!)",
                "MissingEntityPrivilegesList",
                Query.VcenterMissingPrivileges,
                Query.VcenterMissingPrivilegesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	limit = $someInt
	# OPTIONAL
	offset = $someInt
	# REQUIRED
	entityType = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // vCenterMissingPrivilegesV2(
        //     first: Int
        //     after: String
        //     vcenterId: UUID!
        //     jobId: String!
        //     filter: [VcenterMissingPrivilegeFilterInput!]
        //   ): VcenterEntityConnection!
        internal void InitQueryVcenterMissingPrivilegesV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("vcenterId", "UUID!"),
                Tuple.Create("jobId", "String!"),
                Tuple.Create("filter", "[VcenterMissingPrivilegeFilterInput!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterMissingPrivilegesV2",
                "($first: Int,$after: String,$vcenterId: UUID!,$jobId: String!,$filter: [VcenterMissingPrivilegeFilterInput!])",
                "VcenterEntityConnection",
                Query.VcenterMissingPrivilegesV2,
                Query.VcenterMissingPrivilegesV2FieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.vcenterId = $someString
# REQUIRED
$query.Var.jobId = $someString
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someVcenterMissingPrivilegeFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterMissingPrivilegeFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // vCenterNetworks(input: GetNetworksInput!): NetworkInfoListResponse!
        internal void InitQueryVcenterNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNetworksInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterNetworks",
                "($input: GetNetworksInput!)",
                "NetworkInfoListResponse",
                Query.VcenterNetworks,
                Query.VcenterNetworksFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // vCenterNumProxiesNeeded(input: GetNumProxiesNeededInput!): Int!
        internal void InitQueryVcenterNumProxiesNeeded()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNumProxiesNeededInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterNumProxiesNeeded",
                "($input: GetNumProxiesNeededInput!)",
                "System.Int32",
                Query.VcenterNumProxiesNeeded,
                Query.VcenterNumProxiesNeededFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // vCenterPreAddInfo(input: PreAddVcenterInput!): VcenterPreAddInfo!
        internal void InitQueryVcenterPreAddInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PreAddVcenterInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterPreAddInfo",
                "($input: PreAddVcenterInput!)",
                "VcenterPreAddInfo",
                Query.VcenterPreAddInfo,
                Query.VcenterPreAddInfoFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	vcenterConfig = @{
		# OPTIONAL
		id = $someString
		# OPTIONAL
		connectionConfig = @{
			# OPTIONAL
			caCerts = $someString
			# REQUIRED
			hostname = $someString
			# REQUIRED
			password = $someString
			# REQUIRED
			username = $someString
		}
	}
}"
            );
        }

        // Create new GraphQL Query:
        // vCenterRequiredPrivileges(input: VcenterRequiredPrivilegesInput!): RequiredEntityPrivilegeListResponse!
        internal void InitQueryVcenterRequiredPrivileges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VcenterRequiredPrivilegesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterRequiredPrivileges",
                "($input: VcenterRequiredPrivilegesInput!)",
                "RequiredEntityPrivilegeListResponse",
                Query.VcenterRequiredPrivileges,
                Query.VcenterRequiredPrivilegesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // uniqueVSphereVCenterCount(filter: [Filter!]): Int!
        internal void InitQueryUniqueVsphereVcenterCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUniqueVsphereVcenterCount",
                "($filter: [Filter!])",
                "System.Int32",
                Query.UniqueVsphereVcenterCount,
                Query.UniqueVsphereVcenterCountFieldSpec,
                @"# OPTIONAL
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
        // vSphereVCenter(fid: UUID!): VsphereVcenter!
        internal void InitQueryVsphereVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVcenter",
                "($fid: UUID!)",
                "VsphereVcenter",
                Query.VsphereVcenter,
                Query.VsphereVcenterFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }


    } // class New_RscQueryVcenter
}