// InsightType.cs
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
    public enum InsightType
    {
        [EnumMember(Value = "INSIGHT")]
        INSIGHT,

        [EnumMember(Value = "INSIGHT_TYPE_UNSPECIFIED")]
        INSIGHT_TYPE_UNSPECIFIED,

        [EnumMember(Value = "RECOMMENDATION")]
        RECOMMENDATION


    } // enum InsightType

} // namespace RubrikSecurityCloud.Types