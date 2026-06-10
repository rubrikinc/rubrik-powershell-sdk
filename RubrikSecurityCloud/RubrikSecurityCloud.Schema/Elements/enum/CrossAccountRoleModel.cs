// CrossAccountRoleModel.cs
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
    public enum CrossAccountRoleModel
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CROSS_ACCOUNT_ROLE_MODEL_UNSPECIFIED")]
        CROSS_ACCOUNT_ROLE_MODEL_UNSPECIFIED,

        [EnumMember(Value = "MULTI_ROLE")]
        MULTI_ROLE,

        [EnumMember(Value = "SINGLE_ROLE")]
        SINGLE_ROLE


    } // enum CrossAccountRoleModel

} // namespace RubrikSecurityCloud.Types