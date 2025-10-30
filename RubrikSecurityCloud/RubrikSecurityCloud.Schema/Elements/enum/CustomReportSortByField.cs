// CustomReportSortByField.cs
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
    public enum CustomReportSortByField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CREATED_AT")]
        CREATED_AT,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "UPDATED_AT")]
        UPDATED_AT


    } // enum CustomReportSortByField

} // namespace RubrikSecurityCloud.Types