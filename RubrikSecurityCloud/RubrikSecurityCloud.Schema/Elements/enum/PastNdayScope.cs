// PastNdayScope.cs
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
    public enum PastNdayScope
    {
        [EnumMember(Value = "PAST_1_DAY")]
        PAST_1_DAY,

        [EnumMember(Value = "PAST_30_DAYS")]
        PAST_30_DAYS,

        [EnumMember(Value = "PAST_7_DAYS")]
        PAST_7_DAYS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum PastNdayScope

} // namespace RubrikSecurityCloud.Types