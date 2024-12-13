// MssqlDatabaseFileType.cs
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
    public enum MssqlDatabaseFileType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MSSQL_DATABASE_FILE_TYPE_DATA")]
        MSSQL_DATABASE_FILE_TYPE_DATA,

        [EnumMember(Value = "MSSQL_DATABASE_FILE_TYPE_FILESTREAM")]
        MSSQL_DATABASE_FILE_TYPE_FILESTREAM,

        [EnumMember(Value = "MSSQL_DATABASE_FILE_TYPE_LOG")]
        MSSQL_DATABASE_FILE_TYPE_LOG


    } // enum MssqlDatabaseFileType

} // namespace RubrikSecurityCloud.Types