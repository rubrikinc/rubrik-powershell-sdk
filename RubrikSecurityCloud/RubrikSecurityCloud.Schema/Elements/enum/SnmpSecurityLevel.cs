// SnmpSecurityLevel.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:49.
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
    public enum SnmpSecurityLevel
    {
        [EnumMember(Value = "SNMP_SECURITY_LEVEL_ENUM_AUTH_NO_PRIV")]
        SNMP_SECURITY_LEVEL_ENUM_AUTH_NO_PRIV,

        [EnumMember(Value = "SNMP_SECURITY_LEVEL_ENUM_AUTH_PRIV")]
        SNMP_SECURITY_LEVEL_ENUM_AUTH_PRIV,

        [EnumMember(Value = "SNMP_SECURITY_LEVEL_ENUM_NO_AUTH_NO_PRIV")]
        SNMP_SECURITY_LEVEL_ENUM_NO_AUTH_NO_PRIV


    } // enum SnmpSecurityLevel

} // namespace Rubrik.SecurityCloud.Types