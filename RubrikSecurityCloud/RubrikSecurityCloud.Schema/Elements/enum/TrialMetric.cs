// TrialMetric.cs
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
    public enum TrialMetric
    {
        [EnumMember(Value = "M365_SHAREPOINT_PROTECTED")]
        M365_SHAREPOINT_PROTECTED,

        [EnumMember(Value = "M365_SHAREPOINT_RECOVERIES")]
        M365_SHAREPOINT_RECOVERIES,

        [EnumMember(Value = "M365_SHAREPOINT_TOTAL")]
        M365_SHAREPOINT_TOTAL,

        [EnumMember(Value = "METRIC_TYPE_UNSPECIFIED")]
        METRIC_TYPE_UNSPECIFIED


    } // enum TrialMetric

} // namespace RubrikSecurityCloud.Types