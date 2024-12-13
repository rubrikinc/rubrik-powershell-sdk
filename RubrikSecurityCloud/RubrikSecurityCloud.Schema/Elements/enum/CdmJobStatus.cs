// CdmJobStatus.cs
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
    public enum CdmJobStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "JOB_ACQUIRING")]
        JOB_ACQUIRING,

        [EnumMember(Value = "JOB_CANCELED")]
        JOB_CANCELED,

        [EnumMember(Value = "JOB_CANCELING")]
        JOB_CANCELING,

        [EnumMember(Value = "JOB_FAILED")]
        JOB_FAILED,

        [EnumMember(Value = "JOB_FINISHING")]
        JOB_FINISHING,

        [EnumMember(Value = "JOB_NOTFOUND")]
        JOB_NOTFOUND,

        [EnumMember(Value = "JOB_PENDING")]
        JOB_PENDING,

        [EnumMember(Value = "JOB_QUEUED")]
        JOB_QUEUED,

        [EnumMember(Value = "JOB_RUNNING")]
        JOB_RUNNING,

        [EnumMember(Value = "JOB_SUCCEEDED")]
        JOB_SUCCEEDED,

        [EnumMember(Value = "JOB_UNDOING")]
        JOB_UNDOING


    } // enum CdmJobStatus

} // namespace RubrikSecurityCloud.Types