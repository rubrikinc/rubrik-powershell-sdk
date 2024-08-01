// VmwareTemplateType.cs
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
    public enum VmwareTemplateType
    {
        [EnumMember(Value = "DEPLOYED_VM")]
        DEPLOYED_VM,

        [EnumMember(Value = "LIBRARY_ITEM")]
        LIBRARY_ITEM,

        [EnumMember(Value = "TEMPLATE")]
        TEMPLATE,

        [EnumMember(Value = "TEMPORARY_VM")]
        TEMPORARY_VM,

        [EnumMember(Value = "UNDEFINED")]
        UNDEFINED,

        [EnumMember(Value = "VM")]
        VM,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum VmwareTemplateType

} // namespace RubrikSecurityCloud.Types