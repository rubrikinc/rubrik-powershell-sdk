// SnappableSlaAssignment.cs
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
    public enum SnappableSlaAssignment
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SNAPPABLE_SLA_ASSIGNMENT_DERIVED")]
        SNAPPABLE_SLA_ASSIGNMENT_DERIVED,

        [EnumMember(Value = "SNAPPABLE_SLA_ASSIGNMENT_DIRECT")]
        SNAPPABLE_SLA_ASSIGNMENT_DIRECT,

        [EnumMember(Value = "SNAPPABLE_SLA_ASSIGNMENT_UNASSIGNED")]
        SNAPPABLE_SLA_ASSIGNMENT_UNASSIGNED


    } // enum SnappableSlaAssignment

} // namespace RubrikSecurityCloud.Types