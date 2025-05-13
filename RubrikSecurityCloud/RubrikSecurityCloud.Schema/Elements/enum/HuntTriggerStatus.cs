// HuntTriggerStatus.cs
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
    public enum HuntTriggerStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "HUNT_TRIGGER_FAILED")]
        HUNT_TRIGGER_FAILED,

        [EnumMember(Value = "HUNT_TRIGGER_SUCCEEDED")]
        HUNT_TRIGGER_SUCCEEDED


    } // enum HuntTriggerStatus

} // namespace RubrikSecurityCloud.Types