// AzureCosmosNosqlNetworkAccessMode.cs
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
    public enum AzureCosmosNosqlNetworkAccessMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_DISABLED")]
        AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_DISABLED,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_PRIVATE_ENDPOINT_ONLY")]
        AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_PRIVATE_ENDPOINT_ONLY,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_PUBLIC_IP_RESTRICTED")]
        AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_PUBLIC_IP_RESTRICTED,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_PUBLIC_OPEN")]
        AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_PUBLIC_OPEN,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_UNSPECIFIED")]
        AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_UNSPECIFIED,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_VNET_RESTRICTED")]
        AZURE_COSMOS_NOSQL_NETWORK_ACCESS_MODE_VNET_RESTRICTED


    } // enum AzureCosmosNosqlNetworkAccessMode

} // namespace RubrikSecurityCloud.Types