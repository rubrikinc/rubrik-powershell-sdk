// KerberosProtocolType.cs
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
    public enum KerberosProtocolType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "KERBEROS_PROTOCOL_NFS")]
        KERBEROS_PROTOCOL_NFS,

        [EnumMember(Value = "KERBEROS_PROTOCOL_NFS4")]
        KERBEROS_PROTOCOL_NFS4,

        [EnumMember(Value = "KERBEROS_PROTOCOL_SMB")]
        KERBEROS_PROTOCOL_SMB


    } // enum KerberosProtocolType

} // namespace RubrikSecurityCloud.Types