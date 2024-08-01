// SnappableGroupByEnum.cs
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
    public enum SnappableGroupByEnum
    {
        [EnumMember(Value = "Cluster")]
        CLUSTER,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "ComplianceStatus")]
        COMPLIANCE_STATUS,

        [EnumMember(Value = "Day")]
        DAY,

        [EnumMember(Value = "Hour")]
        HOUR,

        [EnumMember(Value = "Month")]
        MONTH,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "ProtectionStatus")]
        PROTECTION_STATUS,

        [EnumMember(Value = "PullTimeWithOffset")]
        PULL_TIME_WITH_OFFSET,

        [EnumMember(Value = "Quarter")]
        QUARTER,

        [EnumMember(Value = "SlaDomain")]
        SLA_DOMAIN,

        [EnumMember(Value = "TRANSFERRED_BYTES_OBJECT_TYPE")]
        TRANSFERRED_BYTES_OBJECT_TYPE,

        [EnumMember(Value = "Week")]
        WEEK,

        [EnumMember(Value = "Year")]
        YEAR,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SnappableGroupByEnum

} // namespace RubrikSecurityCloud.Types