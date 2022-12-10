// RegisteredMode.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:17.
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
    public enum RegisteredMode
    {
        [EnumMember(Value = "REGISTERED_MODE_ENUM_HYBRID")]
        REGISTERED_MODE_ENUM_HYBRID,

        [EnumMember(Value = "REGISTERED_MODE_ENUM_LEGACY")]
        REGISTERED_MODE_ENUM_LEGACY,

        [EnumMember(Value = "REGISTERED_MODE_ENUM_LIFE_OF_DEVICE")]
        REGISTERED_MODE_ENUM_LIFE_OF_DEVICE,

        [EnumMember(Value = "REGISTERED_MODE_ENUM_NOT_REGISTERED")]
        REGISTERED_MODE_ENUM_NOT_REGISTERED,

        [EnumMember(Value = "REGISTERED_MODE_ENUM_UNSPECIFIED")]
        REGISTERED_MODE_ENUM_UNSPECIFIED


    } // enum RegisteredMode

} // namespace Rubrik.SecurityCloud.Types