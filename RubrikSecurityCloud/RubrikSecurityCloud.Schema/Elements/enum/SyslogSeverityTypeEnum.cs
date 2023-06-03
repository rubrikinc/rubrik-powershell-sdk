// SyslogSeverityTypeEnum.cs
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
    public enum SyslogSeverityTypeEnum
    {
        [EnumMember(Value = "ALL_SEVERITY")]
        ALL_SEVERITY,

        [EnumMember(Value = "CRITICAL")]
        CRITICAL,

        [EnumMember(Value = "INFORMATIONAL")]
        INFORMATIONAL,

        [EnumMember(Value = "WARNING")]
        WARNING


    } // enum SyslogSeverityTypeEnum

} // namespace Rubrik.SecurityCloud.Types