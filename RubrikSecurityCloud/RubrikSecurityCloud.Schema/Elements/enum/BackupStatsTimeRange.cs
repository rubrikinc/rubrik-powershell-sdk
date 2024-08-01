// BackupStatsTimeRange.cs
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
    public enum BackupStatsTimeRange
    {
        [EnumMember(Value = "BSTR_LAST_24_HOURS")]
        BSTR_LAST_24_HOURS,

        [EnumMember(Value = "BSTR_LAST_30_DAYS")]
        BSTR_LAST_30_DAYS,

        [EnumMember(Value = "BSTR_LAST_7_DAYS")]
        BSTR_LAST_7_DAYS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum BackupStatsTimeRange

} // namespace RubrikSecurityCloud.Types