// PermissionType.cs
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
    public enum PermissionType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FIELD")]
        FIELD,

        [EnumMember(Value = "OBJECT")]
        OBJECT,

        [EnumMember(Value = "OBJECT_FIELD")]
        OBJECT_FIELD,

        [EnumMember(Value = "SYSTEM_APP")]
        SYSTEM_APP


    } // enum PermissionType

} // namespace RubrikSecurityCloud.Types