// O365GroupType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:51.
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
    public enum O365GroupType
    {
        [EnumMember(Value = "AD_GROUP")]
        AD_GROUP,

        [EnumMember(Value = "CONFIGURED_GROUP")]
        CONFIGURED_GROUP,

        [EnumMember(Value = "UNTYPED_GROUP")]
        UNTYPED_GROUP


    } // enum O365GroupType

} // namespace Rubrik.SecurityCloud.Types