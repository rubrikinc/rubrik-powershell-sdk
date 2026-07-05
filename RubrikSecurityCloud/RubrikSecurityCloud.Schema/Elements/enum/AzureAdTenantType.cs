// AzureAdTenantType.cs
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
    public enum AzureAdTenantType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "COMMERCIAL")]
        COMMERCIAL,

        [EnumMember(Value = "GCC")]
        GCC,

        [EnumMember(Value = "GCC_HIGH")]
        GCC_HIGH,

        [EnumMember(Value = "TENANT_TYPE_UNSPECIFIED")]
        TENANT_TYPE_UNSPECIFIED


    } // enum AzureAdTenantType

} // namespace RubrikSecurityCloud.Types