// ActivitySeriesSortByEnum.cs
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
    public enum ActivitySeriesSortByEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ActivityStatus")]
        ACTIVITY_STATUS,

        [EnumMember(Value = "ActivityType")]
        ACTIVITY_TYPE,

        [EnumMember(Value = "ClusterName")]
        CLUSTER_NAME,

        [EnumMember(Value = "LastUpdated")]
        LAST_UPDATED,

        [EnumMember(Value = "Location")]
        LOCATION,

        [EnumMember(Value = "ObjectName")]
        OBJECT_NAME,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "Severity")]
        SEVERITY,

        [EnumMember(Value = "StartTime")]
        START_TIME


    } // enum ActivitySeriesSortByEnum

} // namespace RubrikSecurityCloud.Types