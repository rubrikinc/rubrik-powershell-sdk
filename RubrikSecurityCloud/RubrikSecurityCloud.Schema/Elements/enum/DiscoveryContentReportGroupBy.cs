// DiscoveryContentReportGroupBy.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:30.
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