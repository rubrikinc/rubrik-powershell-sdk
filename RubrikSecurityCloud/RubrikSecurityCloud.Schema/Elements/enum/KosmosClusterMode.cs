// KosmosClusterMode.cs
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
    public enum KosmosClusterMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "HA")]
        HA,

        [EnumMember(Value = "STANDALONE")]
        STANDALONE,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum KosmosClusterMode

} // namespace RubrikSecurityCloud.Types