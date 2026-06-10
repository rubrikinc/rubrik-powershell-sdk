// Relationship.cs
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
    public enum Relationship
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AFTER")]
        AFTER,

        [EnumMember(Value = "BEFORE")]
        BEFORE,

        [EnumMember(Value = "BETWEEN")]
        BETWEEN,

        [EnumMember(Value = "CONTAINS")]
        CONTAINS,

        [EnumMember(Value = "DOES_NOT_CONTAIN")]
        DOES_NOT_CONTAIN,

        [EnumMember(Value = "EQUALS")]
        EQUALS,

        [EnumMember(Value = "EXISTS")]
        EXISTS,

        [EnumMember(Value = "GREATER_THAN")]
        GREATER_THAN,

        [EnumMember(Value = "IS")]
        IS,

        [EnumMember(Value = "IS_EMPTY")]
        IS_EMPTY,

        [EnumMember(Value = "IS_NOT")]
        IS_NOT,

        [EnumMember(Value = "IS_NOT_EMPTY")]
        IS_NOT_EMPTY,

        [EnumMember(Value = "LESS_THAN")]
        LESS_THAN,

        [EnumMember(Value = "NONE_OF")]
        NONE_OF,

        [EnumMember(Value = "NOT_EQUALS")]
        NOT_EQUALS,

        [EnumMember(Value = "OTHER_THAN")]
        OTHER_THAN,

        [EnumMember(Value = "RELATIONSHIP_UNSPECIFIED")]
        RELATIONSHIP_UNSPECIFIED


    } // enum Relationship

} // namespace RubrikSecurityCloud.Types