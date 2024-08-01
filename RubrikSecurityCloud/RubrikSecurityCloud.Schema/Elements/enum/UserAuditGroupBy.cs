// UserAuditGroupBy.cs
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
    public enum UserAuditGroupBy
    {
        [EnumMember(Value = "AUDIT_OBJECT_TYPE")]
        AUDIT_OBJECT_TYPE,

        [EnumMember(Value = "AUDIT_STATUS")]
        AUDIT_STATUS,

        [EnumMember(Value = "AUDIT_TYPE")]
        AUDIT_TYPE,

        [EnumMember(Value = "CLUSTER_TYPE")]
        CLUSTER_TYPE,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "DAY")]
        DAY,

        [EnumMember(Value = "GROUP_BY_UNSPECIFIED")]
        GROUP_BY_UNSPECIFIED,

        [EnumMember(Value = "HOUR")]
        HOUR,

        [EnumMember(Value = "MONTH")]
        MONTH,

        [EnumMember(Value = "QUARTER")]
        QUARTER,

        [EnumMember(Value = "WEEK")]
        WEEK,

        [EnumMember(Value = "YEAR")]
        YEAR,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum UserAuditGroupBy

} // namespace RubrikSecurityCloud.Types