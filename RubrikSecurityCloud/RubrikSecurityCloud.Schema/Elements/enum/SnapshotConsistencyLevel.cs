// SnapshotConsistencyLevel.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum SnapshotConsistencyLevel
    {
        [EnumMember(Value = "SNAPSHOT_APP_CONSISTENT")]
        SNAPSHOT_APP_CONSISTENT,

        [EnumMember(Value = "SNAPSHOT_CRASH_CONSISTENT")]
        SNAPSHOT_CRASH_CONSISTENT,

        [EnumMember(Value = "UNKNOWN_CONSISTENCY_LEVEL")]
        UNKNOWN_CONSISTENCY_LEVEL


    } // enum SnapshotConsistencyLevel

} // namespace Rubrik.SecurityCloud.Types