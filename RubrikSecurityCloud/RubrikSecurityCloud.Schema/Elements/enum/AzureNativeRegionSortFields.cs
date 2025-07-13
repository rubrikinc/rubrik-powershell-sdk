// AzureNativeRegionSortFields.cs
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
    public enum AzureNativeRegionSortFields
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ASSIGNED_SLA_DOMAIN")]
        ASSIGNED_SLA_DOMAIN,

        [EnumMember(Value = "AZURE_REGION_DISKCOUNT")]
        AZURE_REGION_DISKCOUNT,

        [EnumMember(Value = "AZURE_REGION_SQL_DATABASE_DB_COUNT")]
        AZURE_REGION_SQL_DATABASE_DB_COUNT,

        [EnumMember(Value = "AZURE_REGION_SQL_MANAGED_INSTANCE_DB_COUNT")]
        AZURE_REGION_SQL_MANAGED_INSTANCE_DB_COUNT,

        [EnumMember(Value = "AZURE_REGION_STORAGE_ACCOUNT_COUNT")]
        AZURE_REGION_STORAGE_ACCOUNT_COUNT,

        [EnumMember(Value = "AZURE_REGION_VMCOUNT")]
        AZURE_REGION_VMCOUNT,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum AzureNativeRegionSortFields

} // namespace RubrikSecurityCloud.Types