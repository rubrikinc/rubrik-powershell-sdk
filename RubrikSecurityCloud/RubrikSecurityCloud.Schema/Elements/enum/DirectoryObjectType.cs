// DirectoryObjectType.cs
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
    public enum DirectoryObjectType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "GROUP")]
        GROUP,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        [EnumMember(Value = "USER")]
        USER


    } // enum DirectoryObjectType

} // namespace RubrikSecurityCloud.Types