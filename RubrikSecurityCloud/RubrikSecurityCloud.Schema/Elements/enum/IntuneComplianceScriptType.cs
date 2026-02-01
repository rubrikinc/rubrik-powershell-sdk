// IntuneComplianceScriptType.cs
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
    public enum IntuneComplianceScriptType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INTUNE_COMPLIANCE_SCRIPT_TYPE_POWERSHELL")]
        INTUNE_COMPLIANCE_SCRIPT_TYPE_POWERSHELL,

        [EnumMember(Value = "INTUNE_COMPLIANCE_SCRIPT_TYPE_SHELL")]
        INTUNE_COMPLIANCE_SCRIPT_TYPE_SHELL,

        [EnumMember(Value = "INTUNE_COMPLIANCE_SCRIPT_TYPE_UNKNOWN")]
        INTUNE_COMPLIANCE_SCRIPT_TYPE_UNKNOWN


    } // enum IntuneComplianceScriptType

} // namespace RubrikSecurityCloud.Types