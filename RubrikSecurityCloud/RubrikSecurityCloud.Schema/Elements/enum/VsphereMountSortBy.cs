// VsphereMountSortBy.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:08.
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
    public enum VsphereMountSortBy
    {
        [EnumMember(Value = "CLUSTER_NAME")]
        CLUSTER_NAME,

        [EnumMember(Value = "MOUNT_TIME")]
        MOUNT_TIME,

        [EnumMember(Value = "NEW_VM_NAME")]
        NEW_VM_NAME,

        [EnumMember(Value = "SOURCE_VM_NAME")]
        SOURCE_VM_NAME,

        [EnumMember(Value = "STATUS")]
        STATUS


    } // enum VsphereMountSortBy

} // namespace Rubrik.SecurityCloud.Types