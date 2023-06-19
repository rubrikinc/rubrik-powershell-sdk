// EventClusterType.cs
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
    public enum EventClusterType
    {
        [EnumMember(Value = "CLOUD")]
        CLOUD,

        [EnumMember(Value = "EXO_COMPUTE")]
        EXO_COMPUTE,

        [EnumMember(Value = "ON_PREM")]
        ON_PREM,

        [EnumMember(Value = "ROBO")]
        ROBO,

        [EnumMember(Value = "RUBRIK_SAAS")]
        RUBRIK_SAAS,

        [EnumMember(Value = "UNKNOWN_CLUSTER_TYPE")]
        UNKNOWN_CLUSTER_TYPE


    } // enum EventClusterType

} // namespace RubrikSecurityCloud.Types