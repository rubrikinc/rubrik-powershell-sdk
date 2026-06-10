// DefenderAlertSeverity.cs
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
    public enum DefenderAlertSeverity
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DEFENDER_SEVERITY_HIGH")]
        DEFENDER_SEVERITY_HIGH,

        [EnumMember(Value = "DEFENDER_SEVERITY_INFORMATIONAL")]
        DEFENDER_SEVERITY_INFORMATIONAL,

        [EnumMember(Value = "DEFENDER_SEVERITY_LOW")]
        DEFENDER_SEVERITY_LOW,

        [EnumMember(Value = "DEFENDER_SEVERITY_MEDIUM")]
        DEFENDER_SEVERITY_MEDIUM


    } // enum DefenderAlertSeverity

} // namespace RubrikSecurityCloud.Types