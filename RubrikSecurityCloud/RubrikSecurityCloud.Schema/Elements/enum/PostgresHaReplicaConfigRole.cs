// PostgresHaReplicaConfigRole.cs
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
    public enum PostgresHaReplicaConfigRole
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "POSTGRES_HA_REPLICA_CONFIG_ROLE_PRIMARY")]
        POSTGRES_HA_REPLICA_CONFIG_ROLE_PRIMARY,

        [EnumMember(Value = "POSTGRES_HA_REPLICA_CONFIG_ROLE_STANDBY")]
        POSTGRES_HA_REPLICA_CONFIG_ROLE_STANDBY


    } // enum PostgresHaReplicaConfigRole

} // namespace RubrikSecurityCloud.Types