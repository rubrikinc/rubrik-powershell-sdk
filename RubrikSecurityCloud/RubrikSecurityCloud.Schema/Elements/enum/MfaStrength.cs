// MfaStrength.cs
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
    public enum MfaStrength
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MFA_DISABLED")]
        MFA_DISABLED,

        [EnumMember(Value = "MFA_STRENGTH_UNSPECIFIED")]
        MFA_STRENGTH_UNSPECIFIED,

        [EnumMember(Value = "MFA_STRONG")]
        MFA_STRONG,

        [EnumMember(Value = "MFA_WEAK")]
        MFA_WEAK


    } // enum MfaStrength

} // namespace RubrikSecurityCloud.Types