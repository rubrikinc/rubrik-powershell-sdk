// DiagnosticTaskStatus.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum DiagnosticTaskStatus
    {
        [EnumMember(Value = "DIAGNOSTIC_TASK_STATUS_CANCELED")]
        DIAGNOSTIC_TASK_STATUS_CANCELED,

        [EnumMember(Value = "DIAGNOSTIC_TASK_STATUS_FAILED")]
        DIAGNOSTIC_TASK_STATUS_FAILED,

        [EnumMember(Value = "DIAGNOSTIC_TASK_STATUS_QUEUED")]
        DIAGNOSTIC_TASK_STATUS_QUEUED,

        [EnumMember(Value = "DIAGNOSTIC_TASK_STATUS_RETRIED")]
        DIAGNOSTIC_TASK_STATUS_RETRIED,

        [EnumMember(Value = "DIAGNOSTIC_TASK_STATUS_STARTED")]
        DIAGNOSTIC_TASK_STATUS_STARTED,

        [EnumMember(Value = "DIAGNOSTIC_TASK_STATUS_SUCCEEDED")]
        DIAGNOSTIC_TASK_STATUS_SUCCEEDED


    } // enum DiagnosticTaskStatus

} // namespace Rubrik.SecurityCloud.Types