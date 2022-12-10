// ReplicationType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:12.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum ReplicationType
    {
        [EnumMember(Value = "REPLICATION_TO_CLOUD_LOCATION")]
        REPLICATION_TO_CLOUD_LOCATION,

        [EnumMember(Value = "REPLICATION_TO_CLOUD_REGION")]
        REPLICATION_TO_CLOUD_REGION,

        [EnumMember(Value = "UNIDIRECTIONAL_REPLICATION_TO_CLUSTER")]
        UNIDIRECTIONAL_REPLICATION_TO_CLUSTER,

        [EnumMember(Value = "UNKNOWN_REPLICATION_TYPE")]
        UNKNOWN_REPLICATION_TYPE


    } // enum ReplicationType

} // namespace Rubrik.SecurityCloud.Types