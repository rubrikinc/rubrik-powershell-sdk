// OpenAccessType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:27.
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
    public enum OpenAccessType
    {
        [EnumMember(Value = "EXPLICIT")]
        EXPLICIT,

        [EnumMember(Value = "INHERITED")]
        INHERITED,

        [EnumMember(Value = "NOT_OPEN")]
        NOT_OPEN,

        [EnumMember(Value = "UNKNOWN_ACCESS")]
        UNKNOWN_ACCESS


    } // enum OpenAccessType

} // namespace Rubrik.SecurityCloud.Types