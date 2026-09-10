// RelationshipType.cs
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
    public enum RelationshipType
    {
        [EnumMember(Value = "CHILD")]
        CHILD,

        [EnumMember(Value = "PARENT")]
        PARENT,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RelationshipType

} // namespace RubrikSecurityCloud.Types