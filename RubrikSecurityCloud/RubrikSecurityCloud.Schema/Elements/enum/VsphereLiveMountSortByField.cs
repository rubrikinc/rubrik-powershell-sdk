// VsphereLiveMountSortByField.cs
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
    public enum VsphereLiveMountSortByField
    {
        [EnumMember(Value = "CLUSTER_NAME")]
        CLUSTER_NAME,

        [EnumMember(Value = "CREATION_DATE")]
        CREATION_DATE,

        [EnumMember(Value = "MOUNT_NAME")]
        MOUNT_NAME,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        [EnumMember(Value = "VM_STATUS")]
        VM_STATUS


    } // enum VsphereLiveMountSortByField

} // namespace RubrikSecurityCloud.Types