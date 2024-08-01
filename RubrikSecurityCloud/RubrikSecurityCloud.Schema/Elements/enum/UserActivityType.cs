// UserActivityType.cs
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
    public enum UserActivityType
    {
        [EnumMember(Value = "ACCESS_DENIED")]
        ACCESS_DENIED,

        [EnumMember(Value = "DELETED")]
        DELETED,

        [EnumMember(Value = "MODIFIED")]
        MODIFIED,

        [EnumMember(Value = "READ")]
        READ,

        [EnumMember(Value = "UNKNOWN_ACTIVITY")]
        UNKNOWN_ACTIVITY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum UserActivityType

} // namespace RubrikSecurityCloud.Types