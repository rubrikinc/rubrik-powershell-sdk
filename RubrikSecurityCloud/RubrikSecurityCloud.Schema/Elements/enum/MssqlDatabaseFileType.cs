// MssqlDatabaseFileType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:47.
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
    public enum MssqlDatabaseFileType
    {
        [EnumMember(Value = "MSSQL_DATABASE_FILE_TYPE_DATA")]
        MSSQL_DATABASE_FILE_TYPE_DATA,

        [EnumMember(Value = "MSSQL_DATABASE_FILE_TYPE_FILESTREAM")]
        MSSQL_DATABASE_FILE_TYPE_FILESTREAM,

        [EnumMember(Value = "MSSQL_DATABASE_FILE_TYPE_LOG")]
        MSSQL_DATABASE_FILE_TYPE_LOG


    } // enum MssqlDatabaseFileType

} // namespace Rubrik.SecurityCloud.Types