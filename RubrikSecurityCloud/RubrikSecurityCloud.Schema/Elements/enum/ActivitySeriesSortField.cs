// ActivitySeriesSortField.cs
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
    public enum ActivitySeriesSortField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVITY_STATUS")]
        ACTIVITY_STATUS,

        [EnumMember(Value = "ACTIVITY_TYPE")]
        ACTIVITY_TYPE,

        [EnumMember(Value = "CLUSTER_NAME")]
        CLUSTER_NAME,

        [EnumMember(Value = "LAST_UPDATED")]
        LAST_UPDATED,

        [EnumMember(Value = "LOCATION")]
        LOCATION,

        [EnumMember(Value = "OBJECT_NAME")]
        OBJECT_NAME,

        [EnumMember(Value = "OBJECT_TYPE")]
        OBJECT_TYPE,

        [EnumMember(Value = "SEVERITY")]
        SEVERITY,

        [EnumMember(Value = "START_TIME")]
        START_TIME


    } // enum ActivitySeriesSortField

} // namespace RubrikSecurityCloud.Types