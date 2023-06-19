// SlaAssignmentTypeEnum.cs
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
    public enum SlaAssignmentTypeEnum
    {
        [EnumMember(Value = "Derived")]
        DERIVED,

        [EnumMember(Value = "Direct")]
        DIRECT,

        [EnumMember(Value = "Unassigned")]
        UNASSIGNED


    } // enum SlaAssignmentTypeEnum

} // namespace RubrikSecurityCloud.Types