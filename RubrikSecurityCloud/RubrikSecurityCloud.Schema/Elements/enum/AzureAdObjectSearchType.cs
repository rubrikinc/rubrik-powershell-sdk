// AzureAdObjectSearchType.cs
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
    public enum AzureAdObjectSearchType
    {
        [EnumMember(Value = "GROUP_NAME")]
        GROUP_NAME,

        [EnumMember(Value = "GROUP_TYPE")]
        GROUP_TYPE,

        [EnumMember(Value = "PRINCIPAL_USER_NAME")]
        PRINCIPAL_USER_NAME,

        [EnumMember(Value = "ROLE_NAME")]
        ROLE_NAME,

        [EnumMember(Value = "USER_NAME")]
        USER_NAME,

        [EnumMember(Value = "USER_TYPE")]
        USER_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AzureAdObjectSearchType

} // namespace RubrikSecurityCloud.Types