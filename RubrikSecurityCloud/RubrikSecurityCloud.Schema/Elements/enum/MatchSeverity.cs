// MatchSeverity.cs
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
    public enum MatchSeverity
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CRITICAL")]
        CRITICAL,

        [EnumMember(Value = "MATCH_SEVERITY_UNSPECIFIED")]
        MATCH_SEVERITY_UNSPECIFIED,

        [EnumMember(Value = "WARNING")]
        WARNING


    } // enum MatchSeverity

} // namespace RubrikSecurityCloud.Types