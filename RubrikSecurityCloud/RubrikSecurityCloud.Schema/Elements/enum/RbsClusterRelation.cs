// RbsClusterRelation.cs
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
    public enum RbsClusterRelation
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PRIMARY")]
        PRIMARY,

        [EnumMember(Value = "RELATION_UNKNOWN")]
        RELATION_UNKNOWN,

        [EnumMember(Value = "SECONDARY")]
        SECONDARY


    } // enum RbsClusterRelation

} // namespace RubrikSecurityCloud.Types