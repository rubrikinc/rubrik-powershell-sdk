// BackupNodePreferenceStrategy.cs
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
    public enum BackupNodePreferenceStrategy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BACKUP_NODE_PREFERENCE_STRATEGY_ANY")]
        BACKUP_NODE_PREFERENCE_STRATEGY_ANY,

        [EnumMember(Value = "BACKUP_NODE_PREFERENCE_STRATEGY_PREFER_STANDBY")]
        BACKUP_NODE_PREFERENCE_STRATEGY_PREFER_STANDBY,

        [EnumMember(Value = "BACKUP_NODE_PREFERENCE_STRATEGY_PRIMARY_ONLY")]
        BACKUP_NODE_PREFERENCE_STRATEGY_PRIMARY_ONLY,

        [EnumMember(Value = "BACKUP_NODE_PREFERENCE_STRATEGY_STANDBY_ONLY")]
        BACKUP_NODE_PREFERENCE_STRATEGY_STANDBY_ONLY


    } // enum BackupNodePreferenceStrategy

} // namespace RubrikSecurityCloud.Types