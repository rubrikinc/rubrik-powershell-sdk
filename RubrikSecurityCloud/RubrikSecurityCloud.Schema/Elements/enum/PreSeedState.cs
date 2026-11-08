// PreSeedState.cs
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
    public enum PreSeedState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PRE_SEED_STATE_FAILED")]
        PRE_SEED_STATE_FAILED,

        [EnumMember(Value = "PRE_SEED_STATE_PENDING")]
        PRE_SEED_STATE_PENDING,

        [EnumMember(Value = "PRE_SEED_STATE_RUNNING")]
        PRE_SEED_STATE_RUNNING,

        [EnumMember(Value = "PRE_SEED_STATE_SUCCEEDED")]
        PRE_SEED_STATE_SUCCEEDED,

        [EnumMember(Value = "PRE_SEED_STATE_UNSPECIFIED")]
        PRE_SEED_STATE_UNSPECIFIED


    } // enum PreSeedState

} // namespace RubrikSecurityCloud.Types