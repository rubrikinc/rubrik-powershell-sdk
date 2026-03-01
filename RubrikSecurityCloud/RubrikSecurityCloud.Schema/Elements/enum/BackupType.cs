// BackupType.cs
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
    public enum BackupType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NATIVE")]
        NATIVE,

        [EnumMember(Value = "RUBRIK")]
        RUBRIK,

        [EnumMember(Value = "UNKNOWN_BACKUP_TYPE")]
        UNKNOWN_BACKUP_TYPE


    } // enum BackupType

} // namespace RubrikSecurityCloud.Types