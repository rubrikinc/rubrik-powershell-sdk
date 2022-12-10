// InstanceTypeEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:19.
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
    public enum InstanceTypeEnum
    {
        [EnumMember(Value = "AZURE_CHINA")]
        AZURE_CHINA,

        [EnumMember(Value = "AZURE_DEFAULT")]
        AZURE_DEFAULT,

        [EnumMember(Value = "AZURE_GERMANY")]
        AZURE_GERMANY,

        [EnumMember(Value = "AZURE_GOVERNMENT")]
        AZURE_GOVERNMENT,

        [EnumMember(Value = "UNKNOWN_INSTANCE")]
        UNKNOWN_INSTANCE


    } // enum InstanceTypeEnum

} // namespace Rubrik.SecurityCloud.Types