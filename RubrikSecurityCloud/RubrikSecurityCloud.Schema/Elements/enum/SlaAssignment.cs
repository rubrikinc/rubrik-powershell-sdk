// SlaAssignment.cs
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
    public enum SlaAssignment
    {
        [EnumMember(Value = "SLA_ASSIGNMENT_DERIVED")]
        SLA_ASSIGNMENT_DERIVED,

        [EnumMember(Value = "SLA_ASSIGNMENT_DIRECT")]
        SLA_ASSIGNMENT_DIRECT,

        [EnumMember(Value = "SLA_ASSIGNMENT_UNASSIGNED")]
        SLA_ASSIGNMENT_UNASSIGNED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SlaAssignment

} // namespace RubrikSecurityCloud.Types