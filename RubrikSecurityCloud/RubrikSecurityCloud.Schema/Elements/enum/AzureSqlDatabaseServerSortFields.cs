// AzureSqlDatabaseServerSortFields.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:15.
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
    public enum AzureSqlDatabaseServerSortFields
    {
        [EnumMember(Value = "AZURE_SQL_DATABASE_SERVER_REGION")]
        AZURE_SQL_DATABASE_SERVER_REGION,

        [EnumMember(Value = "AZURE_SQL_SERVER_RESOURCE_GROUP")]
        AZURE_SQL_SERVER_RESOURCE_GROUP,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum AzureSqlDatabaseServerSortFields

} // namespace Rubrik.SecurityCloud.Types