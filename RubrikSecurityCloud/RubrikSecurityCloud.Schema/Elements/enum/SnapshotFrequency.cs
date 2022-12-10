// SnapshotFrequency.cs
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
    public enum SnapshotFrequency
    {
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

} // namespace Rubrik.SecurityCloud.Types