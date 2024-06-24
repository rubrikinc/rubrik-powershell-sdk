// AttributeType.cs
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
    public enum AttributeType
    {
        [EnumMember(Value = "ADMINISTRATIVE_UNIT")]
        ADMINISTRATIVE_UNIT,

        [EnumMember(Value = "ATTRIBUTE_UNSPECIFIED")]
        ATTRIBUTE_UNSPECIFIED,

        [EnumMember(Value = "EXTENSION_ATTRIBUTES")]
        EXTENSION_ATTRIBUTES,

        [EnumMember(Value = "SCHEMA_EXTENSION_ATTRIBUTES")]
        SCHEMA_EXTENSION_ATTRIBUTES


    } // enum AttributeType

} // namespace RubrikSecurityCloud.Types