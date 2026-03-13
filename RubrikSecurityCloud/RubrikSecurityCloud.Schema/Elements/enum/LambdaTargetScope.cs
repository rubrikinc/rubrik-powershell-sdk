// LambdaTargetScope.cs
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
    public enum LambdaTargetScope
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "TARGET_SCOPE_PRINCIPAL")]
        TARGET_SCOPE_PRINCIPAL,

        [EnumMember(Value = "TARGET_SCOPE_TENANT")]
        TARGET_SCOPE_TENANT,

        [EnumMember(Value = "TARGET_SCOPE_UNSPECIFIED")]
        TARGET_SCOPE_UNSPECIFIED


    } // enum LambdaTargetScope

} // namespace RubrikSecurityCloud.Types