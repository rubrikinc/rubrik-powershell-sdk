// BackupCopyType.cs
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
    public enum BackupCopyType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BACKUP_COPY_TYPE_UNSPECIFIED")]
        BACKUP_COPY_TYPE_UNSPECIFIED,

        [EnumMember(Value = "PRIMARY")]
        PRIMARY,

        [EnumMember(Value = "RECOVERED")]
        RECOVERED,

        [EnumMember(Value = "REPLICA")]
        REPLICA


    } // enum BackupCopyType

} // namespace RubrikSecurityCloud.Types