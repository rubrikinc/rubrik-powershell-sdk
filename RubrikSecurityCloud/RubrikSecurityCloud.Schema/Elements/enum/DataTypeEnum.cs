// DataTypeEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:59.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum DataTypeEnum
    {
        [EnumMember(Value = "BOOLEAN")]
        BOOLEAN,

        [EnumMember(Value = "BYTE")]
        BYTE,

        [EnumMember(Value = "DATE_TIME")]
        DATE_TIME,

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

} // namespace Rubrik.SecurityCloud.Types