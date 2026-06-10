// DcRecoveryMethod.cs
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
    public enum DcRecoveryMethod
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DC_RECOVERY_METHOD_APPLICATION_ONLY")]
        DC_RECOVERY_METHOD_APPLICATION_ONLY,

        [EnumMember(Value = "DC_RECOVERY_METHOD_BARE_METAL")]
        DC_RECOVERY_METHOD_BARE_METAL,

        [EnumMember(Value = "DC_RECOVERY_METHOD_SYSTEM_STATE")]
        DC_RECOVERY_METHOD_SYSTEM_STATE,

        [EnumMember(Value = "DC_RECOVERY_METHOD_UNSPECIFIED")]
        DC_RECOVERY_METHOD_UNSPECIFIED


    } // enum DcRecoveryMethod

} // namespace RubrikSecurityCloud.Types