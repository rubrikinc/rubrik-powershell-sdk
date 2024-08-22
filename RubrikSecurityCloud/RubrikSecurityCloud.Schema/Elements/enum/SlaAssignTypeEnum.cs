// SlaAssignTypeEnum.cs
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
    public enum SlaAssignTypeEnum
    {
        [EnumMember(Value = "doNotProtect")]
        DO_NOT_PROTECT,

        [EnumMember(Value = "noAssignment")]
        NO_ASSIGNMENT,

        [EnumMember(Value = "protectWithSlaId")]
        PROTECT_WITH_SLA_ID,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SlaAssignTypeEnum

} // namespace RubrikSecurityCloud.Types