// RiskLevelType.cs
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
    public enum RiskLevelType
    {
        [EnumMember(Value = "HIGH_RISK")]
        HIGH_RISK,

        [EnumMember(Value = "LOW_RISK")]
        LOW_RISK,

        [EnumMember(Value = "MEDIUM_RISK")]
        MEDIUM_RISK,

        [EnumMember(Value = "NO_RISK")]
        NO_RISK,

        [EnumMember(Value = "UNKNOWN_RISK")]
        UNKNOWN_RISK


    } // enum RiskLevelType

} // namespace RubrikSecurityCloud.Types