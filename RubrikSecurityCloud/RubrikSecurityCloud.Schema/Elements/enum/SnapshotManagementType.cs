// SnapshotManagementType.cs
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
    public enum SnapshotManagementType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CDM")]
        CDM,

        [EnumMember(Value = "CLOUD_DIRECT")]
        CLOUD_DIRECT,

        [EnumMember(Value = "CNP")]
        CNP,

        [EnumMember(Value = "SNAPSHOT_MANAGEMENT_UNKNOWN")]
        SNAPSHOT_MANAGEMENT_UNKNOWN


    } // enum SnapshotManagementType

} // namespace RubrikSecurityCloud.Types