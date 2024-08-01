// InterfaceType.cs
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
    public enum InterfaceType
    {
        [EnumMember(Value = "BOND0")]
        BON_D0,

        [EnumMember(Value = "BOND1")]
        BON_D1,

        [EnumMember(Value = "CUSTOM")]
        CUSTOM,

        [EnumMember(Value = "UNKNOWN_TYPE")]
        UNKNOWN_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum InterfaceType

} // namespace RubrikSecurityCloud.Types