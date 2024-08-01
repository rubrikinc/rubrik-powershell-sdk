// MssqlDbReplicaAvailabilityInfoRole.cs
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
    public enum MssqlDbReplicaAvailabilityInfoRole
    {
        [EnumMember(Value = "MSSQL_DB_REPLICA_AVAILABILITY_INFO_ROLE_PRIMARY")]
        MSSQL_DB_REPLICA_AVAILABILITY_INFO_ROLE_PRIMARY,

        [EnumMember(Value = "MSSQL_DB_REPLICA_AVAILABILITY_INFO_ROLE_RESOLVING")]
        MSSQL_DB_REPLICA_AVAILABILITY_INFO_ROLE_RESOLVING,

        [EnumMember(Value = "MSSQL_DB_REPLICA_AVAILABILITY_INFO_ROLE_SECONDARY")]
        MSSQL_DB_REPLICA_AVAILABILITY_INFO_ROLE_SECONDARY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MssqlDbReplicaAvailabilityInfoRole

} // namespace RubrikSecurityCloud.Types