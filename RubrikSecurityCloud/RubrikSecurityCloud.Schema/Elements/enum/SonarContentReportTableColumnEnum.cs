// SonarContentReportTableColumnEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:38.
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
    public enum SonarContentReportTableColumnEnum
    {
        [EnumMember(Value = "AnalyzersBreakdown")]
        ANALYZERS_BREAKDOWN,

        [EnumMember(Value = "Cluster")]
        CLUSTER,

        [EnumMember(Value = "FileName")]
        FILE_NAME,

        [EnumMember(Value = "ObjectName")]
        OBJECT_NAME,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "Path")]
        PATH,

        [EnumMember(Value = "PoliciesBreakdown")]
        POLICIES_BREAKDOWN,

        [EnumMember(Value = "Size")]
        SIZE,

        [EnumMember(Value = "SnapshotTime")]
        SNAPSHOT_TIME,

        [EnumMember(Value = "TotalHits")]
        TOTAL_HITS


    } // enum SonarContentReportTableColumnEnum

} // namespace Rubrik.SecurityCloud.Types