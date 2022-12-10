// InodeType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:30.
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
    public enum InodeType
    {
        [EnumMember(Value = "DIRECTORY")]
        DIRECTORY,

        [EnumMember(Value = "FILE")]
        FILE,

        [EnumMember(Value = "UNKNOWN_INODE")]
        UNKNOWN_INODE


    } // enum InodeType

} // namespace Rubrik.SecurityCloud.Types