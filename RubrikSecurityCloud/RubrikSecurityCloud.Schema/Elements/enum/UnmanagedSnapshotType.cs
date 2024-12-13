// UnmanagedSnapshotType.cs
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
    public enum UnmanagedSnapshotType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "UNMANAGED_SNAPSHOT_TYPE_ON_DEMAND")]
        UNMANAGED_SNAPSHOT_TYPE_ON_DEMAND,

        [EnumMember(Value = "UNMANAGED_SNAPSHOT_TYPE_POLICY_BASED")]
        UNMANAGED_SNAPSHOT_TYPE_POLICY_BASED,

        [EnumMember(Value = "UNMANAGED_SNAPSHOT_TYPE_RETRIEVED")]
        UNMANAGED_SNAPSHOT_TYPE_RETRIEVED


    } // enum UnmanagedSnapshotType

} // namespace RubrikSecurityCloud.Types