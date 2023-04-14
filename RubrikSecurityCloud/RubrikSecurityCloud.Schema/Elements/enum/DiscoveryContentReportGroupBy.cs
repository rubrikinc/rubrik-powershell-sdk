// DiscoveryContentReportGroupBy.cs
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
    public enum DiscoveryContentReportGroupBy
    {
        [EnumMember(Value = "ANALYZER")]
        ANALYZER,

        [EnumMember(Value = "CLUSTER")]
        CLUSTER,

        [EnumMember(Value = "FILE")]
        FILE,

        [EnumMember(Value = "OBJECT_NAME")]
        OBJECT_NAME,

        [EnumMember(Value = "POLICY")]
        POLICY,

        [EnumMember(Value = "SLA_DOMAIN")]
        SLA_DOMAIN,

        [EnumMember(Value = "TIME")]
        TIME


    } // enum DiscoveryContentReportGroupBy

} // namespace Rubrik.SecurityCloud.Types