// ArmTemplateDeploymentLevel.cs
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
    public enum ArmTemplateDeploymentLevel
    {
        [EnumMember(Value = "DEPLOYMENT_LEVEL_UNSPECIFIED")]
        DEPLOYMENT_LEVEL_UNSPECIFIED,

        [EnumMember(Value = "RESOURCE_GROUP")]
        RESOURCE_GROUP,

        [EnumMember(Value = "SUBSCRIPTION")]
        SUBSCRIPTION,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ArmTemplateDeploymentLevel

} // namespace RubrikSecurityCloud.Types