// FilterOperator.cs
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
    public enum FilterOperator
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "IN")]
        IN,

        [EnumMember(Value = "LIKE")]
        LIKE,

        [EnumMember(Value = "NOT_IN")]
        NOT_IN,

        [EnumMember(Value = "NOT_LIKE")]
        NOT_LIKE


    } // enum FilterOperator

} // namespace RubrikSecurityCloud.Types