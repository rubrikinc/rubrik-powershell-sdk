// DataCategoryFilter.cs
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
    public enum DataCategoryFilter
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE_DATA_CATEGORIES")]
        ACTIVE_DATA_CATEGORIES,

        [EnumMember(Value = "ALL_DATA_CATEGORIES")]
        ALL_DATA_CATEGORIES,

        [EnumMember(Value = "INACTIVE_DATA_CATEGORIES")]
        INACTIVE_DATA_CATEGORIES


    } // enum DataCategoryFilter

} // namespace RubrikSecurityCloud.Types