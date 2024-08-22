// ManagedVolumeState.cs
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
    public enum ManagedVolumeState
    {
        [EnumMember(Value = "MANAGED_VOLUME_STATE_DESTROYED")]
        MANAGED_VOLUME_STATE_DESTROYED,

        [EnumMember(Value = "MANAGED_VOLUME_STATE_EXPORTED")]
        MANAGED_VOLUME_STATE_EXPORTED,

        [EnumMember(Value = "MANAGED_VOLUME_STATE_EXPORTING")]
        MANAGED_VOLUME_STATE_EXPORTING,

        [EnumMember(Value = "MANAGED_VOLUME_STATE_EXPORT_REQUESTED")]
        MANAGED_VOLUME_STATE_EXPORT_REQUESTED,

        [EnumMember(Value = "MANAGED_VOLUME_STATE_RESETTING")]
        MANAGED_VOLUME_STATE_RESETTING,

        [EnumMember(Value = "MANAGED_VOLUME_STATE_RESET_REQUESTED")]
        MANAGED_VOLUME_STATE_RESET_REQUESTED,

        [EnumMember(Value = "MANAGED_VOLUME_STATE_RESIZE_REQUESTED")]
        MANAGED_VOLUME_STATE_RESIZE_REQUESTED,

        [EnumMember(Value = "MANAGED_VOLUME_STATE_RESIZING")]
        MANAGED_VOLUME_STATE_RESIZING,

        [EnumMember(Value = "MANAGED_VOLUME_STATE_SNAPSHOTTING")]
        MANAGED_VOLUME_STATE_SNAPSHOTTING,

        [EnumMember(Value = "MANAGED_VOLUME_STATE_SNAPSHOT_REQUESTED")]
        MANAGED_VOLUME_STATE_SNAPSHOT_REQUESTED,

        [EnumMember(Value = "MANAGED_VOLUME_STATE_UNEXPORTING")]
        MANAGED_VOLUME_STATE_UNEXPORTING,

        [EnumMember(Value = "MANAGED_VOLUME_STATE_UNEXPORT_REQUESTED")]
        MANAGED_VOLUME_STATE_UNEXPORT_REQUESTED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ManagedVolumeState

} // namespace RubrikSecurityCloud.Types