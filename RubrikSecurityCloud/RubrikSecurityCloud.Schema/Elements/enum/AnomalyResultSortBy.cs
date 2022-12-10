// AnomalyResultSortBy.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:07.
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
    public enum AnomalyResultSortBy
    {
        [EnumMember(Value = "ANOMALY_PROBABILITY")]
        ANOMALY_PROBABILITY,

        [EnumMember(Value = "BYTES_CREATED_COUNT")]
        BYTES_CREATED_COUNT,

        [EnumMember(Value = "BYTES_DELETED_COUNT")]
        BYTES_DELETED_COUNT,

        [EnumMember(Value = "BYTES_MODIFIED_COUNT")]
        BYTES_MODIFIED_COUNT,

        [EnumMember(Value = "BYTES_NET_CHANGED_COUNT")]
        BYTES_NET_CHANGED_COUNT,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "FILES_CREATED_COUNT")]
        FILES_CREATED_COUNT,

        [EnumMember(Value = "FILES_DELETED_COUNT")]
        FILES_DELETED_COUNT,

        [EnumMember(Value = "FILES_MODIFIED_COUNT")]
        FILES_MODIFIED_COUNT,

        [EnumMember(Value = "IS_ANOMALY")]
        IS_ANOMALY,

        [EnumMember(Value = "IS_ENCRYPTED")]
        IS_ENCRYPTED,

        [EnumMember(Value = "MANAGED_ID")]
        MANAGED_ID,

        [EnumMember(Value = "OBJECT_TYPE")]
        OBJECT_TYPE,

        [EnumMember(Value = "PREVIOUS_SNAPSHOT_DATE")]
        PREVIOUS_SNAPSHOT_DATE,

        [EnumMember(Value = "PREVIOUS_SNAPSHOT_ID")]
        PREVIOUS_SNAPSHOT_ID,

        [EnumMember(Value = "SEVERITY")]
        SEVERITY,

        [EnumMember(Value = "SNAPSHOT_DATE")]
        SNAPSHOT_DATE,

        [EnumMember(Value = "SNAPSHOT_ID")]
        SNAPSHOT_ID,

        [EnumMember(Value = "SUSPICIOUS_FILES_COUNT")]
        SUSPICIOUS_FILES_COUNT,

        [EnumMember(Value = "WORKLOAD_NAME")]
        WORKLOAD_NAME,

        [EnumMember(Value = "WORKLOAD_TYPE")]
        WORKLOAD_TYPE


    } // enum AnomalyResultSortBy

} // namespace Rubrik.SecurityCloud.Types