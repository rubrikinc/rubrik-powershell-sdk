// Operator.cs
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
    public enum Operator
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EQUALS")]
        EQUALS,

        [EnumMember(Value = "GREATER_THAN")]
        GREATER_THAN,

        [EnumMember(Value = "GREATER_THAN_EQUALS")]
        GREATER_THAN_EQUALS,

        [EnumMember(Value = "IN")]
        IN,

        [EnumMember(Value = "LESS_THAN")]
        LESS_THAN,

        [EnumMember(Value = "LESS_THAN_EQUALS")]
        LESS_THAN_EQUALS,

        [EnumMember(Value = "LIKE")]
        LIKE,

        [EnumMember(Value = "NOT_EQUALS")]
        NOT_EQUALS,

        [EnumMember(Value = "NOT_IN")]
        NOT_IN,

        [EnumMember(Value = "NOT_LIKE")]
        NOT_LIKE,

        [EnumMember(Value = "OPERATOR_UNSPECIFIED")]
        OPERATOR_UNSPECIFIED


    } // enum Operator

} // namespace RubrikSecurityCloud.Types