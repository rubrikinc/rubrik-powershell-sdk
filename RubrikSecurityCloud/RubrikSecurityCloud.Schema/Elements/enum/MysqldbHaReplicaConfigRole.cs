// MysqldbHaReplicaConfigRole.cs
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
    public enum MysqldbHaReplicaConfigRole
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MYSQLDB_HA_REPLICA_CONFIG_ROLE_PRIMARY")]
        MYSQLDB_HA_REPLICA_CONFIG_ROLE_PRIMARY,

        [EnumMember(Value = "MYSQLDB_HA_REPLICA_CONFIG_ROLE_REPLICA")]
        MYSQLDB_HA_REPLICA_CONFIG_ROLE_REPLICA


    } // enum MysqldbHaReplicaConfigRole

} // namespace RubrikSecurityCloud.Types