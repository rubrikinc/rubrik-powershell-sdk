// ArchivalLocationStatus.cs
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
    public enum ArchivalLocationStatus
    {
        [EnumMember(Value = "DELETED")]
        DELETED,

        [EnumMember(Value = "DISABLED")]
        DISABLED,

        [EnumMember(Value = "PAUSED")]
        PAUSED,

        [EnumMember(Value = "READ_ONLY")]
        READ_ONLY,

        [EnumMember(Value = "READ_WRITE")]
        READ_WRITE,

        [EnumMember(Value = "UNKNOWN_ARCHIVAL_LOCATION_STATUS")]
        UNKNOWN_ARCHIVAL_LOCATION_STATUS


    } // enum ArchivalLocationStatus

} // namespace RubrikSecurityCloud.Types