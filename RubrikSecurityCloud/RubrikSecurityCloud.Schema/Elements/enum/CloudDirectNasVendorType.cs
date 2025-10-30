// CloudDirectNasVendorType.cs
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
    public enum CloudDirectNasVendorType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_FILES")]
        AZURE_FILES,

        [EnumMember(Value = "AZURE_NETAPP")]
        AZURE_NETAPP,

        [EnumMember(Value = "FLASHBLADE")]
        FLASHBLADE,

        [EnumMember(Value = "FSXN")]
        FSXN,

        [EnumMember(Value = "GENERIC")]
        GENERIC,

        [EnumMember(Value = "GENERIC_NFS")]
        GENERIC_NFS,

        [EnumMember(Value = "GENERIC_NFS4")]
        GENERIC_NFS4,

        [EnumMember(Value = "GENERIC_S3")]
        GENERIC_S3,

        [EnumMember(Value = "GENERIC_SMB")]
        GENERIC_SMB,

        [EnumMember(Value = "GPFS")]
        GPFS,

        [EnumMember(Value = "ISILON")]
        ISILON,

        [EnumMember(Value = "NETAPP")]
        NETAPP,

        [EnumMember(Value = "NETAPP_7_MODE")]
        NETAPP_7_MODE,

        [EnumMember(Value = "NETAPP_CLUSTER_MODE")]
        NETAPP_CLUSTER_MODE,

        [EnumMember(Value = "NUTANIX")]
        NUTANIX,

        [EnumMember(Value = "NUTANIX_FILESERVER")]
        NUTANIX_FILESERVER,

        [EnumMember(Value = "QUMULO")]
        QUMULO,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        [EnumMember(Value = "VAST_DATA")]
        VAST_DATA


    } // enum CloudDirectNasVendorType

} // namespace RubrikSecurityCloud.Types