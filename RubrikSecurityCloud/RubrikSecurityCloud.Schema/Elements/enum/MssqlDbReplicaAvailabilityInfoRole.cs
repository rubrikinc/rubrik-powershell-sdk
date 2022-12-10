// MssqlDbReplicaAvailabilityInfoRole.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:30.
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
    public enum MssqlDbReplicaAvailabilityInfoRole
    {
        [EnumMember(Value = "MSSQL_DB_REPLICA_AVAILABILITY_INFO_ROLE_PRIMARY")]
        MSSQL_DB_REPLICA_AVAILABILITY_INFO_ROLE_PRIMARY,

        [EnumMember(Value = "MSSQL_DB_REPLICA_AVAILABILITY_INFO_ROLE_RESOLVING")]
        MSSQL_DB_REPLICA_AVAILABILITY_INFO_ROLE_RESOLVING,

        [EnumMember(Value = "MSSQL_DB_REPLICA_AVAILABILITY_INFO_ROLE_SECONDARY")]
        MSSQL_DB_REPLICA_AVAILABILITY_INFO_ROLE_SECONDARY


    } // enum MssqlDbReplicaAvailabilityInfoRole

} // namespace Rubrik.SecurityCloud.Types