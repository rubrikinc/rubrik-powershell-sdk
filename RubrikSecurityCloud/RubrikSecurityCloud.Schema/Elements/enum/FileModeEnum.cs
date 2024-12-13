// FileModeEnum.cs
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
    public enum FileModeEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DIRECTORY")]
        DIRECTORY,

        [EnumMember(Value = "FILE")]
        FILE,

        [EnumMember(Value = "SHARE")]
        SHARE,

        [EnumMember(Value = "SYMLINK")]
        SYMLINK


    } // enum FileModeEnum

} // namespace RubrikSecurityCloud.Types