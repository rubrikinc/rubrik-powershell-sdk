// LlmFunctionCallFunctionType.cs
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
    public enum LlmFunctionCallFunctionType
    {
        [EnumMember(Value = "THREAT_HUNT")]
        THREAT_HUNT,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        [EnumMember(Value = "VSPHERE_DOWNLOAD_SNAPSHOT")]
        VSPHERE_DOWNLOAD_SNAPSHOT,

        [EnumMember(Value = "VSPHERE_IN_PLACE_RECOVERY")]
        VSPHERE_IN_PLACE_RECOVERY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum LlmFunctionCallFunctionType

} // namespace RubrikSecurityCloud.Types