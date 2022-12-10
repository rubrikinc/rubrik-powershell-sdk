// InterfaceType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:24.
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
    public enum InterfaceType
    {
        [EnumMember(Value = "BOND0")]
        BON_D0,

        [EnumMember(Value = "BOND1")]
        BON_D1,

        [EnumMember(Value = "CUSTOM")]
        CUSTOM,

        [EnumMember(Value = "UNKNOWN_TYPE")]
        UNKNOWN_TYPE


    } // enum InterfaceType

} // namespace Rubrik.SecurityCloud.Types