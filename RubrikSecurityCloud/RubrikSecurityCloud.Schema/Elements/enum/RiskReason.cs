// RiskReason.cs
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
    public enum RiskReason
    {
        [EnumMember(Value = "HIGH_RISK_ANALYZER_HITS")]
        HIGH_RISK_ANALYZER_HITS,

        [EnumMember(Value = "INSECURE_USERS")]
        INSECURE_USERS,

        [EnumMember(Value = "LOW_RISK_ANALYZER_HITS")]
        LOW_RISK_ANALYZER_HITS,

        [EnumMember(Value = "MEDIUM_RISK_ANALYZER_HITS")]
        MEDIUM_RISK_ANALYZER_HITS,

        [EnumMember(Value = "NO_RISK_ANALYZER_HITS")]
        NO_RISK_ANALYZER_HITS,

        [EnumMember(Value = "OPEN_ACCESS")]
        OPEN_ACCESS,

        [EnumMember(Value = "RISK_REASON_UNSPECIFIED")]
        RISK_REASON_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RiskReason

} // namespace RubrikSecurityCloud.Types