// TprReqOperation.cs
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
    public enum TprReqOperation
    {
        [EnumMember(Value = "APPROVE")]
        APPROVE,

        [EnumMember(Value = "CANCEL")]
        CANCEL,

        [EnumMember(Value = "COMPLETE")]
        COMPLETE,

        [EnumMember(Value = "DENY")]
        DENY,

        [EnumMember(Value = "EXPIRE")]
        EXPIRE,

        [EnumMember(Value = "FAIL")]
        FAIL,

        [EnumMember(Value = "SCHEDULE")]
        SCHEDULE,

        [EnumMember(Value = "SUBMIT")]
        SUBMIT


    } // enum TprReqOperation

} // namespace RubrikSecurityCloud.Types