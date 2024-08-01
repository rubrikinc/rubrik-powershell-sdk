// TrialType.cs
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
    public enum TrialType
    {
        [EnumMember(Value = "ATLASSIAN_JIRA")]
        ATLASSIAN_JIRA,

        [EnumMember(Value = "M365")]
        M365,

        [EnumMember(Value = "TRIAL_UNSPECIFIED")]
        TRIAL_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TrialType

} // namespace RubrikSecurityCloud.Types