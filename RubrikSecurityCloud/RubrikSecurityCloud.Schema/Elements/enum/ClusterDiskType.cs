// ClusterDiskType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:04.
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
    public enum ClusterDiskType
    {
        [EnumMember(Value = "FLASH")]
        FLASH,

        [EnumMember(Value = "HDD")]
        HDD,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ClusterDiskType

} // namespace Rubrik.SecurityCloud.Types