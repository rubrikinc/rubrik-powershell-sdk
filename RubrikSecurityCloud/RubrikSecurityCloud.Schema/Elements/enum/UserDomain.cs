// UserDomain.cs
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
    public enum UserDomain
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLIENT")]
        CLIENT,

        [EnumMember(Value = "LDAP")]
        LDAP,

        [EnumMember(Value = "LOCAL")]
        LOCAL,

        [EnumMember(Value = "PAT")]
        PAT,

        [EnumMember(Value = "SSO")]
        SSO,

        [EnumMember(Value = "SUPPORT")]
        SUPPORT


    } // enum UserDomain

} // namespace RubrikSecurityCloud.Types