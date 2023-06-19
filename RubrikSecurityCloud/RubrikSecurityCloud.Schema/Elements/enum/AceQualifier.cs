// AceQualifier.cs
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

} // namespace RubrikSecurityCloud.Types