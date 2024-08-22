// OperatingSystemType.cs
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
    public enum OperatingSystemType
    {
        [EnumMember(Value = "OPERATING_SYSTEM_TYPE_AIX")]
        OPERATING_SYSTEM_TYPE_AIX,

        [EnumMember(Value = "OPERATING_SYSTEM_TYPE_HPUX")]
        OPERATING_SYSTEM_TYPE_HPUX,

        [EnumMember(Value = "OPERATING_SYSTEM_TYPE_LINUX")]
        OPERATING_SYSTEM_TYPE_LINUX,

        [EnumMember(Value = "OPERATING_SYSTEM_TYPE_SUN_OS")]
        OPERATING_SYSTEM_TYPE_SUN_OS,

        [EnumMember(Value = "OPERATING_SYSTEM_TYPE_UNKNOWN")]
        OPERATING_SYSTEM_TYPE_UNKNOWN,

        [EnumMember(Value = "OPERATING_SYSTEM_TYPE_WINDOWS")]
        OPERATING_SYSTEM_TYPE_WINDOWS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum OperatingSystemType

} // namespace RubrikSecurityCloud.Types