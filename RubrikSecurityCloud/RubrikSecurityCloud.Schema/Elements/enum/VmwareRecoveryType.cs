// VmwareRecoveryType.cs
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
    public enum VmwareRecoveryType
    {
        [EnumMember(Value = "EXPORT")]
        EXPORT,

        [EnumMember(Value = "INPLACE")]
        INPLACE,

        [EnumMember(Value = "LIVEMOUNT")]
        LIVEMOUNT,

        [EnumMember(Value = "UNKNOWN_RECOVERY_TYPE")]
        UNKNOWN_RECOVERY_TYPE


    } // enum VmwareRecoveryType

} // namespace RubrikSecurityCloud.Types