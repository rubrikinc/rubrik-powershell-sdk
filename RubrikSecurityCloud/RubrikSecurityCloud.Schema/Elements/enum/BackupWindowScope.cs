// BackupWindowScope.cs
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
    public enum BackupWindowScope
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BACKUP_WINDOW_SCOPE_OBJECT_LEVEL")]
        BACKUP_WINDOW_SCOPE_OBJECT_LEVEL,

        [EnumMember(Value = "BACKUP_WINDOW_SCOPE_SLA_LEVEL")]
        BACKUP_WINDOW_SCOPE_SLA_LEVEL


    } // enum BackupWindowScope

} // namespace RubrikSecurityCloud.Types