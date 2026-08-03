// RecoverySpecTypeV2.cs
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
    public enum RecoverySpecTypeV2
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INSTANCE")]
        INSTANCE,

        [EnumMember(Value = "PROMOTION")]
        PROMOTION,

        [EnumMember(Value = "TEMPLATE")]
        TEMPLATE,

        [EnumMember(Value = "UNKNOWN_SPEC_TYPE")]
        UNKNOWN_SPEC_TYPE


    } // enum RecoverySpecTypeV2

} // namespace RubrikSecurityCloud.Types