// FileTypeEnumType.cs
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
    public enum FileTypeEnumType
    {
        [EnumMember(Value = "ANOMALY_DETAILS_CSV")]
        ANOMALY_DETAILS_CSV,

        [EnumMember(Value = "CDM_API_METRICS_CSV")]
        CDM_API_METRICS_CSV,

        [EnumMember(Value = "REPORT")]
        REPORT,

        [EnumMember(Value = "SAAS_APPS")]
        SAAS_APPS,

        [EnumMember(Value = "THREAT_HUNT_RESULT_CSV")]
        THREAT_HUNT_RESULT_CSV,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum FileTypeEnumType

} // namespace RubrikSecurityCloud.Types