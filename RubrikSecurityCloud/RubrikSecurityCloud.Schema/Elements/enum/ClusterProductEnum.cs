// ClusterProductEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:01.
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
    public enum ClusterProductEnum
    {
        [EnumMember(Value = "CDM")]
        CDM,

        [EnumMember(Value = "CLOUD_DIRECT")]
        CLOUD_DIRECT,

        [EnumMember(Value = "DATOS")]
        DATOS,

        [EnumMember(Value = "POLARIS")]
        POLARIS


    } // enum ClusterProductEnum

} // namespace Rubrik.SecurityCloud.Types