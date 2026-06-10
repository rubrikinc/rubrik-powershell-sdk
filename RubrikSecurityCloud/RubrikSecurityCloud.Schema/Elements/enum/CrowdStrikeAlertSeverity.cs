// CrowdStrikeAlertSeverity.cs
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
    public enum CrowdStrikeAlertSeverity
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CROWDSTRIKE_SEVERITY_CRITICAL")]
        CROWDSTRIKE_SEVERITY_CRITICAL,

        [EnumMember(Value = "CROWDSTRIKE_SEVERITY_HIGH")]
        CROWDSTRIKE_SEVERITY_HIGH,

        [EnumMember(Value = "CROWDSTRIKE_SEVERITY_INFORMATIONAL")]
        CROWDSTRIKE_SEVERITY_INFORMATIONAL,

        [EnumMember(Value = "CROWDSTRIKE_SEVERITY_LOW")]
        CROWDSTRIKE_SEVERITY_LOW,

        [EnumMember(Value = "CROWDSTRIKE_SEVERITY_MEDIUM")]
        CROWDSTRIKE_SEVERITY_MEDIUM


    } // enum CrowdStrikeAlertSeverity

} // namespace RubrikSecurityCloud.Types