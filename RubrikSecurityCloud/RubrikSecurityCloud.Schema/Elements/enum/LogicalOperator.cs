// LogicalOperator.cs
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
    public enum LogicalOperator
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AND")]
        AND,

        [EnumMember(Value = "LOGICAL_OPERATOR_UNSPECIFIED")]
        LOGICAL_OPERATOR_UNSPECIFIED,

        [EnumMember(Value = "OR")]
        OR


    } // enum LogicalOperator

} // namespace RubrikSecurityCloud.Types