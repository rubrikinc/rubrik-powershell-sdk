// ClusterDiskMode.cs
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
    public enum ClusterDiskMode
    {
        [EnumMember(Value = "BOOT")]
        BOOT,

        [EnumMember(Value = "DATA")]
        DATA,

        [EnumMember(Value = "METADATA")]
        METADATA,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "UNPARTITIONED")]
        UNPARTITIONED


    } // enum ClusterDiskMode

} // namespace RubrikSecurityCloud.Types