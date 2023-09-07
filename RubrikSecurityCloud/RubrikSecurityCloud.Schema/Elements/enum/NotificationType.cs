// NotificationType.cs
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
    public enum NotificationType
    {
        [EnumMember(Value = "ERROR")]
        ERROR,

        [EnumMember(Value = "INFO")]
        INFO,

        [EnumMember(Value = "TYPE_UNSPECIFIED")]
        TYPE_UNSPECIFIED,

        [EnumMember(Value = "WARNING")]
        WARNING


    } // enum NotificationType

} // namespace RubrikSecurityCloud.Types