// RegisteredMode.cs
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
    public enum RegisteredMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

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

} // namespace RubrikSecurityCloud.Types