// GpoStatus.cs
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
    public enum GpoStatus
    {
        [EnumMember(Value = "COMPUTER_SETTINGS_DISABLED")]
        COMPUTER_SETTINGS_DISABLED,

        [EnumMember(Value = "DISABLED")]
        DISABLED,

        [EnumMember(Value = "ENABLED")]
        ENABLED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "USER_SETTINGS_DISABLED")]
        USER_SETTINGS_DISABLED


    } // enum GpoStatus

} // namespace RubrikSecurityCloud.Types