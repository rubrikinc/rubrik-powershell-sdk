// AirGatewayProvisioningState.cs
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
    public enum AirGatewayProvisioningState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "GATEWAY_PROVISIONING_STATE_ACTIVE")]
        GATEWAY_PROVISIONING_STATE_ACTIVE,

        [EnumMember(Value = "GATEWAY_PROVISIONING_STATE_DELETING")]
        GATEWAY_PROVISIONING_STATE_DELETING,

        [EnumMember(Value = "GATEWAY_PROVISIONING_STATE_FAILED")]
        GATEWAY_PROVISIONING_STATE_FAILED,

        [EnumMember(Value = "GATEWAY_PROVISIONING_STATE_NOT_DEPLOYED")]
        GATEWAY_PROVISIONING_STATE_NOT_DEPLOYED,

        [EnumMember(Value = "GATEWAY_PROVISIONING_STATE_PROVISIONING")]
        GATEWAY_PROVISIONING_STATE_PROVISIONING,

        [EnumMember(Value = "GATEWAY_PROVISIONING_STATE_UNSPECIFIED")]
        GATEWAY_PROVISIONING_STATE_UNSPECIFIED,

        [EnumMember(Value = "GATEWAY_PROVISIONING_STATE_UPDATE_FAILED")]
        GATEWAY_PROVISIONING_STATE_UPDATE_FAILED,

        [EnumMember(Value = "GATEWAY_PROVISIONING_STATE_UPDATING")]
        GATEWAY_PROVISIONING_STATE_UPDATING


    } // enum AirGatewayProvisioningState

} // namespace RubrikSecurityCloud.Types