// V1QueryUnmanagedObjectSnapshotsV1RequestSnapshotType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:02.
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
    public enum V1QueryUnmanagedObjectSnapshotsV1RequestSnapshotType
    {
        [EnumMember(Value = "V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SNAPSHOT_TYPE_ON_DEMAND")]
        V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SNAPSHOT_TYPE_ON_DEMAND,

        [EnumMember(Value = "V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SNAPSHOT_TYPE_POLICY_BASED")]
        V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SNAPSHOT_TYPE_POLICY_BASED,

        [EnumMember(Value = "V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SNAPSHOT_TYPE_RETRIEVED")]
        V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SNAPSHOT_TYPE_RETRIEVED


    } // enum V1QueryUnmanagedObjectSnapshotsV1RequestSnapshotType

} // namespace Rubrik.SecurityCloud.Types