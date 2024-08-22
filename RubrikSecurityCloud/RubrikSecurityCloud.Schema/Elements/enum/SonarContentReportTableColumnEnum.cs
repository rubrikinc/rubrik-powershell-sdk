// SonarContentReportTableColumnEnum.cs
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
        TOTAL_HITS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SonarContentReportTableColumnEnum

} // namespace RubrikSecurityCloud.Types