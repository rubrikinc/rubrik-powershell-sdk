// BliMigrationStatus.cs
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
    public enum BliMigrationStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BLI_MIGRATION_FAILED")]
        BLI_MIGRATION_FAILED,

        [EnumMember(Value = "BLI_MIGRATION_IN_PROGRESS")]
        BLI_MIGRATION_IN_PROGRESS,

        [EnumMember(Value = "BLI_MIGRATION_QUEUED")]
        BLI_MIGRATION_QUEUED,

        [EnumMember(Value = "BLI_MIGRATION_SUCCESS")]
        BLI_MIGRATION_SUCCESS,

        [EnumMember(Value = "LOCATION_NEEDS_REVIEW")]
        LOCATION_NEEDS_REVIEW,

        [EnumMember(Value = "LOCATION_READY_TO_CONVERT")]
        LOCATION_READY_TO_CONVERT,

        [EnumMember(Value = "MIGRATION_STATUS_UNSPECIFIED")]
        MIGRATION_STATUS_UNSPECIFIED


    } // enum BliMigrationStatus

} // namespace RubrikSecurityCloud.Types