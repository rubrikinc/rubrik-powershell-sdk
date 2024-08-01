// SidPolicySummarySortBy.cs
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
    public enum SidPolicySummarySortBy
    {
        [EnumMember(Value = "SID_POLICY_SUMMARY_SORT_BY_UNSPECIFIED")]
        SID_POLICY_SUMMARY_SORT_BY_UNSPECIFIED,

        [EnumMember(Value = "TOTAL_SENSITIVE_HITS")]
        TOTAL_SENSITIVE_HITS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SidPolicySummarySortBy

} // namespace RubrikSecurityCloud.Types