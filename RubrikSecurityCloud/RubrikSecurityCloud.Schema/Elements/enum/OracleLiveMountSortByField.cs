// OracleLiveMountSortByField.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:58.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum OracleLiveMountSortByField
    {
        [EnumMember(Value = "CREATION_DATE")]
        CREATION_DATE,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "SOURCE_DATABASE_NAME")]
        SOURCE_DATABASE_NAME,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum OracleLiveMountSortByField

} // namespace Rubrik.SecurityCloud.Types