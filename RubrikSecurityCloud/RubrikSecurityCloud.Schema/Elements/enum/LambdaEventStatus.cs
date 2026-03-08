// LambdaEventStatus.cs
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
    public enum LambdaEventStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EVENT_STATUS_FAILURE")]
        EVENT_STATUS_FAILURE,

        [EnumMember(Value = "EVENT_STATUS_SUCCESS")]
        EVENT_STATUS_SUCCESS,

        [EnumMember(Value = "EVENT_STATUS_UNSPECIFIED")]
        EVENT_STATUS_UNSPECIFIED


    } // enum LambdaEventStatus

} // namespace RubrikSecurityCloud.Types