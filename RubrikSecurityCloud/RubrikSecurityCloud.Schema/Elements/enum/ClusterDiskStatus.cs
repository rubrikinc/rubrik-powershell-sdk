// ClusterDiskStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:04.
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
    public enum ClusterDiskStatus
    {
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "LOCKED")]
        LOCKED,

        [EnumMember(Value = "MISSING")]
        MISSING,

        [EnumMember(Value = "PRE_REMOVAL")]
        PRE_REMOVAL,

        [EnumMember(Value = "PRE_REPAIR")]
        PRE_REPAIR,

        [EnumMember(Value = "READY_TO_REMOVE")]
        READY_TO_REMOVE,

        [EnumMember(Value = "REMOVED")]
        REMOVED,

        [EnumMember(Value = "REPAIR")]
        REPAIR,

        [EnumMember(Value = "UNFORMATTED")]
        UNFORMATTED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ClusterDiskStatus

} // namespace Rubrik.SecurityCloud.Types