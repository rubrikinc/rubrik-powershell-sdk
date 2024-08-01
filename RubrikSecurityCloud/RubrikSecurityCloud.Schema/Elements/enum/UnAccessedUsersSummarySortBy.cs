// UnAccessedUsersSummarySortBy.cs
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
    public enum UnAccessedUsersSummarySortBy
    {
        [EnumMember(Value = "PERCENTAGE_UNACCESSED_SENSITIVE_FILES")]
        PERCENTAGE_UNACCESSED_SENSITIVE_FILES,

        [EnumMember(Value = "UNACCESSED_USERS_SUMMARY_SORT_BY_UNSPECIFIED")]
        UNACCESSED_USERS_SUMMARY_SORT_BY_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum UnAccessedUsersSummarySortBy

} // namespace RubrikSecurityCloud.Types