// ActivityStatusEnum.cs
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
    public enum ActivityStatusEnum
    {
        [EnumMember(Value = "Canceled")]
        CANCELED,

        [EnumMember(Value = "Canceling")]
        CANCELING,

        [EnumMember(Value = "Failure")]
        FAILURE,

        [EnumMember(Value = "Info")]
        INFO,

        [EnumMember(Value = "PARTIAL_SUCCESS")]
        PARTIAL_SUCCESS,

        [EnumMember(Value = "Queued")]
        QUEUED,

        [EnumMember(Value = "Running")]
        RUNNING,

        [EnumMember(Value = "Success")]
        SUCCESS,

        [EnumMember(Value = "TaskFailure")]
        TASK_FAILURE,

        [EnumMember(Value = "TaskSuccess")]
        TASK_SUCCESS,

        [EnumMember(Value = "Warning")]
        WARNING


    } // enum ActivityStatusEnum

} // namespace RubrikSecurityCloud.Types