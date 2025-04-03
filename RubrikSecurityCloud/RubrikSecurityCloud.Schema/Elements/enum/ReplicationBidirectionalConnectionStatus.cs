// ReplicationBidirectionalConnectionStatus.cs
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
    public enum ReplicationBidirectionalConnectionStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BIDIRECTIONAL_CONNECTED")]
        BIDIRECTIONAL_CONNECTED,

        [EnumMember(Value = "BIDIRECTIONAL_DISCONNECTED")]
        BIDIRECTIONAL_DISCONNECTED,

        [EnumMember(Value = "BIDIRECTIONAL_PARTIAL")]
        BIDIRECTIONAL_PARTIAL,

        [EnumMember(Value = "BIDIRECTIONAL_UNSPECIFIED")]
        BIDIRECTIONAL_UNSPECIFIED


    } // enum ReplicationBidirectionalConnectionStatus

} // namespace RubrikSecurityCloud.Types