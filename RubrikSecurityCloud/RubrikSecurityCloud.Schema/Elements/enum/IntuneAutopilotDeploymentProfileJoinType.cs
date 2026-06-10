// IntuneAutopilotDeploymentProfileJoinType.cs
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
    public enum IntuneAutopilotDeploymentProfileJoinType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INTUNE_AUTOPILOT_DEPLOYMENT_PROFILE_JOIN_TYPE_AZURE_AD_JOINED")]
        INTUNE_AUTOPILOT_DEPLOYMENT_PROFILE_JOIN_TYPE_AZURE_AD_JOINED,

        [EnumMember(Value = "INTUNE_AUTOPILOT_DEPLOYMENT_PROFILE_JOIN_TYPE_ENTRA_ID_HYBRID_AUTOPILOT")]
        INTUNE_AUTOPILOT_DEPLOYMENT_PROFILE_JOIN_TYPE_ENTRA_ID_HYBRID_AUTOPILOT,

        [EnumMember(Value = "INTUNE_AUTOPILOT_DEPLOYMENT_PROFILE_JOIN_TYPE_HYBRID_AZURE_AD_JOINED")]
        INTUNE_AUTOPILOT_DEPLOYMENT_PROFILE_JOIN_TYPE_HYBRID_AZURE_AD_JOINED,

        [EnumMember(Value = "INTUNE_AUTOPILOT_DEPLOYMENT_PROFILE_JOIN_TYPE_UNKNOWN")]
        INTUNE_AUTOPILOT_DEPLOYMENT_PROFILE_JOIN_TYPE_UNKNOWN


    } // enum IntuneAutopilotDeploymentProfileJoinType

} // namespace RubrikSecurityCloud.Types