// CdmSnapshotFilterField.cs
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
    public enum CdmSnapshotFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "EMPTY")]
        EMPTY,

        [EnumMember(Value = "IS_EXPIRED")]
        IS_EXPIRED,

        [EnumMember(Value = "IS_ON_DEMAND_SNAPSHOT")]
        IS_ON_DEMAND_SNAPSHOT,

        [EnumMember(Value = "SNAPPABLE_ID")]
        SNAPPABLE_ID,

        [EnumMember(Value = "SNAPSHOT_ID")]
        SNAPSHOT_ID,

        [EnumMember(Value = "TIME_RANGE")]
        TIME_RANGE


    } // enum CdmSnapshotFilterField

} // namespace RubrikSecurityCloud.Types