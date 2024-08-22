// AuditSeverity.cs
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
    public enum AuditSeverity
    {
        [EnumMember(Value = "CRITICAL")]
        CRITICAL,

        [EnumMember(Value = "INFO")]
        INFO,

        [EnumMember(Value = "SEVERITY_UNSPECIFIED")]
        SEVERITY_UNSPECIFIED,

        [EnumMember(Value = "WARNING")]
        WARNING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AuditSeverity

} // namespace RubrikSecurityCloud.Types