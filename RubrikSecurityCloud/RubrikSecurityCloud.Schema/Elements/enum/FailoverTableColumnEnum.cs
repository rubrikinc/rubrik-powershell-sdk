// FailoverTableColumnEnum.cs
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
    public enum FailoverTableColumnEnum
    {
        [EnumMember(Value = "AppBlueprintName")]
        APP_BLUEPRINT_NAME,

        [EnumMember(Value = "Duration")]
        DURATION,

        [EnumMember(Value = "EndTime")]
        END_TIME,

        [EnumMember(Value = "FailoverStatus")]
        FAILOVER_STATUS,

        [EnumMember(Value = "FailoverType")]
        FAILOVER_TYPE,

        [EnumMember(Value = "LastTestStatus")]
        LAST_TEST_STATUS,

        [EnumMember(Value = "LastTestTime")]
        LAST_TEST_TIME,

        [EnumMember(Value = "Source")]
        SOURCE,

        [EnumMember(Value = "StartTime")]
        START_TIME,

        [EnumMember(Value = "TargetSite")]
        TARGET_SITE


    } // enum FailoverTableColumnEnum

} // namespace Rubrik.SecurityCloud.Types