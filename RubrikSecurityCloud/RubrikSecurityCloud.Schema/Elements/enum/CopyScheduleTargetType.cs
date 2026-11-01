// CopyScheduleTargetType.cs
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
    public enum CopyScheduleTargetType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "COPY_SCHEDULE_TARGET_TYPE_CLOUD")]
        COPY_SCHEDULE_TARGET_TYPE_CLOUD,

        [EnumMember(Value = "COPY_SCHEDULE_TARGET_TYPE_NAS_SHARE")]
        COPY_SCHEDULE_TARGET_TYPE_NAS_SHARE,

        [EnumMember(Value = "COPY_SCHEDULE_TARGET_TYPE_UNSPECIFIED")]
        COPY_SCHEDULE_TARGET_TYPE_UNSPECIFIED


    } // enum CopyScheduleTargetType

} // namespace RubrikSecurityCloud.Types