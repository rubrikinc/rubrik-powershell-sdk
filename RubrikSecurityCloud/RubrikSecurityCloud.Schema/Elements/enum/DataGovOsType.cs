// DataGovOsType.cs
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
    public enum DataGovOsType
    {
        [EnumMember(Value = "LINUX")]
        LINUX,

        [EnumMember(Value = "NONE")]
        NONE,

        [EnumMember(Value = "WINDOWS")]
        WINDOWS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum DataGovOsType

} // namespace RubrikSecurityCloud.Types