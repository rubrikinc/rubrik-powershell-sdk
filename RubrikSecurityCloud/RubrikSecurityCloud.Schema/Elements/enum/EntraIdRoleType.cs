// EntraIdRoleType.cs
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
    public enum EntraIdRoleType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EID_ROLE_TYPE_BUILT_IN")]
        EID_ROLE_TYPE_BUILT_IN,

        [EnumMember(Value = "EID_ROLE_TYPE_CUSTOM")]
        EID_ROLE_TYPE_CUSTOM,

        [EnumMember(Value = "EID_ROLE_TYPE_UNSPECIFIED")]
        EID_ROLE_TYPE_UNSPECIFIED


    } // enum EntraIdRoleType

} // namespace RubrikSecurityCloud.Types