// AceFlags.cs
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
    public enum AceFlags
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

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

} // namespace RubrikSecurityCloud.Types