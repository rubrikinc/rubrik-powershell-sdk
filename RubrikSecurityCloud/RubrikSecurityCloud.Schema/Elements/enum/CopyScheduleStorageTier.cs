// CopyScheduleStorageTier.cs
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
    public enum CopyScheduleStorageTier
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_AZURE_ARCHIVE")]
        COPY_SCHEDULE_STORAGE_TIER_AZURE_ARCHIVE,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_AZURE_COLD")]
        COPY_SCHEDULE_STORAGE_TIER_AZURE_COLD,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_AZURE_COOL")]
        COPY_SCHEDULE_STORAGE_TIER_AZURE_COOL,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_AZURE_HOT")]
        COPY_SCHEDULE_STORAGE_TIER_AZURE_HOT,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_GCP_ARCHIVE")]
        COPY_SCHEDULE_STORAGE_TIER_GCP_ARCHIVE,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_GCP_COLDLINE")]
        COPY_SCHEDULE_STORAGE_TIER_GCP_COLDLINE,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_GCP_DURABLE_REDUCED_AVAILABILITY")]
        COPY_SCHEDULE_STORAGE_TIER_GCP_DURABLE_REDUCED_AVAILABILITY,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_GCP_NEARLINE")]
        COPY_SCHEDULE_STORAGE_TIER_GCP_NEARLINE,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_GCP_REGIONAL")]
        COPY_SCHEDULE_STORAGE_TIER_GCP_REGIONAL,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_GCP_STANDARD")]
        COPY_SCHEDULE_STORAGE_TIER_GCP_STANDARD,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_S3_DEEP_ARCHIVE")]
        COPY_SCHEDULE_STORAGE_TIER_S3_DEEP_ARCHIVE,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_S3_GLACIER")]
        COPY_SCHEDULE_STORAGE_TIER_S3_GLACIER,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_S3_GLACIER_IR")]
        COPY_SCHEDULE_STORAGE_TIER_S3_GLACIER_IR,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_S3_INTELLIGENT_TIERING")]
        COPY_SCHEDULE_STORAGE_TIER_S3_INTELLIGENT_TIERING,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_S3_ONEZONE_IA")]
        COPY_SCHEDULE_STORAGE_TIER_S3_ONEZONE_IA,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_S3_STANDARD")]
        COPY_SCHEDULE_STORAGE_TIER_S3_STANDARD,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_S3_STANDARD_IA")]
        COPY_SCHEDULE_STORAGE_TIER_S3_STANDARD_IA,

        [EnumMember(Value = "COPY_SCHEDULE_STORAGE_TIER_UNSPECIFIED")]
        COPY_SCHEDULE_STORAGE_TIER_UNSPECIFIED


    } // enum CopyScheduleStorageTier

} // namespace RubrikSecurityCloud.Types