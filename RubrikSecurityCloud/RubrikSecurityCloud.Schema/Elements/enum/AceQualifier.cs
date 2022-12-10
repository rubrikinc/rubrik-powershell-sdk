// AceQualifier.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:29.
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
    public enum AceQualifier
    {
        [EnumMember(Value = "ACCESS_ALLOWED")]
        ACCESS_ALLOWED,

        [EnumMember(Value = "ACCESS_DENIED")]
        ACCESS_DENIED,

        [EnumMember(Value = "CUSTOM")]
        CUSTOM,

        [EnumMember(Value = "SYSTEM_ALARM")]
        SYSTEM_ALARM,

        [EnumMember(Value = "SYSTEM_AUDIT")]
        SYSTEM_AUDIT


    } // enum AceQualifier

} // namespace Rubrik.SecurityCloud.Types