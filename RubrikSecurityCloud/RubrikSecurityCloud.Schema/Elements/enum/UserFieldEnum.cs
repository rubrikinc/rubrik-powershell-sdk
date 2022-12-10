// UserFieldEnum.cs
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
    public enum UserFieldEnum
    {
        [EnumMember(Value = "Domain")]
        DOMAIN,

        [EnumMember(Value = "Email")]
        EMAIL,

        [EnumMember(Value = "LastLogin")]
        LAST_LOGIN,

        [EnumMember(Value = "Status")]
        STATUS


    } // enum UserFieldEnum

} // namespace Rubrik.SecurityCloud.Types