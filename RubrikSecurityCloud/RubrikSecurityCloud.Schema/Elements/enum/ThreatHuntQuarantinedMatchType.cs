// ThreatHuntQuarantinedMatchType.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum ThreatHuntQuarantinedMatchType
    {
        [EnumMember(Value = "NO_QUARANTINED_MATCHES")]
        NO_QUARANTINED_MATCHES,

        [EnumMember(Value = "QUARANTINED_MATCHES")]
        QUARANTINED_MATCHES,

        [EnumMember(Value = "QUARANTINED_MATCHES_UNSPECIFIED")]
        QUARANTINED_MATCHES_UNSPECIFIED


    } // enum ThreatHuntQuarantinedMatchType

} // namespace Rubrik.SecurityCloud.Types