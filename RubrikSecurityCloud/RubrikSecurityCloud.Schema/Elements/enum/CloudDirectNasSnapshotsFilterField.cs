// CloudDirectNasSnapshotsFilterField.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum CloudDirectNasSnapshotsFilterField
    {
        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "FID")]
        FID,

        [EnumMember(Value = "SNAPPABLE_ID")]
        SNAPPABLE_ID,

        [EnumMember(Value = "STATE")]
        STATE,

        [EnumMember(Value = "TYPE")]
        TYPE,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum CloudDirectNasSnapshotsFilterField

} // namespace Rubrik.SecurityCloud.Types