// ThreatHuntMatchesFound.cs
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
    public enum ThreatHuntMatchesFound
    {
        [EnumMember(Value = "MATCHES_FOUND")]
        MATCHES_FOUND,

        [EnumMember(Value = "MATCHES_FOUND_UNSPECIFIED")]
        MATCHES_FOUND_UNSPECIFIED,

        [EnumMember(Value = "NO_MATCHES")]
        NO_MATCHES,

        [EnumMember(Value = "UNSCANNED")]
        UNSCANNED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ThreatHuntMatchesFound

} // namespace RubrikSecurityCloud.Types