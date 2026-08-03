// AccessPathType.cs
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
    public enum AccessPathType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCESS_PATH_TYPE_DIRECT")]
        ACCESS_PATH_TYPE_DIRECT,

        [EnumMember(Value = "ACCESS_PATH_TYPE_IMPACTED")]
        ACCESS_PATH_TYPE_IMPACTED,

        [EnumMember(Value = "ACCESS_PATH_TYPE_INDIRECT")]
        ACCESS_PATH_TYPE_INDIRECT,

        [EnumMember(Value = "ACCESS_PATH_TYPE_UNSPECIFIED")]
        ACCESS_PATH_TYPE_UNSPECIFIED


    } // enum AccessPathType

} // namespace RubrikSecurityCloud.Types