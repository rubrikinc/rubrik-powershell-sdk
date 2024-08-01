// ClusterMigrationModes.cs
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
    public enum ClusterMigrationModes
    {
        [EnumMember(Value = "ClusterHybridMode")]
        CLUSTER_HYBRID_MODE,

        [EnumMember(Value = "NotSpecified")]
        NOT_SPECIFIED,

        [EnumMember(Value = "SlaBlockMode")]
        SLA_BLOCK_MODE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ClusterMigrationModes

} // namespace RubrikSecurityCloud.Types