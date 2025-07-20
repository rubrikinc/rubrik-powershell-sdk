// CloudDirectNetworkOverrideProtocol.cs
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
    public enum CloudDirectNetworkOverrideProtocol
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NFS")]
        NFS,

        [EnumMember(Value = "NFS_V4")]
        NFS_V4,

        [EnumMember(Value = "S3")]
        S3,

        [EnumMember(Value = "SMB")]
        SMB


    } // enum CloudDirectNetworkOverrideProtocol

} // namespace RubrikSecurityCloud.Types