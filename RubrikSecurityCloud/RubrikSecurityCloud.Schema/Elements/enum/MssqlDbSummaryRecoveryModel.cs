// MssqlDbSummaryRecoveryModel.cs
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
    public enum MssqlDbSummaryRecoveryModel
    {
        [EnumMember(Value = "MSSQL_DB_SUMMARY_RECOVERY_MODEL_BULK_LOGGED")]
        MSSQL_DB_SUMMARY_RECOVERY_MODEL_BULK_LOGGED,

        [EnumMember(Value = "MSSQL_DB_SUMMARY_RECOVERY_MODEL_FULL")]
        MSSQL_DB_SUMMARY_RECOVERY_MODEL_FULL,

        [EnumMember(Value = "MSSQL_DB_SUMMARY_RECOVERY_MODEL_SIMPLE")]
        MSSQL_DB_SUMMARY_RECOVERY_MODEL_SIMPLE


    } // enum MssqlDbSummaryRecoveryModel

} // namespace Rubrik.SecurityCloud.Types