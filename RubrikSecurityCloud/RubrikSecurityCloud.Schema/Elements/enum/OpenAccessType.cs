// OpenAccessType.cs
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
    public enum OpenAccessType
    {
        [EnumMember(Value = "EXPLICIT")]
        EXPLICIT,

        [EnumMember(Value = "INHERITED")]
        INHERITED,

        [EnumMember(Value = "NOT_OPEN")]
        NOT_OPEN,

        [EnumMember(Value = "PUBLIC")]
        PUBLIC,

        [EnumMember(Value = "UNKNOWN_ACCESS")]
        UNKNOWN_ACCESS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum OpenAccessType

} // namespace RubrikSecurityCloud.Types