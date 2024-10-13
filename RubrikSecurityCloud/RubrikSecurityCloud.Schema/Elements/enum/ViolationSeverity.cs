// ViolationSeverity.cs
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
    public enum ViolationSeverity
    {
        [EnumMember(Value = "CRITICAL")]
        CRITICAL,

        [EnumMember(Value = "HIGH")]
        HIGH,

        [EnumMember(Value = "LOW")]
        LOW,

        [EnumMember(Value = "MEDIUM")]
        MEDIUM,

        [EnumMember(Value = "SEVERITY_UNSPECIFIED")]
        SEVERITY_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ViolationSeverity

} // namespace RubrikSecurityCloud.Types