// SapHanaOnDemandBackupConfigBackupType.cs
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
    public enum SapHanaOnDemandBackupConfigBackupType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SAP_HANA_ON_DEMAND_BACKUP_CONFIG_BACKUP_TYPE_DIFFERENTIAL")]
        SAP_HANA_ON_DEMAND_BACKUP_CONFIG_BACKUP_TYPE_DIFFERENTIAL,

        [EnumMember(Value = "SAP_HANA_ON_DEMAND_BACKUP_CONFIG_BACKUP_TYPE_FULL")]
        SAP_HANA_ON_DEMAND_BACKUP_CONFIG_BACKUP_TYPE_FULL,

        [EnumMember(Value = "SAP_HANA_ON_DEMAND_BACKUP_CONFIG_BACKUP_TYPE_INCREMENTAL")]
        SAP_HANA_ON_DEMAND_BACKUP_CONFIG_BACKUP_TYPE_INCREMENTAL


    } // enum SapHanaOnDemandBackupConfigBackupType

} // namespace RubrikSecurityCloud.Types