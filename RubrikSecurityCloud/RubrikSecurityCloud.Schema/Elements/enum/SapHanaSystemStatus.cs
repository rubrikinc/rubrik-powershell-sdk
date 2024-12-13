// SapHanaSystemStatus.cs
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
    public enum SapHanaSystemStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ERROR")]
        ERROR,

        [EnumMember(Value = "OK")]
        OK,

        [EnumMember(Value = "UNKNOWN_SYSTEM_STATUS")]
        UNKNOWN_SYSTEM_STATUS,

        [EnumMember(Value = "WARNING")]
        WARNING


    } // enum SapHanaSystemStatus

} // namespace RubrikSecurityCloud.Types