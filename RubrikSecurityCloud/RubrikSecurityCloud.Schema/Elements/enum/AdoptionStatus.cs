// AdoptionStatus.cs
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
    public enum AdoptionStatus
    {
        [EnumMember(Value = "DECLINING")]
        DECLINING,

        [EnumMember(Value = "MOST_POPULAR")]
        MOST_POPULAR,

        [EnumMember(Value = "POPULAR")]
        POPULAR,

        [EnumMember(Value = "RISING")]
        RISING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AdoptionStatus

} // namespace RubrikSecurityCloud.Types