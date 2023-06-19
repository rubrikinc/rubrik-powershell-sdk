// SupportUserAccessFilterField.cs
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
    public enum SupportUserAccessFilterField
    {
        [EnumMember(Value = "ACCESS_PROVIDER_OR_IMPERSONATED_USER")]
        ACCESS_PROVIDER_OR_IMPERSONATED_USER,

        [EnumMember(Value = "ACCESS_STATUS")]
        ACCESS_STATUS,

        [EnumMember(Value = "ENABLE_AT")]
        ENABLE_AT,

        [EnumMember(Value = "IMPERSONATED_USER_ID")]
        IMPERSONATED_USER_ID,

        [EnumMember(Value = "IS_EXPIRED")]
        IS_EXPIRED,

        [EnumMember(Value = "SUPPORT_ACCESS_ID")]
        SUPPORT_ACCESS_ID,

        [EnumMember(Value = "SUPPORT_USER_ID")]
        SUPPORT_USER_ID


    } // enum SupportUserAccessFilterField

} // namespace RubrikSecurityCloud.Types