// DhrcCategory.cs
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
    public enum DhrcCategory
    {
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

} // namespace Rubrik.SecurityCloud.Types