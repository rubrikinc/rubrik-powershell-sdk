// IntuneAssignmentFilterManagementType.cs
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
    public enum IntuneAssignmentFilterManagementType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INTUNE_ASSIGNMENT_FILTER_MANAGEMENT_TYPE_APPS")]
        INTUNE_ASSIGNMENT_FILTER_MANAGEMENT_TYPE_APPS,

        [EnumMember(Value = "INTUNE_ASSIGNMENT_FILTER_MANAGEMENT_TYPE_DEVICES")]
        INTUNE_ASSIGNMENT_FILTER_MANAGEMENT_TYPE_DEVICES,

        [EnumMember(Value = "INTUNE_ASSIGNMENT_FILTER_MANAGEMENT_TYPE_UNKNOWN")]
        INTUNE_ASSIGNMENT_FILTER_MANAGEMENT_TYPE_UNKNOWN


    } // enum IntuneAssignmentFilterManagementType

} // namespace RubrikSecurityCloud.Types