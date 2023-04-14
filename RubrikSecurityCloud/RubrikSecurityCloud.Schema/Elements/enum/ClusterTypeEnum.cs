// ClusterTypeEnum.cs
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
    public enum ClusterTypeEnum
    {
        [EnumMember(Value = "Cloud")]
        CLOUD,

        [EnumMember(Value = "ExoCompute")]
        EXO_COMPUTE,

        [EnumMember(Value = "OnPrem")]
        ON_PREM,

        [EnumMember(Value = "Polaris")]
        POLARIS,

        [EnumMember(Value = "Robo")]
        ROBO,

        [EnumMember(Value = "Unknown")]
        UNKNOWN


    } // enum ClusterTypeEnum

} // namespace Rubrik.SecurityCloud.Types