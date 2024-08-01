// NotificationApplication.cs
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
    public enum NotificationApplication
    {
        [EnumMember(Value = "APPLICATION_UNSPECIFIED")]
        APPLICATION_UNSPECIFIED,

        [EnumMember(Value = "DATA_DISCOVERY")]
        DATA_DISCOVERY,

        [EnumMember(Value = "USER_ACCESS")]
        USER_ACCESS,

        [EnumMember(Value = "USER_ACTIVITY")]
        USER_ACTIVITY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum NotificationApplication

} // namespace RubrikSecurityCloud.Types