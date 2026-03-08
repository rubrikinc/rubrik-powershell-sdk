// RemediationState.cs
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
    public enum RemediationState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "REMEDIATION_STATE_CLOSED")]
        REMEDIATION_STATE_CLOSED,

        [EnumMember(Value = "REMEDIATION_STATE_FAILED")]
        REMEDIATION_STATE_FAILED,

        [EnumMember(Value = "REMEDIATION_STATE_IN_PROGRESS")]
        REMEDIATION_STATE_IN_PROGRESS,

        [EnumMember(Value = "REMEDIATION_STATE_SUCCESS")]
        REMEDIATION_STATE_SUCCESS,

        [EnumMember(Value = "REMEDIATION_STATE_UNSPECIFIED")]
        REMEDIATION_STATE_UNSPECIFIED


    } // enum RemediationState

} // namespace RubrikSecurityCloud.Types