// ClusterKeyRotationState.cs
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
    public enum ClusterKeyRotationState
    {
        [EnumMember(Value = "CDM_ABORTED")]
        CDM_ABORTED,

        [EnumMember(Value = "CDM_DONE")]
        CDM_DONE,

        [EnumMember(Value = "CDM_FAILED")]
        CDM_FAILED,

        [EnumMember(Value = "CDM_IN_PROGRESS")]
        CDM_IN_PROGRESS,

        [EnumMember(Value = "CLUSTER_ROTATION_STATE_UNSPECIFIED")]
        CLUSTER_ROTATION_STATE_UNSPECIFIED,

        [EnumMember(Value = "PENDING_ON_CDM")]
        PENDING_ON_CDM


    } // enum ClusterKeyRotationState

} // namespace RubrikSecurityCloud.Types