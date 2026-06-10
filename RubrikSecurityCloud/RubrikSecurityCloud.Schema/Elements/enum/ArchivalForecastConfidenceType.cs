// ArchivalForecastConfidenceType.cs
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
    public enum ArchivalForecastConfidenceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FORECAST_CONFIDENCE_HIGH")]
        FORECAST_CONFIDENCE_HIGH,

        [EnumMember(Value = "FORECAST_CONFIDENCE_LOW")]
        FORECAST_CONFIDENCE_LOW,

        [EnumMember(Value = "FORECAST_CONFIDENCE_MEDIUM")]
        FORECAST_CONFIDENCE_MEDIUM


    } // enum ArchivalForecastConfidenceType

} // namespace RubrikSecurityCloud.Types