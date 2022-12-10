// FileModeEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:19.
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
    public enum FileModeEnum
    {
        [EnumMember(Value = "DIRECTORY")]
        DIRECTORY,

        [EnumMember(Value = "FILE")]
        FILE,

        [EnumMember(Value = "SYMLINK")]
        SYMLINK


    } // enum FileModeEnum

} // namespace Rubrik.SecurityCloud.Types