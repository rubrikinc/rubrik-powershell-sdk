// PendingActionSyncType.cs
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
    public enum PendingActionSyncType
    {
        [EnumMember(Value = "CDM")]
        CDM,

        [EnumMember(Value = "CLOUD_DIRECT")]
        CLOUD_DIRECT,

        [EnumMember(Value = "DERIVED")]
        DERIVED,

        [EnumMember(Value = "MOSAIC")]
        MOSAIC,

        [EnumMember(Value = "POLARIS")]
        POLARIS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum PendingActionSyncType

} // namespace RubrikSecurityCloud.Types