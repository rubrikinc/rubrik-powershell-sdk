// CustomReportSortByEnum.cs
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
    public enum CustomReportSortByEnum
    {
        [EnumMember(Value = "CreationTime")]
        CREATION_TIME,

        [EnumMember(Value = "UpdateTime")]
        UPDATE_TIME,

        [EnumMember(Value = "ViewTime")]
        VIEW_TIME


    } // enum CustomReportSortByEnum

} // namespace RubrikSecurityCloud.Types