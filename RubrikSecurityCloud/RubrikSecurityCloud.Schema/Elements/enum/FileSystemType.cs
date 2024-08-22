// FileSystemType.cs
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
    public enum FileSystemType
    {
        [EnumMember(Value = "FILE_SYSTEM_TYPE_NTFS")]
        FILE_SYSTEM_TYPE_NTFS,

        [EnumMember(Value = "FILE_SYSTEM_TYPE_RE_FS")]
        FILE_SYSTEM_TYPE_RE_FS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum FileSystemType

} // namespace RubrikSecurityCloud.Types