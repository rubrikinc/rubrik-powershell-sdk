// SnappableProtectionStatus.cs
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
    public enum SnappableProtectionStatus
    {
        [EnumMember(Value = "DO_NOT_PROTECT")]
        DO_NOT_PROTECT,

        [EnumMember(Value = "NATIVE_PROTECTION")]
        NATIVE_PROTECTION,

        [EnumMember(Value = "RSC_PROTECTED")]
        RSC_PROTECTED,

        [EnumMember(Value = "UNKNOWN_PROTECTION")]
        UNKNOWN_PROTECTION,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SnappableProtectionStatus

} // namespace RubrikSecurityCloud.Types