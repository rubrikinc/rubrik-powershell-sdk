// WhitelistModeEnum.cs
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
    public enum WhitelistModeEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ALL_USERS")]
        ALL_USERS,

        [EnumMember(Value = "LOCAL_USERS")]
        LOCAL_USERS


    } // enum WhitelistModeEnum

} // namespace RubrikSecurityCloud.Types