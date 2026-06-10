// AzureAdAccessReviewRecurrence.cs
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
    public enum AzureAdAccessReviewRecurrence
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCESS_REVIEW_RECURRENCE_ANNUALLY")]
        ACCESS_REVIEW_RECURRENCE_ANNUALLY,

        [EnumMember(Value = "ACCESS_REVIEW_RECURRENCE_MONTHLY")]
        ACCESS_REVIEW_RECURRENCE_MONTHLY,

        [EnumMember(Value = "ACCESS_REVIEW_RECURRENCE_QUARTERLY")]
        ACCESS_REVIEW_RECURRENCE_QUARTERLY,

        [EnumMember(Value = "ACCESS_REVIEW_RECURRENCE_SEMI_ANNUALLY")]
        ACCESS_REVIEW_RECURRENCE_SEMI_ANNUALLY,

        [EnumMember(Value = "ACCESS_REVIEW_RECURRENCE_UNSPECIFIED")]
        ACCESS_REVIEW_RECURRENCE_UNSPECIFIED,

        [EnumMember(Value = "ACCESS_REVIEW_RECURRENCE_WEEKLY")]
        ACCESS_REVIEW_RECURRENCE_WEEKLY


    } // enum AzureAdAccessReviewRecurrence

} // namespace RubrikSecurityCloud.Types