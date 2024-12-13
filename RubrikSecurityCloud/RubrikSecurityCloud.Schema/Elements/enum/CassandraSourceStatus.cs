// CassandraSourceStatus.cs
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
    public enum CassandraSourceStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ADDING")]
        ADDING,

        [EnumMember(Value = "CONNECTED")]
        CONNECTED,

        [EnumMember(Value = "DELETED")]
        DELETED,

        [EnumMember(Value = "DELETING")]
        DELETING,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "REFRESHING")]
        REFRESHING,

        [EnumMember(Value = "UNKNOWN_SYSTEM_STATUS")]
        UNKNOWN_SYSTEM_STATUS


    } // enum CassandraSourceStatus

} // namespace RubrikSecurityCloud.Types