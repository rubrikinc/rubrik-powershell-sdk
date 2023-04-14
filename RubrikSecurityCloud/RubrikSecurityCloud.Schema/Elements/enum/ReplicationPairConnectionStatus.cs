// ReplicationPairConnectionStatus.cs
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
    public enum ReplicationPairConnectionStatus
    {
        [EnumMember(Value = "REPLICATION_ACTIVE")]
        REPLICATION_ACTIVE,

        [EnumMember(Value = "REPLICATION_DISCONNECTED")]
        REPLICATION_DISCONNECTED,

        [EnumMember(Value = "REPLICATION_PAUSED")]
        REPLICATION_PAUSED


    } // enum ReplicationPairConnectionStatus

} // namespace Rubrik.SecurityCloud.Types