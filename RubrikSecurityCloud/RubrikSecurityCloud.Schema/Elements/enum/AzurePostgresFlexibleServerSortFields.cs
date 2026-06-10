// AzurePostgresFlexibleServerSortFields.cs
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
    public enum AzurePostgresFlexibleServerSortFields
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_POSTGRES_FLEXIBLE_SERVER_REGION")]
        AZURE_POSTGRES_FLEXIBLE_SERVER_REGION,

        [EnumMember(Value = "AZURE_POSTGRES_FLEXIBLE_SERVER_RESOURCE_GROUP")]
        AZURE_POSTGRES_FLEXIBLE_SERVER_RESOURCE_GROUP,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum AzurePostgresFlexibleServerSortFields

} // namespace RubrikSecurityCloud.Types