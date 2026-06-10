// SigninLogFailureCategory.cs
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
    public enum SigninLogFailureCategory
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SIGNIN_LOG_FAILURE_CATEGORY_ACCOUNT_DISABLED")]
        SIGNIN_LOG_FAILURE_CATEGORY_ACCOUNT_DISABLED,

        [EnumMember(Value = "SIGNIN_LOG_FAILURE_CATEGORY_ACCOUNT_LOCKED")]
        SIGNIN_LOG_FAILURE_CATEGORY_ACCOUNT_LOCKED,

        [EnumMember(Value = "SIGNIN_LOG_FAILURE_CATEGORY_INVALID_CREDENTIALS")]
        SIGNIN_LOG_FAILURE_CATEGORY_INVALID_CREDENTIALS,

        [EnumMember(Value = "SIGNIN_LOG_FAILURE_CATEGORY_MFA_FAILURE")]
        SIGNIN_LOG_FAILURE_CATEGORY_MFA_FAILURE,

        [EnumMember(Value = "SIGNIN_LOG_FAILURE_CATEGORY_OTHER")]
        SIGNIN_LOG_FAILURE_CATEGORY_OTHER,

        [EnumMember(Value = "SIGNIN_LOG_FAILURE_CATEGORY_PASSWORD_EXPIRED")]
        SIGNIN_LOG_FAILURE_CATEGORY_PASSWORD_EXPIRED,

        [EnumMember(Value = "SIGNIN_LOG_FAILURE_CATEGORY_POLICY_BLOCKED")]
        SIGNIN_LOG_FAILURE_CATEGORY_POLICY_BLOCKED


    } // enum SigninLogFailureCategory

} // namespace RubrikSecurityCloud.Types