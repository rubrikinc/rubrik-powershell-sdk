// SlaArchivalWarning.cs
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
    public enum SlaArchivalWarning
    {
        [EnumMember(Value = "ARCHIVAL_RETENTION_GREATER_THAN_IMMUTABILITY_DURATION_PROVIDED")]
        ARCHIVAL_RETENTION_GREATER_THAN_IMMUTABILITY_DURATION_PROVIDED,

        [EnumMember(Value = "NON_COMPLIANT_ARCHIVAL_RETENTION_FOR_TIER")]
        NON_COMPLIANT_ARCHIVAL_RETENTION_FOR_TIER,

        [EnumMember(Value = "NON_COMPLIANT_ARCHIVAL_RETENTION_PROVIDED")]
        NON_COMPLIANT_ARCHIVAL_RETENTION_PROVIDED,

        [EnumMember(Value = "NON_COMPLIANT_ARCHIVAL_RETENTION_WITHOUT_COMMON_RANGE_PROVIDED")]
        NON_COMPLIANT_ARCHIVAL_RETENTION_WITHOUT_COMMON_RANGE_PROVIDED,

        [EnumMember(Value = "NON_COMPLIANT_ARCHIVAL_RETENTION_WITH_COMMON_RANGE_PROVIDED")]
        NON_COMPLIANT_ARCHIVAL_RETENTION_WITH_COMMON_RANGE_PROVIDED,

        [EnumMember(Value = "NON_COMPLIANT_ARCHIVAL_TIERS")]
        NON_COMPLIANT_ARCHIVAL_TIERS,

        [EnumMember(Value = "NO_WARNINGS")]
        NO_WARNINGS,

        [EnumMember(Value = "SINGLE_FREQUENCY_ARCHIVAL_NOT_PROVIDED")]
        SINGLE_FREQUENCY_ARCHIVAL_NOT_PROVIDED


    } // enum SlaArchivalWarning

} // namespace RubrikSecurityCloud.Types