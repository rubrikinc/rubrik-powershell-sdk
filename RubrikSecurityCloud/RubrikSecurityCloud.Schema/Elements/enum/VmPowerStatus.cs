// VmPowerStatus.cs
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
    public enum VmPowerStatus
    {
        [EnumMember(Value = "POWERED_OFF")]
        POWERED_OFF,

        [EnumMember(Value = "POWERED_ON")]
        POWERED_ON,

        [EnumMember(Value = "SUSPENDED")]
        SUSPENDED


    } // enum VmPowerStatus

} // namespace RubrikSecurityCloud.Types