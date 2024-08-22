// AnomalyTableColumnEnum.cs
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
    public enum AnomalyTableColumnEnum
    {
        [EnumMember(Value = "BytesCreated")]
        BYTES_CREATED,

        [EnumMember(Value = "BytesDeleted")]
        BYTES_DELETED,

        [EnumMember(Value = "BytesModified")]
        BYTES_MODIFIED,

        [EnumMember(Value = "BytesNetChanged")]
        BYTES_NET_CHANGED,

        [EnumMember(Value = "FilesCreated")]
        FILES_CREATED,

        [EnumMember(Value = "FilesDeleted")]
        FILES_DELETED,

        [EnumMember(Value = "FilesModified")]
        FILES_MODIFIED,

        [EnumMember(Value = "IsAnomaly")]
        IS_ANOMALY,

        [EnumMember(Value = "PreviousSnapshotDate")]
        PREVIOUS_SNAPSHOT_DATE,

        [EnumMember(Value = "PreviousSnapshotId")]
        PREVIOUS_SNAPSHOT_ID,

        [EnumMember(Value = "SnapshotDate")]
        SNAPSHOT_DATE,

        [EnumMember(Value = "SnapshotId")]
        SNAPSHOT_ID,

        [EnumMember(Value = "SuspiciousFilesAdded")]
        SUSPICIOUS_FILES_ADDED,

        [EnumMember(Value = "WorkloadName")]
        WORKLOAD_NAME,

        [EnumMember(Value = "WorkloadType")]
        WORKLOAD_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AnomalyTableColumnEnum

} // namespace RubrikSecurityCloud.Types