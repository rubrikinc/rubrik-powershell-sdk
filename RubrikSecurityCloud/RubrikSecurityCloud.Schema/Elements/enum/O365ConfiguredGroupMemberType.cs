// O365ConfiguredGroupMemberType.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum O365ConfiguredGroupMemberType
    {
        [EnumMember(Value = "SITE")]
        SITE,

        [EnumMember(Value = "TEAM")]
        TEAM,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum O365ConfiguredGroupMemberType

} // namespace Rubrik.SecurityCloud.Types