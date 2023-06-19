// HypervMountedVmStatusType.cs
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
    public enum HypervMountedVmStatusType
    {
        [EnumMember(Value = "POWEREDOFF")]
        POWEREDOFF,

        [EnumMember(Value = "POWEREDON")]
        POWEREDON,

        [EnumMember(Value = "POWERINGOFF")]
        POWERINGOFF,

        [EnumMember(Value = "POWERINGON")]
        POWERINGON,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum HypervMountedVmStatusType

} // namespace RubrikSecurityCloud.Types