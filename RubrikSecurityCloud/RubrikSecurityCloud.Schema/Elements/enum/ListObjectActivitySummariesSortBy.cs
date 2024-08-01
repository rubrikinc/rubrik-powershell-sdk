// ListObjectActivitySummariesSortBy.cs
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
    public enum ListObjectActivitySummariesSortBy
    {
        [EnumMember(Value = "LIST_OBJECT_ACTIVITY_SUMMARIES_UNSPECIFIED")]
        LIST_OBJECT_ACTIVITY_SUMMARIES_UNSPECIFIED,

        [EnumMember(Value = "NUM_SENSITIVE_FILES_WITH_ACTIVITY_PER_OBJECT")]
        NUM_SENSITIVE_FILES_WITH_ACTIVITY_PER_OBJECT,

        [EnumMember(Value = "OBJECT_NAME")]
        OBJECT_NAME,

        [EnumMember(Value = "OBJECT_RISK")]
        OBJECT_RISK,

        [EnumMember(Value = "TOTAL_ACTIVITIES_IN_SENSITIVE_FILES_PER_OBJECT")]
        TOTAL_ACTIVITIES_IN_SENSITIVE_FILES_PER_OBJECT,

        [EnumMember(Value = "UNUSED_SENSITIVE_FILES_PER_OBJECT")]
        UNUSED_SENSITIVE_FILES_PER_OBJECT,

        [EnumMember(Value = "USERS_WITH_ACTIVITY_PER_OBJECT")]
        USERS_WITH_ACTIVITY_PER_OBJECT,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ListObjectActivitySummariesSortBy

} // namespace RubrikSecurityCloud.Types