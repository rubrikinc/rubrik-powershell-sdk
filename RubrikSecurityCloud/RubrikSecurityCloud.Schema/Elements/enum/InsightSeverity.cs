// InsightSeverity.cs
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
    public enum InsightSeverity
    {
        [EnumMember(Value = "CRITICAL")]
        CRITICAL,

        [EnumMember(Value = "MAJOR")]
        MAJOR,

        [EnumMember(Value = "MINOR")]
        MINOR,

        [EnumMember(Value = "NO_IMPACT")]
        NO_IMPACT,

        [EnumMember(Value = "SEVERITY_UNSPECIFIED")]
        SEVERITY_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum InsightSeverity

} // namespace RubrikSecurityCloud.Types