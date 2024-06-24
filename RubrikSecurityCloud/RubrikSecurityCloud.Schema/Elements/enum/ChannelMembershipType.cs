// ChannelMembershipType.cs
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
    public enum ChannelMembershipType
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "PRIVATE")]
        PRIVATE,

        [EnumMember(Value = "SHARED")]
        SHARED,

        [EnumMember(Value = "STANDARD")]
        STANDARD


    } // enum ChannelMembershipType

} // namespace RubrikSecurityCloud.Types