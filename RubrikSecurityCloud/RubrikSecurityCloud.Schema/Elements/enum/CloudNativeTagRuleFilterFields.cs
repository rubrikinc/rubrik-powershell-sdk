// CloudNativeTagRuleFilterFields.cs
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
    public enum CloudNativeTagRuleFilterFields
    {
        [EnumMember(Value = "AWS_ACCOUNT")]
        AWS_ACCOUNT,

        [EnumMember(Value = "CLOUD_NATIVE_ACCOUNT")]
        CLOUD_NATIVE_ACCOUNT,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "SLA_DOMAIN")]
        SLA_DOMAIN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CloudNativeTagRuleFilterFields

} // namespace RubrikSecurityCloud.Types