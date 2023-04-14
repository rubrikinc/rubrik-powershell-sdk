// AzureNativeManagedDiskType.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum AzureNativeManagedDiskType
    {
        [EnumMember(Value = "NOT_SPECIFIED")]
        NOT_SPECIFIED,

        [EnumMember(Value = "PREMIUM_LRS")]
        PREMIUM_LRS,

        [EnumMember(Value = "STANDARDSSD_LRS")]
        STANDARDSSD_LRS,

        [EnumMember(Value = "STANDARD_LRS")]
        STANDARD_LRS,

        [EnumMember(Value = "ULTRASSD_LRS")]
        ULTRASSD_LRS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AzureNativeManagedDiskType

} // namespace Rubrik.SecurityCloud.Types