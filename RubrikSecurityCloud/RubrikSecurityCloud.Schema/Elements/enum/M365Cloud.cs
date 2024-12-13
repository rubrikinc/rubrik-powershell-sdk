// M365Cloud.cs
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
    public enum M365Cloud
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "COMMERCIAL")]
        COMMERCIAL,

        [EnumMember(Value = "GCC_HIGH")]
        GCC_HIGH,

        [EnumMember(Value = "GCC_MIL")]
        GCC_MIL,

        [EnumMember(Value = "NULL_CLOUD_TYPE")]
        NULL_CLOUD_TYPE


    } // enum M365Cloud

} // namespace RubrikSecurityCloud.Types