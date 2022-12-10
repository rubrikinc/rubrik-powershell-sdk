// AzureSqlManagedInstanceServerSortFields.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:16.
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
    public enum AzureSqlManagedInstanceServerSortFields
    {
        [EnumMember(Value = "AZURE_SQL_MANAGED_INSTANCE_SERVER_REGION")]
        AZURE_SQL_MANAGED_INSTANCE_SERVER_REGION,

        [EnumMember(Value = "AZURE_SQL_SERVER_RESOURCE_GROUP")]
        AZURE_SQL_SERVER_RESOURCE_GROUP,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum AzureSqlManagedInstanceServerSortFields

} // namespace Rubrik.SecurityCloud.Types