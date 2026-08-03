// ViolationHistoryEventType.cs
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
    public enum ViolationHistoryEventType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "HISTORY_EVENT_CREATED")]
        HISTORY_EVENT_CREATED,

        [EnumMember(Value = "HISTORY_EVENT_REMEDIATION_CLOSED")]
        HISTORY_EVENT_REMEDIATION_CLOSED,

        [EnumMember(Value = "HISTORY_EVENT_REMEDIATION_COMPLETED")]
        HISTORY_EVENT_REMEDIATION_COMPLETED,

        [EnumMember(Value = "HISTORY_EVENT_REMEDIATION_FAILED")]
        HISTORY_EVENT_REMEDIATION_FAILED,

        [EnumMember(Value = "HISTORY_EVENT_REMEDIATION_TRIGGERED")]
        HISTORY_EVENT_REMEDIATION_TRIGGERED,

        [EnumMember(Value = "HISTORY_EVENT_STATUS_CHANGED")]
        HISTORY_EVENT_STATUS_CHANGED,

        [EnumMember(Value = "HISTORY_EVENT_UNSPECIFIED")]
        HISTORY_EVENT_UNSPECIFIED


    } // enum ViolationHistoryEventType

} // namespace RubrikSecurityCloud.Types