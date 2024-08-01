// PolarisReportsFilterType.cs
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
    public enum PolarisReportsFilterType
    {
        [EnumMember(Value = "CREATED_BY")]
        CREATED_BY,

        [EnumMember(Value = "FILTER_UNSPECIFIED")]
        FILTER_UNSPECIFIED,

        [EnumMember(Value = "SEARCH_TERM")]
        SEARCH_TERM,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum PolarisReportsFilterType

} // namespace RubrikSecurityCloud.Types