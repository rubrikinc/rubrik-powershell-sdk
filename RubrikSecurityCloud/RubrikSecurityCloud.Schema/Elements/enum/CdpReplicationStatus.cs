// CdpReplicationStatus.cs
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
    public enum CdpReplicationStatus
    {
        [EnumMember(Value = "CDP_REPLICATION_STATUS_FAILED")]
        CDP_REPLICATION_STATUS_FAILED,

        [EnumMember(Value = "CDP_REPLICATION_STATUS_HEALTHY")]
        CDP_REPLICATION_STATUS_HEALTHY,

        [EnumMember(Value = "CDP_REPLICATION_STATUS_INITIALIZING")]
        CDP_REPLICATION_STATUS_INITIALIZING,

        [EnumMember(Value = "CDP_REPLICATION_STATUS_NOT_ENABLED")]
        CDP_REPLICATION_STATUS_NOT_ENABLED


    } // enum CdpReplicationStatus

} // namespace RubrikSecurityCloud.Types