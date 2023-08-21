// NotificationResourceType.cs
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
    public enum NotificationResourceType
    {
        [EnumMember(Value = "EVENTS")]
        EVENTS,

        [EnumMember(Value = "RESOURCE_TYPE_UNSPECIFIED")]
        RESOURCE_TYPE_UNSPECIFIED,

        [EnumMember(Value = "TPR")]
        TPR


    } // enum NotificationResourceType

} // namespace RubrikSecurityCloud.Types