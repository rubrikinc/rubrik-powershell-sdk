// ReplicationPairPauseStatus.cs
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
    public enum ReplicationPairPauseStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "REPLICATION_PAIR_NOT_PAUSED")]
        REPLICATION_PAIR_NOT_PAUSED,

        [EnumMember(Value = "REPLICATION_PAIR_PAUSED")]
        REPLICATION_PAIR_PAUSED,

        [EnumMember(Value = "REPLICATION_PAUSE_UNSPECIFIED")]
        REPLICATION_PAUSE_UNSPECIFIED


    } // enum ReplicationPairPauseStatus

} // namespace RubrikSecurityCloud.Types