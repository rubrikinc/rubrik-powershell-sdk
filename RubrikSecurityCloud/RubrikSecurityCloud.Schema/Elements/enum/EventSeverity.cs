// EventSeverity.cs
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
    public enum EventSeverity
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SEVERITY_CRITICAL")]
        SEVERITY_CRITICAL,

        [EnumMember(Value = "SEVERITY_INFO")]
        SEVERITY_INFO,

        [EnumMember(Value = "SEVERITY_WARNING")]
        SEVERITY_WARNING


    } // enum EventSeverity

} // namespace RubrikSecurityCloud.Types