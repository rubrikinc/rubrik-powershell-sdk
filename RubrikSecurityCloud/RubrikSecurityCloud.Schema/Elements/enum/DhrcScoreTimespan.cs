// DhrcScoreTimespan.cs
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
        YEAR,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum DhrcScoreTimespan

} // namespace RubrikSecurityCloud.Types