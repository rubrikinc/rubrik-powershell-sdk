// EventStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:05.
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
    public enum EventStatus
    {
        [EnumMember(Value = "CANCELED")]
        CANCELED,

        [EnumMember(Value = "CANCELING")]
        CANCELING,

        [EnumMember(Value = "FAILURE")]
        FAILURE,

        [EnumMember(Value = "INFO")]
        INFO,

        [EnumMember(Value = "PARTIAL_SUCCESS")]
        PARTIAL_SUCCESS,

        [EnumMember(Value = "QUEUED")]
        QUEUED,

        [EnumMember(Value = "RUNNING")]
        RUNNING,

        [EnumMember(Value = "SUCCESS")]
        SUCCESS,

        [EnumMember(Value = "TASK_FAILURE")]
        TASK_FAILURE,

        [EnumMember(Value = "TASK_SUCCESS")]
        TASK_SUCCESS,

        [EnumMember(Value = "UNKNOWN_EVENT_STATUS")]
        UNKNOWN_EVENT_STATUS,

        [EnumMember(Value = "WARNING")]
        WARNING


    } // enum EventStatus

} // namespace Rubrik.SecurityCloud.Types