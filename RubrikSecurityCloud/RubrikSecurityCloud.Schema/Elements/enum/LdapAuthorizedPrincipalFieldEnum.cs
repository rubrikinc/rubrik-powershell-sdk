// LdapAuthorizedPrincipalFieldEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:41.
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
    public enum LdapAuthorizedPrincipalFieldEnum
    {
        [EnumMember(Value = "DirectoryName")]
        DIRECTORY_NAME,

        [EnumMember(Value = "Email")]
        EMAIL,

        [EnumMember(Value = "LAST_LOGIN")]
        LAST_LOGIN,

        [EnumMember(Value = "Name")]
        NAME


    } // enum LdapAuthorizedPrincipalFieldEnum

} // namespace Rubrik.SecurityCloud.Types