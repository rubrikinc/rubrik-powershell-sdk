// AzureSqlDbBackupSetupStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:15.
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
    public enum AzureSqlDbBackupSetupStatus
    {
        [EnumMember(Value = "CDC_DISABLED")]
        CDC_DISABLED,

        [EnumMember(Value = "CDC_INVALID_CONFIG")]
        CDC_INVALID_CONFIG,

        [EnumMember(Value = "ENCRYPTED_OBJECTS_EXIST")]
        ENCRYPTED_OBJECTS_EXIST,

        [EnumMember(Value = "INVALID_CREDENTIALS")]
        INVALID_CREDENTIALS,

        [EnumMember(Value = "LEDGER_TABLES_EXIST")]
        LEDGER_TABLES_EXIST,

        [EnumMember(Value = "MISSING_PERMISSIONS")]
        MISSING_PERMISSIONS,

        [EnumMember(Value = "NOT_SPECIFIED")]
        NOT_SPECIFIED,

        [EnumMember(Value = "SUCCESS")]
        SUCCESS,

        [EnumMember(Value = "TEMPORAL_TABLES_EXIST")]
        TEMPORAL_TABLES_EXIST,

        [EnumMember(Value = "UNSUPPORTED_COLLATION_CONFIG")]
        UNSUPPORTED_COLLATION_CONFIG


    } // enum AzureSqlDbBackupSetupStatus

} // namespace Rubrik.SecurityCloud.Types