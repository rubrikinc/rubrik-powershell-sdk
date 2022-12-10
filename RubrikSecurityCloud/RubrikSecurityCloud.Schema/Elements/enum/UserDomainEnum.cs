// UserDomainEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:02.
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
    public enum UserDomainEnum
    {
        [EnumMember(Value = "CLIENT")]
        CLIENT,

        [EnumMember(Value = "LDAP")]
        LDAP,

        [EnumMember(Value = "LOCAL")]
        LOCAL,

        [EnumMember(Value = "SSO")]
        SSO,

        [EnumMember(Value = "SUPPORT")]
        SUPPORT


    } // enum UserDomainEnum

} // namespace Rubrik.SecurityCloud.Types