// VolumeGroupLiveMountFilterField.cs
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
    public enum VolumeGroupLiveMountFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "MOUNT_NAME")]
        MOUNT_NAME,

        [EnumMember(Value = "ORG_ID")]
        ORG_ID,

        [EnumMember(Value = "SOURCE_HOST_ID")]
        SOURCE_HOST_ID


    } // enum VolumeGroupLiveMountFilterField

} // namespace RubrikSecurityCloud.Types