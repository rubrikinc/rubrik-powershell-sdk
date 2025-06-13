// CloudDirectSnapshotsFilterField.cs
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
    public enum CloudDirectSnapshotsFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "FID")]
        FID,

        [EnumMember(Value = "JOB_STATE")]
        JOB_STATE,

        [EnumMember(Value = "POLICY_NAME")]
        POLICY_NAME,

        [EnumMember(Value = "PROTOCOL")]
        PROTOCOL,

        [EnumMember(Value = "SYSTEM_ID")]
        SYSTEM_ID,

        [EnumMember(Value = "TARGET_ID")]
        TARGET_ID,

        [EnumMember(Value = "TIME_RANGE")]
        TIME_RANGE,

        [EnumMember(Value = "TYPE")]
        TYPE,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        [EnumMember(Value = "WORKLOAD_ID")]
        WORKLOAD_ID


    } // enum CloudDirectSnapshotsFilterField

} // namespace RubrikSecurityCloud.Types