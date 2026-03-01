// MysqldbAuthenticationType.cs
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
    public enum MysqldbAuthenticationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MYSQLDB_AUTHENTICATION_TYPE_SOCKET_BASED")]
        MYSQLDB_AUTHENTICATION_TYPE_SOCKET_BASED,

        [EnumMember(Value = "MYSQLDB_AUTHENTICATION_TYPE_TCP_BASED")]
        MYSQLDB_AUTHENTICATION_TYPE_TCP_BASED


    } // enum MysqldbAuthenticationType

} // namespace RubrikSecurityCloud.Types