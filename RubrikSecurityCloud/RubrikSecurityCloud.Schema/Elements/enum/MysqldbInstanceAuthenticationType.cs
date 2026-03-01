// MysqldbInstanceAuthenticationType.cs
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
    public enum MysqldbInstanceAuthenticationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AUTH_TYPE_UNSPECIFIED")]
        AUTH_TYPE_UNSPECIFIED,

        [EnumMember(Value = "SOCKET_BASED")]
        SOCKET_BASED,

        [EnumMember(Value = "TCP_BASED")]
        TCP_BASED


    } // enum MysqldbInstanceAuthenticationType

} // namespace RubrikSecurityCloud.Types