// ArchivalGroupTieringStatus.cs
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
    public enum ArchivalGroupTieringStatus
    {
        [EnumMember(Value = "INSTANT_TIERING_NOT_SUPPORTED")]
        INSTANT_TIERING_NOT_SUPPORTED,

        [EnumMember(Value = "SMART_TIERING_NOT_SUPPORTED")]
        SMART_TIERING_NOT_SUPPORTED,

        [EnumMember(Value = "UNKNOWN_ARCHIVAL_GROUP_TIERING_STATUS")]
        UNKNOWN_ARCHIVAL_GROUP_TIERING_STATUS


    } // enum ArchivalGroupTieringStatus

} // namespace RubrikSecurityCloud.Types