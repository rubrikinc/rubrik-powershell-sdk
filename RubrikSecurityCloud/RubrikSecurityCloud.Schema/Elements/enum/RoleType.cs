// RoleType.cs
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
    public enum RoleType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ROLE_CROSSACCOUNT")]
        ROLE_CROSSACCOUNT,

        [EnumMember(Value = "ROLE_EXOCOMPUTE_EKS_MASTER")]
        ROLE_EXOCOMPUTE_EKS_MASTER,

        [EnumMember(Value = "ROLE_EXOCOMPUTE_EKS_WORKER")]
        ROLE_EXOCOMPUTE_EKS_WORKER,

        [EnumMember(Value = "ROLE_UNSPECIFIED")]
        ROLE_UNSPECIFIED


    } // enum RoleType

} // namespace RubrikSecurityCloud.Types