// CloudNativeProtectionStatus.cs
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
    public enum CloudNativeProtectionStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PROTECTION_STATUS_PARTIALLY_PROTECTED")]
        PROTECTION_STATUS_PARTIALLY_PROTECTED,

        [EnumMember(Value = "PROTECTION_STATUS_PROTECTED")]
        PROTECTION_STATUS_PROTECTED,

        [EnumMember(Value = "PROTECTION_STATUS_PROTECTED_WITH_WARNINGS")]
        PROTECTION_STATUS_PROTECTED_WITH_WARNINGS,

        [EnumMember(Value = "PROTECTION_STATUS_UNPROTECTED")]
        PROTECTION_STATUS_UNPROTECTED,

        [EnumMember(Value = "PROTECTION_STATUS_UNSPECIFIED")]
        PROTECTION_STATUS_UNSPECIFIED


    } // enum CloudNativeProtectionStatus

} // namespace RubrikSecurityCloud.Types