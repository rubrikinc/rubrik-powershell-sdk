// SonarReportTableColumnEnum.cs
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

} // namespace RubrikSecurityCloud.Types