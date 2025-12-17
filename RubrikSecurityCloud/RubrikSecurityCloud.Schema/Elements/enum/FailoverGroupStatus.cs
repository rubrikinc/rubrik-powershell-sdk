// FailoverGroupStatus.cs
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
    public enum FailoverGroupStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_FAILBACK_COMPLETED")]
        FAILOVER_GROUP_STATUS_FAILBACK_COMPLETED,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_FAILBACK_IN_PROGRESS")]
        FAILOVER_GROUP_STATUS_FAILBACK_IN_PROGRESS,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_FAILOVER_COMPLETED")]
        FAILOVER_GROUP_STATUS_FAILOVER_COMPLETED,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_FAILOVER_FAILED")]
        FAILOVER_GROUP_STATUS_FAILOVER_FAILED,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_FAILOVER_IN_PROGRESS")]
        FAILOVER_GROUP_STATUS_FAILOVER_IN_PROGRESS,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_NO_SLA_DOMAIN_ASSIGNED")]
        FAILOVER_GROUP_STATUS_NO_SLA_DOMAIN_ASSIGNED,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_PARTIAL_FAILOVER")]
        FAILOVER_GROUP_STATUS_PARTIAL_FAILOVER,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_READY_TO_FAILOVER")]
        FAILOVER_GROUP_STATUS_READY_TO_FAILOVER,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_UNSPECIFIED")]
        FAILOVER_GROUP_STATUS_UNSPECIFIED


    } // enum FailoverGroupStatus

} // namespace RubrikSecurityCloud.Types