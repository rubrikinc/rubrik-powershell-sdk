// AzureNativeVirtualMachineSortFields.cs
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
    public enum AzureNativeVirtualMachineSortFields
    {
        [EnumMember(Value = "ASSIGNED_SLA_DOMAIN")]
        ASSIGNED_SLA_DOMAIN,

        [EnumMember(Value = "AZURE_REGION")]
        AZURE_REGION,

        [EnumMember(Value = "AZURE_SUBNET_NAME")]
        AZURE_SUBNET_NAME,

        [EnumMember(Value = "AZURE_VM_CRG_NAME")]
        AZURE_VM_CRG_NAME,

        [EnumMember(Value = "AZURE_VM_CRG_SUBSCRIPTION_NAME")]
        AZURE_VM_CRG_SUBSCRIPTION_NAME,

        [EnumMember(Value = "AZURE_VM_SIZE")]
        AZURE_VM_SIZE,

        [EnumMember(Value = "AZURE_VNET_NAME")]
        AZURE_VNET_NAME,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "SENSITIVITY_HITS")]
        SENSITIVITY_HITS,

        [EnumMember(Value = "SENSITIVITY_STATUS")]
        SENSITIVITY_STATUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AzureNativeVirtualMachineSortFields

} // namespace RubrikSecurityCloud.Types