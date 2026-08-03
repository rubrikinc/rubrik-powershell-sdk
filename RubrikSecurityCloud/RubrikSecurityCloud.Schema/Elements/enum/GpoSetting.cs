// GpoSetting.cs
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
    public enum GpoSetting
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "GPO_SETTING_CONFIGURED")]
        GPO_SETTING_CONFIGURED,

        [EnumMember(Value = "GPO_SETTING_UNCONFIGURED")]
        GPO_SETTING_UNCONFIGURED


    } // enum GpoSetting

} // namespace RubrikSecurityCloud.Types