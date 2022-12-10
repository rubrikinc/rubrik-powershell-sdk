// ConsistencyLevelEnum.cs
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
    public enum ConsistencyLevelEnum
    {
        [EnumMember(Value = "APP_CONSISTENT")]
        APP_CONSISTENT,

        [EnumMember(Value = "CRASH_CONSISTENT")]
        CRASH_CONSISTENT,

        [EnumMember(Value = "FILE_SYSTEM_CONSISTENT")]
        FILE_SYSTEM_CONSISTENT,

        [EnumMember(Value = "INCONSISTENT")]
        INCONSISTENT,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "VSS_CONSISTENT")]
        VSS_CONSISTENT


    } // enum ConsistencyLevelEnum

} // namespace Rubrik.SecurityCloud.Types