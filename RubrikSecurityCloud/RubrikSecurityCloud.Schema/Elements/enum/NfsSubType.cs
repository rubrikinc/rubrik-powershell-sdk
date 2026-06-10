// NfsSubType.cs
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
    public enum NfsSubType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NFS_DELL_DATA_DOMAIN")]
        NFS_DELL_DATA_DOMAIN,

        [EnumMember(Value = "NFS_ISILON")]
        NFS_ISILON,

        [EnumMember(Value = "NFS_TYPE_UNSPECIFIED")]
        NFS_TYPE_UNSPECIFIED,

        [EnumMember(Value = "NFS_VAST_DATA")]
        NFS_VAST_DATA


    } // enum NfsSubType

} // namespace RubrikSecurityCloud.Types