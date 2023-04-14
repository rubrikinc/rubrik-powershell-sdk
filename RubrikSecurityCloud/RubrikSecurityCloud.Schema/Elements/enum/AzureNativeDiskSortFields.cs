// AzureNativeDiskSortFields.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum AzureNativeDiskSortFields
    {
        [EnumMember(Value = "ASSIGNED_SLA_DOMAIN")]
        ASSIGNED_SLA_DOMAIN,

        [EnumMember(Value = "AZURE_DISK_CRG_NAME")]
        AZURE_DISK_CRG_NAME,

        [EnumMember(Value = "AZURE_DISK_CRG_SUBSCRIPTION_NAME")]
        AZURE_DISK_CRG_SUBSCRIPTION_NAME,

        [EnumMember(Value = "AZURE_DISK_SIZE")]
        AZURE_DISK_SIZE,

        [EnumMember(Value = "AZURE_DISK_TYPE")]
        AZURE_DISK_TYPE,

        [EnumMember(Value = "AZURE_REGION")]
        AZURE_REGION,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum AzureNativeDiskSortFields

} // namespace Rubrik.SecurityCloud.Types