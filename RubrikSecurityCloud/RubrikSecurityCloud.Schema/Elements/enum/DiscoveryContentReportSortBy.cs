// DiscoveryContentReportSortBy.cs
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
    public enum DiscoveryContentReportSortBy
    {
        [EnumMember(Value = "ANALYZER_NAME")]
        ANALYZER_NAME,

        [EnumMember(Value = "CLUSTER")]
        CLUSTER,

        [EnumMember(Value = "FILES_WITH_HITS")]
        FILES_WITH_HITS,

        [EnumMember(Value = "FILE_NAME")]
        FILE_NAME,

        [EnumMember(Value = "LOCATION")]
        LOCATION,

        [EnumMember(Value = "OBJECT_NAME")]
        OBJECT_NAME,

        [EnumMember(Value = "PATH")]
        PATH,

        [EnumMember(Value = "POLICY_NAME")]
        POLICY_NAME,

        [EnumMember(Value = "SIZE")]
        SIZE,

        [EnumMember(Value = "SLA_DOMAIN")]
        SLA_DOMAIN,

        [EnumMember(Value = "SNAPSHOT_TIME")]
        SNAPSHOT_TIME,

        [EnumMember(Value = "TOTAL_HITS")]
        TOTAL_HITS


    } // enum DiscoveryContentReportSortBy

} // namespace RubrikSecurityCloud.Types