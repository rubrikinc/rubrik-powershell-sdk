// ArchiveFolderAction.cs
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
    public enum ArchiveFolderAction
    {
        [EnumMember(Value = "ARCHIVE_ONLY")]
        ARCHIVE_ONLY,

        [EnumMember(Value = "EXCLUDE_ARCHIVE")]
        EXCLUDE_ARCHIVE,

        [EnumMember(Value = "NO_ACTION")]
        NO_ACTION


    } // enum ArchiveFolderAction

} // namespace RubrikSecurityCloud.Types