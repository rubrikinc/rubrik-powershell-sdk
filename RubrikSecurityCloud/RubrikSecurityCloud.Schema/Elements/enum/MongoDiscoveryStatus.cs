// MongoDiscoveryStatus.cs
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
    public enum MongoDiscoveryStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INVALID_DISCOVERY_STATUS")]
        INVALID_DISCOVERY_STATUS,

        [EnumMember(Value = "NO_DISCOVERY_IN_PROGRESS")]
        NO_DISCOVERY_IN_PROGRESS,

        [EnumMember(Value = "ON_DEMAND_DISCOVERY_IN_PROGRESS")]
        ON_DEMAND_DISCOVERY_IN_PROGRESS,

        [EnumMember(Value = "SCHEDULED_DISCOVERY_IN_PROGRESS")]
        SCHEDULED_DISCOVERY_IN_PROGRESS


    } // enum MongoDiscoveryStatus

} // namespace RubrikSecurityCloud.Types