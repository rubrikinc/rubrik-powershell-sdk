// CdmReportMigrationStatus.cs
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
    public enum CdmReportMigrationStatus
    {
        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "PARTIAL_SUCCESS")]
        PARTIAL_SUCCESS,

        [EnumMember(Value = "READY")]
        READY,

        [EnumMember(Value = "SUCCESS")]
        SUCCESS,

        [EnumMember(Value = "UNAVAILABLE")]
        UNAVAILABLE,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum CdmReportMigrationStatus

} // namespace RubrikSecurityCloud.Types