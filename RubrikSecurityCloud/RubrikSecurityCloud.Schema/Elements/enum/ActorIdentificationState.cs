// ActorIdentificationState.cs
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
    public enum ActorIdentificationState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTOR_STATE_IDENTIFIED")]
        ACTOR_STATE_IDENTIFIED,

        [EnumMember(Value = "ACTOR_STATE_IDENTIFYING")]
        ACTOR_STATE_IDENTIFYING,

        [EnumMember(Value = "ACTOR_STATE_UNIDENTIFIED")]
        ACTOR_STATE_UNIDENTIFIED,

        [EnumMember(Value = "ACTOR_STATE_UNSPECIFIED")]
        ACTOR_STATE_UNSPECIFIED


    } // enum ActorIdentificationState

} // namespace RubrikSecurityCloud.Types