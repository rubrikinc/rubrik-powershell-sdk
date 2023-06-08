// PolicyAssignmentType.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum PolicyAssignmentType
    {
        [EnumMember(Value = "ASSIGNMENT_UNSPECIFIED")]
        ASSIGNMENT_UNSPECIFIED,

        [EnumMember(Value = "DIRECT")]
        DIRECT,

        [EnumMember(Value = "INHERITED")]
        INHERITED


    } // enum PolicyAssignmentType

} // namespace Rubrik.SecurityCloud.Types