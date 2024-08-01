// KubernetesObjectType.cs
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
    public enum KubernetesObjectType
    {
        [EnumMember(Value = "INVENTORY")]
        INVENTORY,

        [EnumMember(Value = "SLA")]
        SLA,

        [EnumMember(Value = "SNAPSHOT")]
        SNAPSHOT,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum KubernetesObjectType

} // namespace RubrikSecurityCloud.Types