// GcpNativeGceInstanceSortFields.cs
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
    public enum GcpNativeGceInstanceSortFields
    {
        [EnumMember(Value = "ASSIGNED_SLA_DOMAIN")]
        ASSIGNED_SLA_DOMAIN,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "GCP_INSTANCE_NATIVE_ID")]
        GCP_INSTANCE_NATIVE_ID,

        [EnumMember(Value = "GCP_INSTANCE_NATIVE_NAME")]
        GCP_INSTANCE_NATIVE_NAME,

        [EnumMember(Value = "GCP_INSTANCE_NETWORK_NAME")]
        GCP_INSTANCE_NETWORK_NAME,

        [EnumMember(Value = "GCP_INSTANCE_PROJECT_NAME")]
        GCP_INSTANCE_PROJECT_NAME,

        [EnumMember(Value = "GCP_INSTANCE_REGION")]
        GCP_INSTANCE_REGION,

        [EnumMember(Value = "GCP_INSTANCE_TYPE")]
        GCP_INSTANCE_TYPE


    } // enum GcpNativeGceInstanceSortFields

} // namespace Rubrik.SecurityCloud.Types