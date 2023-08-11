// TrialStep.cs
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
    public enum TrialStep
    {
        [EnumMember(Value = "M365_ASSIGN_SLA")]
        M365_ASSIGN_SLA,

        [EnumMember(Value = "M365_DISCOVERY")]
        M365_DISCOVERY,

        [EnumMember(Value = "M365_OBJECT_RECOVERY")]
        M365_OBJECT_RECOVERY,

        [EnumMember(Value = "M365_SONAR")]
        M365_SONAR,

        [EnumMember(Value = "M365_VIEW_REPORT")]
        M365_VIEW_REPORT,

        [EnumMember(Value = "STEP_UNSPECIFIED")]
        STEP_UNSPECIFIED


    } // enum TrialStep

} // namespace RubrikSecurityCloud.Types