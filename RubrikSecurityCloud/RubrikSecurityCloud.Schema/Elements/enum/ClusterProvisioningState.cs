// ClusterProvisioningState.cs
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
    public enum ClusterProvisioningState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PROVISIONING_STATE_CREATING")]
        PROVISIONING_STATE_CREATING,

        [EnumMember(Value = "PROVISIONING_STATE_DELETED")]
        PROVISIONING_STATE_DELETED,

        [EnumMember(Value = "PROVISIONING_STATE_DELETING")]
        PROVISIONING_STATE_DELETING,

        [EnumMember(Value = "PROVISIONING_STATE_FAILED")]
        PROVISIONING_STATE_FAILED,

        [EnumMember(Value = "PROVISIONING_STATE_SUCCEEDED")]
        PROVISIONING_STATE_SUCCEEDED,

        [EnumMember(Value = "PROVISIONING_STATE_UNHEALTHY")]
        PROVISIONING_STATE_UNHEALTHY,

        [EnumMember(Value = "PROVISIONING_STATE_UNSPECIFIED")]
        PROVISIONING_STATE_UNSPECIFIED,

        [EnumMember(Value = "PROVISIONING_STATE_UPDATING")]
        PROVISIONING_STATE_UPDATING


    } // enum ClusterProvisioningState

} // namespace RubrikSecurityCloud.Types