// ActivityOperation.cs
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
    public enum ActivityOperation
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVITY_OPERATION_ADD")]
        ACTIVITY_OPERATION_ADD,

        [EnumMember(Value = "ACTIVITY_OPERATION_CHANGE")]
        ACTIVITY_OPERATION_CHANGE,

        [EnumMember(Value = "ACTIVITY_OPERATION_REMOVE")]
        ACTIVITY_OPERATION_REMOVE,

        [EnumMember(Value = "ACTIVITY_OPERATION_UNSPECIFIED")]
        ACTIVITY_OPERATION_UNSPECIFIED


    } // enum ActivityOperation

} // namespace RubrikSecurityCloud.Types