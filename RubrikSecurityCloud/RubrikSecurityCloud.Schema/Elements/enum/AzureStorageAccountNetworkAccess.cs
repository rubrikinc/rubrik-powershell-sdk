// AzureStorageAccountNetworkAccess.cs
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
    public enum AzureStorageAccountNetworkAccess
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PRIVATE")]
        PRIVATE,

        [EnumMember(Value = "PUBLIC")]
        PUBLIC,

        [EnumMember(Value = "SELECTED_NETWORKS")]
        SELECTED_NETWORKS,

        [EnumMember(Value = "UNKNOWN_NETWORK_ACCESS")]
        UNKNOWN_NETWORK_ACCESS


    } // enum AzureStorageAccountNetworkAccess

} // namespace RubrikSecurityCloud.Types