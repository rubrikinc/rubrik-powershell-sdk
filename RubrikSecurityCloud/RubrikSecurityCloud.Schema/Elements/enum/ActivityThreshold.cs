// ActivityThreshold.cs
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
    public enum ActivityThreshold
    {
        [EnumMember(Value = "ACTIVITY_THRESHOLD_UNSPECIFIED")]
        ACTIVITY_THRESHOLD_UNSPECIFIED,

        [EnumMember(Value = "NO_ACTIVITY")]
        NO_ACTIVITY,

        [EnumMember(Value = "SOME_ACTIVITY")]
        SOME_ACTIVITY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ActivityThreshold

} // namespace RubrikSecurityCloud.Types