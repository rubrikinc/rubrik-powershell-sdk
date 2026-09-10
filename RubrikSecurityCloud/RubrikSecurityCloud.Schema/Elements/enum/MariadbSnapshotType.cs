// MariadbSnapshotType.cs
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
    public enum MariadbSnapshotType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MARIADB_SNAPSHOT_TYPE_DIFFERENTIAL")]
        MARIADB_SNAPSHOT_TYPE_DIFFERENTIAL,

        [EnumMember(Value = "MARIADB_SNAPSHOT_TYPE_FULL")]
        MARIADB_SNAPSHOT_TYPE_FULL


    } // enum MariadbSnapshotType

} // namespace RubrikSecurityCloud.Types