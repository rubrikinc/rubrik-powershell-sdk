// RcvMigrationUpdateStatus.cs
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
    public enum RcvMigrationUpdateStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INVALID_INPUT")]
        INVALID_INPUT,

        [EnumMember(Value = "IN_PROGRESS_MIGRATION_NOT_FOUND")]
        IN_PROGRESS_MIGRATION_NOT_FOUND,

        [EnumMember(Value = "MIGRATION_UPDATE_STATUS_UNSPECIFIED")]
        MIGRATION_UPDATE_STATUS_UNSPECIFIED,

        [EnumMember(Value = "UPDATE_FAILURE")]
        UPDATE_FAILURE,

        [EnumMember(Value = "UPDATE_SUCCESSFUL")]
        UPDATE_SUCCESSFUL


    } // enum RcvMigrationUpdateStatus

} // namespace RubrikSecurityCloud.Types