// HostIneligibilityReason.cs
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
    public enum HostIneligibilityReason
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "HOST_INELIGIBILITY_REASON_INVALID_PRIMARY_HOST_STATUS")]
        HOST_INELIGIBILITY_REASON_INVALID_PRIMARY_HOST_STATUS,

        [EnumMember(Value = "HOST_INELIGIBILITY_REASON_INVALID_SECONDARY_HOST_STATUS")]
        HOST_INELIGIBILITY_REASON_INVALID_SECONDARY_HOST_STATUS,

        [EnumMember(Value = "HOST_INELIGIBILITY_REASON_NONE")]
        HOST_INELIGIBILITY_REASON_NONE,

        [EnumMember(Value = "HOST_INELIGIBILITY_REASON_NOT_PRIMARY")]
        HOST_INELIGIBILITY_REASON_NOT_PRIMARY,

        [EnumMember(Value = "HOST_INELIGIBILITY_REASON_NO_AGENT")]
        HOST_INELIGIBILITY_REASON_NO_AGENT,

        [EnumMember(Value = "HOST_INELIGIBILITY_REASON_NO_SECONDARY_HOST")]
        HOST_INELIGIBILITY_REASON_NO_SECONDARY_HOST,

        [EnumMember(Value = "HOST_INELIGIBILITY_REASON_PRIMARY_IN_FAILOVER_GROUP")]
        HOST_INELIGIBILITY_REASON_PRIMARY_IN_FAILOVER_GROUP,

        [EnumMember(Value = "HOST_INELIGIBILITY_REASON_SECONDARY_IN_FAILOVER_GROUP")]
        HOST_INELIGIBILITY_REASON_SECONDARY_IN_FAILOVER_GROUP,

        [EnumMember(Value = "HOST_INELIGIBILITY_REASON_UNKNOWN")]
        HOST_INELIGIBILITY_REASON_UNKNOWN,

        [EnumMember(Value = "HOST_INELIGIBILITY_REASON_UNSPECIFIED")]
        HOST_INELIGIBILITY_REASON_UNSPECIFIED


    } // enum HostIneligibilityReason

} // namespace RubrikSecurityCloud.Types