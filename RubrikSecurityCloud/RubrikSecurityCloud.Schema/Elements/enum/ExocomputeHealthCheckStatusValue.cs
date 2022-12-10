// ExocomputeHealthCheckStatusValue.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:25.
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
    public enum ExocomputeHealthCheckStatusValue
    {
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

} // namespace Rubrik.SecurityCloud.Types