// OktaGeneralSecuritySettingType.cs
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
    public enum OktaGeneralSecuritySettingType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "GENERAL_SECURITY_SETTING_TYPE_THREAT_INSIGHT")]
        GENERAL_SECURITY_SETTING_TYPE_THREAT_INSIGHT,

        [EnumMember(Value = "GENERAL_SECURITY_SETTING_TYPE_UNSPECIFIED")]
        GENERAL_SECURITY_SETTING_TYPE_UNSPECIFIED


    } // enum OktaGeneralSecuritySettingType

} // namespace RubrikSecurityCloud.Types