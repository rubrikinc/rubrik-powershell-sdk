// GpoStatusEnum.cs
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
    public enum GpoStatusEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "GPO_ALL_SETTINGS_DISABLED")]
        GPO_ALL_SETTINGS_DISABLED,

        [EnumMember(Value = "GPO_COMPUTER_SETTINGS_DISABLED")]
        GPO_COMPUTER_SETTINGS_DISABLED,

        [EnumMember(Value = "GPO_ENABLED")]
        GPO_ENABLED,

        [EnumMember(Value = "GPO_USER_SETTINGS_DISABLED")]
        GPO_USER_SETTINGS_DISABLED


    } // enum GpoStatusEnum

} // namespace RubrikSecurityCloud.Types