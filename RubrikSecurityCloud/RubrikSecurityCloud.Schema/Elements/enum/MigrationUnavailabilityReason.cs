// MigrationUnavailabilityReason.cs
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
    public enum MigrationUnavailabilityReason
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLUSTER_DISCONNECTED")]
        CLUSTER_DISCONNECTED,

        [EnumMember(Value = "CLUSTER_REQUIRES_UPGRADE")]
        CLUSTER_REQUIRES_UPGRADE,

        [EnumMember(Value = "MIGRATION_UNAVAILABILITY_REASON_UNSPECIFIED")]
        MIGRATION_UNAVAILABILITY_REASON_UNSPECIFIED


    } // enum MigrationUnavailabilityReason

} // namespace RubrikSecurityCloud.Types