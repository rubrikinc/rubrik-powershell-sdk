// SlaAssignmentType.cs
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
    public enum SlaAssignmentType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DIRECT")]
        DIRECT,

        [EnumMember(Value = "INHERITED")]
        INHERITED,

        [EnumMember(Value = "NONE")]
        NONE


    } // enum SlaAssignmentType

} // namespace RubrikSecurityCloud.Types