// VmwareFolderType.cs
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
    public enum VmwareFolderType
    {
        [EnumMember(Value = "DATACENTER")]
        DATACENTER,

        [EnumMember(Value = "HOST")]
        HOST,

        [EnumMember(Value = "UNDEFINED")]
        UNDEFINED,

        [EnumMember(Value = "VM")]
        VM


    } // enum VmwareFolderType

} // namespace RubrikSecurityCloud.Types