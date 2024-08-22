// TenantAuthDomainConfig.cs
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
    public enum TenantAuthDomainConfig
    {
        [EnumMember(Value = "ALLOW_AUTH_DOMAIN_CONTROL")]
        ALLOW_AUTH_DOMAIN_CONTROL,

        [EnumMember(Value = "AUTH_DOMAIN_UNSPECIFIED")]
        AUTH_DOMAIN_UNSPECIFIED,

        [EnumMember(Value = "INHERIT_AUTH_DOMAIN")]
        INHERIT_AUTH_DOMAIN,

        [EnumMember(Value = "LOCAL_AUTH_DOMAIN_ONLY")]
        LOCAL_AUTH_DOMAIN_ONLY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TenantAuthDomainConfig

} // namespace RubrikSecurityCloud.Types