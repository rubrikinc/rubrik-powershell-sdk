// SnapshotFileDownloadSnappableType.cs
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
    public enum SnapshotFileDownloadSnappableType
    {
        [EnumMember(Value = "FILESET")]
        FILESET,

        [EnumMember(Value = "HYPERV")]
        HYPERV,

        [EnumMember(Value = "NONE")]
        NONE,

        [EnumMember(Value = "NUTANIX")]
        NUTANIX,

        [EnumMember(Value = "VSPHERE")]
        VSPHERE,

        [EnumMember(Value = "WINDOWS_VOLUME_GROUP")]
        WINDOWS_VOLUME_GROUP,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SnapshotFileDownloadSnappableType

} // namespace RubrikSecurityCloud.Types