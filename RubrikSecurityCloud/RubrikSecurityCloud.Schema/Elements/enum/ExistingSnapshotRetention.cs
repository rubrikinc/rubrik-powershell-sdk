// ExistingSnapshotRetention.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:31.
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
    public enum ExistingSnapshotRetention
    {
        [EnumMember(Value = "EXISTING_SNAPSHOT_RETENTION_EXPIRE_IMMEDIATELY")]
        EXISTING_SNAPSHOT_RETENTION_EXPIRE_IMMEDIATELY,

        [EnumMember(Value = "EXISTING_SNAPSHOT_RETENTION_KEEP_FOREVER")]
        EXISTING_SNAPSHOT_RETENTION_KEEP_FOREVER,

        [EnumMember(Value = "EXISTING_SNAPSHOT_RETENTION_RETAIN_SNAPSHOTS")]
        EXISTING_SNAPSHOT_RETENTION_RETAIN_SNAPSHOTS


    } // enum ExistingSnapshotRetention

} // namespace Rubrik.SecurityCloud.Types