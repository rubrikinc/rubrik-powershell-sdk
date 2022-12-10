// CloudNativeTagRuleFilterFields.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:18.
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
    public enum CloudNativeTagRuleFilterFields
    {
        [EnumMember(Value = "AWS_ACCOUNT")]
        AWS_ACCOUNT,

        [EnumMember(Value = "CLOUD_NATIVE_ACCOUNT")]
        CLOUD_NATIVE_ACCOUNT,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "SLA_DOMAIN")]
        SLA_DOMAIN


    } // enum CloudNativeTagRuleFilterFields

} // namespace Rubrik.SecurityCloud.Types