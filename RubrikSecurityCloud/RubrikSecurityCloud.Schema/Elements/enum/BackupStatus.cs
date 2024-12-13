// BackupStatus.cs
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
    public enum BackupStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BACKUP_UNKNOWN")]
        BACKUP_UNKNOWN,

        [EnumMember(Value = "NATIVELY_BACKED_UP")]
        NATIVELY_BACKED_UP,

        [EnumMember(Value = "NOT_BACKED_UP")]
        NOT_BACKED_UP,

        [EnumMember(Value = "RUBRIK_BACKED_UP")]
        RUBRIK_BACKED_UP


    } // enum BackupStatus

} // namespace RubrikSecurityCloud.Types