// UserAuditSeverityEnum.cs
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
    public enum UserAuditSeverityEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "Critical")]
        CRITICAL,

        [EnumMember(Value = "Info")]
        INFO,

        [EnumMember(Value = "NA")]
        NA,

        [EnumMember(Value = "Warning")]
        WARNING


    } // enum UserAuditSeverityEnum

} // namespace RubrikSecurityCloud.Types