// ActivityTableColumnEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:38.
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
    public enum ActivityTableColumnEnum
    {
        [EnumMember(Value = "ActivityStatus")]
        ACTIVITY_STATUS,

        [EnumMember(Value = "ActivityType")]
        ACTIVITY_TYPE,

        [EnumMember(Value = "ClusterName")]
        CLUSTER_NAME,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "ComplianceStatus")]
        COMPLIANCE_STATUS,

        [EnumMember(Value = "LastUpdated")]
        LAST_UPDATED,

        [EnumMember(Value = "Location")]
        LOCATION,

        [EnumMember(Value = "ObjectName")]
        OBJECT_NAME,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "SlaDomain")]
        SLA_DOMAIN,

        [EnumMember(Value = "StartTime")]
        START_TIME


    } // enum ActivityTableColumnEnum

} // namespace Rubrik.SecurityCloud.Types