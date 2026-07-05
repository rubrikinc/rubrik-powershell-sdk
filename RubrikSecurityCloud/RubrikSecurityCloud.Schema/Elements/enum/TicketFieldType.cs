// TicketFieldType.cs
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
    public enum TicketFieldType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FIELD_TYPE_ARRAY")]
        FIELD_TYPE_ARRAY,

        [EnumMember(Value = "FIELD_TYPE_BOOLEAN")]
        FIELD_TYPE_BOOLEAN,

        [EnumMember(Value = "FIELD_TYPE_DATE")]
        FIELD_TYPE_DATE,

        [EnumMember(Value = "FIELD_TYPE_DATETIME")]
        FIELD_TYPE_DATETIME,

        [EnumMember(Value = "FIELD_TYPE_MULTI_OPTION")]
        FIELD_TYPE_MULTI_OPTION,

        [EnumMember(Value = "FIELD_TYPE_NUMBER")]
        FIELD_TYPE_NUMBER,

        [EnumMember(Value = "FIELD_TYPE_OPTION")]
        FIELD_TYPE_OPTION,

        [EnumMember(Value = "FIELD_TYPE_STRING")]
        FIELD_TYPE_STRING,

        [EnumMember(Value = "FIELD_TYPE_TEXT_AREA")]
        FIELD_TYPE_TEXT_AREA,

        [EnumMember(Value = "FIELD_TYPE_USER")]
        FIELD_TYPE_USER


    } // enum TicketFieldType

} // namespace RubrikSecurityCloud.Types