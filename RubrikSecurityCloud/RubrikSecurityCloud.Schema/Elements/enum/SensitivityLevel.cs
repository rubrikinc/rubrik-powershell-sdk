// SensitivityLevel.cs
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
    public enum SensitivityLevel
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "HIGH_SENSITIVITY")]
        HIGH_SENSITIVITY,

        [EnumMember(Value = "LOW_SENSITIVITY")]
        LOW_SENSITIVITY,

        [EnumMember(Value = "MEDIUM_SENSITIVITY")]
        MEDIUM_SENSITIVITY,

        [EnumMember(Value = "NO_SENSITIVITY")]
        NO_SENSITIVITY,

        [EnumMember(Value = "UNKNOWN_SENSITIVITY")]
        UNKNOWN_SENSITIVITY


    } // enum SensitivityLevel

} // namespace RubrikSecurityCloud.Types