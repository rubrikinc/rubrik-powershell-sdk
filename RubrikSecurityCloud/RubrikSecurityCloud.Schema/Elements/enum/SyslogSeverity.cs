// SyslogSeverity.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:49.
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
    public enum SyslogSeverity
    {
        [EnumMember(Value = "SYSLOG_SEVERITY_ALERT")]
        SYSLOG_SEVERITY_ALERT,

        [EnumMember(Value = "SYSLOG_SEVERITY_ALL")]
        SYSLOG_SEVERITY_ALL,

        [EnumMember(Value = "SYSLOG_SEVERITY_CRITICAL")]
        SYSLOG_SEVERITY_CRITICAL,

        [EnumMember(Value = "SYSLOG_SEVERITY_DEBUG")]
        SYSLOG_SEVERITY_DEBUG,

        [EnumMember(Value = "SYSLOG_SEVERITY_EMERGENCY")]
        SYSLOG_SEVERITY_EMERGENCY,

        [EnumMember(Value = "SYSLOG_SEVERITY_ERROR")]
        SYSLOG_SEVERITY_ERROR,

        [EnumMember(Value = "SYSLOG_SEVERITY_INFORMATIONAL")]
        SYSLOG_SEVERITY_INFORMATIONAL,

        [EnumMember(Value = "SYSLOG_SEVERITY_NOTICE")]
        SYSLOG_SEVERITY_NOTICE,

        [EnumMember(Value = "SYSLOG_SEVERITY_WARNING")]
        SYSLOG_SEVERITY_WARNING


    } // enum SyslogSeverity

} // namespace Rubrik.SecurityCloud.Types