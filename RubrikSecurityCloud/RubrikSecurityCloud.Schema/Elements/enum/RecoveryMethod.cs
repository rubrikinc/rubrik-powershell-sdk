// RecoveryMethod.cs
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
    public enum RecoveryMethod
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "RECOVERY_METHOD_APPLICATION_ONLY")]
        RECOVERY_METHOD_APPLICATION_ONLY,

        [EnumMember(Value = "RECOVERY_METHOD_BARE_METAL")]
        RECOVERY_METHOD_BARE_METAL,

        [EnumMember(Value = "RECOVERY_METHOD_SYSTEM_STATE")]
        RECOVERY_METHOD_SYSTEM_STATE


    } // enum RecoveryMethod

} // namespace RubrikSecurityCloud.Types