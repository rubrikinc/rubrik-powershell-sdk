// ClusterNodePosition.cs
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
    public enum ClusterNodePosition
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "LEFT_BOTTOM")]
        LEFT_BOTTOM,

        [EnumMember(Value = "LEFT_TOP")]
        LEFT_TOP,

        [EnumMember(Value = "RIGHT_BOTTOM")]
        RIGHT_BOTTOM,

        [EnumMember(Value = "RIGHT_TOP")]
        RIGHT_TOP


    } // enum ClusterNodePosition

} // namespace RubrikSecurityCloud.Types