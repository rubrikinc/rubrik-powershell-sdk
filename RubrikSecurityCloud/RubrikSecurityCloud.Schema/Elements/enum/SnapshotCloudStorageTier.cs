// SnapshotCloudStorageTier.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:33.
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
    public enum SnapshotCloudStorageTier
    {
        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_AZURE_ARCHIVE")]
        SNAPSHOT_CLOUD_STORAGE_TIER_AZURE_ARCHIVE,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_COLD")]
        SNAPSHOT_CLOUD_STORAGE_TIER_COLD,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_COOL")]
        SNAPSHOT_CLOUD_STORAGE_TIER_COOL,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER")]
        SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER_DEEP_ARCHIVE")]
        SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER_DEEP_ARCHIVE,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_HOT")]
        SNAPSHOT_CLOUD_STORAGE_TIER_HOT


    } // enum SnapshotCloudStorageTier

} // namespace Rubrik.SecurityCloud.Types