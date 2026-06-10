// QueryType.cs
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
    public enum QueryType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CHILDREN")]
        CHILDREN,

        [EnumMember(Value = "DESCENDANTS")]
        DESCENDANTS


    } // enum QueryType

} // namespace RubrikSecurityCloud.Types