// AwsNativeRdsDbEngine.cs
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
    public enum AwsNativeRdsDbEngine
    {
        [EnumMember(Value = "AURORA")]
        AURORA,

        [EnumMember(Value = "AURORA_MYSQL")]
        AURORA_MYSQL,

        [EnumMember(Value = "AURORA_POSTGRESQL")]
        AURORA_POSTGRESQL,

        [EnumMember(Value = "MARIADB")]
        MARIADB,

        [EnumMember(Value = "MYSQL")]
        MYSQL,

        [EnumMember(Value = "ORACLE_EE")]
        ORACLE_EE,

        [EnumMember(Value = "ORACLE_SE")]
        ORACLE_SE,

        [EnumMember(Value = "ORACLE_SE1")]
        ORACLE_SE1,

        [EnumMember(Value = "ORACLE_SE2")]
        ORACLE_SE2,

        [EnumMember(Value = "POSTGRES")]
        POSTGRES,

        [EnumMember(Value = "SQLSERVER_EE")]
        SQLSERVER_EE,

        [EnumMember(Value = "SQLSERVER_EX")]
        SQLSERVER_EX,

        [EnumMember(Value = "SQLSERVER_SE")]
        SQLSERVER_SE,

        [EnumMember(Value = "SQLSERVER_WEB")]
        SQLSERVER_WEB,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AwsNativeRdsDbEngine

} // namespace Rubrik.SecurityCloud.Types