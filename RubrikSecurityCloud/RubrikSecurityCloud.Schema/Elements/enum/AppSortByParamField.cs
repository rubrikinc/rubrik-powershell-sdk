// AppSortByParamField.cs
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
    public enum AppSortByParamField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ADDED_AT")]
        ADDED_AT,

        [EnumMember(Value = "APP_ID")]
        APP_ID,

        [EnumMember(Value = "APP_OWNER")]
        APP_OWNER,

        [EnumMember(Value = "APP_TYPE")]
        APP_TYPE,

        [EnumMember(Value = "IS_AUTHENTICATED")]
        IS_AUTHENTICATED,

        [EnumMember(Value = "SUBSCRIPTION")]
        SUBSCRIPTION


    } // enum AppSortByParamField

} // namespace RubrikSecurityCloud.Types