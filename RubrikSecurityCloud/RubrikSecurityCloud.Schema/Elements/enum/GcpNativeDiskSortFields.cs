// GcpNativeDiskSortFields.cs
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
    public enum GcpNativeDiskSortFields
    {
        [EnumMember(Value = "ASSIGNED_SLA_DOMAIN")]
        ASSIGNED_SLA_DOMAIN,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "GCP_DISK_LOCATION")]
        GCP_DISK_LOCATION,

        [EnumMember(Value = "GCP_DISK_NATIVE_ID")]
        GCP_DISK_NATIVE_ID,

        [EnumMember(Value = "GCP_DISK_NATIVE_NAME")]
        GCP_DISK_NATIVE_NAME,

        [EnumMember(Value = "GCP_DISK_PROJECT_NAME")]
        GCP_DISK_PROJECT_NAME,

        [EnumMember(Value = "GCP_DISK_SIZE")]
        GCP_DISK_SIZE


    } // enum GcpNativeDiskSortFields

} // namespace Rubrik.SecurityCloud.Types