// WorkloadLevelHierarchy.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum WorkloadLevelHierarchy
    {
        [EnumMember(Value = "AWS_NATIVE_S3_BUCKET")]
        AWS_NATIVE_S3_BUCKET,

        [EnumMember(Value = "AZURE_AD_TENANT")]
        AZURE_AD_TENANT,

        [EnumMember(Value = "AZURE_STORAGE_ACCOUNT")]
        AZURE_STORAGE_ACCOUNT,

        [EnumMember(Value = "AllSubHierarchyType")]
        ALL_SUB_HIERARCHY_TYPE,

        [EnumMember(Value = "AwsNativeEbsVolume")]
        AWS_NATIVE_EBS_VOLUME,

        [EnumMember(Value = "AwsNativeEc2Instance")]
        AWS_NATIVE_EC2_INSTANCE,

        [EnumMember(Value = "AwsNativeRdsInstance")]
        AWS_NATIVE_RDS_INSTANCE,

        [EnumMember(Value = "AzureNativeManagedDisk")]
        AZURE_NATIVE_MANAGED_DISK,

        [EnumMember(Value = "AzureNativeVirtualMachine")]
        AZURE_NATIVE_VIRTUAL_MACHINE,

        [EnumMember(Value = "AzureSqlDatabaseDb")]
        AZURE_SQL_DATABASE_DB,

        [EnumMember(Value = "AzureSqlManagedInstanceDb")]
        AZURE_SQL_MANAGED_INSTANCE_DB,

        [EnumMember(Value = "GcpNativeGCEInstance")]
        GCP_NATIVE_GCE_INSTANCE,

        [EnumMember(Value = "KuprNamespace")]
        KUPR_NAMESPACE,

        [EnumMember(Value = "O365Mailbox")]
        O365_MAILBOX,

        [EnumMember(Value = "O365Onedrive")]
        O365_ONEDRIVE,

        [EnumMember(Value = "O365SharePointDrive")]
        O365_SHARE_POINT_DRIVE,

        [EnumMember(Value = "O365SharePointList")]
        O365_SHARE_POINT_LIST,

        [EnumMember(Value = "O365Site")]
        O365_SITE,

        [EnumMember(Value = "O365Teams")]
        O365_TEAMS


    } // enum WorkloadLevelHierarchy

} // namespace Rubrik.SecurityCloud.Types