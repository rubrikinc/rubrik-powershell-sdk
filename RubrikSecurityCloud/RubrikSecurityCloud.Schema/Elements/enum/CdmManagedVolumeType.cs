// CdmManagedVolumeType.cs
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
    public enum CdmManagedVolumeType
    {
        [EnumMember(Value = "MANAGED_VOLUME_TYPE_ALWAYS_MOUNTED")]
        MANAGED_VOLUME_TYPE_ALWAYS_MOUNTED,

        [EnumMember(Value = "MANAGED_VOLUME_TYPE_SLA_BASED")]
        MANAGED_VOLUME_TYPE_SLA_BASED


    } // enum CdmManagedVolumeType

} // namespace RubrikSecurityCloud.Types