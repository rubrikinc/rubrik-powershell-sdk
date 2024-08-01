// BrowseFilesActivitySummariesSortBy.cs
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
    public enum BrowseFilesActivitySummariesSortBy
    {
        [EnumMember(Value = "ACTIVITIES")]
        ACTIVITIES,

        [EnumMember(Value = "BROWSE_FILES_ACTIVITY_SUMMARIES_UNSPECIFIED")]
        BROWSE_FILES_ACTIVITY_SUMMARIES_UNSPECIFIED,

        [EnumMember(Value = "CHANGE_IN_ACTIVITY")]
        CHANGE_IN_ACTIVITY,

        [EnumMember(Value = "FILE_NAME")]
        FILE_NAME,

        [EnumMember(Value = "LAST_ACCESSED")]
        LAST_ACCESSED,

        [EnumMember(Value = "RISK")]
        RISK,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum BrowseFilesActivitySummariesSortBy

} // namespace RubrikSecurityCloud.Types