// ThreatHuntCsvGenerationStatus.cs
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
    public enum ThreatHuntCsvGenerationStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CSV_GENERATION_FAILED")]
        CSV_GENERATION_FAILED,

        [EnumMember(Value = "CSV_GENERATION_IN_PROGRESS")]
        CSV_GENERATION_IN_PROGRESS,

        [EnumMember(Value = "CSV_GENERATION_PENDING")]
        CSV_GENERATION_PENDING,

        [EnumMember(Value = "CSV_GENERATION_STATUS_UNKNOWN")]
        CSV_GENERATION_STATUS_UNKNOWN,

        [EnumMember(Value = "CSV_GENERATION_SUCCEEDED")]
        CSV_GENERATION_SUCCEEDED


    } // enum ThreatHuntCsvGenerationStatus

} // namespace RubrikSecurityCloud.Types