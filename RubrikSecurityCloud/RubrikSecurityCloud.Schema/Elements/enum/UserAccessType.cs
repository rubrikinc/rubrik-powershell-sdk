// UserAccessType.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum UserAccessType
    {
        [EnumMember(Value = "INSECURE")]
        INSECURE,

        [EnumMember(Value = "SECURE")]
        SECURE,

        [EnumMember(Value = "USER_ACCESS_TYPE_UNKNOWN")]
        USER_ACCESS_TYPE_UNKNOWN


    } // enum UserAccessType

} // namespace Rubrik.SecurityCloud.Types