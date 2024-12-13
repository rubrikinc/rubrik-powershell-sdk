// AzureSqlManagedInstanceDatabaseSortFields.cs
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
    public enum AzureSqlManagedInstanceDatabaseSortFields
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_SQL_DB_RESOURCE_GROUP")]
        AZURE_SQL_DB_RESOURCE_GROUP,

        [EnumMember(Value = "AZURE_SQL_MANAGED_INSTANCE_DB_REGION")]
        AZURE_SQL_MANAGED_INSTANCE_DB_REGION,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "SENSITIVITY_HITS")]
        SENSITIVITY_HITS,

        [EnumMember(Value = "SENSITIVITY_STATUS")]
        SENSITIVITY_STATUS


    } // enum AzureSqlManagedInstanceDatabaseSortFields

} // namespace RubrikSecurityCloud.Types