// ReplicationSetupType.cs
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
    public enum ReplicationSetupType
    {
        [EnumMember(Value = "NAT")]
        NAT,

        [EnumMember(Value = "PRIVATE")]
        PRIVATE,

        [EnumMember(Value = "REPLICATION_SETUP_TYPE_UNSPECIFIED")]
        REPLICATION_SETUP_TYPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ReplicationSetupType

} // namespace RubrikSecurityCloud.Types