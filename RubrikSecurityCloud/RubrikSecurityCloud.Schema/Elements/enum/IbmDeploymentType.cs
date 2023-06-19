// IbmDeploymentType.cs
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
    public enum IbmDeploymentType
    {
        [EnumMember(Value = "CLOUD")]
        CLOUD,

        [EnumMember(Value = "CONTAINER")]
        CONTAINER,

        [EnumMember(Value = "IBM_DEPLOYMENT_TYPE_UNSPECIFIED")]
        IBM_DEPLOYMENT_TYPE_UNSPECIFIED,

        [EnumMember(Value = "VAULT")]
        VAULT


    } // enum IbmDeploymentType

} // namespace RubrikSecurityCloud.Types