// AzureAdPimAssignmentType.cs
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
    public enum AzureAdPimAssignmentType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PIM_ASSIGNMENT_TYPE_ACTIVATED")]
        PIM_ASSIGNMENT_TYPE_ACTIVATED,

        [EnumMember(Value = "PIM_ASSIGNMENT_TYPE_ASSIGNED")]
        PIM_ASSIGNMENT_TYPE_ASSIGNED,

        [EnumMember(Value = "PIM_ASSIGNMENT_TYPE_UNSPECIFIED")]
        PIM_ASSIGNMENT_TYPE_UNSPECIFIED


    } // enum AzureAdPimAssignmentType

} // namespace RubrikSecurityCloud.Types