// K8sClusterProtoType.cs
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
    public enum K8sClusterProtoType
    {
        [EnumMember(Value = "AWS")]
        AWS,

        [EnumMember(Value = "AZURE")]
        AZURE,

        [EnumMember(Value = "GCP")]
        GCP,

        [EnumMember(Value = "ON_PREM")]
        ON_PREM,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum K8sClusterProtoType

} // namespace Rubrik.SecurityCloud.Types