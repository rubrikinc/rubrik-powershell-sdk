// HypervVmSubtype.cs
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
    public enum HypervVmSubtype
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_LOCAL")]
        AZURE_LOCAL,

        [EnumMember(Value = "HYPERV")]
        HYPERV


    } // enum HypervVmSubtype

} // namespace RubrikSecurityCloud.Types