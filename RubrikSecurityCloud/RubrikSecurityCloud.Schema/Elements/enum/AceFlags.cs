// AceFlags.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:29.
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
    public enum AceFlags
    {
        [EnumMember(Value = "CONTAINER_INHERIT")]
        CONTAINER_INHERIT,

        [EnumMember(Value = "EMPTY_FLAG")]
        EMPTY_FLAG,

        [EnumMember(Value = "FAILED_ACCESS")]
        FAILED_ACCESS,

        [EnumMember(Value = "INHERITED")]
        INHERITED,

        [EnumMember(Value = "INHERIT_ONLY")]
        INHERIT_ONLY,

        [EnumMember(Value = "NO_PROPAGATE_INHERIT")]
        NO_PROPAGATE_INHERIT,

        [EnumMember(Value = "OBJECT_INHERIT")]
        OBJECT_INHERIT,

        [EnumMember(Value = "SUCCESSFUL_ACCESS")]
        SUCCESSFUL_ACCESS


    } // enum AceFlags

} // namespace Rubrik.SecurityCloud.Types