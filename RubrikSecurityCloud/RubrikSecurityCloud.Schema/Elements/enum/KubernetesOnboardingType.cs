// KubernetesOnboardingType.cs
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
    public enum KubernetesOnboardingType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "KUBECONFIG")]
        KUBECONFIG,

        [EnumMember(Value = "MANIFEST")]
        MANIFEST


    } // enum KubernetesOnboardingType

} // namespace RubrikSecurityCloud.Types