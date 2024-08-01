// UsersSummaryCategoryType.cs
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
    public enum UsersSummaryCategoryType
    {
        [EnumMember(Value = "USERS_WITH_NO_SENSITIVE_DATA_ACCESS")]
        USERS_WITH_NO_SENSITIVE_DATA_ACCESS,

        [EnumMember(Value = "USERS_WITH_SENSITIVE_DATA_ACCESS")]
        USERS_WITH_SENSITIVE_DATA_ACCESS,

        [EnumMember(Value = "USER_SUMMARY_TYPE_UNSPECIFIED")]
        USER_SUMMARY_TYPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum UsersSummaryCategoryType

} // namespace RubrikSecurityCloud.Types