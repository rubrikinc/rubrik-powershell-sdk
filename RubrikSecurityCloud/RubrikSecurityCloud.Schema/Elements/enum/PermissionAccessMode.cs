// PermissionAccessMode.cs
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
    public enum PermissionAccessMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FULL_ACCESS")]
        FULL_ACCESS,

        [EnumMember(Value = "JUST_IN_TIME_ACCESS")]
        JUST_IN_TIME_ACCESS,

        [EnumMember(Value = "PERMISSION_ACCESS_MODE_UNSPECIFIED")]
        PERMISSION_ACCESS_MODE_UNSPECIFIED


    } // enum PermissionAccessMode

} // namespace RubrikSecurityCloud.Types