// DataTypeEnum.cs
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
    public enum DataTypeEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BOOLEAN")]
        BOOLEAN,

        [EnumMember(Value = "BYTE")]
        BYTE,

        [EnumMember(Value = "DATE_TIME")]
        DATE_TIME,

        [EnumMember(Value = "FILTER_COMPLIANCE_RANGE")]
        FILTER_COMPLIANCE_RANGE,

        [EnumMember(Value = "FILTER_DATE_RANGE")]
        FILTER_DATE_RANGE,

        [EnumMember(Value = "FLOAT")]
        FLOAT,

        [EnumMember(Value = "INTEGER")]
        INTEGER,

        [EnumMember(Value = "LONG")]
        LONG,

        [EnumMember(Value = "STRING")]
        STRING,

        [EnumMember(Value = "URL")]
        URL


    } // enum DataTypeEnum

} // namespace RubrikSecurityCloud.Types