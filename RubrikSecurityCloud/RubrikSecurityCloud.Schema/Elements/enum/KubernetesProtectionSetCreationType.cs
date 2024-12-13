// KubernetesProtectionSetCreationType.cs
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
    public enum KubernetesProtectionSetCreationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "API")]
        API,

        [EnumMember(Value = "AUTO")]
        AUTO,

        [EnumMember(Value = "CRD")]
        CRD,

        [EnumMember(Value = "RSC")]
        RSC


    } // enum KubernetesProtectionSetCreationType

} // namespace RubrikSecurityCloud.Types