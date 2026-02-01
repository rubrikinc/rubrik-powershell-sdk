// SigninLogResult.cs
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
    public enum SigninLogResult
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SIGNIN_LOG_RESULT_FAILURE")]
        SIGNIN_LOG_RESULT_FAILURE,

        [EnumMember(Value = "SIGNIN_LOG_RESULT_INTERRUPTED")]
        SIGNIN_LOG_RESULT_INTERRUPTED,

        [EnumMember(Value = "SIGNIN_LOG_RESULT_SUCCESS")]
        SIGNIN_LOG_RESULT_SUCCESS


    } // enum SigninLogResult

} // namespace RubrikSecurityCloud.Types