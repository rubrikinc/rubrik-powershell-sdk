// SchemaFieldType.cs
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
    public enum SchemaFieldType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SCHEMAFIELDTYPE_ARRAY")]
        SCHEMAFIELDTYPE_ARRAY,

        [EnumMember(Value = "SCHEMAFIELDTYPE_LEAF")]
        SCHEMAFIELDTYPE_LEAF,

        [EnumMember(Value = "SCHEMAFIELDTYPE_OBJECT")]
        SCHEMAFIELDTYPE_OBJECT,

        [EnumMember(Value = "SCHEMAFIELDTYPE_UNSPECIFIED")]
        SCHEMAFIELDTYPE_UNSPECIFIED


    } // enum SchemaFieldType

} // namespace RubrikSecurityCloud.Types