// New-RscQueryAwsNative.cs
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
    /// Create a new RscQuery object for any of the 19
    /// operations in the 'AWS Native' API domain:
    /// Account, Accounts, AmiTypeForArchivedSnapshotExport, EbsVolume, EbsVolumes, EbsVolumesByName, Ec2Instance, Ec2Instances, Ec2InstancesByName, IsEbsVolumeSnapshotRestorable, IsRdsInstanceLaunchConfigurationValid, RdsExportDefaults, RdsInstance, RdsInstances, RdsPointInTimeRestoreWindow, Root, S3Bucket, ValidateRdsClusterNameForExport, or ValidateRdsInstanceNameForExport.
    /// </summary>
    /// <description>
    /// New-RscQueryAwsNative creates a new
    /// query object for operations
    /// in the 'AWS Native' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 19 operations
    /// in the 'AWS Native' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Account, Accounts, AmiTypeForArchivedSnapshotExport, EbsVolume, EbsVolumes, EbsVolumesByName, Ec2Instance, Ec2Instances, Ec2InstancesByName, IsEbsVolumeSnapshotRestorable, IsRdsInstanceLaunchConfigurationValid, RdsExportDefaults, RdsInstance, RdsInstances, RdsPointInTimeRestoreWindow, Root, S3Bucket, ValidateRdsClusterNameForExport, or ValidateRdsInstanceNameForExport.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryAwsNative -Account).Info().
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
    /// (New-RscQueryAwsNative -Account).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Account operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: Account
    /// 
    /// $query = New-RscQueryAwsNative -Account
    /// 
    /// # REQUIRED
    /// $query.Var.awsNativeAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.awsNativeProtectionFeature = $someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeAccount
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Accounts operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: Accounts
    /// 
    /// $query = New-RscQueryAwsNative -Accounts
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
    /// $query.Var.sortBy = $someAwsNativeAccountSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeAccountSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.accountFilters = @{
    /// 	# OPTIONAL
    /// 	nameSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	cloudTypeFilter = @{
    /// 		# REQUIRED
    /// 		cloudTypes = @(
    /// 			$someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 		)
    /// 	}
    /// }
    /// # OPTIONAL
    /// $query.Var.authorizedOperationFilter = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// # REQUIRED
    /// $query.Var.awsNativeProtectionFeature = $someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeAccountConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AmiTypeForArchivedSnapshotExport operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: AmiTypeForArchivedSnapshotExport
    /// 
    /// $query = New-RscQueryAwsNative -AmiTypeForArchivedSnapshotExport
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	destinationRegionId = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 	# REQUIRED
    /// 	destinationAwsAccountRubrikId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AmiTypeForAwsNativeArchivedSnapshotExportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EbsVolume operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: EbsVolume
    /// 
    /// $query = New-RscQueryAwsNative -EbsVolume
    /// 
    /// # REQUIRED
    /// $query.Var.ebsVolumeRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeEbsVolume
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EbsVolumes operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: EbsVolumes
    /// 
    /// $query = New-RscQueryAwsNative -EbsVolumes
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
    /// $query.Var.sortBy = $someAwsNativeEbsVolumeSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.ebsVolumeFilters = @{
    /// 	# OPTIONAL
    /// 	nameOrIdSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameOrIdSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	fileRecoveryStatusFilter = @{
    /// 		# REQUIRED
    /// 		statuses = @(
    /// 			$someAwsNativeFileRecoveryStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeFileRecoveryStatus]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	typeFilter = @{
    /// 		# REQUIRED
    /// 		ebsVolumeTypes = @(
    /// 			$someAwsNativeEbsVolumeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeType]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	attachedInstanceFilter = @{
    /// 		# REQUIRED
    /// 		ec2InstanceIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	accountFilter = @{
    /// 		# REQUIRED
    /// 		accountIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	regionFilter = @{
    /// 		# REQUIRED
    /// 		regions = @(
    /// 			$someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	relicFilter = @{
    /// 		# REQUIRED
    /// 		relic = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	tagFilter = @{
    /// 		# REQUIRED
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
    /// 	}
    /// 	# OPTIONAL
    /// 	orgFilter = @{
    /// 		# REQUIRED
    /// 		orgIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeEbsVolumeConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EbsVolumesByName operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: EbsVolumesByName
    /// 
    /// $query = New-RscQueryAwsNative -EbsVolumesByName
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
    /// $query.Var.sortBy = $someAwsNativeEbsVolumeSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # REQUIRED
    /// $query.Var.ebsVolumeName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeEbsVolumeConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Ec2Instance operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: Ec2Instance
    /// 
    /// $query = New-RscQueryAwsNative -Ec2Instance
    /// 
    /// # REQUIRED
    /// $query.Var.ec2InstanceRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeEc2Instance
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Ec2Instances operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: Ec2Instances
    /// 
    /// $query = New-RscQueryAwsNative -Ec2Instances
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
    /// $query.Var.sortBy = $someAwsNativeEc2InstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.descendantTypeFilter = @(
    /// 	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.ec2InstanceFilters = @{
    /// 	# OPTIONAL
    /// 	nameOrIdSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameOrIdSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	accountFilter = @{
    /// 		# REQUIRED
    /// 		accountIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	fileRecoveryStatusFilter = @{
    /// 		# REQUIRED
    /// 		statuses = @(
    /// 			$someAwsNativeFileRecoveryStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeFileRecoveryStatus]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	regionFilter = @{
    /// 		# REQUIRED
    /// 		regions = @(
    /// 			$someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	typeFilter = @{
    /// 		# REQUIRED
    /// 		ec2InstanceTypes = @(
    /// 			$someAwsNativeEc2InstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceType]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	vpcFilter = @{
    /// 		# REQUIRED
    /// 		vpcIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	relicFilter = @{
    /// 		# REQUIRED
    /// 		relic = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	tagFilter = @{
    /// 		# REQUIRED
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
    /// 	}
    /// 	# OPTIONAL
    /// 	appProtectionStatusFilter = @{
    /// 		# REQUIRED
    /// 		isProtectionSetup = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	rbsStatusFilter = @{
    /// 		# REQUIRED
    /// 		status = $someCloudInstanceRbsConnectionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudInstanceRbsConnectionStatus]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	orgFilter = @{
    /// 		# REQUIRED
    /// 		orgIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeEc2InstanceConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Ec2InstancesByName operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: Ec2InstancesByName
    /// 
    /// $query = New-RscQueryAwsNative -Ec2InstancesByName
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
    /// $query.Var.sortBy = $someAwsNativeEc2InstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # REQUIRED
    /// $query.Var.ec2InstanceName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeEc2InstanceConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsEbsVolumeSnapshotRestorable operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: IsEbsVolumeSnapshotRestorable
    /// 
    /// $query = New-RscQueryAwsNative -IsEbsVolumeSnapshotRestorable
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: IsVolumeSnapshotRestorableReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsRdsInstanceLaunchConfigurationValid operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: IsRdsInstanceLaunchConfigurationValid
    /// 
    /// $query = New-RscQueryAwsNative -IsRdsInstanceLaunchConfigurationValid
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.dbEngine = $someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
    /// # REQUIRED
    /// $query.Var.dbEngineVersion = $someString
    /// # REQUIRED
    /// $query.Var.dbClass = $someAwsNativeRdsDbInstanceClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
    /// # OPTIONAL
    /// $query.Var.databaseInstanceClass = $someString
    /// # OPTIONAL
    /// $query.Var.primaryAz = $someString
    /// # OPTIONAL
    /// $query.Var.storageType = $someAwsNativeRdsStorageType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsStorageType]) for enum values.
    /// # REQUIRED
    /// $query.Var.isMultiAz = $someBoolean
    /// # OPTIONAL
    /// $query.Var.kmsKeyId = $someString
    /// # OPTIONAL
    /// $query.Var.iops = $someInt
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
    /// Runs the RdsExportDefaults operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: RdsExportDefaults
    /// 
    /// $query = New-RscQueryAwsNative -RdsExportDefaults
    /// 
    /// # REQUIRED
    /// $query.Var.rdsInstanceRubrikId = $someString
    /// # OPTIONAL
    /// $query.Var.snapshotId = $someString
    /// # REQUIRED
    /// $query.Var.isPointInTime = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RdsInstanceExportDefaults
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RdsInstance operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: RdsInstance
    /// 
    /// $query = New-RscQueryAwsNative -RdsInstance
    /// 
    /// # REQUIRED
    /// $query.Var.rdsInstanceRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeRdsInstance
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RdsInstances operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: RdsInstances
    /// 
    /// $query = New-RscQueryAwsNative -RdsInstances
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
    /// $query.Var.sortBy = $someAwsNativeRdsInstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsInstanceSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.rdsInstanceFilters = @{
    /// 	# OPTIONAL
    /// 	nameSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	accountFilter = @{
    /// 		# REQUIRED
    /// 		accountIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	vpcFilter = @{
    /// 		# REQUIRED
    /// 		vpcIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	relicFilter = @{
    /// 		# REQUIRED
    /// 		relic = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	tagFilter = @{
    /// 		# REQUIRED
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
    /// 	}
    /// 	# OPTIONAL
    /// 	regionFilter = @{
    /// 		# REQUIRED
    /// 		regions = @(
    /// 			$someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	dbEngineFilter = @{
    /// 		# REQUIRED
    /// 		dbEngines = @(
    /// 			$someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	dbInstanceClassFilter = @{
    /// 		# REQUIRED
    /// 		dbInstanceClasses = @(
    /// 			$someAwsNativeRdsDbInstanceClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	orgFilter = @{
    /// 		# REQUIRED
    /// 		orgIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeRdsInstanceConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RdsPointInTimeRestoreWindow operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: RdsPointInTimeRestoreWindow
    /// 
    /// $query = New-RscQueryAwsNative -RdsPointInTimeRestoreWindow
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.rdsInstanceName = $someString
    /// # OPTIONAL
    /// $query.Var.rdsDatabaseRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeRdsPointInTimeRestoreWindow
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Root operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: Root
    /// 
    /// $query = New-RscQueryAwsNative -Root
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeRoot
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the S3Bucket operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: S3Bucket
    /// 
    /// $query = New-RscQueryAwsNative -S3Bucket
    /// 
    /// # REQUIRED
    /// $query.Var.s3BucketRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeS3Bucket
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateRdsClusterNameForExport operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: ValidateRdsClusterNameForExport
    /// 
    /// $query = New-RscQueryAwsNative -ValidateRdsClusterNameForExport
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.rdsClusterName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateAwsNativeRdsClusterNameForExportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateRdsInstanceNameForExport operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: ValidateRdsInstanceNameForExport
    /// 
    /// $query = New-RscQueryAwsNative -ValidateRdsInstanceNameForExport
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.rdsInstanceName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateAwsNativeRdsInstanceNameForExportReply
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
        "RscQueryAwsNative",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryAwsNative : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Account",
                "Accounts",
                "AmiTypeForArchivedSnapshotExport",
                "EbsVolume",
                "EbsVolumes",
                "EbsVolumesByName",
                "Ec2Instance",
                "Ec2Instances",
                "Ec2InstancesByName",
                "IsEbsVolumeSnapshotRestorable",
                "IsRdsInstanceLaunchConfigurationValid",
                "RdsExportDefaults",
                "RdsInstance",
                "RdsInstances",
                "RdsPointInTimeRestoreWindow",
                "Root",
                "S3Bucket",
                "ValidateRdsClusterNameForExport",
                "ValidateRdsInstanceNameForExport",
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
                    case "Account":
                        this.ProcessRecord_Account();
                        break;
                    case "Accounts":
                        this.ProcessRecord_Accounts();
                        break;
                    case "AmiTypeForArchivedSnapshotExport":
                        this.ProcessRecord_AmiTypeForArchivedSnapshotExport();
                        break;
                    case "EbsVolume":
                        this.ProcessRecord_EbsVolume();
                        break;
                    case "EbsVolumes":
                        this.ProcessRecord_EbsVolumes();
                        break;
                    case "EbsVolumesByName":
                        this.ProcessRecord_EbsVolumesByName();
                        break;
                    case "Ec2Instance":
                        this.ProcessRecord_Ec2Instance();
                        break;
                    case "Ec2Instances":
                        this.ProcessRecord_Ec2Instances();
                        break;
                    case "Ec2InstancesByName":
                        this.ProcessRecord_Ec2InstancesByName();
                        break;
                    case "IsEbsVolumeSnapshotRestorable":
                        this.ProcessRecord_IsEbsVolumeSnapshotRestorable();
                        break;
                    case "IsRdsInstanceLaunchConfigurationValid":
                        this.ProcessRecord_IsRdsInstanceLaunchConfigurationValid();
                        break;
                    case "RdsExportDefaults":
                        this.ProcessRecord_RdsExportDefaults();
                        break;
                    case "RdsInstance":
                        this.ProcessRecord_RdsInstance();
                        break;
                    case "RdsInstances":
                        this.ProcessRecord_RdsInstances();
                        break;
                    case "RdsPointInTimeRestoreWindow":
                        this.ProcessRecord_RdsPointInTimeRestoreWindow();
                        break;
                    case "Root":
                        this.ProcessRecord_Root();
                        break;
                    case "S3Bucket":
                        this.ProcessRecord_S3Bucket();
                        break;
                    case "ValidateRdsClusterNameForExport":
                        this.ProcessRecord_ValidateRdsClusterNameForExport();
                        break;
                    case "ValidateRdsInstanceNameForExport":
                        this.ProcessRecord_ValidateRdsInstanceNameForExport();
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
        // awsNativeAccount.
        internal void ProcessRecord_Account()
        {
            this._logger.name += " -Account";
            // Create new graphql operation awsNativeAccount
            InitQueryAwsNativeAccount();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeAccounts.
        internal void ProcessRecord_Accounts()
        {
            this._logger.name += " -Accounts";
            // Create new graphql operation awsNativeAccounts
            InitQueryAwsNativeAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // amiTypeForAwsNativeArchivedSnapshotExport.
        internal void ProcessRecord_AmiTypeForArchivedSnapshotExport()
        {
            this._logger.name += " -AmiTypeForArchivedSnapshotExport";
            // Create new graphql operation amiTypeForAwsNativeArchivedSnapshotExport
            InitQueryAmiTypeForAwsNativeArchivedSnapshotExport();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolume.
        internal void ProcessRecord_EbsVolume()
        {
            this._logger.name += " -EbsVolume";
            // Create new graphql operation awsNativeEbsVolume
            InitQueryAwsNativeEbsVolume();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolumes.
        internal void ProcessRecord_EbsVolumes()
        {
            this._logger.name += " -EbsVolumes";
            // Create new graphql operation awsNativeEbsVolumes
            InitQueryAwsNativeEbsVolumes();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolumesByName.
        internal void ProcessRecord_EbsVolumesByName()
        {
            this._logger.name += " -EbsVolumesByName";
            // Create new graphql operation awsNativeEbsVolumesByName
            InitQueryAwsNativeEbsVolumesByName();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2Instance.
        internal void ProcessRecord_Ec2Instance()
        {
            this._logger.name += " -Ec2Instance";
            // Create new graphql operation awsNativeEc2Instance
            InitQueryAwsNativeEc2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2Instances.
        internal void ProcessRecord_Ec2Instances()
        {
            this._logger.name += " -Ec2Instances";
            // Create new graphql operation awsNativeEc2Instances
            InitQueryAwsNativeEc2Instances();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2InstancesByName.
        internal void ProcessRecord_Ec2InstancesByName()
        {
            this._logger.name += " -Ec2InstancesByName";
            // Create new graphql operation awsNativeEc2InstancesByName
            InitQueryAwsNativeEc2InstancesByName();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeEbsVolumeSnapshotRestorable.
        internal void ProcessRecord_IsEbsVolumeSnapshotRestorable()
        {
            this._logger.name += " -IsEbsVolumeSnapshotRestorable";
            // Create new graphql operation isAwsNativeEbsVolumeSnapshotRestorable
            InitQueryIsAwsNativeEbsVolumeSnapshotRestorable();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeRdsInstanceLaunchConfigurationValid.
        internal void ProcessRecord_IsRdsInstanceLaunchConfigurationValid()
        {
            this._logger.name += " -IsRdsInstanceLaunchConfigurationValid";
            // Create new graphql operation isAwsNativeRdsInstanceLaunchConfigurationValid
            InitQueryIsAwsNativeRdsInstanceLaunchConfigurationValid();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsExportDefaults.
        internal void ProcessRecord_RdsExportDefaults()
        {
            this._logger.name += " -RdsExportDefaults";
            // Create new graphql operation awsNativeRdsExportDefaults
            InitQueryAwsNativeRdsExportDefaults();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsInstance.
        internal void ProcessRecord_RdsInstance()
        {
            this._logger.name += " -RdsInstance";
            // Create new graphql operation awsNativeRdsInstance
            InitQueryAwsNativeRdsInstance();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsInstances.
        internal void ProcessRecord_RdsInstances()
        {
            this._logger.name += " -RdsInstances";
            // Create new graphql operation awsNativeRdsInstances
            InitQueryAwsNativeRdsInstances();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsPointInTimeRestoreWindow.
        internal void ProcessRecord_RdsPointInTimeRestoreWindow()
        {
            this._logger.name += " -RdsPointInTimeRestoreWindow";
            // Create new graphql operation awsNativeRdsPointInTimeRestoreWindow
            InitQueryAwsNativeRdsPointInTimeRestoreWindow();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRoot.
        internal void ProcessRecord_Root()
        {
            this._logger.name += " -Root";
            // Create new graphql operation awsNativeRoot
            InitQueryAwsNativeRoot();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeS3Bucket.
        internal void ProcessRecord_S3Bucket()
        {
            this._logger.name += " -S3Bucket";
            // Create new graphql operation awsNativeS3Bucket
            InitQueryAwsNativeS3Bucket();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsClusterNameForExport.
        internal void ProcessRecord_ValidateRdsClusterNameForExport()
        {
            this._logger.name += " -ValidateRdsClusterNameForExport";
            // Create new graphql operation validateAwsNativeRdsClusterNameForExport
            InitQueryValidateAwsNativeRdsClusterNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsInstanceNameForExport.
        internal void ProcessRecord_ValidateRdsInstanceNameForExport()
        {
            this._logger.name += " -ValidateRdsInstanceNameForExport";
            // Create new graphql operation validateAwsNativeRdsInstanceNameForExport
            InitQueryValidateAwsNativeRdsInstanceNameForExport();
        }


        // Create new GraphQL Query:
        // awsNativeAccount(awsNativeAccountRubrikId: UUID!, awsNativeProtectionFeature: AwsNativeProtectionFeature!): AwsNativeAccount!
        internal void InitQueryAwsNativeAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeAccountRubrikId", "UUID!"),
                Tuple.Create("awsNativeProtectionFeature", "AwsNativeProtectionFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeAccount",
                "($awsNativeAccountRubrikId: UUID!,$awsNativeProtectionFeature: AwsNativeProtectionFeature!)",
                "AwsNativeAccount",
                Query.AwsNativeAccount_ObjectFieldSpec,
                Query.AwsNativeAccountFieldSpec,
                @"# REQUIRED
$query.Var.awsNativeAccountRubrikId = $someString
# REQUIRED
$query.Var.awsNativeProtectionFeature = $someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // awsNativeAccounts(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeAccountSortFields
        //     sortOrder: SortOrder
        //     accountFilters: AwsNativeAccountFilters
        //     authorizedOperationFilter: Operation
        //     awsNativeProtectionFeature: AwsNativeProtectionFeature!
        //   ): AwsNativeAccountConnection!
        internal void InitQueryAwsNativeAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeAccountSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("accountFilters", "AwsNativeAccountFilters"),
                Tuple.Create("authorizedOperationFilter", "Operation"),
                Tuple.Create("awsNativeProtectionFeature", "AwsNativeProtectionFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeAccounts",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeAccountSortFields,$sortOrder: SortOrder,$accountFilters: AwsNativeAccountFilters,$authorizedOperationFilter: Operation,$awsNativeProtectionFeature: AwsNativeProtectionFeature!)",
                "AwsNativeAccountConnection",
                Query.AwsNativeAccounts_ObjectFieldSpec,
                Query.AwsNativeAccountsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAwsNativeAccountSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeAccountSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.accountFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = $someString
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
	# OPTIONAL
	cloudTypeFilter = @{
		# REQUIRED
		cloudTypes = @(
			$someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
		)
	}
}
# OPTIONAL
$query.Var.authorizedOperationFilter = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
# REQUIRED
$query.Var.awsNativeProtectionFeature = $someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // amiTypeForAwsNativeArchivedSnapshotExport(input: AmiTypeForAwsNativeArchivedSnapshotExportInput!): AmiTypeForAwsNativeArchivedSnapshotExportReply!
        internal void InitQueryAmiTypeForAwsNativeArchivedSnapshotExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AmiTypeForAwsNativeArchivedSnapshotExportInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAmiTypeForAwsNativeArchivedSnapshotExport",
                "($input: AmiTypeForAwsNativeArchivedSnapshotExportInput!)",
                "AmiTypeForAwsNativeArchivedSnapshotExportReply",
                Query.AmiTypeForAwsNativeArchivedSnapshotExport_ObjectFieldSpec,
                Query.AmiTypeForAwsNativeArchivedSnapshotExportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	destinationRegionId = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
	# REQUIRED
	destinationAwsAccountRubrikId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEbsVolume(ebsVolumeRubrikId: UUID!): AwsNativeEbsVolume!
        internal void InitQueryAwsNativeEbsVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ebsVolumeRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEbsVolume",
                "($ebsVolumeRubrikId: UUID!)",
                "AwsNativeEbsVolume",
                Query.AwsNativeEbsVolume_ObjectFieldSpec,
                Query.AwsNativeEbsVolumeFieldSpec,
                @"# REQUIRED
$query.Var.ebsVolumeRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEbsVolumes(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEbsVolumeSortFields
        //     sortOrder: SortOrder
        //     ebsVolumeFilters: AwsNativeEbsVolumeFilters
        //   ): AwsNativeEbsVolumeConnection!
        internal void InitQueryAwsNativeEbsVolumes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEbsVolumeSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ebsVolumeFilters", "AwsNativeEbsVolumeFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEbsVolumes",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEbsVolumeSortFields,$sortOrder: SortOrder,$ebsVolumeFilters: AwsNativeEbsVolumeFilters)",
                "AwsNativeEbsVolumeConnection",
                Query.AwsNativeEbsVolumes_ObjectFieldSpec,
                Query.AwsNativeEbsVolumesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAwsNativeEbsVolumeSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.ebsVolumeFilters = @{
	# OPTIONAL
	nameOrIdSubstringFilter = @{
		# REQUIRED
		nameOrIdSubstring = $someString
	}
	# OPTIONAL
	fileRecoveryStatusFilter = @{
		# REQUIRED
		statuses = @(
			$someAwsNativeFileRecoveryStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeFileRecoveryStatus]) for enum values.
		)
	}
	# OPTIONAL
	typeFilter = @{
		# REQUIRED
		ebsVolumeTypes = @(
			$someAwsNativeEbsVolumeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeType]) for enum values.
		)
	}
	# OPTIONAL
	attachedInstanceFilter = @{
		# REQUIRED
		ec2InstanceIds = @(
			$someString
		)
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
	# OPTIONAL
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			$someString
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			$someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = $someBoolean
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
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
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEbsVolumesByName(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEbsVolumeSortFields
        //     sortOrder: SortOrder
        //     ebsVolumeName: String!
        //   ): AwsNativeEbsVolumeConnection!
        internal void InitQueryAwsNativeEbsVolumesByName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEbsVolumeSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ebsVolumeName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEbsVolumesByName",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEbsVolumeSortFields,$sortOrder: SortOrder,$ebsVolumeName: String!)",
                "AwsNativeEbsVolumeConnection",
                Query.AwsNativeEbsVolumesByName_ObjectFieldSpec,
                Query.AwsNativeEbsVolumesByNameFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAwsNativeEbsVolumeSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$query.Var.ebsVolumeName = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEc2Instance(ec2InstanceRubrikId: UUID!): AwsNativeEc2Instance!
        internal void InitQueryAwsNativeEc2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ec2InstanceRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEc2Instance",
                "($ec2InstanceRubrikId: UUID!)",
                "AwsNativeEc2Instance",
                Query.AwsNativeEc2Instance_ObjectFieldSpec,
                Query.AwsNativeEc2InstanceFieldSpec,
                @"# REQUIRED
$query.Var.ec2InstanceRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEc2Instances(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEc2InstanceSortFields
        //     sortOrder: SortOrder
        //     descendantTypeFilter: [HierarchyObjectTypeEnum!]
        //     ec2InstanceFilters: AwsNativeEc2InstanceFilters
        //   ): AwsNativeEc2InstanceConnection!
        internal void InitQueryAwsNativeEc2Instances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEc2InstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("descendantTypeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("ec2InstanceFilters", "AwsNativeEc2InstanceFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEc2Instances",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEc2InstanceSortFields,$sortOrder: SortOrder,$descendantTypeFilter: [HierarchyObjectTypeEnum!],$ec2InstanceFilters: AwsNativeEc2InstanceFilters)",
                "AwsNativeEc2InstanceConnection",
                Query.AwsNativeEc2Instances_ObjectFieldSpec,
                Query.AwsNativeEc2InstancesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAwsNativeEc2InstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.descendantTypeFilter = @(
	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$query.Var.ec2InstanceFilters = @{
	# OPTIONAL
	nameOrIdSubstringFilter = @{
		# REQUIRED
		nameOrIdSubstring = $someString
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
	# OPTIONAL
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			$someString
		)
	}
	# OPTIONAL
	fileRecoveryStatusFilter = @{
		# REQUIRED
		statuses = @(
			$someAwsNativeFileRecoveryStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeFileRecoveryStatus]) for enum values.
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			$someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	typeFilter = @{
		# REQUIRED
		ec2InstanceTypes = @(
			$someAwsNativeEc2InstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceType]) for enum values.
		)
	}
	# OPTIONAL
	vpcFilter = @{
		# REQUIRED
		vpcIds = @(
			$someString
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = $someBoolean
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
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
	}
	# OPTIONAL
	appProtectionStatusFilter = @{
		# REQUIRED
		isProtectionSetup = $someBoolean
	}
	# OPTIONAL
	rbsStatusFilter = @{
		# REQUIRED
		status = $someCloudInstanceRbsConnectionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudInstanceRbsConnectionStatus]) for enum values.
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEc2InstancesByName(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEc2InstanceSortFields
        //     sortOrder: SortOrder
        //     ec2InstanceName: String!
        //   ): AwsNativeEc2InstanceConnection!
        internal void InitQueryAwsNativeEc2InstancesByName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEc2InstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ec2InstanceName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEc2InstancesByName",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEc2InstanceSortFields,$sortOrder: SortOrder,$ec2InstanceName: String!)",
                "AwsNativeEc2InstanceConnection",
                Query.AwsNativeEc2InstancesByName_ObjectFieldSpec,
                Query.AwsNativeEc2InstancesByNameFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAwsNativeEc2InstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$query.Var.ec2InstanceName = $someString"
            );
        }

        // Create new GraphQL Query:
        // isAwsNativeEbsVolumeSnapshotRestorable(snapshotId: String!): IsVolumeSnapshotRestorableReply!
        internal void InitQueryIsAwsNativeEbsVolumeSnapshotRestorable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAwsNativeEbsVolumeSnapshotRestorable",
                "($snapshotId: String!)",
                "IsVolumeSnapshotRestorableReply",
                Query.IsAwsNativeEbsVolumeSnapshotRestorable_ObjectFieldSpec,
                Query.IsAwsNativeEbsVolumeSnapshotRestorableFieldSpec,
                @"# REQUIRED
$query.Var.snapshotId = $someString"
            );
        }

        // Create new GraphQL Query:
        // isAwsNativeRdsInstanceLaunchConfigurationValid(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String!
        //     dbClass: AwsNativeRdsDbInstanceClass!
        //     databaseInstanceClass: String
        //     primaryAz: String
        //     storageType: AwsNativeRdsStorageType
        //     isMultiAz: Boolean!
        //     kmsKeyId: String
        //     iops: Int
        //   ): Boolean!
        internal void InitQueryIsAwsNativeRdsInstanceLaunchConfigurationValid()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("dbClass", "AwsNativeRdsDbInstanceClass!"),
                Tuple.Create("databaseInstanceClass", "String"),
                Tuple.Create("primaryAz", "String"),
                Tuple.Create("storageType", "AwsNativeRdsStorageType"),
                Tuple.Create("isMultiAz", "Boolean!"),
                Tuple.Create("kmsKeyId", "String"),
                Tuple.Create("iops", "Int"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAwsNativeRdsInstanceLaunchConfigurationValid",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$dbClass: AwsNativeRdsDbInstanceClass!,$databaseInstanceClass: String,$primaryAz: String,$storageType: AwsNativeRdsStorageType,$isMultiAz: Boolean!,$kmsKeyId: String,$iops: Int)",
                "System.Boolean",
                Query.IsAwsNativeRdsInstanceLaunchConfigurationValid_ObjectFieldSpec,
                Query.IsAwsNativeRdsInstanceLaunchConfigurationValidFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$query.Var.dbEngine = $someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$query.Var.dbEngineVersion = $someString
# REQUIRED
$query.Var.dbClass = $someAwsNativeRdsDbInstanceClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
# OPTIONAL
$query.Var.databaseInstanceClass = $someString
# OPTIONAL
$query.Var.primaryAz = $someString
# OPTIONAL
$query.Var.storageType = $someAwsNativeRdsStorageType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsStorageType]) for enum values.
# REQUIRED
$query.Var.isMultiAz = $someBoolean
# OPTIONAL
$query.Var.kmsKeyId = $someString
# OPTIONAL
$query.Var.iops = $someInt"
            );
        }

        // Create new GraphQL Query:
        // awsNativeRdsExportDefaults(rdsInstanceRubrikId: UUID!, snapshotId: String, isPointInTime: Boolean!): RdsInstanceExportDefaults!
        internal void InitQueryAwsNativeRdsExportDefaults()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rdsInstanceRubrikId", "UUID!"),
                Tuple.Create("snapshotId", "String"),
                Tuple.Create("isPointInTime", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsExportDefaults",
                "($rdsInstanceRubrikId: UUID!,$snapshotId: String,$isPointInTime: Boolean!)",
                "RdsInstanceExportDefaults",
                Query.AwsNativeRdsExportDefaults_ObjectFieldSpec,
                Query.AwsNativeRdsExportDefaultsFieldSpec,
                @"# REQUIRED
$query.Var.rdsInstanceRubrikId = $someString
# OPTIONAL
$query.Var.snapshotId = $someString
# REQUIRED
$query.Var.isPointInTime = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // awsNativeRdsInstance(rdsInstanceRubrikId: UUID!): AwsNativeRdsInstance!
        internal void InitQueryAwsNativeRdsInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rdsInstanceRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsInstance",
                "($rdsInstanceRubrikId: UUID!)",
                "AwsNativeRdsInstance",
                Query.AwsNativeRdsInstance_ObjectFieldSpec,
                Query.AwsNativeRdsInstanceFieldSpec,
                @"# REQUIRED
$query.Var.rdsInstanceRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsNativeRdsInstances(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeRdsInstanceSortFields
        //     sortOrder: SortOrder
        //     rdsInstanceFilters: AwsNativeRdsInstanceFilters
        //   ): AwsNativeRdsInstanceConnection!
        internal void InitQueryAwsNativeRdsInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeRdsInstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("rdsInstanceFilters", "AwsNativeRdsInstanceFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsInstances",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeRdsInstanceSortFields,$sortOrder: SortOrder,$rdsInstanceFilters: AwsNativeRdsInstanceFilters)",
                "AwsNativeRdsInstanceConnection",
                Query.AwsNativeRdsInstances_ObjectFieldSpec,
                Query.AwsNativeRdsInstancesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAwsNativeRdsInstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsInstanceSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.rdsInstanceFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = $someString
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
	# OPTIONAL
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			$someString
		)
	}
	# OPTIONAL
	vpcFilter = @{
		# REQUIRED
		vpcIds = @(
			$someString
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = $someBoolean
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
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
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			$someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	dbEngineFilter = @{
		# REQUIRED
		dbEngines = @(
			$someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
		)
	}
	# OPTIONAL
	dbInstanceClassFilter = @{
		# REQUIRED
		dbInstanceClasses = @(
			$someAwsNativeRdsDbInstanceClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
		)
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // awsNativeRdsPointInTimeRestoreWindow(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     rdsInstanceName: String!
        //     rdsDatabaseRubrikId: UUID
        //   ): AwsNativeRdsPointInTimeRestoreWindow!
        internal void InitQueryAwsNativeRdsPointInTimeRestoreWindow()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
                Tuple.Create("rdsDatabaseRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsPointInTimeRestoreWindow",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!,$rdsDatabaseRubrikId: UUID)",
                "AwsNativeRdsPointInTimeRestoreWindow",
                Query.AwsNativeRdsPointInTimeRestoreWindow_ObjectFieldSpec,
                Query.AwsNativeRdsPointInTimeRestoreWindowFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$query.Var.rdsInstanceName = $someString
# OPTIONAL
$query.Var.rdsDatabaseRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsNativeRoot: AwsNativeRoot!
        internal void InitQueryAwsNativeRoot()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRoot",
                "",
                "AwsNativeRoot",
                Query.AwsNativeRoot_ObjectFieldSpec,
                Query.AwsNativeRootFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // awsNativeS3Bucket(s3BucketRubrikId: UUID!): AwsNativeS3Bucket!
        internal void InitQueryAwsNativeS3Bucket()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("s3BucketRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeS3Bucket",
                "($s3BucketRubrikId: UUID!)",
                "AwsNativeS3Bucket",
                Query.AwsNativeS3Bucket_ObjectFieldSpec,
                Query.AwsNativeS3BucketFieldSpec,
                @"# REQUIRED
$query.Var.s3BucketRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // validateAwsNativeRdsClusterNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsClusterName: String!): ValidateAwsNativeRdsClusterNameForExportReply!
        internal void InitQueryValidateAwsNativeRdsClusterNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsClusterName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAwsNativeRdsClusterNameForExport",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsClusterName: String!)",
                "ValidateAwsNativeRdsClusterNameForExportReply",
                Query.ValidateAwsNativeRdsClusterNameForExport_ObjectFieldSpec,
                Query.ValidateAwsNativeRdsClusterNameForExportFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$query.Var.rdsClusterName = $someString"
            );
        }

        // Create new GraphQL Query:
        // validateAwsNativeRdsInstanceNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!): ValidateAwsNativeRdsInstanceNameForExportReply!
        internal void InitQueryValidateAwsNativeRdsInstanceNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAwsNativeRdsInstanceNameForExport",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!)",
                "ValidateAwsNativeRdsInstanceNameForExportReply",
                Query.ValidateAwsNativeRdsInstanceNameForExport_ObjectFieldSpec,
                Query.ValidateAwsNativeRdsInstanceNameForExportFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$query.Var.rdsInstanceName = $someString"
            );
        }


    } // class New_RscQueryAwsNative
}