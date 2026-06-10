// TprSnapshotLocationType.cs
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
    public enum TprSnapshotLocationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "TPR_SNAPSHOT_LOCATION_TYPE_ARCHIVAL")]
        TPR_SNAPSHOT_LOCATION_TYPE_ARCHIVAL,

        [EnumMember(Value = "TPR_SNAPSHOT_LOCATION_TYPE_LOCAL")]
        TPR_SNAPSHOT_LOCATION_TYPE_LOCAL,

        [EnumMember(Value = "TPR_SNAPSHOT_LOCATION_TYPE_REHYDRATED")]
        TPR_SNAPSHOT_LOCATION_TYPE_REHYDRATED,

        [EnumMember(Value = "TPR_SNAPSHOT_LOCATION_TYPE_UNSPECIFIED")]
        TPR_SNAPSHOT_LOCATION_TYPE_UNSPECIFIED


    } // enum TprSnapshotLocationType

} // namespace RubrikSecurityCloud.Types