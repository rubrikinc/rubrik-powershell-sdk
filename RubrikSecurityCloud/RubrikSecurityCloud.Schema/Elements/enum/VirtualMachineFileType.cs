// VirtualMachineFileType.cs
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
    public enum VirtualMachineFileType
    {
        [EnumMember(Value = "VIRTUAL_MACHINE_FILE_TYPE_FILE")]
        VIRTUAL_MACHINE_FILE_TYPE_FILE,

        [EnumMember(Value = "VIRTUAL_MACHINE_FILE_TYPE_NON_VOLATILE_MEMORY_FILE")]
        VIRTUAL_MACHINE_FILE_TYPE_NON_VOLATILE_MEMORY_FILE,

        [EnumMember(Value = "VIRTUAL_MACHINE_FILE_TYPE_VIRTUAL_DISK")]
        VIRTUAL_MACHINE_FILE_TYPE_VIRTUAL_DISK,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum VirtualMachineFileType

} // namespace RubrikSecurityCloud.Types