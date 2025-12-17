// NetworkInterfaceSetting.cs
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
    public enum NetworkInterfaceSetting
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NETWORK_INTERFACE_SETTING_INTACT")]
        NETWORK_INTERFACE_SETTING_INTACT,

        [EnumMember(Value = "NETWORK_INTERFACE_SETTING_SOURCE_DC_NETWORK_INTERFACE")]
        NETWORK_INTERFACE_SETTING_SOURCE_DC_NETWORK_INTERFACE,

        [EnumMember(Value = "NETWORK_INTERFACE_SETTING_TARGET_HOST_NETWORK_INTERFACE")]
        NETWORK_INTERFACE_SETTING_TARGET_HOST_NETWORK_INTERFACE


    } // enum NetworkInterfaceSetting

} // namespace RubrikSecurityCloud.Types