// UserSortByField.cs
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
    public enum UserSortByField
    {
        [EnumMember(Value = "DOMAIN")]
        DOMAIN,

        [EnumMember(Value = "EMAIL")]
        EMAIL,

        [EnumMember(Value = "LAST_LOGIN")]
        LAST_LOGIN,

        [EnumMember(Value = "STATUS")]
        STATUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum UserSortByField

} // namespace RubrikSecurityCloud.Types