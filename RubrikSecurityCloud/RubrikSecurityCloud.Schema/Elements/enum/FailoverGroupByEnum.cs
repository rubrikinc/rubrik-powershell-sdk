// FailoverGroupByEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:37.
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
    public enum FailoverGroupByEnum
    {
        [EnumMember(Value = "Day")]
        DAY,

        [EnumMember(Value = "FailoverStatus")]
        FAILOVER_STATUS,

        [EnumMember(Value = "FailoverType")]
        FAILOVER_TYPE,

        [EnumMember(Value = "Hour")]
        HOUR,

        [EnumMember(Value = "LastTestStatus")]
        LAST_TEST_STATUS,

        [EnumMember(Value = "Month")]
        MONTH,

        [EnumMember(Value = "Quarter")]
        QUARTER,

        [EnumMember(Value = "Source")]
        SOURCE,

        [EnumMember(Value = "TargetSite")]
        TARGET_SITE,

        [EnumMember(Value = "Week")]
        WEEK,

        [EnumMember(Value = "Year")]
        YEAR


    } // enum FailoverGroupByEnum

} // namespace Rubrik.SecurityCloud.Types