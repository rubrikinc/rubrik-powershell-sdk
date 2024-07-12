// CloudAccountFeature.cs
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
    public enum CloudAccountFeature
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "APP_FLOWS")]
        APP_FLOWS,

        [EnumMember(Value = "ARCHIVAL")]
        ARCHIVAL,

        [EnumMember(Value = "AZURE_SQL_DB_PROTECTION")]
        AZURE_SQL_DB_PROTECTION,

        [EnumMember(Value = "AZURE_SQL_MI_PROTECTION")]
        AZURE_SQL_MI_PROTECTION,

        [EnumMember(Value = "CLOUDACCOUNTS")]
        CLOUDACCOUNTS,

        [EnumMember(Value = "CLOUD_NATIVE_ARCHIVAL")]
        CLOUD_NATIVE_ARCHIVAL,

        [EnumMember(Value = "CLOUD_NATIVE_ARCHIVAL_ENCRYPTION")]
        CLOUD_NATIVE_ARCHIVAL_ENCRYPTION,

        [EnumMember(Value = "CLOUD_NATIVE_BLOB_PROTECTION")]
        CLOUD_NATIVE_BLOB_PROTECTION,

        [EnumMember(Value = "CLOUD_NATIVE_PROTECTION")]
        CLOUD_NATIVE_PROTECTION,

        [EnumMember(Value = "CLOUD_NATIVE_S3_PROTECTION")]
        CLOUD_NATIVE_S3_PROTECTION,

        [EnumMember(Value = "DATA_CENTER_ROLE_BASED_ARCHIVAL")]
        DATA_CENTER_ROLE_BASED_ARCHIVAL,

        [EnumMember(Value = "EXOCOMPUTE")]
        EXOCOMPUTE,

        [EnumMember(Value = "FEATURE_UNSPECIFIED")]
        FEATURE_UNSPECIFIED,

        [EnumMember(Value = "GCP_SHARED_VPC_HOST")]
        GCP_SHARED_VPC_HOST,

        [EnumMember(Value = "KUBERNETES_PROTECTION")]
        KUBERNETES_PROTECTION,

        [EnumMember(Value = "LAMINAR_CROSS_ACCOUNT")]
        LAMINAR_CROSS_ACCOUNT,

        [EnumMember(Value = "LAMINAR_INTERNAL")]
        LAMINAR_INTERNAL,

        [EnumMember(Value = "RDS_PROTECTION")]
        RDS_PROTECTION,

        [EnumMember(Value = "SERVERS_AND_APPS")]
        SERVERS_AND_APPS


    } // enum CloudAccountFeature

} // namespace RubrikSecurityCloud.Types