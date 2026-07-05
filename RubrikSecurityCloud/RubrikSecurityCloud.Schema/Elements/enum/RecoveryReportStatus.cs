// RecoveryReportStatus.cs
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
    public enum RecoveryReportStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        [EnumMember(Value = "EXPIRED")]
        EXPIRED,

        [EnumMember(Value = "GENERATING")]
        GENERATING,

        [EnumMember(Value = "GENERATION_FAILED")]
        GENERATION_FAILED,

        [EnumMember(Value = "UNKNOWN_REPORT_STATUS")]
        UNKNOWN_REPORT_STATUS


    } // enum RecoveryReportStatus

} // namespace RubrikSecurityCloud.Types