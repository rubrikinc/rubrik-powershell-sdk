// IbmDeploymentType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:19.
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

} // namespace Rubrik.SecurityCloud.Types