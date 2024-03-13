// ExocomputeHealthCheckStatusValue.cs
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
    public enum ExocomputeHealthCheckStatusValue
    {
        [EnumMember(Value = "CUSTOMER_MANAGED_CLUSTER_NOT_REGISTERED")]
        CUSTOMER_MANAGED_CLUSTER_NOT_REGISTERED,

        [EnumMember(Value = "HEALTHY")]
        HEALTHY,

        [EnumMember(Value = "JOB_UNSUCCESSFUL")]
        JOB_UNSUCCESSFUL,

        [EnumMember(Value = "UNHEALTHY")]
        UNHEALTHY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "VERIFYING")]
        VERIFYING


    } // enum ExocomputeHealthCheckStatusValue

} // namespace RubrikSecurityCloud.Types