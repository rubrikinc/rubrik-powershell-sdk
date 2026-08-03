// PolicyViolationGroupBy.cs
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
    public enum PolicyViolationGroupBy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "POLICY_VIOLATION_GROUP_BY_NONE")]
        POLICY_VIOLATION_GROUP_BY_NONE,

        [EnumMember(Value = "POLICY_VIOLATION_GROUP_BY_POLICY")]
        POLICY_VIOLATION_GROUP_BY_POLICY,

        [EnumMember(Value = "POLICY_VIOLATION_GROUP_BY_RESOURCE")]
        POLICY_VIOLATION_GROUP_BY_RESOURCE,

        [EnumMember(Value = "POLICY_VIOLATION_GROUP_BY_UNSPECIFIED")]
        POLICY_VIOLATION_GROUP_BY_UNSPECIFIED


    } // enum PolicyViolationGroupBy

} // namespace RubrikSecurityCloud.Types