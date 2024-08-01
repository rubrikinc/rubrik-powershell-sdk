// ListPrincipalsSummarySortBy.cs
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
    public enum ListPrincipalsSummarySortBy
    {
        [EnumMember(Value = "RISK_LEVEL")]
        RISK_LEVEL,

        [EnumMember(Value = "RISK_SENSITIVE_FILES")]
        RISK_SENSITIVE_FILES,

        [EnumMember(Value = "RISK_SENSITIVE_HITS")]
        RISK_SENSITIVE_HITS,

        [EnumMember(Value = "RISK_TOTAL_SENSITIVE_HITS")]
        RISK_TOTAL_SENSITIVE_HITS,

        [EnumMember(Value = "SID")]
        SID,

        [EnumMember(Value = "TOTAL_SENSITIVE_FILES")]
        TOTAL_SENSITIVE_FILES,

        [EnumMember(Value = "TOTAL_SENSITIVE_HITS")]
        TOTAL_SENSITIVE_HITS,

        [EnumMember(Value = "TOTAL_SENSITIVE_OBJECTS")]
        TOTAL_SENSITIVE_OBJECTS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ListPrincipalsSummarySortBy

} // namespace RubrikSecurityCloud.Types