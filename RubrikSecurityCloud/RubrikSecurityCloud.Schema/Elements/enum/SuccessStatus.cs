// SuccessStatus.cs
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
    public enum SuccessStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FAILURE")]
        FAILURE,

        [EnumMember(Value = "PARTIAL_SUCCESS")]
        PARTIAL_SUCCESS,

        [EnumMember(Value = "SUCCESS")]
        SUCCESS


    } // enum SuccessStatus

} // namespace RubrikSecurityCloud.Types