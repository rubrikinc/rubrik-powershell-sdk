// ActorType.cs
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
    public enum ActorType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTOR_TYPE_UNSPECIFIED")]
        ACTOR_TYPE_UNSPECIFIED,

        [EnumMember(Value = "HUMAN_USER")]
        HUMAN_USER,

        [EnumMember(Value = "PERSONAL_ACCESS_TOKEN")]
        PERSONAL_ACCESS_TOKEN,

        [EnumMember(Value = "RUBRIK_AI")]
        RUBRIK_AI,

        [EnumMember(Value = "SERVICE_ACCOUNT")]
        SERVICE_ACCOUNT


    } // enum ActorType

} // namespace RubrikSecurityCloud.Types