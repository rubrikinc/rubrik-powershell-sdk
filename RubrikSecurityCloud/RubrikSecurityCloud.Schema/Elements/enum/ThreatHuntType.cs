// ThreatHuntType.cs
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
    public enum ThreatHuntType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "THREAT_HUNT_V1")]
        THREAT_HUNT_V1,

        [EnumMember(Value = "THREAT_HUNT_V2")]
        THREAT_HUNT_V2,

        [EnumMember(Value = "TURBO_THREAT_HUNT")]
        TURBO_THREAT_HUNT


    } // enum ThreatHuntType

} // namespace RubrikSecurityCloud.Types