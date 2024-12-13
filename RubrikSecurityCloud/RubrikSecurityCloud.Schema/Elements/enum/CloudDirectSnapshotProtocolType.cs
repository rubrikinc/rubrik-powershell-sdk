// CloudDirectSnapshotProtocolType.cs
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
    public enum CloudDirectSnapshotProtocolType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NFS")]
        NFS,

        [EnumMember(Value = "NFS_SMB")]
        NFS_SMB,

        [EnumMember(Value = "PROTOCOL_UNSPECIFIED")]
        PROTOCOL_UNSPECIFIED,

        [EnumMember(Value = "SMB")]
        SMB


    } // enum CloudDirectSnapshotProtocolType

} // namespace RubrikSecurityCloud.Types