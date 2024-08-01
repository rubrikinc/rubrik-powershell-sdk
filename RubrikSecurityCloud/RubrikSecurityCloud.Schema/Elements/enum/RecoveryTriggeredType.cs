// RecoveryTriggeredType.cs
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
    public enum RecoveryTriggeredType
    {
        [EnumMember(Value = "APPFLOWS")]
        APPFLOWS,

        [EnumMember(Value = "RADAR")]
        RADAR,

        [EnumMember(Value = "SCHEDULE")]
        SCHEDULE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RecoveryTriggeredType

} // namespace RubrikSecurityCloud.Types