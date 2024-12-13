// AzureNativeCommonResourceGroupSortFields.cs
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
    public enum AzureNativeCommonResourceGroupSortFields
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_REGION")]
        AZURE_REGION,

        [EnumMember(Value = "AZURE_RG_DISK_EFFECTIVE_SLA")]
        AZURE_RG_DISK_EFFECTIVE_SLA,

        [EnumMember(Value = "AZURE_RG_SQL_DATABASE_DB_EFFECTIVE_SLA")]
        AZURE_RG_SQL_DATABASE_DB_EFFECTIVE_SLA,

        [EnumMember(Value = "AZURE_RG_SQL_MANAGED_INSTANCE_DB_EFFECTIVE_SLA")]
        AZURE_RG_SQL_MANAGED_INSTANCE_DB_EFFECTIVE_SLA,

        [EnumMember(Value = "AZURE_RG_SUBSCRIPTION_NAME")]
        AZURE_RG_SUBSCRIPTION_NAME,

        [EnumMember(Value = "AZURE_RG_VM_EFFECTIVE_SLA")]
        AZURE_RG_VM_EFFECTIVE_SLA,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum AzureNativeCommonResourceGroupSortFields

} // namespace RubrikSecurityCloud.Types