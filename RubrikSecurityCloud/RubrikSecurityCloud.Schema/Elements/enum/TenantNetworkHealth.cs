// TenantNetworkHealth.cs
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
    public enum TenantNetworkHealth
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CRITICAL_TENANT_NETWORK_HEALTH")]
        CRITICAL_TENANT_NETWORK_HEALTH,

        [EnumMember(Value = "DEGRADED_TENANT_NETWORK_HEALTH")]
        DEGRADED_TENANT_NETWORK_HEALTH,

        [EnumMember(Value = "HEALTHY_TENANT_NETWORK_HEALTH")]
        HEALTHY_TENANT_NETWORK_HEALTH,

        [EnumMember(Value = "TENANT_NETWORK_HEALTH_UNSPECIFIED")]
        TENANT_NETWORK_HEALTH_UNSPECIFIED


    } // enum TenantNetworkHealth

} // namespace RubrikSecurityCloud.Types