// RcsConsumptionMetricOutputNameType.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum RcsConsumptionMetricOutputNameType
    {
        [EnumMember(Value = "BLOB_CAPACITY")]
        BLOB_CAPACITY,

        [EnumMember(Value = "EGRESS")]
        EGRESS,

        [EnumMember(Value = "FORECASTED_BLOB_CAPACITY")]
        FORECASTED_BLOB_CAPACITY,

        [EnumMember(Value = "INGRESS")]
        INGRESS


    } // enum RcsConsumptionMetricOutputNameType

} // namespace Rubrik.SecurityCloud.Types