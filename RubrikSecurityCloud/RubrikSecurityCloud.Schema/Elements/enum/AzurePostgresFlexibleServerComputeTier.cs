// AzurePostgresFlexibleServerComputeTier.cs
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
    public enum AzurePostgresFlexibleServerComputeTier
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_POSTGRES_FLEXIBLE_SERVER_COMPUTE_TIER_BURSTABLE")]
        AZURE_POSTGRES_FLEXIBLE_SERVER_COMPUTE_TIER_BURSTABLE,

        [EnumMember(Value = "AZURE_POSTGRES_FLEXIBLE_SERVER_COMPUTE_TIER_GENERAL_PURPOSE")]
        AZURE_POSTGRES_FLEXIBLE_SERVER_COMPUTE_TIER_GENERAL_PURPOSE,

        [EnumMember(Value = "AZURE_POSTGRES_FLEXIBLE_SERVER_COMPUTE_TIER_MEMORY_OPTIMIZED")]
        AZURE_POSTGRES_FLEXIBLE_SERVER_COMPUTE_TIER_MEMORY_OPTIMIZED,

        [EnumMember(Value = "AZURE_POSTGRES_FLEXIBLE_SERVER_COMPUTE_TIER_UNSPECIFIED")]
        AZURE_POSTGRES_FLEXIBLE_SERVER_COMPUTE_TIER_UNSPECIFIED


    } // enum AzurePostgresFlexibleServerComputeTier

} // namespace RubrikSecurityCloud.Types