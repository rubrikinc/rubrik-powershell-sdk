// SonarReportTableColumnEnum.cs
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
    public enum SonarReportTableColumnEnum
    {
        [EnumMember(Value = "NumCoveredObjects")]
        NUM_COVERED_OBJECTS,

        [EnumMember(Value = "NumHighRiskLocations")]
        NUM_HIGH_RISK_LOCATIONS,

        [EnumMember(Value = "NumViolatedFiles")]
        NUM_VIOLATED_FILES,

        [EnumMember(Value = "NumViolations")]
        NUM_VIOLATIONS,

        [EnumMember(Value = "PolicyName")]
        POLICY_NAME,

        [EnumMember(Value = "PolicyStatus")]
        POLICY_STATUS


    } // enum SonarReportTableColumnEnum

} // namespace Rubrik.SecurityCloud.Types