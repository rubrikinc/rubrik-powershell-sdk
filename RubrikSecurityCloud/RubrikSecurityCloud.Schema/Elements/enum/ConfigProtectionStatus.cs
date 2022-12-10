// ConfigProtectionStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:04.
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
    public enum ConfigProtectionStatus
    {
        [EnumMember(Value = "BACKUP_COMPLETED")]
        BACKUP_COMPLETED,

        [EnumMember(Value = "BACKUP_FAILED")]
        BACKUP_FAILED,

        [EnumMember(Value = "BACKUP_PARTIALLY_COMPLETED")]
        BACKUP_PARTIALLY_COMPLETED,

        [EnumMember(Value = "BACKUP_RUNNING")]
        BACKUP_RUNNING,

        [EnumMember(Value = "NOT_SETUP")]
        NOT_SETUP,

        [EnumMember(Value = "RESTORE_COMPLETED")]
        RESTORE_COMPLETED,

        [EnumMember(Value = "RESTORE_FAILED")]
        RESTORE_FAILED,

        [EnumMember(Value = "RESTORE_PARTIALLY_COMPLETED")]
        RESTORE_PARTIALLY_COMPLETED,

        [EnumMember(Value = "RESTORE_RUNNING")]
        RESTORE_RUNNING,

        [EnumMember(Value = "SETUP_COMPLETED")]
        SETUP_COMPLETED,

        [EnumMember(Value = "SETUP_FAILED")]
        SETUP_FAILED,

        [EnumMember(Value = "SETUP_RUNNING")]
        SETUP_RUNNING


    } // enum ConfigProtectionStatus

} // namespace Rubrik.SecurityCloud.Types