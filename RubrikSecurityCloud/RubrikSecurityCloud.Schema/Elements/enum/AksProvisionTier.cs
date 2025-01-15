// AksProvisionTier.cs
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
    public enum AksProvisionTier
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AKS_CLUSTER_TIER_FREE")]
        AKS_CLUSTER_TIER_FREE,

        [EnumMember(Value = "AKS_CLUSTER_TIER_STANDARD")]
        AKS_CLUSTER_TIER_STANDARD,

        [EnumMember(Value = "AKS_CLUSTER_TIER_UNSPECIFIED")]
        AKS_CLUSTER_TIER_UNSPECIFIED


    } // enum AksProvisionTier

} // namespace RubrikSecurityCloud.Types