// RcvConversionEnumType.cs
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
    public enum RcvConversionEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "RCV_CONVERSION_UNSPECIFIED")]
        RCV_CONVERSION_UNSPECIFIED,

        [EnumMember(Value = "RCV_REDUNDANCY_CONVERSION")]
        RCV_REDUNDANCY_CONVERSION,

        [EnumMember(Value = "RCV_TIER_CONVERSION")]
        RCV_TIER_CONVERSION


    } // enum RcvConversionEnumType

} // namespace RubrikSecurityCloud.Types