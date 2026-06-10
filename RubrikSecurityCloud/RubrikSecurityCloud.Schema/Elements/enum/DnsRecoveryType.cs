// DnsRecoveryType.cs
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
    public enum DnsRecoveryType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DNS_RECOVERY_TYPE_AD_INTEGRATED_DNS")]
        DNS_RECOVERY_TYPE_AD_INTEGRATED_DNS,

        [EnumMember(Value = "DNS_RECOVERY_TYPE_CUSTOM_DNS")]
        DNS_RECOVERY_TYPE_CUSTOM_DNS,

        [EnumMember(Value = "DNS_RECOVERY_TYPE_INTACT")]
        DNS_RECOVERY_TYPE_INTACT


    } // enum DnsRecoveryType

} // namespace RubrikSecurityCloud.Types