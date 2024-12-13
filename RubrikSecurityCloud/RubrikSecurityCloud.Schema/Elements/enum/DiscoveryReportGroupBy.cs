// DiscoveryReportGroupBy.cs
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
    public enum DiscoveryReportGroupBy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "POLICY_VIOLATIONS")]
        POLICY_VIOLATIONS,

        [EnumMember(Value = "STATUS_POLICY")]
        STATUS_POLICY,

        [EnumMember(Value = "TIME_ISSUES")]
        TIME_ISSUES,

        [EnumMember(Value = "TIME_VIOLATIONS")]
        TIME_VIOLATIONS


    } // enum DiscoveryReportGroupBy

} // namespace RubrikSecurityCloud.Types