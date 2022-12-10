// VmPowerStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:07.
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
    public enum VmPowerStatus
    {
        [EnumMember(Value = "POWERED_OFF")]
        POWERED_OFF,

        [EnumMember(Value = "POWERED_ON")]
        POWERED_ON,

        [EnumMember(Value = "SUSPENDED")]
        SUSPENDED


    } // enum VmPowerStatus

} // namespace Rubrik.SecurityCloud.Types