// SapHanaSystemPatchBackupTriggerType.cs
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
    public enum SapHanaSystemPatchBackupTriggerType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SAP_HANA_SYSTEM_PATCH_BACKUP_TRIGGER_TYPE_CUSTOMER_MANAGED")]
        SAP_HANA_SYSTEM_PATCH_BACKUP_TRIGGER_TYPE_CUSTOMER_MANAGED,

        [EnumMember(Value = "SAP_HANA_SYSTEM_PATCH_BACKUP_TRIGGER_TYPE_RUBRIK")]
        SAP_HANA_SYSTEM_PATCH_BACKUP_TRIGGER_TYPE_RUBRIK


    } // enum SapHanaSystemPatchBackupTriggerType

} // namespace RubrikSecurityCloud.Types