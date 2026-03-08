// ArchivalMigrationStatus.cs
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
    public enum ArchivalMigrationStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ARCHIVAL_MIGRATION_DATA_COPY_PENDING")]
        ARCHIVAL_MIGRATION_DATA_COPY_PENDING,

        [EnumMember(Value = "ARCHIVAL_MIGRATION_SUCCESSFUL")]
        ARCHIVAL_MIGRATION_SUCCESSFUL,

        [EnumMember(Value = "ARCHIVAL_MIGRATION_TERMINATED")]
        ARCHIVAL_MIGRATION_TERMINATED


    } // enum ArchivalMigrationStatus

} // namespace RubrikSecurityCloud.Types