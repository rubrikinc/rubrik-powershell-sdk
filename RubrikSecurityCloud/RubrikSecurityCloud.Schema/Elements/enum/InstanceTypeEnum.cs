// InstanceTypeEnum.cs
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

} // namespace RubrikSecurityCloud.Types