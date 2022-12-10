// DhrcScoreTimespan.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:24.
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
    public enum DhrcScoreTimespan
    {
        [EnumMember(Value = "MONTH")]
        MONTH,

        [EnumMember(Value = "THREE_DAYS")]
        THREE_DAYS,

        [EnumMember(Value = "THREE_MONTHS")]
        THREE_MONTHS,

        [EnumMember(Value = "TIMESPAN_UNSPECIFIED")]
        TIMESPAN_UNSPECIFIED,

        [EnumMember(Value = "WEEK")]
        WEEK,

        [EnumMember(Value = "YEAR")]
        YEAR


    } // enum DhrcScoreTimespan

} // namespace Rubrik.SecurityCloud.Types