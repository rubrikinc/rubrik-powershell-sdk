// BackupTriggerType.cs
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
    public enum BackupTriggerType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BACKUP_TRIGGER_TYPE_CUSTOMER_MANAGED")]
        BACKUP_TRIGGER_TYPE_CUSTOMER_MANAGED,

        [EnumMember(Value = "BACKUP_TRIGGER_TYPE_RUBRIK")]
        BACKUP_TRIGGER_TYPE_RUBRIK


    } // enum BackupTriggerType

} // namespace RubrikSecurityCloud.Types