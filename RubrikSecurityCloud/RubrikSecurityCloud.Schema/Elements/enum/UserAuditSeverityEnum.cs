// UserAuditSeverityEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:01.
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
    public enum UserAuditSeverityEnum
    {
        [EnumMember(Value = "Critical")]
        CRITICAL,

        [EnumMember(Value = "Info")]
        INFO,

        [EnumMember(Value = "NA")]
        NA,

        [EnumMember(Value = "Warning")]
        WARNING


    } // enum UserAuditSeverityEnum

} // namespace Rubrik.SecurityCloud.Types