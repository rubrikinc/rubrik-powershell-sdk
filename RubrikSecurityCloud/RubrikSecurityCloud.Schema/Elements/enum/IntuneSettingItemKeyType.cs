// IntuneSettingItemKeyType.cs
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
    public enum IntuneSettingItemKeyType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INTUNE_SETTING_ITEM_KEY_TYPE_DEVICE_NAME")]
        INTUNE_SETTING_ITEM_KEY_TYPE_DEVICE_NAME,

        [EnumMember(Value = "INTUNE_SETTING_ITEM_KEY_TYPE_NAME")]
        INTUNE_SETTING_ITEM_KEY_TYPE_NAME,

        [EnumMember(Value = "INTUNE_SETTING_ITEM_KEY_TYPE_UNKNOWN")]
        INTUNE_SETTING_ITEM_KEY_TYPE_UNKNOWN


    } // enum IntuneSettingItemKeyType

} // namespace RubrikSecurityCloud.Types