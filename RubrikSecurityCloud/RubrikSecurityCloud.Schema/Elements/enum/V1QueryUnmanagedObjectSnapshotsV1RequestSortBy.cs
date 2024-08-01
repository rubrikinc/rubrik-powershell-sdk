// V1QueryUnmanagedObjectSnapshotsV1RequestSortBy.cs
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
    public enum V1QueryUnmanagedObjectSnapshotsV1RequestSortBy
    {
        [EnumMember(Value = "V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SORT_BY_ARCHIVAL_LOCATION")]
        V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SORT_BY_ARCHIVAL_LOCATION,

        [EnumMember(Value = "V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SORT_BY_LOCAL_EXPIRATION_DATE")]
        V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SORT_BY_LOCAL_EXPIRATION_DATE,

        [EnumMember(Value = "V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SORT_BY_SNAPSHOT_DATE_AND_TIME")]
        V1_QUERY_UNMANAGED_OBJECT_SNAPSHOTS_V1_REQUEST_SORT_BY_SNAPSHOT_DATE_AND_TIME,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum V1QueryUnmanagedObjectSnapshotsV1RequestSortBy

} // namespace RubrikSecurityCloud.Types