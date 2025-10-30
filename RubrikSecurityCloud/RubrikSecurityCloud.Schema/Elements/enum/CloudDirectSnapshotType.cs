// CloudDirectSnapshotType.cs
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
    public enum CloudDirectSnapshotType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ARCHIVE")]
        ARCHIVE,

        [EnumMember(Value = "BACKUP")]
        BACKUP,

        [EnumMember(Value = "ON_DEMAND_SNAPSHOT")]
        ON_DEMAND_SNAPSHOT,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum CloudDirectSnapshotType

} // namespace RubrikSecurityCloud.Types