// ArchivalLocationIneligibilityReason.cs
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
    public enum ArchivalLocationIneligibilityReason
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NONE")]
        ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NONE,

        [EnumMember(Value = "ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NOT_ACTIVE")]
        ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NOT_ACTIVE,

        [EnumMember(Value = "ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NOT_CONNECTED")]
        ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NOT_CONNECTED,

        [EnumMember(Value = "ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NOT_OWNER")]
        ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NOT_OWNER,

        [EnumMember(Value = "ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NO_READER_LOCATION")]
        ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NO_READER_LOCATION,

        [EnumMember(Value = "ARCHIVAL_LOCATION_INELIGIBILITY_REASON_PRIMARY_IN_FAILOVER_GROUP")]
        ARCHIVAL_LOCATION_INELIGIBILITY_REASON_PRIMARY_IN_FAILOVER_GROUP,

        [EnumMember(Value = "ARCHIVAL_LOCATION_INELIGIBILITY_REASON_SECONDARY_IN_FAILOVER_GROUP")]
        ARCHIVAL_LOCATION_INELIGIBILITY_REASON_SECONDARY_IN_FAILOVER_GROUP,

        [EnumMember(Value = "ARCHIVAL_LOCATION_INELIGIBILITY_REASON_UNSPECIFIED")]
        ARCHIVAL_LOCATION_INELIGIBILITY_REASON_UNSPECIFIED,

        [EnumMember(Value = "ARCHIVAL_LOCATION_INELIGIBILITY_REASON_UNSUPPORTED_TYPE")]
        ARCHIVAL_LOCATION_INELIGIBILITY_REASON_UNSUPPORTED_TYPE


    } // enum ArchivalLocationIneligibilityReason

} // namespace RubrikSecurityCloud.Types