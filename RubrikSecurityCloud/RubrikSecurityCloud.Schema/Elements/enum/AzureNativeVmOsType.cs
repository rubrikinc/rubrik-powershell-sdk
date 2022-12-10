// AzureNativeVmOsType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:13.
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
    public enum AzureNativeVmOsType
    {
        [EnumMember(Value = "LINUX")]
        LINUX,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "WINDOWS")]
        WINDOWS


    } // enum AzureNativeVmOsType

} // namespace Rubrik.SecurityCloud.Types