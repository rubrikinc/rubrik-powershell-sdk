// ArchivalGroupType.cs
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
    public enum ArchivalGroupType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AUTOMATIC_ARCHIVAL_GROUP")]
        AUTOMATIC_ARCHIVAL_GROUP,

        [EnumMember(Value = "CLOUD_NATIVE_ARCHIVAL_GROUP")]
        CLOUD_NATIVE_ARCHIVAL_GROUP,

        [EnumMember(Value = "DATACENTER_ARCHIVAL_GROUP")]
        DATACENTER_ARCHIVAL_GROUP,

        [EnumMember(Value = "MANUAL_ARCHIVAL_GROUP")]
        MANUAL_ARCHIVAL_GROUP,

        [EnumMember(Value = "UNKNOWN_ARCHIVAL_GROUP")]
        UNKNOWN_ARCHIVAL_GROUP


    } // enum ArchivalGroupType

} // namespace RubrikSecurityCloud.Types