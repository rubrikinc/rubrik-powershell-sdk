// KosmosTopologyReplicaRole.cs
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
    public enum KosmosTopologyReplicaRole
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PRIMARY")]
        PRIMARY,

        [EnumMember(Value = "SECONDARY")]
        SECONDARY,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum KosmosTopologyReplicaRole

} // namespace RubrikSecurityCloud.Types