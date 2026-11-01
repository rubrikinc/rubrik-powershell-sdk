// CloudNativeSearchOperator.cs
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
    public enum CloudNativeSearchOperator
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLOUD_NATIVE_SEARCH_OPERATOR_BEGINS_WITH")]
        CLOUD_NATIVE_SEARCH_OPERATOR_BEGINS_WITH,

        [EnumMember(Value = "CLOUD_NATIVE_SEARCH_OPERATOR_BETWEEN")]
        CLOUD_NATIVE_SEARCH_OPERATOR_BETWEEN,

        [EnumMember(Value = "CLOUD_NATIVE_SEARCH_OPERATOR_CONTAINS")]
        CLOUD_NATIVE_SEARCH_OPERATOR_CONTAINS,

        [EnumMember(Value = "CLOUD_NATIVE_SEARCH_OPERATOR_EQ")]
        CLOUD_NATIVE_SEARCH_OPERATOR_EQ,

        [EnumMember(Value = "CLOUD_NATIVE_SEARCH_OPERATOR_EXISTS")]
        CLOUD_NATIVE_SEARCH_OPERATOR_EXISTS,

        [EnumMember(Value = "CLOUD_NATIVE_SEARCH_OPERATOR_GE")]
        CLOUD_NATIVE_SEARCH_OPERATOR_GE,

        [EnumMember(Value = "CLOUD_NATIVE_SEARCH_OPERATOR_GT")]
        CLOUD_NATIVE_SEARCH_OPERATOR_GT,

        [EnumMember(Value = "CLOUD_NATIVE_SEARCH_OPERATOR_IN")]
        CLOUD_NATIVE_SEARCH_OPERATOR_IN,

        [EnumMember(Value = "CLOUD_NATIVE_SEARCH_OPERATOR_LE")]
        CLOUD_NATIVE_SEARCH_OPERATOR_LE,

        [EnumMember(Value = "CLOUD_NATIVE_SEARCH_OPERATOR_LT")]
        CLOUD_NATIVE_SEARCH_OPERATOR_LT,

        [EnumMember(Value = "CLOUD_NATIVE_SEARCH_OPERATOR_NOT_EXISTS")]
        CLOUD_NATIVE_SEARCH_OPERATOR_NOT_EXISTS,

        [EnumMember(Value = "CLOUD_NATIVE_SEARCH_OPERATOR_UNSPECIFIED")]
        CLOUD_NATIVE_SEARCH_OPERATOR_UNSPECIFIED


    } // enum CloudNativeSearchOperator

} // namespace RubrikSecurityCloud.Types