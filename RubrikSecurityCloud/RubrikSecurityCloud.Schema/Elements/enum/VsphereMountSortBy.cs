// VsphereMountSortBy.cs
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
        STATUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum VsphereMountSortBy

} // namespace RubrikSecurityCloud.Types