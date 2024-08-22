// InodeType.cs
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
    public enum InodeType
    {
        [EnumMember(Value = "DIRECTORY")]
        DIRECTORY,

        [EnumMember(Value = "FILE")]
        FILE,

        [EnumMember(Value = "UNKNOWN_INODE")]
        UNKNOWN_INODE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum InodeType

} // namespace RubrikSecurityCloud.Types