// SlaUnsyncableReason.cs
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
    public enum SlaUnsyncableReason
    {
        [EnumMember(Value = "ALREADY_SYNCED")]
        ALREADY_SYNCED,

        [EnumMember(Value = "ARCHIVAL_CONFIGURATION")]
        ARCHIVAL_CONFIGURATION,

        [EnumMember(Value = "CLUSTER_NOT_CONFIGURED_AS_SOURCE")]
        CLUSTER_NOT_CONFIGURED_AS_SOURCE,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "REPLICATION_PAIR_NOT_EXIST")]
        REPLICATION_PAIR_NOT_EXIST,

        [EnumMember(Value = "REPLICATION_TARGET")]
        REPLICATION_TARGET,

        [EnumMember(Value = "REPLICATION_TARGET_DISCONNECTED")]
        REPLICATION_TARGET_DISCONNECTED,

        [EnumMember(Value = "UNSYNCABLE_REASON_UNSPECIFIED")]
        UNSYNCABLE_REASON_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SlaUnsyncableReason

} // namespace RubrikSecurityCloud.Types