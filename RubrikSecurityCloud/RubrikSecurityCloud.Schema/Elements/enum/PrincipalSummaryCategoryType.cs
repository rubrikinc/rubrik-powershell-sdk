// PrincipalSummaryCategoryType.cs
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
    public enum PrincipalSummaryCategoryType
    {
        [EnumMember(Value = "NEW_USERS_WITH_SENSITIVE_ACCESS")]
        NEW_USERS_WITH_SENSITIVE_ACCESS,

        [EnumMember(Value = "PRINCIPAL_SUMMARY_CATEGORY_UNSPECIFIED")]
        PRINCIPAL_SUMMARY_CATEGORY_UNSPECIFIED,

        [EnumMember(Value = "USERS_WITH_RISK_LEVEL_INCREASE")]
        USERS_WITH_RISK_LEVEL_INCREASE,

        [EnumMember(Value = "USERS_WITH_SENSITIVE_ACCESS")]
        USERS_WITH_SENSITIVE_ACCESS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum PrincipalSummaryCategoryType

} // namespace RubrikSecurityCloud.Types