// FailoverSortByEnum.cs
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
    public enum FailoverSortByEnum
    {
        [EnumMember(Value = "AppBlueprintName")]
        APP_BLUEPRINT_NAME,

        [EnumMember(Value = "SourceSiteName")]
        SOURCE_SITE_NAME,

        [EnumMember(Value = "StartTime")]
        START_TIME,

        [EnumMember(Value = "TargetSiteName")]
        TARGET_SITE_NAME


    } // enum FailoverSortByEnum

} // namespace Rubrik.SecurityCloud.Types