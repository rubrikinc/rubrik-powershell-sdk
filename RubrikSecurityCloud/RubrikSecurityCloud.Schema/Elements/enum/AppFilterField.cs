// AppFilterField.cs
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
    public enum AppFilterField
    {
        [EnumMember(Value = "APP_ID")]
        APP_ID,

        [EnumMember(Value = "APP_TYPE")]
        APP_TYPE,

        [EnumMember(Value = "SUBSCRIPTION")]
        SUBSCRIPTION,

        [EnumMember(Value = "TENANT_ID")]
        TENANT_ID,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AppFilterField

} // namespace RubrikSecurityCloud.Types