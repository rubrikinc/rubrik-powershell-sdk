// Type.cs
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
    public enum Type
    {
        [EnumMember(Value = "BOOLEAN")]
        BOOLEAN,

        [EnumMember(Value = "INTEGER")]
        INTEGER,

        [EnumMember(Value = "ISO_8601_DATETIME")]
        ISO_8601_DATETIME,

        [EnumMember(Value = "STRING")]
        STRING


    } // enum Type

} // namespace RubrikSecurityCloud.Types