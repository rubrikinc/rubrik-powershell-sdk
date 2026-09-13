// M365AccessMode.cs
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
    public enum M365AccessMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "M365_ACCESS_MODE_FULL_PERMISSIONS")]
        M365_ACCESS_MODE_FULL_PERMISSIONS,

        [EnumMember(Value = "M365_ACCESS_MODE_JUST_IN_TIME_PERMISSIONS")]
        M365_ACCESS_MODE_JUST_IN_TIME_PERMISSIONS,

        [EnumMember(Value = "M365_ACCESS_MODE_UNKNOWN")]
        M365_ACCESS_MODE_UNKNOWN


    } // enum M365AccessMode

} // namespace RubrikSecurityCloud.Types