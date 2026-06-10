// RecoveryPurpose.cs
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
    public enum RecoveryPurpose
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "RECOVERY_PURPOSE_UNSPECIFIED")]
        RECOVERY_PURPOSE_UNSPECIFIED,

        [EnumMember(Value = "SURGICAL_RECOVERY")]
        SURGICAL_RECOVERY


    } // enum RecoveryPurpose

} // namespace RubrikSecurityCloud.Types