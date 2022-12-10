// ActivitySeriesSortField.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:05.
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
    public enum ActivitySeriesSortField
    {
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

} // namespace Rubrik.SecurityCloud.Types