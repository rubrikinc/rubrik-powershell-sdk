// ManagedVolumeShareType.cs
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
    public enum ManagedVolumeShareType
    {
        [EnumMember(Value = "MANAGED_VOLUME_SHARE_TYPE_NFS")]
        MANAGED_VOLUME_SHARE_TYPE_NFS,

        [EnumMember(Value = "MANAGED_VOLUME_SHARE_TYPE_SMB")]
        MANAGED_VOLUME_SHARE_TYPE_SMB,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ManagedVolumeShareType

} // namespace RubrikSecurityCloud.Types