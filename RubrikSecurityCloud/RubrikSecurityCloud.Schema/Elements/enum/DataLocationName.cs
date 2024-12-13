// DataLocationName.cs
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
    public enum DataLocationName
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE")]
        AZURE,

        [EnumMember(Value = "CLEVERSAFE")]
        CLEVERSAFE,

        [EnumMember(Value = "CLOUD_NATIVE_AWS")]
        CLOUD_NATIVE_AWS,

        [EnumMember(Value = "CLOUD_NATIVE_GCP")]
        CLOUD_NATIVE_GCP,

        [EnumMember(Value = "DELLECS")]
        DELLECS,

        [EnumMember(Value = "GLACIER")]
        GLACIER,

        [EnumMember(Value = "GOOGLE")]
        GOOGLE,

        [EnumMember(Value = "HDS")]
        HDS,

        [EnumMember(Value = "IBMCOS")]
        IBMCOS,

        [EnumMember(Value = "LOCAL")]
        LOCAL,

        [EnumMember(Value = "NETAPPSG")]
        NETAPPSG,

        [EnumMember(Value = "NFS")]
        NFS,

        [EnumMember(Value = "QSTAR")]
        QSTAR,

        [EnumMember(Value = "REHYDRATED")]
        REHYDRATED,

        [EnumMember(Value = "REPLICATION_OFF")]
        REPLICATION_OFF,

        [EnumMember(Value = "REPLICATION_POLARIS_SOURCE")]
        REPLICATION_POLARIS_SOURCE,

        [EnumMember(Value = "REPLICATION_SOURCE")]
        REPLICATION_SOURCE,

        [EnumMember(Value = "REPLICATION_SOURCE_AND_TARGET")]
        REPLICATION_SOURCE_AND_TARGET,

        [EnumMember(Value = "REPLICATION_TARGET")]
        REPLICATION_TARGET,

        [EnumMember(Value = "S3")]
        S3,

        [EnumMember(Value = "S3_COMPATIBLE")]
        S3_COMPATIBLE,

        [EnumMember(Value = "SCALITY")]
        SCALITY


    } // enum DataLocationName

} // namespace RubrikSecurityCloud.Types