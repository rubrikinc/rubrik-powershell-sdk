// UnselectedDcBehavior.cs
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
    public enum UnselectedDcBehavior
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "UNSELECTED_DC_BEHAVIOR_KEEP")]
        UNSELECTED_DC_BEHAVIOR_KEEP,

        [EnumMember(Value = "UNSELECTED_DC_BEHAVIOR_REMOVE")]
        UNSELECTED_DC_BEHAVIOR_REMOVE,

        [EnumMember(Value = "UNSELECTED_DC_BEHAVIOR_UNSPECIFIED")]
        UNSELECTED_DC_BEHAVIOR_UNSPECIFIED


    } // enum UnselectedDcBehavior

} // namespace RubrikSecurityCloud.Types