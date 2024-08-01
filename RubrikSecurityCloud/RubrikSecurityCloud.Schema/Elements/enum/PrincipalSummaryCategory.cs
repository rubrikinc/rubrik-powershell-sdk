// PrincipalSummaryCategory.cs
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
    public enum PrincipalSummaryCategory
    {
        [EnumMember(Value = "PRINCIPAL_SUMMARY_CATEGORY_UNSPECIFIED")]
        PRINCIPAL_SUMMARY_CATEGORY_UNSPECIFIED,

        [EnumMember(Value = "USERS_WITH_ACTIVITY")]
        USERS_WITH_ACTIVITY,

        [EnumMember(Value = "USERS_WITH_INCREASED_ACTIVITY")]
        USERS_WITH_INCREASED_ACTIVITY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum PrincipalSummaryCategory

} // namespace RubrikSecurityCloud.Types