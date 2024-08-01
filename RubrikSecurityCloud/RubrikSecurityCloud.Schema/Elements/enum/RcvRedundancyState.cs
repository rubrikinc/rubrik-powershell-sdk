// RcvRedundancyState.cs
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
    public enum RcvRedundancyState
    {
        [EnumMember(Value = "P_FIP")]
        P_FIP,

        [EnumMember(Value = "P_GRS")]
        P_GRS,

        [EnumMember(Value = "P_LRS")]
        P_LRS,

        [EnumMember(Value = "P_RIP")]
        P_RIP,

        [EnumMember(Value = "S_FIP")]
        S_FIP,

        [EnumMember(Value = "S_GRS")]
        S_GRS,

        [EnumMember(Value = "S_LRS")]
        S_LRS,

        [EnumMember(Value = "S_RIP")]
        S_RIP,

        [EnumMember(Value = "UNKNOWN_REDUNDANCY_STATE")]
        UNKNOWN_REDUNDANCY_STATE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RcvRedundancyState

} // namespace RubrikSecurityCloud.Types