// KosmosTopologyReplicaStatus.cs
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
    public enum KosmosTopologyReplicaStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "PENDING_DISCOVERY")]
        PENDING_DISCOVERY,

        [EnumMember(Value = "PENDING_REMOVAL")]
        PENDING_REMOVAL,

        [EnumMember(Value = "REMOVED")]
        REMOVED,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        [EnumMember(Value = "VALIDATION_FAILED")]
        VALIDATION_FAILED


    } // enum KosmosTopologyReplicaStatus

} // namespace RubrikSecurityCloud.Types