// SigninLogFilterType.cs
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
    public enum SigninLogFilterType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SIGNIN_LOG_FILTER_APPLICATION_NAME")]
        SIGNIN_LOG_FILTER_APPLICATION_NAME,

        [EnumMember(Value = "SIGNIN_LOG_FILTER_CITY")]
        SIGNIN_LOG_FILTER_CITY,

        [EnumMember(Value = "SIGNIN_LOG_FILTER_COUNTRY")]
        SIGNIN_LOG_FILTER_COUNTRY,

        [EnumMember(Value = "SIGNIN_LOG_FILTER_DEVICE_NAME")]
        SIGNIN_LOG_FILTER_DEVICE_NAME,

        [EnumMember(Value = "SIGNIN_LOG_FILTER_DISPLAY_NAME")]
        SIGNIN_LOG_FILTER_DISPLAY_NAME,

        [EnumMember(Value = "SIGNIN_LOG_FILTER_IP_ADDRESS")]
        SIGNIN_LOG_FILTER_IP_ADDRESS,

        [EnumMember(Value = "SIGNIN_LOG_FILTER_LOCATION")]
        SIGNIN_LOG_FILTER_LOCATION,

        [EnumMember(Value = "SIGNIN_LOG_FILTER_TENANT")]
        SIGNIN_LOG_FILTER_TENANT,

        [EnumMember(Value = "SIGNIN_LOG_FILTER_USER")]
        SIGNIN_LOG_FILTER_USER


    } // enum SigninLogFilterType

} // namespace RubrikSecurityCloud.Types