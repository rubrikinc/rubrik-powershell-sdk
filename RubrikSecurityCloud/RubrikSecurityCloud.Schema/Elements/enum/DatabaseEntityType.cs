// DatabaseEntityType.cs
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
    public enum DatabaseEntityType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DATABASE")]
        DATABASE,

        [EnumMember(Value = "SCHEMA")]
        SCHEMA,

        [EnumMember(Value = "TABLE")]
        TABLE,

        [EnumMember(Value = "UNDEFINED_ENTITY")]
        UNDEFINED_ENTITY


    } // enum DatabaseEntityType

} // namespace RubrikSecurityCloud.Types