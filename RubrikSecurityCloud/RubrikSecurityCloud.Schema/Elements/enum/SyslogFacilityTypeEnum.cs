// SyslogFacilityTypeEnum.cs
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
    public enum SyslogFacilityTypeEnum
    {
        [EnumMember(Value = "ALL_SYSLOG")]
        ALL_SYSLOG,

        [EnumMember(Value = "AUTH")]
        AUTH,

        [EnumMember(Value = "RUBRIK_CLI")]
        RUBRIK_CLI,

        [EnumMember(Value = "RUBRIK_EVENT")]
        RUBRIK_EVENT,

        [EnumMember(Value = "RUBRIK_SSH")]
        RUBRIK_SSH,

        [EnumMember(Value = "SECURITY")]
        SECURITY,

        [EnumMember(Value = "SYSLOG")]
        SYSLOG


    } // enum SyslogFacilityTypeEnum

} // namespace Rubrik.SecurityCloud.Types