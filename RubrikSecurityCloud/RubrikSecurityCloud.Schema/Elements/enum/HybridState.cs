// HybridState.cs
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
    public enum HybridState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLOUD_ONLY")]
        CLOUD_ONLY,

        [EnumMember(Value = "HYBRID")]
        HYBRID,

        [EnumMember(Value = "HYBRID_STATE_UNSPECIFIED")]
        HYBRID_STATE_UNSPECIFIED,

        [EnumMember(Value = "ONPREM_ONLY")]
        ONPREM_ONLY


    } // enum HybridState

} // namespace RubrikSecurityCloud.Types