// BackupWindowType.cs
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
    public enum BackupWindowType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BACKUP_WINDOW_TYPE_FIRST_FULL")]
        BACKUP_WINDOW_TYPE_FIRST_FULL,

        [EnumMember(Value = "BACKUP_WINDOW_TYPE_REGULAR")]
        BACKUP_WINDOW_TYPE_REGULAR


    } // enum BackupWindowType

} // namespace RubrikSecurityCloud.Types