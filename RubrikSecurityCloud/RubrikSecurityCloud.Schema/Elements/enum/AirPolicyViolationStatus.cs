// AirPolicyViolationStatus.cs
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
    public enum AirPolicyViolationStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_DISMISSED")]
        POLICY_VIOLATION_STATUS_DISMISSED,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_IN_PROGRESS")]
        POLICY_VIOLATION_STATUS_IN_PROGRESS,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_OPEN")]
        POLICY_VIOLATION_STATUS_OPEN,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_REMEDIATED")]
        POLICY_VIOLATION_STATUS_REMEDIATED,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_UNSPECIFIED")]
        POLICY_VIOLATION_STATUS_UNSPECIFIED


    } // enum AirPolicyViolationStatus

} // namespace RubrikSecurityCloud.Types