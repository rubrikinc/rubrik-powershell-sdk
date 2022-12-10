// UserSortByField.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:03.
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
    public enum UserSortByField
    {
        [EnumMember(Value = "DOMAIN")]
        DOMAIN,

        [EnumMember(Value = "EMAIL")]
        EMAIL,

        [EnumMember(Value = "LAST_LOGIN")]
        LAST_LOGIN,

        [EnumMember(Value = "STATUS")]
        STATUS


    } // enum UserSortByField

} // namespace Rubrik.SecurityCloud.Types