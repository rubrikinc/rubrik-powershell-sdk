// AksOutboundType.cs
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
    public enum AksOutboundType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AKS_OUTBOUND_TYPE_LOAD_BALANCER")]
        AKS_OUTBOUND_TYPE_LOAD_BALANCER,

        [EnumMember(Value = "AKS_OUTBOUND_TYPE_UNSPECIFIED")]
        AKS_OUTBOUND_TYPE_UNSPECIFIED,

        [EnumMember(Value = "AKS_OUTBOUND_TYPE_USER_ASSIGNED_NAT_GATEWAY")]
        AKS_OUTBOUND_TYPE_USER_ASSIGNED_NAT_GATEWAY,

        [EnumMember(Value = "AKS_OUTBOUND_TYPE_USER_DEFINED_ROUTING")]
        AKS_OUTBOUND_TYPE_USER_DEFINED_ROUTING


    } // enum AksOutboundType

} // namespace RubrikSecurityCloud.Types