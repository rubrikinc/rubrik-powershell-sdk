// LookBackWindow.cs
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
    public enum LookBackWindow
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "LAST_1_MONTH")]
        LAST_1_MONTH,

        [EnumMember(Value = "LAST_1_YEAR")]
        LAST_1_YEAR,

        [EnumMember(Value = "LAST_3_MONTHS")]
        LAST_3_MONTHS,

        [EnumMember(Value = "LAST_7_DAYS")]
        LAST_7_DAYS,

        [EnumMember(Value = "LOOK_BACK_WINDOW_UNSPECIFIED")]
        LOOK_BACK_WINDOW_UNSPECIFIED


    } // enum LookBackWindow

} // namespace RubrikSecurityCloud.Types