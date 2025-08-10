// FlowErrorCode.cs
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

namespace RubrikSecurityCloud.Types
{
    public enum FlowErrorCode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_ACCESS_DENIED")]
        AWS_ACCESS_DENIED,

        [EnumMember(Value = "AWS_INVALID_CLIENT_TOKEN_ID")]
        AWS_INVALID_CLIENT_TOKEN_ID,

        [EnumMember(Value = "AWS_UNAUTHORIZED_OPERATION")]
        AWS_UNAUTHORIZED_OPERATION,

        [EnumMember(Value = "AZURE_FUNCTION_APP_QUOTA_EXCEEDED")]
        AZURE_FUNCTION_APP_QUOTA_EXCEEDED,

        [EnumMember(Value = "AZURE_SQL_ELASTIC_POOL_UNSUPPORTED")]
        AZURE_SQL_ELASTIC_POOL_UNSUPPORTED,

        [EnumMember(Value = "AZURE_SQL_SERVER_CREATION_DISALLOWED")]
        AZURE_SQL_SERVER_CREATION_DISALLOWED,

        [EnumMember(Value = "AZURE_SQL_UNRECOVERABLE_DATABASE_EDITION")]
        AZURE_SQL_UNRECOVERABLE_DATABASE_EDITION,

        [EnumMember(Value = "CLOUD_FUNCTION_EXCEPTION")]
        CLOUD_FUNCTION_EXCEPTION,

        [EnumMember(Value = "DISK_SCAN_FROM_ANOTHER_REGION_UNSUPPORTED")]
        DISK_SCAN_FROM_ANOTHER_REGION_UNSUPPORTED,

        [EnumMember(Value = "ERROR_CODE_UNSPECIFIED")]
        ERROR_CODE_UNSPECIFIED,

        [EnumMember(Value = "FILE_SYSTEM_MOUNT_ERROR")]
        FILE_SYSTEM_MOUNT_ERROR,

        [EnumMember(Value = "GENERIC_AWS_THIRD_PARTY_ERROR")]
        GENERIC_AWS_THIRD_PARTY_ERROR,

        [EnumMember(Value = "GENERIC_ERROR")]
        GENERIC_ERROR,

        [EnumMember(Value = "GENERIC_RECOVERABLE_ERROR")]
        GENERIC_RECOVERABLE_ERROR,

        [EnumMember(Value = "GENERIC_UNAUTHORIZED_ERROR")]
        GENERIC_UNAUTHORIZED_ERROR,

        [EnumMember(Value = "GENERIC_UNSUPPORTED_ERROR")]
        GENERIC_UNSUPPORTED_ERROR,

        [EnumMember(Value = "LVM2_MULTIPLE_PVS")]
        LVM2_MULTIPLE_PVS,

        [EnumMember(Value = "MANAGED_DATABASE_NO_RESTORE_POINT_FOUND")]
        MANAGED_DATABASE_NO_RESTORE_POINT_FOUND,

        [EnumMember(Value = "MISSING_MSCLOUD_PERMISSIONS")]
        MISSING_MSCLOUD_PERMISSIONS,

        [EnumMember(Value = "NO_SUPPORTED_PARTITION_FOUND")]
        NO_SUPPORTED_PARTITION_FOUND,

        [EnumMember(Value = "RDS_CLUSTER_SNAPSHOT_QUOTA_EXCEEDED")]
        RDS_CLUSTER_SNAPSHOT_QUOTA_EXCEEDED,

        [EnumMember(Value = "RDS_DB_PERSISTENT_OR_PERMANENT")]
        RDS_DB_PERSISTENT_OR_PERMANENT,

        [EnumMember(Value = "RDS_DB_SNAPSHOT_QUOTA_EXCEEDED")]
        RDS_DB_SNAPSHOT_QUOTA_EXCEEDED,

        [EnumMember(Value = "RDS_DB_UNSUPPORTED_ENGINE")]
        RDS_DB_UNSUPPORTED_ENGINE,

        [EnumMember(Value = "RDS_READ_REPLICA_SNAPSHOTS_UNSUPPORTED")]
        RDS_READ_REPLICA_SNAPSHOTS_UNSUPPORTED,

        [EnumMember(Value = "RDS_SOURCE_SNAPSHOT_KMS_NOT_ACCESSIBLE")]
        RDS_SOURCE_SNAPSHOT_KMS_NOT_ACCESSIBLE,

        [EnumMember(Value = "RDS_UNSUPPORTED_RESTORE_DB_INSTANCE")]
        RDS_UNSUPPORTED_RESTORE_DB_INSTANCE,

        [EnumMember(Value = "SUCCESS")]
        SUCCESS,

        [EnumMember(Value = "VOLUME_HAS_MARKETPLACE_PRODUCT_CODE")]
        VOLUME_HAS_MARKETPLACE_PRODUCT_CODE


    } // enum FlowErrorCode

} // namespace RubrikSecurityCloud.Types