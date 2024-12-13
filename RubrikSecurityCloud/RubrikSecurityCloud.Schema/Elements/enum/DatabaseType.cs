// DatabaseType.cs
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
    public enum DatabaseType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DATABASE_TYPE_ORACLE")]
        DATABASE_TYPE_ORACLE,

        [EnumMember(Value = "DATABASE_TYPE_SQL")]
        DATABASE_TYPE_SQL


    } // enum DatabaseType

} // namespace RubrikSecurityCloud.Types