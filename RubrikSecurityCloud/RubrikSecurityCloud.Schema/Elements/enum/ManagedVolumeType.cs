// ManagedVolumeType.cs
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
    public enum ManagedVolumeType
    {
        [EnumMember(Value = "ALWAYS_MOUNTED")]
        ALWAYS_MOUNTED,

        [EnumMember(Value = "MANAGED_VOLUME_TYPE_UNSPECIFIED")]
        MANAGED_VOLUME_TYPE_UNSPECIFIED,

        [EnumMember(Value = "SLA_BASED")]
        SLA_BASED


    } // enum ManagedVolumeType

} // namespace RubrikSecurityCloud.Types