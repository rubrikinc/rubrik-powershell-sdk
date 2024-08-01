// SqlOperatorType.cs
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
    public enum SqlOperatorType
    {
        [EnumMember(Value = "EQUAL_TO")]
        EQUAL_TO,

        [EnumMember(Value = "GREATER_THAN")]
        GREATER_THAN,

        [EnumMember(Value = "GREATER_THAN_EQUAL_TO")]
        GREATER_THAN_EQUAL_TO,

        [EnumMember(Value = "IN")]
        IN,

        [EnumMember(Value = "LESS_THAN")]
        LESS_THAN,

        [EnumMember(Value = "LESS_THAN_EQUAL_TO")]
        LESS_THAN_EQUAL_TO,

        [EnumMember(Value = "LIKE")]
        LIKE,

        [EnumMember(Value = "NOT_EQUAL_TO")]
        NOT_EQUAL_TO,

        [EnumMember(Value = "NOT_IN")]
        NOT_IN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SqlOperatorType

} // namespace RubrikSecurityCloud.Types