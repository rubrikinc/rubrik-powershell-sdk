// ExchangeBackupPreference.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum ExchangeBackupPreference
    {
        [EnumMember(Value = "EXCHANGE_BACKUP_PREFERENCE_PASSIVE_ONLY")]
        EXCHANGE_BACKUP_PREFERENCE_PASSIVE_ONLY,

        [EnumMember(Value = "EXCHANGE_BACKUP_PREFERENCE_PREFER_PASSIVE")]
        EXCHANGE_BACKUP_PREFERENCE_PREFER_PASSIVE


    } // enum ExchangeBackupPreference

} // namespace Rubrik.SecurityCloud.Types