// SigninLogSortField.cs
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
    public enum SigninLogSortField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SIGNIN_LOG_SORT_FIELD_ACTOR_PRINCIPAL_NAME")]
        SIGNIN_LOG_SORT_FIELD_ACTOR_PRINCIPAL_NAME,

        [EnumMember(Value = "SIGNIN_LOG_SORT_FIELD_EVENT_TIMESTAMP")]
        SIGNIN_LOG_SORT_FIELD_EVENT_TIMESTAMP,

        [EnumMember(Value = "SIGNIN_LOG_SORT_FIELD_PROVIDER")]
        SIGNIN_LOG_SORT_FIELD_PROVIDER,

        [EnumMember(Value = "SIGNIN_LOG_SORT_FIELD_RESULT")]
        SIGNIN_LOG_SORT_FIELD_RESULT,

        [EnumMember(Value = "SIGNIN_LOG_SORT_FIELD_RISK_LEVEL")]
        SIGNIN_LOG_SORT_FIELD_RISK_LEVEL


    } // enum SigninLogSortField

} // namespace RubrikSecurityCloud.Types