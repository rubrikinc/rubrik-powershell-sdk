// SnapshotCloudStorageTier.cs
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
    public enum SnapshotCloudStorageTier
    {
        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_AZURE_ARCHIVE")]
        SNAPSHOT_CLOUD_STORAGE_TIER_AZURE_ARCHIVE,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_AZURE_COLD")]
        SNAPSHOT_CLOUD_STORAGE_TIER_AZURE_COLD,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_AZURE_COOL")]
        SNAPSHOT_CLOUD_STORAGE_TIER_AZURE_COOL,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_COLD")]
        SNAPSHOT_CLOUD_STORAGE_TIER_COLD,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_COOL")]
        SNAPSHOT_CLOUD_STORAGE_TIER_COOL,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER")]
        SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER_DEEP_ARCHIVE")]
        SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER_DEEP_ARCHIVE,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER_IR")]
        SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER_IR,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_HOT")]
        SNAPSHOT_CLOUD_STORAGE_TIER_HOT,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_ONE_ZONE_IA")]
        SNAPSHOT_CLOUD_STORAGE_TIER_ONE_ZONE_IA,

        [EnumMember(Value = "SNAPSHOT_CLOUD_STORAGE_TIER_STANDARD_IA")]
        SNAPSHOT_CLOUD_STORAGE_TIER_STANDARD_IA,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SnapshotCloudStorageTier

} // namespace RubrikSecurityCloud.Types