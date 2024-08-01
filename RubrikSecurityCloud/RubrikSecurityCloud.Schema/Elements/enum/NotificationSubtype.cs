// NotificationSubtype.cs
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
    public enum NotificationSubtype
    {
        [EnumMember(Value = "INSIGHT")]
        INSIGHT,

        [EnumMember(Value = "SUBTYPE_UNSPECIFIED")]
        SUBTYPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum NotificationSubtype

} // namespace RubrikSecurityCloud.Types