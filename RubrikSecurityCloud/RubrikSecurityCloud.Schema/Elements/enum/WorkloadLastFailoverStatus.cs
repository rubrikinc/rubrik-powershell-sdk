// WorkloadLastFailoverStatus.cs
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
    public enum WorkloadLastFailoverStatus
    {
        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "FAILOVER_STATUS_UNSPECIFIED")]
        FAILOVER_STATUS_UNSPECIFIED,

        [EnumMember(Value = "RUNNING")]
        RUNNING,

        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED


    } // enum WorkloadLastFailoverStatus

} // namespace RubrikSecurityCloud.Types