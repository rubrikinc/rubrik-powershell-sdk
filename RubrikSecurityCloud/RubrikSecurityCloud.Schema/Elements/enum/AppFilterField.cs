// AppFilterField.cs
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
    public enum AppFilterField
    {
        [EnumMember(Value = "APP_ID")]
        APP_ID,

        [EnumMember(Value = "APP_TYPE")]
        APP_TYPE,

        [EnumMember(Value = "SUBSCRIPTION")]
        SUBSCRIPTION,

        [EnumMember(Value = "TENANT_ID")]
        TENANT_ID


    } // enum AppFilterField

} // namespace Rubrik.SecurityCloud.Types