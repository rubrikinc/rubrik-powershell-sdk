// Db2DatabaseType.cs
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
    public enum Db2DatabaseType
    {
        [EnumMember(Value = "DBTYPE_UNSPECIFIED")]
        DBTYPE_UNSPECIFIED,

        [EnumMember(Value = "HADR")]
        HADR,

        [EnumMember(Value = "PARTITIONED")]
        PARTITIONED,

        [EnumMember(Value = "STANDALONE")]
        STANDALONE


    } // enum Db2DatabaseType

} // namespace RubrikSecurityCloud.Types