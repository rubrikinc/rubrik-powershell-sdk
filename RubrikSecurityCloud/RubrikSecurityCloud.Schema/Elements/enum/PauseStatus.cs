// PauseStatus.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum PauseStatus
    {
        [EnumMember(Value = "NOT_PAUSED")]
        NOT_PAUSED,

        [EnumMember(Value = "PAUSED")]
        PAUSED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum PauseStatus

} // namespace Rubrik.SecurityCloud.Types