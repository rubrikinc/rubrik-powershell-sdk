// ClusterPauseStatus.cs
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
    public enum ClusterPauseStatus
    {
        [EnumMember(Value = "NOT_PAUSED")]
        NOT_PAUSED,

        [EnumMember(Value = "PAUSED")]
        PAUSED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ClusterPauseStatus

} // namespace RubrikSecurityCloud.Types