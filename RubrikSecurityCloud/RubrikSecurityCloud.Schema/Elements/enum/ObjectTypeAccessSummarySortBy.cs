// ObjectTypeAccessSummarySortBy.cs
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
    public enum ObjectTypeAccessSummarySortBy
    {
        [EnumMember(Value = "SORT_BY_UNSPECIFIED")]
        SORT_BY_UNSPECIFIED,

        [EnumMember(Value = "TOTAL_HIGH_RISK_HITS")]
        TOTAL_HIGH_RISK_HITS,

        [EnumMember(Value = "TOTAL_HITS")]
        TOTAL_HITS,

        [EnumMember(Value = "TOTAL_LOW_RISK_HITS")]
        TOTAL_LOW_RISK_HITS,

        [EnumMember(Value = "TOTAL_MEDIUM_RISK_HITS")]
        TOTAL_MEDIUM_RISK_HITS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ObjectTypeAccessSummarySortBy

} // namespace RubrikSecurityCloud.Types