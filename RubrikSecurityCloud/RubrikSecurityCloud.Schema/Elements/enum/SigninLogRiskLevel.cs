// SigninLogRiskLevel.cs
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
    public enum SigninLogRiskLevel
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SIGNIN_LOG_RISK_LEVEL_HIGH")]
        SIGNIN_LOG_RISK_LEVEL_HIGH,

        [EnumMember(Value = "SIGNIN_LOG_RISK_LEVEL_LOW")]
        SIGNIN_LOG_RISK_LEVEL_LOW,

        [EnumMember(Value = "SIGNIN_LOG_RISK_LEVEL_MEDIUM")]
        SIGNIN_LOG_RISK_LEVEL_MEDIUM,

        [EnumMember(Value = "SIGNIN_LOG_RISK_LEVEL_NONE")]
        SIGNIN_LOG_RISK_LEVEL_NONE


    } // enum SigninLogRiskLevel

} // namespace RubrikSecurityCloud.Types