// DtaProduct.cs
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
    public enum DtaProduct
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DTA_PRODUCT_ANOMALY_DETECTION")]
        DTA_PRODUCT_ANOMALY_DETECTION,

        [EnumMember(Value = "DTA_PRODUCT_THREAT_MONITORING")]
        DTA_PRODUCT_THREAT_MONITORING,

        [EnumMember(Value = "DTA_PRODUCT_UNSPECIFIED")]
        DTA_PRODUCT_UNSPECIFIED


    } // enum DtaProduct

} // namespace RubrikSecurityCloud.Types