// AzureClusterStorageRedundancy.cs
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
    public enum AzureClusterStorageRedundancy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_CLUSTER_STORAGE_REDUNDANCY_GRS")]
        AZURE_CLUSTER_STORAGE_REDUNDANCY_GRS,

        [EnumMember(Value = "AZURE_CLUSTER_STORAGE_REDUNDANCY_GZRS")]
        AZURE_CLUSTER_STORAGE_REDUNDANCY_GZRS,

        [EnumMember(Value = "AZURE_CLUSTER_STORAGE_REDUNDANCY_LRS")]
        AZURE_CLUSTER_STORAGE_REDUNDANCY_LRS,

        [EnumMember(Value = "AZURE_CLUSTER_STORAGE_REDUNDANCY_RA_GRS")]
        AZURE_CLUSTER_STORAGE_REDUNDANCY_RA_GRS,

        [EnumMember(Value = "AZURE_CLUSTER_STORAGE_REDUNDANCY_RA_GZRS")]
        AZURE_CLUSTER_STORAGE_REDUNDANCY_RA_GZRS,

        [EnumMember(Value = "AZURE_CLUSTER_STORAGE_REDUNDANCY_UNKNOWN")]
        AZURE_CLUSTER_STORAGE_REDUNDANCY_UNKNOWN,

        [EnumMember(Value = "AZURE_CLUSTER_STORAGE_REDUNDANCY_ZRS")]
        AZURE_CLUSTER_STORAGE_REDUNDANCY_ZRS


    } // enum AzureClusterStorageRedundancy

} // namespace RubrikSecurityCloud.Types