// MssqlDbReplicaRecoveryModel.cs
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
    public enum MssqlDbReplicaRecoveryModel
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MSSQL_DB_REPLICA_RECOVERY_MODEL_BULK_LOGGED")]
        MSSQL_DB_REPLICA_RECOVERY_MODEL_BULK_LOGGED,

        [EnumMember(Value = "MSSQL_DB_REPLICA_RECOVERY_MODEL_FULL")]
        MSSQL_DB_REPLICA_RECOVERY_MODEL_FULL,

        [EnumMember(Value = "MSSQL_DB_REPLICA_RECOVERY_MODEL_SIMPLE")]
        MSSQL_DB_REPLICA_RECOVERY_MODEL_SIMPLE


    } // enum MssqlDbReplicaRecoveryModel

} // namespace RubrikSecurityCloud.Types