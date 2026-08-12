// TagConditionOperator.cs
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
    public enum TagConditionOperator
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "TAG_CONDITION_OPERATOR_NULL")]
        TAG_CONDITION_OPERATOR_NULL,

        [EnumMember(Value = "TAG_CONDITION_OPERATOR_STRING_EQUALS")]
        TAG_CONDITION_OPERATOR_STRING_EQUALS,

        [EnumMember(Value = "TAG_CONDITION_OPERATOR_STRING_LIKE")]
        TAG_CONDITION_OPERATOR_STRING_LIKE,

        [EnumMember(Value = "TAG_CONDITION_OPERATOR_STRING_NOT_EQUALS")]
        TAG_CONDITION_OPERATOR_STRING_NOT_EQUALS,

        [EnumMember(Value = "TAG_CONDITION_OPERATOR_STRING_NOT_LIKE")]
        TAG_CONDITION_OPERATOR_STRING_NOT_LIKE,

        [EnumMember(Value = "TAG_CONDITION_OPERATOR_UNSPECIFIED")]
        TAG_CONDITION_OPERATOR_UNSPECIFIED


    } // enum TagConditionOperator

} // namespace RubrikSecurityCloud.Types