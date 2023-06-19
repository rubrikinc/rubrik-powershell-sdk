// DiscoveryReportTablePolicyStatus.cs
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
    public enum DiscoveryReportTablePolicyStatus
    {
        [EnumMember(Value = "DISCOVERY")]
        DISCOVERY,

        [EnumMember(Value = "IN_COMPLIANCE")]
        IN_COMPLIANCE,

        [EnumMember(Value = "OUT_OF_COMPLIANCE")]
        OUT_OF_COMPLIANCE


    } // enum DiscoveryReportTablePolicyStatus

} // namespace RubrikSecurityCloud.Types