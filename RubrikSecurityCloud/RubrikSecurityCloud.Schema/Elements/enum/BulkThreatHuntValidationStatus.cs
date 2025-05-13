// BulkThreatHuntValidationStatus.cs
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
    public enum BulkThreatHuntValidationStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FAILURE_LIMIT_EXCEEDED_V1_HUNTS")]
        FAILURE_LIMIT_EXCEEDED_V1_HUNTS,

        [EnumMember(Value = "FAILURE_UNSPECIFIED")]
        FAILURE_UNSPECIFIED,

        [EnumMember(Value = "SUCCESS_AT_LEAST_ONE_V1_HUNT")]
        SUCCESS_AT_LEAST_ONE_V1_HUNT,

        [EnumMember(Value = "SUCCESS_ONLY_V2_HUNT")]
        SUCCESS_ONLY_V2_HUNT


    } // enum BulkThreatHuntValidationStatus

} // namespace RubrikSecurityCloud.Types