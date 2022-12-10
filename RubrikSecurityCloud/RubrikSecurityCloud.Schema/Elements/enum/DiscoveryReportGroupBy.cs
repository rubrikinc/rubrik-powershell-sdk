// DiscoveryReportGroupBy.cs
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
    public enum DiscoveryReportGroupBy
    {
        [EnumMember(Value = "POLICY_VIOLATIONS")]
        POLICY_VIOLATIONS,

        [EnumMember(Value = "STATUS_POLICY")]
        STATUS_POLICY,

        [EnumMember(Value = "TIME_ISSUES")]
        TIME_ISSUES,

        [EnumMember(Value = "TIME_VIOLATIONS")]
        TIME_VIOLATIONS


    } // enum DiscoveryReportGroupBy

} // namespace Rubrik.SecurityCloud.Types