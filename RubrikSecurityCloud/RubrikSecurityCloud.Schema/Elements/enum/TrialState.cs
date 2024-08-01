// TrialState.cs
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
    public enum TrialState
    {
        [EnumMember(Value = "ACTIVATION_FAILED")]
        ACTIVATION_FAILED,

        [EnumMember(Value = "ACTIVATION_PENDING")]
        ACTIVATION_PENDING,

        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        [EnumMember(Value = "DISABLED")]
        DISABLED,

        [EnumMember(Value = "DISABLE_FAILED")]
        DISABLE_FAILED,

        [EnumMember(Value = "DISABLE_PENDING")]
        DISABLE_PENDING,

        [EnumMember(Value = "EXPIRATION_PENDING")]
        EXPIRATION_PENDING,

        [EnumMember(Value = "EXPIRED")]
        EXPIRED,

        [EnumMember(Value = "IGNORED")]
        IGNORED,

        [EnumMember(Value = "INACTIVE")]
        INACTIVE,

        [EnumMember(Value = "UNSPECIFIED_STATE")]
        UNSPECIFIED_STATE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TrialState

} // namespace RubrikSecurityCloud.Types