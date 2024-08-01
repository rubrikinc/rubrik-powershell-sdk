// BrowseFileUsersActivitySortBy.cs
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
    public enum BrowseFileUsersActivitySortBy
    {
        [EnumMember(Value = "BROWSE_FILE_USERS_ACTIVITY_SORT_BY_UNSPECIFIED")]
        BROWSE_FILE_USERS_ACTIVITY_SORT_BY_UNSPECIFIED,

        [EnumMember(Value = "FILE_ACTIVITIES")]
        FILE_ACTIVITIES,

        [EnumMember(Value = "USER_RISK")]
        USER_RISK,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum BrowseFileUsersActivitySortBy

} // namespace RubrikSecurityCloud.Types