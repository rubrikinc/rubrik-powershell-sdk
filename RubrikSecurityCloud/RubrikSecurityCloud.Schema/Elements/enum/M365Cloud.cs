// M365Cloud.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:55.
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
    public enum M365Cloud
    {
        [EnumMember(Value = "COMMERCIAL")]
        COMMERCIAL,

        [EnumMember(Value = "GCC_HIGH")]
        GCC_HIGH,

        [EnumMember(Value = "GCC_MIL")]
        GCC_MIL,

        [EnumMember(Value = "NULL_CLOUD_TYPE")]
        NULL_CLOUD_TYPE


    } // enum M365Cloud

} // namespace Rubrik.SecurityCloud.Types