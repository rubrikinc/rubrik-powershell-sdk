// CloudDirectCheckShareProtocolType.cs
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
    public enum CloudDirectCheckShareProtocolType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NFSV4_PROTOCOL")]
        NFSV4_PROTOCOL,

        [EnumMember(Value = "NFS_PROTOCOL")]
        NFS_PROTOCOL,

        [EnumMember(Value = "SMB_PROTOCOL")]
        SMB_PROTOCOL


    } // enum CloudDirectCheckShareProtocolType

} // namespace RubrikSecurityCloud.Types