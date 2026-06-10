// CloudNativeSnapshotLocationType.cs
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
    public enum CloudNativeSnapshotLocationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CN_SNAPSHOT_LOCATION_AUTOMATIC")]
        CN_SNAPSHOT_LOCATION_AUTOMATIC,

        [EnumMember(Value = "CN_SNAPSHOT_LOCATION_EXTERNAL_ARCHIVE")]
        CN_SNAPSHOT_LOCATION_EXTERNAL_ARCHIVE,

        [EnumMember(Value = "CN_SNAPSHOT_LOCATION_LOCAL")]
        CN_SNAPSHOT_LOCATION_LOCAL,

        [EnumMember(Value = "CN_SNAPSHOT_LOCATION_RCV_PREMIUM")]
        CN_SNAPSHOT_LOCATION_RCV_PREMIUM,

        [EnumMember(Value = "CN_SNAPSHOT_LOCATION_REPLICATED")]
        CN_SNAPSHOT_LOCATION_REPLICATED


    } // enum CloudNativeSnapshotLocationType

} // namespace RubrikSecurityCloud.Types