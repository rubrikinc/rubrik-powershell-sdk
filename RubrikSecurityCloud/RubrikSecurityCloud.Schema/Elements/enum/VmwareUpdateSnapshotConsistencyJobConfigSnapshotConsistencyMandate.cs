// VmwareUpdateSnapshotConsistencyJobConfigSnapshotConsistencyMandate.cs
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
    public enum VmwareUpdateSnapshotConsistencyJobConfigSnapshotConsistencyMandate
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "VMWARE_UPDATE_SNAPSHOT_CONSISTENCY_JOB_CONFIG_SNAPSHOT_CONSISTENCY_MANDATE_AUTOMATIC")]
        VMWARE_UPDATE_SNAPSHOT_CONSISTENCY_JOB_CONFIG_SNAPSHOT_CONSISTENCY_MANDATE_AUTOMATIC,

        [EnumMember(Value = "VMWARE_UPDATE_SNAPSHOT_CONSISTENCY_JOB_CONFIG_SNAPSHOT_CONSISTENCY_MANDATE_CRASH_CONSISTENT")]
        VMWARE_UPDATE_SNAPSHOT_CONSISTENCY_JOB_CONFIG_SNAPSHOT_CONSISTENCY_MANDATE_CRASH_CONSISTENT,

        [EnumMember(Value = "VMWARE_UPDATE_SNAPSHOT_CONSISTENCY_JOB_CONFIG_SNAPSHOT_CONSISTENCY_MANDATE_INHERITED")]
        VMWARE_UPDATE_SNAPSHOT_CONSISTENCY_JOB_CONFIG_SNAPSHOT_CONSISTENCY_MANDATE_INHERITED


    } // enum VmwareUpdateSnapshotConsistencyJobConfigSnapshotConsistencyMandate

} // namespace RubrikSecurityCloud.Types