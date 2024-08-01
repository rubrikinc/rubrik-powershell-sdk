// AzureNativeSubscriptionSortFields.cs
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
    public enum AzureNativeSubscriptionSortFields
    {
        [EnumMember(Value = "ASSIGNED_SLA_DOMAIN")]
        ASSIGNED_SLA_DOMAIN,

        [EnumMember(Value = "AZURE_SUBSCRIPTION_DISKCOUNT")]
        AZURE_SUBSCRIPTION_DISKCOUNT,

        [EnumMember(Value = "AZURE_SUBSCRIPTION_VMCOUNT")]
        AZURE_SUBSCRIPTION_VMCOUNT,

        [EnumMember(Value = "AZURE_TENANT_ID")]
        AZURE_TENANT_ID,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AzureNativeSubscriptionSortFields

} // namespace RubrikSecurityCloud.Types