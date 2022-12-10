// V1QueryUnmanagedObjectSnapshotsV1RequestSortBy.cs
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
    public enum V1QueryUnmanagedObjectSnapshotsV1RequestSortBy
    {
        [EnumMember(Value = "V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SORT_BY_ARCHIVAL_LOCATION")]
        V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SORT_BY_ARCHIVAL_LOCATION,

        [EnumMember(Value = "V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SORT_BY_LOCAL_EXPIRATION_DATE")]
        V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SORT_BY_LOCAL_EXPIRATION_DATE,

        [EnumMember(Value = "V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SORT_BY_SNAPSHOT_DATE_AND_TIME")]
        V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SORT_BY_SNAPSHOT_DATE_AND_TIME


    } // enum V1QueryUnmanagedObjectSnapshotsV1RequestSortBy

} // namespace Rubrik.SecurityCloud.Types