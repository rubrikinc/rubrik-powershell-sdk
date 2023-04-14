// VirtualMachineSummarySnapshotConsistencyMandate.cs
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
    public enum VirtualMachineSummarySnapshotConsistencyMandate
    {
        [EnumMember(Value = "VIRTUAL_MACHINE_SUMMARY_SNAPSHOT_CONSISTENCY_MANDATE_APP_CONSISTENT")]
        VIRTUAL_MACHINE_SUMMARY_SNAPSHOT_CONSISTENCY_MANDATE_APP_CONSISTENT,

        [EnumMember(Value = "VIRTUAL_MACHINE_SUMMARY_SNAPSHOT_CONSISTENCY_MANDATE_CRASH_CONSISTENT")]
        VIRTUAL_MACHINE_SUMMARY_SNAPSHOT_CONSISTENCY_MANDATE_CRASH_CONSISTENT,

        [EnumMember(Value = "VIRTUAL_MACHINE_SUMMARY_SNAPSHOT_CONSISTENCY_MANDATE_FILE_SYSTEM_CONSISTENT")]
        VIRTUAL_MACHINE_SUMMARY_SNAPSHOT_CONSISTENCY_MANDATE_FILE_SYSTEM_CONSISTENT,

        [EnumMember(Value = "VIRTUAL_MACHINE_SUMMARY_SNAPSHOT_CONSISTENCY_MANDATE_INCONSISTENT")]
        VIRTUAL_MACHINE_SUMMARY_SNAPSHOT_CONSISTENCY_MANDATE_INCONSISTENT,

        [EnumMember(Value = "VIRTUAL_MACHINE_SUMMARY_SNAPSHOT_CONSISTENCY_MANDATE_UNKNOWN")]
        VIRTUAL_MACHINE_SUMMARY_SNAPSHOT_CONSISTENCY_MANDATE_UNKNOWN,

        [EnumMember(Value = "VIRTUAL_MACHINE_SUMMARY_SNAPSHOT_CONSISTENCY_MANDATE_VSS_CONSISTENT")]
        VIRTUAL_MACHINE_SUMMARY_SNAPSHOT_CONSISTENCY_MANDATE_VSS_CONSISTENT


    } // enum VirtualMachineSummarySnapshotConsistencyMandate

} // namespace Rubrik.SecurityCloud.Types