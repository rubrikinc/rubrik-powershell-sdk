// GcpCloudSqlInstanceSortFields.cs
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
    public enum GcpCloudSqlInstanceSortFields
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "GCP_CLOUD_SQL_INSTANCE_ENGINE_TYPE")]
        GCP_CLOUD_SQL_INSTANCE_ENGINE_TYPE,

        [EnumMember(Value = "GCP_CLOUD_SQL_INSTANCE_NATIVE_ID")]
        GCP_CLOUD_SQL_INSTANCE_NATIVE_ID,

        [EnumMember(Value = "GCP_CLOUD_SQL_INSTANCE_PROJECT_NAME")]
        GCP_CLOUD_SQL_INSTANCE_PROJECT_NAME,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum GcpCloudSqlInstanceSortFields

} // namespace RubrikSecurityCloud.Types