// NcdTaskStatus.cs
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
    public enum NcdTaskStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CANCELED")]
        CANCELED,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS,

        [EnumMember(Value = "STATUS_UNSPECIFIED")]
        STATUS_UNSPECIFIED,

        [EnumMember(Value = "SUCCESS")]
        SUCCESS


    } // enum NcdTaskStatus

} // namespace RubrikSecurityCloud.Types