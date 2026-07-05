// CdmUserType.cs
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
    public enum CdmUserType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "USER_TYPE_GPS")]
        USER_TYPE_GPS,

        [EnumMember(Value = "USER_TYPE_IDP")]
        USER_TYPE_IDP,

        [EnumMember(Value = "USER_TYPE_LDAP")]
        USER_TYPE_LDAP,

        [EnumMember(Value = "USER_TYPE_LOCAL")]
        USER_TYPE_LOCAL


    } // enum CdmUserType

} // namespace RubrikSecurityCloud.Types