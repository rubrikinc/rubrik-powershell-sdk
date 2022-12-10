// ProxyProtocol.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:21.
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
    public enum ProxyProtocol
    {
        [EnumMember(Value = "HTTP")]
        HTTP,

        [EnumMember(Value = "HTTPS")]
        HTTPS,

        [EnumMember(Value = "PROTOCOL_UNSPECIFIED")]
        PROTOCOL_UNSPECIFIED,

        [EnumMember(Value = "SOCKS5")]
        SOCK_S5


    } // enum ProxyProtocol

} // namespace Rubrik.SecurityCloud.Types