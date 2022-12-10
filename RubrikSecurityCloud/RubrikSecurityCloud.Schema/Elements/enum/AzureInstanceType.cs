// AzureInstanceType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:11.
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
    public enum AzureInstanceType
    {
        [EnumMember(Value = "STANDARD_D16S_V5")]
        STANDARD_D16S_V5,

        [EnumMember(Value = "STANDARD_D32S_V5")]
        STANDARD_D32S_V5,

        [EnumMember(Value = "STANDARD_D8S_V5")]
        STANDARD_D8S_V5,

        [EnumMember(Value = "STANDARD_DS5_V2")]
        STANDARD_DS5_V2,

        [EnumMember(Value = "TYPE_UNSPECIFIED")]
        TYPE_UNSPECIFIED


    } // enum AzureInstanceType

} // namespace Rubrik.SecurityCloud.Types