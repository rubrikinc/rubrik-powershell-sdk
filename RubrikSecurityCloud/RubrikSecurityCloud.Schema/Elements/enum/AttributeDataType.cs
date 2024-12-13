// AttributeDataType.cs
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
    public enum AttributeDataType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ATTRIBUTE_DATA_TYPE_UNSPECIFIED")]
        ATTRIBUTE_DATA_TYPE_UNSPECIFIED,

        [EnumMember(Value = "BOOLEAN")]
        BOOLEAN,

        [EnumMember(Value = "INTEGER")]
        INTEGER,

        [EnumMember(Value = "ISO_8601_DATETIME")]
        ISO_8601_DATETIME,

        [EnumMember(Value = "STRING")]
        STRING


    } // enum AttributeDataType

} // namespace RubrikSecurityCloud.Types