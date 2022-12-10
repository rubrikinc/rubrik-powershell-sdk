// TenantAuthDomainConfig.cs
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
    public enum TenantAuthDomainConfig
    {
        [EnumMember(Value = "ALLOW_AUTH_DOMAIN_CONTROL")]
        ALLOW_AUTH_DOMAIN_CONTROL,

        [EnumMember(Value = "AUTH_DOMAIN_UNSPECIFIED")]
        AUTH_DOMAIN_UNSPECIFIED,

        [EnumMember(Value = "INHERIT_AUTH_DOMAIN")]
        INHERIT_AUTH_DOMAIN,

        [EnumMember(Value = "LOCAL_AUTH_DOMAIN_ONLY")]
        LOCAL_AUTH_DOMAIN_ONLY


    } // enum TenantAuthDomainConfig

} // namespace Rubrik.SecurityCloud.Types