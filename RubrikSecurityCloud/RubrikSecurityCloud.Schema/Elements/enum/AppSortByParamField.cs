// AppSortByParamField.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:56.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum AppSortByParamField
    {
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

} // namespace Rubrik.SecurityCloud.Types