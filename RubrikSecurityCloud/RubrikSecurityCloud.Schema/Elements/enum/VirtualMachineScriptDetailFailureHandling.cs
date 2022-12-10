// VirtualMachineScriptDetailFailureHandling.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:09.
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
    public enum VirtualMachineScriptDetailFailureHandling
    {
        [EnumMember(Value = "VIRTUAL_MACHINE_SCRIPT_DETAIL_FAILURE_HANDLING_ABORT")]
        VIRTUAL_MACHINE_SCRIPT_DETAIL_FAILURE_HANDLING_ABORT,

        [EnumMember(Value = "VIRTUAL_MACHINE_SCRIPT_DETAIL_FAILURE_HANDLING_CONTINUE")]
        VIRTUAL_MACHINE_SCRIPT_DETAIL_FAILURE_HANDLING_CONTINUE


    } // enum VirtualMachineScriptDetailFailureHandling

} // namespace Rubrik.SecurityCloud.Types