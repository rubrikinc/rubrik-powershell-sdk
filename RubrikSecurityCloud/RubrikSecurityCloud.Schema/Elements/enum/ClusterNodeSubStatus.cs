// ClusterNodeSubStatus.cs
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
    public enum ClusterNodeSubStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DYNAMIC")]
        DYNAMIC,

        [EnumMember(Value = "NONE")]
        NONE,

        [EnumMember(Value = "PURE_METADATA")]
        PURE_METADATA,

        [EnumMember(Value = "QUIESCE")]
        QUIESCE


    } // enum ClusterNodeSubStatus

} // namespace RubrikSecurityCloud.Types