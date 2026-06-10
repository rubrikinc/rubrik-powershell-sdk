// SnapshotLocType.cs
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
    public enum SnapshotLocType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SNAPSHOT_LOCATION_TYPE_ARCHIVAL")]
        SNAPSHOT_LOCATION_TYPE_ARCHIVAL,

        [EnumMember(Value = "SNAPSHOT_LOCATION_TYPE_CLUSTER")]
        SNAPSHOT_LOCATION_TYPE_CLUSTER,

        [EnumMember(Value = "SNAPSHOT_LOCATION_TYPE_REHYDRATED")]
        SNAPSHOT_LOCATION_TYPE_REHYDRATED,

        [EnumMember(Value = "SNAPSHOT_LOCATION_TYPE_UNSPECIFIED")]
        SNAPSHOT_LOCATION_TYPE_UNSPECIFIED


    } // enum SnapshotLocType

} // namespace RubrikSecurityCloud.Types