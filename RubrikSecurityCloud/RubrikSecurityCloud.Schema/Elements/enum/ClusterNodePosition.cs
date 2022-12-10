// ClusterNodePosition.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:01.
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
    public enum ClusterNodePosition
    {
        [EnumMember(Value = "LEFT_BOTTOM")]
        LEFT_BOTTOM,

        [EnumMember(Value = "LEFT_TOP")]
        LEFT_TOP,

        [EnumMember(Value = "RIGHT_BOTTOM")]
        RIGHT_BOTTOM,

        [EnumMember(Value = "RIGHT_TOP")]
        RIGHT_TOP


    } // enum ClusterNodePosition

} // namespace Rubrik.SecurityCloud.Types