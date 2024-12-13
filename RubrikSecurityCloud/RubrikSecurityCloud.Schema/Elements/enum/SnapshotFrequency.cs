// SnapshotFrequency.cs
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
    public enum SnapshotFrequency
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DAILY")]
        DAILY,

        [EnumMember(Value = "HOURLY")]
        HOURLY,

        [EnumMember(Value = "MONTHLY")]
        MONTHLY,

        [EnumMember(Value = "NA")]
        NA,

        [EnumMember(Value = "QUARTERLY")]
        QUARTERLY,

        [EnumMember(Value = "WEEKLY")]
        WEEKLY,

        [EnumMember(Value = "YEARLY")]
        YEARLY


    } // enum SnapshotFrequency

} // namespace RubrikSecurityCloud.Types