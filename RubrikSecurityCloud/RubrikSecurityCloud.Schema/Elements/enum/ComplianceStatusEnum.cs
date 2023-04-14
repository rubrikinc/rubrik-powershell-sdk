// ComplianceStatusEnum.cs
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
    public enum ComplianceStatusEnum
    {
        [EnumMember(Value = "EMPTY")]
        EMPTY,

        [EnumMember(Value = "IN_COMPLIANCE")]
        IN_COMPLIANCE,

        [EnumMember(Value = "NOT_APPLICABLE")]
        NOT_APPLICABLE,

        [EnumMember(Value = "NOT_AVAILABLE")]
        NOT_AVAILABLE,

        [EnumMember(Value = "NULL")]
        NULL,

        [EnumMember(Value = "OUT_OF_COMPLIANCE")]
        OUT_OF_COMPLIANCE,

        [EnumMember(Value = "UNPROTECTED")]
        UNPROTECTED


    } // enum ComplianceStatusEnum

} // namespace Rubrik.SecurityCloud.Types