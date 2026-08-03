// ClusterUnsupportedWorkloadState.cs
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
    public enum ClusterUnsupportedWorkloadState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ALL_UNSUPPORTED_WORKLOADS_PAUSED")]
        ALL_UNSUPPORTED_WORKLOADS_PAUSED,

        [EnumMember(Value = "ALL_WORKLOADS_RU_SUPPORTED")]
        ALL_WORKLOADS_RU_SUPPORTED,

        [EnumMember(Value = "AUTO_PAUSE")]
        AUTO_PAUSE,

        [EnumMember(Value = "CLUSTER_UNSUPPORTED_WORKLOAD_STATE_UNSPECIFIED")]
        CLUSTER_UNSUPPORTED_WORKLOAD_STATE_UNSPECIFIED,

        [EnumMember(Value = "MANUAL_PAUSE")]
        MANUAL_PAUSE


    } // enum ClusterUnsupportedWorkloadState

} // namespace RubrikSecurityCloud.Types