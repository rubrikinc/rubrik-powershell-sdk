// VirtualMachineTemplateType.cs
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
    public enum VirtualMachineTemplateType
    {
        [EnumMember(Value = "VIRTUAL_MACHINE_TEMPLATE_TYPE_LIBRARY_ITEM")]
        VIRTUAL_MACHINE_TEMPLATE_TYPE_LIBRARY_ITEM,

        [EnumMember(Value = "VIRTUAL_MACHINE_TEMPLATE_TYPE_TEMPLATE")]
        VIRTUAL_MACHINE_TEMPLATE_TYPE_TEMPLATE,

        [EnumMember(Value = "VIRTUAL_MACHINE_TEMPLATE_TYPE_UNDEFINED")]
        VIRTUAL_MACHINE_TEMPLATE_TYPE_UNDEFINED,

        [EnumMember(Value = "VIRTUAL_MACHINE_TEMPLATE_TYPE_VM")]
        VIRTUAL_MACHINE_TEMPLATE_TYPE_VM


    } // enum VirtualMachineTemplateType

} // namespace RubrikSecurityCloud.Types