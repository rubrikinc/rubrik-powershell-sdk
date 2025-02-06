// DownloadSnapshotFromLocationSnappableType.cs
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
    public enum DownloadSnapshotFromLocationSnappableType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE_DIRECTORY")]
        ACTIVE_DIRECTORY,

        [EnumMember(Value = "K8S")]
        K8_S,

        [EnumMember(Value = "K8S_VM")]
        K8S_VM,

        [EnumMember(Value = "NONE")]
        NONE,

        [EnumMember(Value = "VCD")]
        VCD,

        [EnumMember(Value = "VSPHERE")]
        VSPHERE


    } // enum DownloadSnapshotFromLocationSnappableType

} // namespace RubrikSecurityCloud.Types