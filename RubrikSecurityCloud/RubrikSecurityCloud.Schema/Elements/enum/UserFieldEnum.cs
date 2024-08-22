// UserFieldEnum.cs
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
    public enum UserFieldEnum
    {
        [EnumMember(Value = "Domain")]
        DOMAIN,

        [EnumMember(Value = "Email")]
        EMAIL,

        [EnumMember(Value = "LastLogin")]
        LAST_LOGIN,

        [EnumMember(Value = "Status")]
        STATUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum UserFieldEnum

} // namespace RubrikSecurityCloud.Types