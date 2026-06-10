// AzureAdAccessReviewFallbackAction.cs
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
    public enum AzureAdAccessReviewFallbackAction
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCESS_REVIEW_FALLBACK_ACTION_APPROVE_ACCESS")]
        ACCESS_REVIEW_FALLBACK_ACTION_APPROVE_ACCESS,

        [EnumMember(Value = "ACCESS_REVIEW_FALLBACK_ACTION_NO_CHANGE")]
        ACCESS_REVIEW_FALLBACK_ACTION_NO_CHANGE,

        [EnumMember(Value = "ACCESS_REVIEW_FALLBACK_ACTION_REMOVE_ACCESS")]
        ACCESS_REVIEW_FALLBACK_ACTION_REMOVE_ACCESS,

        [EnumMember(Value = "ACCESS_REVIEW_FALLBACK_ACTION_TAKE_RECOMMENDATIONS")]
        ACCESS_REVIEW_FALLBACK_ACTION_TAKE_RECOMMENDATIONS,

        [EnumMember(Value = "ACCESS_REVIEW_FALLBACK_ACTION_UNSPECIFIED")]
        ACCESS_REVIEW_FALLBACK_ACTION_UNSPECIFIED


    } // enum AzureAdAccessReviewFallbackAction

} // namespace RubrikSecurityCloud.Types