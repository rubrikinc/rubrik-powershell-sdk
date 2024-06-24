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

namespace RubrikSecurityCloud.Types
{
    public enum AzureNativeManagedDiskType
    {
        [EnumMember(Value = "NOT_SPECIFIED")]
        NOT_SPECIFIED,

        [EnumMember(Value = "PREMIUMV2_LRS")]
        PREMIUMV2_LRS,

        [EnumMember(Value = "PREMIUM_LRS")]
        PREMIUM_LRS,

        [EnumMember(Value = "PREMIUM_ZRS")]
        PREMIUM_ZRS,

        [EnumMember(Value = "STANDARDSSD_LRS")]
        STANDARDSSD_LRS,

        [EnumMember(Value = "STANDARDSSD_ZRS")]
        STANDARDSSD_ZRS,

        [EnumMember(Value = "STANDARD_LRS")]
        STANDARD_LRS,

        [EnumMember(Value = "ULTRASSD_LRS")]
        ULTRASSD_LRS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AzureNativeManagedDiskType

} // namespace RubrikSecurityCloud.Types