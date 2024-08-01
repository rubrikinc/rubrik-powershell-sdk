// MountStatusEnum.cs
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
    public enum MountStatusEnum
    {
        [EnumMember(Value = "MOUNTED")]
        MOUNTED,

        [EnumMember(Value = "MOUNTING")]
        MOUNTING,

        [EnumMember(Value = "MOUNT_FAILED")]
        MOUNT_FAILED,

        [EnumMember(Value = "MOUNT_STATUS_UNSPECIFIED")]
        MOUNT_STATUS_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MountStatusEnum

} // namespace RubrikSecurityCloud.Types