// PendingActionGroupTypeEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:58.
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
    public enum PendingActionGroupTypeEnum
    {
        [EnumMember(Value = "APP_FLOW")]
        APP_FLOW,

        [EnumMember(Value = "ARCHIVAL_LOCATION")]
        ARCHIVAL_LOCATION,

        [EnumMember(Value = "CLOUD_ACCOUNTS")]
        CLOUD_ACCOUNTS,

        [EnumMember(Value = "GLOBAL_SLA")]
        GLOBAL_SLA,

        [EnumMember(Value = "REPLICATION")]
        REPLICATION,

        [EnumMember(Value = "SECURITY_SETTING")]
        SECURITY_SETTING,

        [EnumMember(Value = "SERVICE_ACCOUNT")]
        SERVICE_ACCOUNT,

        [EnumMember(Value = "UNMANAGED_OBJECTS")]
        UNMANAGED_OBJECTS


    } // enum PendingActionGroupTypeEnum

} // namespace Rubrik.SecurityCloud.Types