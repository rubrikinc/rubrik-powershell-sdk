// SlaReplicationConfiguration.cs
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
    public enum SlaReplicationConfiguration
    {
        [EnumMember(Value = "MANY_TO_ONE")]
        MANY_TO_ONE,

        [EnumMember(Value = "ONE_TO_ONE")]
        ONE_TO_ONE,

        [EnumMember(Value = "REPLICATION_UNSPECIFIED")]
        REPLICATION_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SlaReplicationConfiguration

} // namespace RubrikSecurityCloud.Types