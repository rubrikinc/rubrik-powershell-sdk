// CdmManagedVolumeType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:29.
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
    public enum CdmManagedVolumeType
    {
        [EnumMember(Value = "MANAGED_VOLUME_TYPE_ALWAYS_MOUNTED")]
        MANAGED_VOLUME_TYPE_ALWAYS_MOUNTED,

        [EnumMember(Value = "MANAGED_VOLUME_TYPE_SLA_BASED")]
        MANAGED_VOLUME_TYPE_SLA_BASED


    } // enum CdmManagedVolumeType

} // namespace Rubrik.SecurityCloud.Types