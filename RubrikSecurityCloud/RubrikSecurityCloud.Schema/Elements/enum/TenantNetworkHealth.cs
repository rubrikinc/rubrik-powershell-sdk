// TenantNetworkHealth.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:02.
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
    public enum TenantNetworkHealth
    {
        [EnumMember(Value = "CRITICAL_TENANT_NETWORK_HEALTH")]
        CRITICAL_TENANT_NETWORK_HEALTH,

        [EnumMember(Value = "DEGRADED_TENANT_NETWORK_HEALTH")]
        DEGRADED_TENANT_NETWORK_HEALTH,

        [EnumMember(Value = "HEALTHY_TENANT_NETWORK_HEALTH")]
        HEALTHY_TENANT_NETWORK_HEALTH,

        [EnumMember(Value = "TENANT_NETWORK_HEALTH_UNSPECIFIED")]
        TENANT_NETWORK_HEALTH_UNSPECIFIED


    } // enum TenantNetworkHealth

} // namespace Rubrik.SecurityCloud.Types