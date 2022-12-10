// GcpNativeProjectSortFields.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:34.
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
    public enum GcpNativeProjectSortFields
    {
        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "GCP_PROJECT_DISK_COUNT")]
        GCP_PROJECT_DISK_COUNT,

        [EnumMember(Value = "GCP_PROJECT_INSTANCE_COUNT")]
        GCP_PROJECT_INSTANCE_COUNT,

        [EnumMember(Value = "GCP_PROJECT_NATIVE_ID")]
        GCP_PROJECT_NATIVE_ID,

        [EnumMember(Value = "GCP_PROJECT_NUMBER")]
        GCP_PROJECT_NUMBER,

        [EnumMember(Value = "GCP_PROJECT_ORG_NAME")]
        GCP_PROJECT_ORG_NAME,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum GcpNativeProjectSortFields

} // namespace Rubrik.SecurityCloud.Types