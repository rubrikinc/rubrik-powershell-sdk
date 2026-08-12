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
        ARCHIVAL_MIGRATION_TERMINATED,

        [EnumMember(Value = "CDM_METADATA_PERSIST_FAILED")]
        CDM_METADATA_PERSIST_FAILED,

        [EnumMember(Value = "CDM_METADATA_PERSIST_IN_PROGRESS")]
        CDM_METADATA_PERSIST_IN_PROGRESS,

        [EnumMember(Value = "CDM_METADATA_PERSIST_SUCCESSFUL")]
        CDM_METADATA_PERSIST_SUCCESSFUL,

        [EnumMember(Value = "DATA_MOVER_ASSETS_CREATION_FAILED")]
        DATA_MOVER_ASSETS_CREATION_FAILED,

        [EnumMember(Value = "DATA_MOVER_ASSETS_CREATION_IN_PROGRESS")]
        DATA_MOVER_ASSETS_CREATION_IN_PROGRESS,

        [EnumMember(Value = "DATA_MOVER_ASSETS_CREATION_SUCCESSFUL")]
        DATA_MOVER_ASSETS_CREATION_SUCCESSFUL,

        [EnumMember(Value = "RCV_LOCATION_CREATION_FAILED")]
        RCV_LOCATION_CREATION_FAILED,

        [EnumMember(Value = "RCV_LOCATION_CREATION_IN_PROGRESS")]
        RCV_LOCATION_CREATION_IN_PROGRESS,

        [EnumMember(Value = "RCV_LOCATION_CREATION_SUCCESSFUL")]
        RCV_LOCATION_CREATION_SUCCESSFUL,

        [EnumMember(Value = "SLA_UPDATE_FAILED")]
        SLA_UPDATE_FAILED,

        [EnumMember(Value = "SLA_UPDATE_IN_PROGRESS")]
        SLA_UPDATE_IN_PROGRESS,

        [EnumMember(Value = "SLA_UPDATE_PENDING")]
        SLA_UPDATE_PENDING,

        [EnumMember(Value = "SLA_UPDATE_SUCCESS")]
        SLA_UPDATE_SUCCESS


    } // enum ArchivalMigrationStatus

} // namespace RubrikSecurityCloud.Types