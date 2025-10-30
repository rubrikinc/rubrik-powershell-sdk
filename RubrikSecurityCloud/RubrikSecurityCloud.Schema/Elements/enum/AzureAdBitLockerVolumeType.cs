// AzureAdBitLockerVolumeType.cs
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
    public enum AzureAdBitLockerVolumeType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FIXED_DATA_VOLUME")]
        FIXED_DATA_VOLUME,

        [EnumMember(Value = "OPERATING_SYSTEM_VOLUME")]
        OPERATING_SYSTEM_VOLUME,

        [EnumMember(Value = "REMOVABLE_DATA_VOLUME")]
        REMOVABLE_DATA_VOLUME,

        [EnumMember(Value = "UNKNOWN_FUTURE_VALUE")]
        UNKNOWN_FUTURE_VALUE,

        [EnumMember(Value = "VOLUME_TYPE_UNKNOWN")]
        VOLUME_TYPE_UNKNOWN


    } // enum AzureAdBitLockerVolumeType

} // namespace RubrikSecurityCloud.Types