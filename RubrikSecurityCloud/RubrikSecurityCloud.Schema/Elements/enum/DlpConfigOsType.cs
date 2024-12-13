// DlpConfigOsType.cs
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
    public enum DlpConfigOsType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "LINUX")]
        LINUX,

        [EnumMember(Value = "OS_TYPE_UNSPECIFIED")]
        OS_TYPE_UNSPECIFIED,

        [EnumMember(Value = "WINDOWS")]
        WINDOWS


    } // enum DlpConfigOsType

} // namespace RubrikSecurityCloud.Types