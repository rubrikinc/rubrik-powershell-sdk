// HostRoot.cs
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
    public enum HostRoot
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EXCHANGE_ROOT")]
        EXCHANGE_ROOT,

        [EnumMember(Value = "LINUX_HOST_ROOT")]
        LINUX_HOST_ROOT,

        [EnumMember(Value = "NAS_HOST_ROOT")]
        NAS_HOST_ROOT,

        [EnumMember(Value = "WINDOWS_HOST_ROOT")]
        WINDOWS_HOST_ROOT


    } // enum HostRoot

} // namespace RubrikSecurityCloud.Types