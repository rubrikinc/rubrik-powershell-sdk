// SyslogFacility.cs
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
    public enum SyslogFacility
    {
        [EnumMember(Value = "SYSLOG_FACILITY_ALL")]
        SYSLOG_FACILITY_ALL,

        [EnumMember(Value = "SYSLOG_FACILITY_AUTH")]
        SYSLOG_FACILITY_AUTH,

        [EnumMember(Value = "SYSLOG_FACILITY_CLOCK")]
        SYSLOG_FACILITY_CLOCK,

        [EnumMember(Value = "SYSLOG_FACILITY_CRON")]
        SYSLOG_FACILITY_CRON,

        [EnumMember(Value = "SYSLOG_FACILITY_DAEMON")]
        SYSLOG_FACILITY_DAEMON,

        [EnumMember(Value = "SYSLOG_FACILITY_FTP")]
        SYSLOG_FACILITY_FTP,

        [EnumMember(Value = "SYSLOG_FACILITY_KERNEL")]
        SYSLOG_FACILITY_KERNEL,

        [EnumMember(Value = "SYSLOG_FACILITY_LOG_ALERT")]
        SYSLOG_FACILITY_LOG_ALERT,

        [EnumMember(Value = "SYSLOG_FACILITY_LOG_AUDIT")]
        SYSLOG_FACILITY_LOG_AUDIT,

        [EnumMember(Value = "SYSLOG_FACILITY_LPR")]
        SYSLOG_FACILITY_LPR,

        [EnumMember(Value = "SYSLOG_FACILITY_MAIL")]
        SYSLOG_FACILITY_MAIL,

        [EnumMember(Value = "SYSLOG_FACILITY_NEWS")]
        SYSLOG_FACILITY_NEWS,

        [EnumMember(Value = "SYSLOG_FACILITY_NTP")]
        SYSLOG_FACILITY_NTP,

        [EnumMember(Value = "SYSLOG_FACILITY_RUBRIK_APP")]
        SYSLOG_FACILITY_RUBRIK_APP,

        [EnumMember(Value = "SYSLOG_FACILITY_RUBRIK_CLI")]
        SYSLOG_FACILITY_RUBRIK_CLI,

        [EnumMember(Value = "SYSLOG_FACILITY_RUBRIK_EVENT")]
        SYSLOG_FACILITY_RUBRIK_EVENT,

        [EnumMember(Value = "SYSLOG_FACILITY_RUBRIK_SSH")]
        SYSLOG_FACILITY_RUBRIK_SSH,

        [EnumMember(Value = "SYSLOG_FACILITY_SECURITY")]
        SYSLOG_FACILITY_SECURITY,

        [EnumMember(Value = "SYSLOG_FACILITY_SYSLOG")]
        SYSLOG_FACILITY_SYSLOG,

        [EnumMember(Value = "SYSLOG_FACILITY_USER")]
        SYSLOG_FACILITY_USER,

        [EnumMember(Value = "SYSLOG_FACILITY_UUCP")]
        SYSLOG_FACILITY_UUCP


    } // enum SyslogFacility

} // namespace Rubrik.SecurityCloud.Types