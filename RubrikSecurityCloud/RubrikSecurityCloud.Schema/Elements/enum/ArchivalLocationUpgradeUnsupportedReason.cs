// ArchivalLocationUpgradeUnsupportedReason.cs
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
    public enum ArchivalLocationUpgradeUnsupportedReason
    {
        [EnumMember(Value = "CLUSTER_CONTAINS_GOV_CLOUD_LOCATION")]
        CLUSTER_CONTAINS_GOV_CLOUD_LOCATION,

        [EnumMember(Value = "CLUSTER_VERSION_NOT_SUPPORTED")]
        CLUSTER_VERSION_NOT_SUPPORTED,

        [EnumMember(Value = "NOT_APPLICABLE")]
        NOT_APPLICABLE,

        [EnumMember(Value = "RSC_MANAGED_LOCATION")]
        RSC_MANAGED_LOCATION,

        [EnumMember(Value = "UNKNOWN_REASON")]
        UNKNOWN_REASON


    } // enum ArchivalLocationUpgradeUnsupportedReason

} // namespace RubrikSecurityCloud.Types