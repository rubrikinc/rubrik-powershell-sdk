// SensitivityStatus.cs
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
    public enum SensitivityStatus
    {
        [EnumMember(Value = "HIGH")]
        HIGH,

        [EnumMember(Value = "LOW")]
        LOW,

        [EnumMember(Value = "MEDIUM")]
        MEDIUM,

        [EnumMember(Value = "NON_SENSITIVE")]
        NON_SENSITIVE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SensitivityStatus

} // namespace RubrikSecurityCloud.Types