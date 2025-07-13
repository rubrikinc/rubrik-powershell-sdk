// ExoHealthCheckStatus.cs
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
    public enum ExoHealthCheckStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "PASSED")]
        PASSED,

        [EnumMember(Value = "SKIPPED")]
        SKIPPED,

        [EnumMember(Value = "STATUS_UNKNOWN")]
        STATUS_UNKNOWN


    } // enum ExoHealthCheckStatus

} // namespace RubrikSecurityCloud.Types