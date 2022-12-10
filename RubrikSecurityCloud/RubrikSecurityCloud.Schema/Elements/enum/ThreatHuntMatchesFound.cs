// ThreatHuntMatchesFound.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:39.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum ThreatHuntMatchesFound
    {
        [EnumMember(Value = "MATCHES_FOUND")]
        MATCHES_FOUND,

        [EnumMember(Value = "MATCHES_FOUND_UNSPECIFIED")]
        MATCHES_FOUND_UNSPECIFIED,

        [EnumMember(Value = "NO_MATCHES")]
        NO_MATCHES


    } // enum ThreatHuntMatchesFound

} // namespace Rubrik.SecurityCloud.Types