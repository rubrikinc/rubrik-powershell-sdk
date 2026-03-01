// MysqldbOnDemandSnapshotConfigSnapshotType.cs
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
    public enum MysqldbOnDemandSnapshotConfigSnapshotType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MYSQLDB_ON_DEMAND_SNAPSHOT_CONFIG_SNAPSHOT_TYPE_FULL")]
        MYSQLDB_ON_DEMAND_SNAPSHOT_CONFIG_SNAPSHOT_TYPE_FULL,

        [EnumMember(Value = "MYSQLDB_ON_DEMAND_SNAPSHOT_CONFIG_SNAPSHOT_TYPE_INCREMENTAL")]
        MYSQLDB_ON_DEMAND_SNAPSHOT_CONFIG_SNAPSHOT_TYPE_INCREMENTAL,

        [EnumMember(Value = "MYSQLDB_ON_DEMAND_SNAPSHOT_CONFIG_SNAPSHOT_TYPE_LOG")]
        MYSQLDB_ON_DEMAND_SNAPSHOT_CONFIG_SNAPSHOT_TYPE_LOG


    } // enum MysqldbOnDemandSnapshotConfigSnapshotType

} // namespace RubrikSecurityCloud.Types