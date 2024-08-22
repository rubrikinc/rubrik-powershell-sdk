// ReplicationTargetsType.cs
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
    public enum ReplicationTargetsType
    {
        [EnumMember(Value = "AIR_GAPPED")]
        AIR_GAPPED,

        [EnumMember(Value = "CROSS_ACCOUNT")]
        CROSS_ACCOUNT,

        [EnumMember(Value = "TARGET_TYPE_UNSPECIFIED")]
        TARGET_TYPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ReplicationTargetsType

} // namespace RubrikSecurityCloud.Types