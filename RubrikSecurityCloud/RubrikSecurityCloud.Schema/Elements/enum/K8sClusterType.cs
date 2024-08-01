// K8sClusterType.cs
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
    public enum K8sClusterType
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


    } // enum K8sClusterType

} // namespace RubrikSecurityCloud.Types