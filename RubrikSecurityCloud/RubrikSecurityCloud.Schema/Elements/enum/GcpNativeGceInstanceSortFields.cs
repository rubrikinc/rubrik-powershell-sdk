// GcpNativeGceInstanceSortFields.cs
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
        GCP_INSTANCE_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum GcpNativeGceInstanceSortFields

} // namespace RubrikSecurityCloud.Types