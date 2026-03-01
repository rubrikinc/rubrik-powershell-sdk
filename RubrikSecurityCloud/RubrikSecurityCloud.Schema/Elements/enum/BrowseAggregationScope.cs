// BrowseAggregationScope.cs
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
    public enum BrowseAggregationScope
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BROWSE_AGGREGATION_SCOPE_DIRECTORY")]
        BROWSE_AGGREGATION_SCOPE_DIRECTORY,

        [EnumMember(Value = "BROWSE_AGGREGATION_SCOPE_FILE")]
        BROWSE_AGGREGATION_SCOPE_FILE,

        [EnumMember(Value = "BROWSE_AGGREGATION_SCOPE_OBJECT")]
        BROWSE_AGGREGATION_SCOPE_OBJECT,

        [EnumMember(Value = "BROWSE_AGGREGATION_SCOPE_UNSPECIFIED")]
        BROWSE_AGGREGATION_SCOPE_UNSPECIFIED


    } // enum BrowseAggregationScope

} // namespace RubrikSecurityCloud.Types