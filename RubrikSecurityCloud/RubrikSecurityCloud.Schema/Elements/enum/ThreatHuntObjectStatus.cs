// ThreatHuntObjectStatus.cs
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
    public enum ThreatHuntObjectStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "OBJ_FAILED")]
        OBJ_FAILED,

        [EnumMember(Value = "OBJ_IN_PROGRESS")]
        OBJ_IN_PROGRESS,

        [EnumMember(Value = "OBJ_NOT_SCANNED")]
        OBJ_NOT_SCANNED,

        [EnumMember(Value = "OBJ_PARTIALLY_SUCCEEDED")]
        OBJ_PARTIALLY_SUCCEEDED,

        [EnumMember(Value = "OBJ_PENDING")]
        OBJ_PENDING,

        [EnumMember(Value = "OBJ_SUCCEEDED")]
        OBJ_SUCCEEDED,

        [EnumMember(Value = "OBJ_UNSPECIFIED")]
        OBJ_UNSPECIFIED


    } // enum ThreatHuntObjectStatus

} // namespace RubrikSecurityCloud.Types