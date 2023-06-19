// ProtectionStatusEnum.cs
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
    public enum ProtectionStatusEnum
    {
        [EnumMember(Value = "DoNotProtect")]
        DO_NOT_PROTECT,

        [EnumMember(Value = "NoSla")]
        NO_SLA,

        [EnumMember(Value = "Protected")]
        PROTECTED


    } // enum ProtectionStatusEnum

} // namespace RubrikSecurityCloud.Types