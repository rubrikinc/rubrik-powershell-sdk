// ListObjectActivityDetailsSortBy.cs
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
    public enum ListObjectActivityDetailsSortBy
    {
        [EnumMember(Value = "DELTA_ACTIVITIES_PER_POLICY")]
        DELTA_ACTIVITIES_PER_POLICY,

        [EnumMember(Value = "LIST_OBJECT_ACTIVITY_DETAILS_UNSPECIFIED")]
        LIST_OBJECT_ACTIVITY_DETAILS_UNSPECIFIED,

        [EnumMember(Value = "TOTAL_ACTIVITIES_PER_POLICY")]
        TOTAL_ACTIVITIES_PER_POLICY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ListObjectActivityDetailsSortBy

} // namespace RubrikSecurityCloud.Types