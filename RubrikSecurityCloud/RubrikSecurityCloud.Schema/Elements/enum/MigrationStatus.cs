// MigrationStatus.cs
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
    public enum MigrationStatus
    {
        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS,

        [EnumMember(Value = "MIGRATED")]
        MIGRATED,

        [EnumMember(Value = "NOT_MIGRATED")]
        NOT_MIGRATED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MigrationStatus

} // namespace RubrikSecurityCloud.Types