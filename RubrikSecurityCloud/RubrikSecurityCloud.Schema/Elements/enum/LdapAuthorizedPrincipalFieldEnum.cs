// LdapAuthorizedPrincipalFieldEnum.cs
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
    public enum LdapAuthorizedPrincipalFieldEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DirectoryName")]
        DIRECTORY_NAME,

        [EnumMember(Value = "Email")]
        EMAIL,

        [EnumMember(Value = "LAST_LOGIN")]
        LAST_LOGIN,

        [EnumMember(Value = "Name")]
        NAME


    } // enum LdapAuthorizedPrincipalFieldEnum

} // namespace RubrikSecurityCloud.Types