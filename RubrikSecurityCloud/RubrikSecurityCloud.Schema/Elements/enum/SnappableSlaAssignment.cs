// SnappableSlaAssignment.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:37.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum SnappableSlaAssignment
    {
        [EnumMember(Value = "SNAPPABLE_SLA_ASSIGNMENT_DERIVED")]
        SNAPPABLE_SLA_ASSIGNMENT_DERIVED,

        [EnumMember(Value = "SNAPPABLE_SLA_ASSIGNMENT_DIRECT")]
        SNAPPABLE_SLA_ASSIGNMENT_DIRECT,

        [EnumMember(Value = "SNAPPABLE_SLA_ASSIGNMENT_UNASSIGNED")]
        SNAPPABLE_SLA_ASSIGNMENT_UNASSIGNED


    } // enum SnappableSlaAssignment

} // namespace Rubrik.SecurityCloud.Types