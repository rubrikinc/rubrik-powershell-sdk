// WorkloadRecoveryStatusV2.cs
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
    public enum WorkloadRecoveryStatusV2
    {
        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "QUEUED")]
        QUEUED,

        [EnumMember(Value = "RUNNING")]
        RUNNING,

        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum WorkloadRecoveryStatusV2

} // namespace RubrikSecurityCloud.Types