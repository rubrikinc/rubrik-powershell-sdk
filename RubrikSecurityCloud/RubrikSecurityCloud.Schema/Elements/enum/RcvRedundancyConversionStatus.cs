// RcvRedundancyConversionStatus.cs
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
    public enum RcvRedundancyConversionStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONVERSION_IN_PROGRESS")]
        CONVERSION_IN_PROGRESS,

        [EnumMember(Value = "CONVERSION_STATUS_UNSPECIFIED")]
        CONVERSION_STATUS_UNSPECIFIED,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "INTERMEDIATE_FAILED")]
        INTERMEDIATE_FAILED,

        [EnumMember(Value = "SUBMITTED")]
        SUBMITTED,

        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED


    } // enum RcvRedundancyConversionStatus

} // namespace RubrikSecurityCloud.Types