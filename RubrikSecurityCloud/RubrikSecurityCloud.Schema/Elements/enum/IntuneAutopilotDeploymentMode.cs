// IntuneAutopilotDeploymentMode.cs
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
    public enum IntuneAutopilotDeploymentMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INTUNE_AUTOPILOT_DEPLOYMENT_MODE_PRE_PROVISIONED")]
        INTUNE_AUTOPILOT_DEPLOYMENT_MODE_PRE_PROVISIONED,

        [EnumMember(Value = "INTUNE_AUTOPILOT_DEPLOYMENT_MODE_SELF_DEPLOYING")]
        INTUNE_AUTOPILOT_DEPLOYMENT_MODE_SELF_DEPLOYING,

        [EnumMember(Value = "INTUNE_AUTOPILOT_DEPLOYMENT_MODE_UNKNOWN")]
        INTUNE_AUTOPILOT_DEPLOYMENT_MODE_UNKNOWN,

        [EnumMember(Value = "INTUNE_AUTOPILOT_DEPLOYMENT_MODE_USER_DRIVEN")]
        INTUNE_AUTOPILOT_DEPLOYMENT_MODE_USER_DRIVEN


    } // enum IntuneAutopilotDeploymentMode

} // namespace RubrikSecurityCloud.Types