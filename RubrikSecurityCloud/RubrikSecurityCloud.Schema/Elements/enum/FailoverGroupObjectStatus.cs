// FailoverGroupObjectStatus.cs
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
    public enum FailoverGroupObjectStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FAILOVER_GROUP_OBJECT_STATUS_DISCONNECTED")]
        FAILOVER_GROUP_OBJECT_STATUS_DISCONNECTED,

        [EnumMember(Value = "FAILOVER_GROUP_OBJECT_STATUS_FAILBACK_COMPLETED")]
        FAILOVER_GROUP_OBJECT_STATUS_FAILBACK_COMPLETED,

        [EnumMember(Value = "FAILOVER_GROUP_OBJECT_STATUS_FAILBACK_IN_PROGRESS")]
        FAILOVER_GROUP_OBJECT_STATUS_FAILBACK_IN_PROGRESS,

        [EnumMember(Value = "FAILOVER_GROUP_OBJECT_STATUS_FAILOVER_IN_PROGRESS")]
        FAILOVER_GROUP_OBJECT_STATUS_FAILOVER_IN_PROGRESS,

        [EnumMember(Value = "FAILOVER_GROUP_OBJECT_STATUS_INCONSISTENT_REPLICATION")]
        FAILOVER_GROUP_OBJECT_STATUS_INCONSISTENT_REPLICATION,

        [EnumMember(Value = "FAILOVER_GROUP_OBJECT_STATUS_READY_TO_FAILBACK")]
        FAILOVER_GROUP_OBJECT_STATUS_READY_TO_FAILBACK,

        [EnumMember(Value = "FAILOVER_GROUP_OBJECT_STATUS_READY_TO_FAILOVER")]
        FAILOVER_GROUP_OBJECT_STATUS_READY_TO_FAILOVER,

        [EnumMember(Value = "FAILOVER_GROUP_OBJECT_STATUS_UNSPECIFIED")]
        FAILOVER_GROUP_OBJECT_STATUS_UNSPECIFIED,

        [EnumMember(Value = "FAILOVER_GROUP_OBJECT_STATUS_WARNING")]
        FAILOVER_GROUP_OBJECT_STATUS_WARNING


    } // enum FailoverGroupObjectStatus

} // namespace RubrikSecurityCloud.Types