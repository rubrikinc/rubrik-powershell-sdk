// FusionComputeSnapshotConsistencyMandate.cs
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
    public enum FusionComputeSnapshotConsistencyMandate
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FUSION_COMPUTE_SNAPSHOT_CONSISTENCY_MANDATE_APPLICATION_CONSISTENT")]
        FUSION_COMPUTE_SNAPSHOT_CONSISTENCY_MANDATE_APPLICATION_CONSISTENT,

        [EnumMember(Value = "FUSION_COMPUTE_SNAPSHOT_CONSISTENCY_MANDATE_AUTOMATIC")]
        FUSION_COMPUTE_SNAPSHOT_CONSISTENCY_MANDATE_AUTOMATIC,

        [EnumMember(Value = "FUSION_COMPUTE_SNAPSHOT_CONSISTENCY_MANDATE_CRASH_CONSISTENT")]
        FUSION_COMPUTE_SNAPSHOT_CONSISTENCY_MANDATE_CRASH_CONSISTENT


    } // enum FusionComputeSnapshotConsistencyMandate

} // namespace RubrikSecurityCloud.Types