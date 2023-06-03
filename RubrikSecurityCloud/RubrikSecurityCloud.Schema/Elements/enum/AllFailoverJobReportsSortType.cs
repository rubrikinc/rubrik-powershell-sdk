// AllFailoverJobReportsSortType.cs
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
    public enum AllFailoverJobReportsSortType
    {
        [EnumMember(Value = "OBJECT_COUNT")]
        OBJECT_COUNT,

        [EnumMember(Value = "RECOVERY_NAME")]
        RECOVERY_NAME,

        [EnumMember(Value = "RECOVERY_PLAN_NAME")]
        RECOVERY_PLAN_NAME,

        [EnumMember(Value = "START_TIME")]
        START_TIME,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AllFailoverJobReportsSortType

} // namespace Rubrik.SecurityCloud.Types