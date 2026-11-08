// BlueprintPlatform.cs
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
    public enum BlueprintPlatform
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS")]
        AWS,

        [EnumMember(Value = "AZURE")]
        AZURE,

        [EnumMember(Value = "NUTANIX")]
        NUTANIX,

        [EnumMember(Value = "UNKNOWN_PLATFORM")]
        UNKNOWN_PLATFORM,

        [EnumMember(Value = "VSPHERE")]
        VSPHERE


    } // enum BlueprintPlatform

} // namespace RubrikSecurityCloud.Types