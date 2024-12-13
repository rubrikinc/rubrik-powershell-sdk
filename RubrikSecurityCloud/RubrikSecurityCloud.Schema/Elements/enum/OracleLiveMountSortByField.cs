// OracleLiveMountSortByField.cs
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
    public enum OracleLiveMountSortByField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CREATION_DATE")]
        CREATION_DATE,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "SOURCE_DATABASE_NAME")]
        SOURCE_DATABASE_NAME,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum OracleLiveMountSortByField

} // namespace RubrikSecurityCloud.Types