// InsightCategory.cs
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
    public enum InsightCategory
    {
        [EnumMember(Value = "DEFECT")]
        DEFECT,

        [EnumMember(Value = "INFORMATIONAL")]
        INFORMATIONAL,

        [EnumMember(Value = "INSIGHT_CATEGORY_UNSPECIFIED")]
        INSIGHT_CATEGORY_UNSPECIFIED


    } // enum InsightCategory

} // namespace RubrikSecurityCloud.Types