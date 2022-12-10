// CdpLocalStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:07.
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
    public enum CdpLocalStatus
    {
        [EnumMember(Value = "CDP_LOCAL_STATUS_ACTIVE")]
        CDP_LOCAL_STATUS_ACTIVE,

        [EnumMember(Value = "CDP_LOCAL_STATUS_FAILED")]
        CDP_LOCAL_STATUS_FAILED,

        [EnumMember(Value = "CDP_LOCAL_STATUS_NOT_ENABLED")]
        CDP_LOCAL_STATUS_NOT_ENABLED,

        [EnumMember(Value = "CDP_LOCAL_STATUS_PENDING")]
        CDP_LOCAL_STATUS_PENDING,

        [EnumMember(Value = "CDP_LOCAL_STATUS_RESYNCING")]
        CDP_LOCAL_STATUS_RESYNCING,

        [EnumMember(Value = "CDP_LOCAL_STATUS_TAKING_SNAPSHOT")]
        CDP_LOCAL_STATUS_TAKING_SNAPSHOT


    } // enum CdpLocalStatus

} // namespace Rubrik.SecurityCloud.Types