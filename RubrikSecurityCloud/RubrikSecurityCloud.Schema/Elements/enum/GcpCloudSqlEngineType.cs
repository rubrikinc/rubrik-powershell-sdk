// GcpCloudSqlEngineType.cs
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
    public enum GcpCloudSqlEngineType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLOUD_SQL_ENGINE_UNSPECIFIED")]
        CLOUD_SQL_ENGINE_UNSPECIFIED,

        [EnumMember(Value = "CLOUD_SQL_MYSQL")]
        CLOUD_SQL_MYSQL,

        [EnumMember(Value = "CLOUD_SQL_POSTGRES")]
        CLOUD_SQL_POSTGRES,

        [EnumMember(Value = "CLOUD_SQL_SQLSERVER")]
        CLOUD_SQL_SQLSERVER


    } // enum GcpCloudSqlEngineType

} // namespace RubrikSecurityCloud.Types