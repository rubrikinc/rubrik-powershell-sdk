// DhrcCategory.cs
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
    public enum DhrcCategory
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ANOMALIES_DETECTED")]
        ANOMALIES_DETECTED,

        [EnumMember(Value = "CATEGORY_UNSPECIFIED")]
        CATEGORY_UNSPECIFIED,

        [EnumMember(Value = "DATA_SAFETY_SCORE")]
        DATA_SAFETY_SCORE,

        [EnumMember(Value = "RECOVERABILITY_STATUS")]
        RECOVERABILITY_STATUS,

        [EnumMember(Value = "SECURITY_CONFIG")]
        SECURITY_CONFIG,

        [EnumMember(Value = "SENSITIVE_DATA")]
        SENSITIVE_DATA,

        [EnumMember(Value = "SUSPICIOUS_USER_ACTIVITY")]
        SUSPICIOUS_USER_ACTIVITY


    } // enum DhrcCategory

} // namespace RubrikSecurityCloud.Types