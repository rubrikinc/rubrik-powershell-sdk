// MssqlBackupType.cs
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
    public enum MssqlBackupType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MSSQL_BACKUP_TYPE_LOG")]
        MSSQL_BACKUP_TYPE_LOG,

        [EnumMember(Value = "MSSQL_BACKUP_TYPE_SNAPSHOT")]
        MSSQL_BACKUP_TYPE_SNAPSHOT


    } // enum MssqlBackupType

} // namespace RubrikSecurityCloud.Types