// ClusterSystemStatus.cs
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
    public enum ClusterSystemStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FATAL")]
        FATAL,

        [EnumMember(Value = "OK")]
        OK,

        [EnumMember(Value = "WARNING")]
        WARNING


    } // enum ClusterSystemStatus

} // namespace RubrikSecurityCloud.Types