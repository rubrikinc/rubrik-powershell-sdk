// HostRoot.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:33.
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
    public enum HostRoot
    {
        [EnumMember(Value = "EXCHANGE_ROOT")]
        EXCHANGE_ROOT,

        [EnumMember(Value = "LINUX_HOST_ROOT")]
        LINUX_HOST_ROOT,

        [EnumMember(Value = "NAS_HOST_ROOT")]
        NAS_HOST_ROOT,

        [EnumMember(Value = "WINDOWS_HOST_ROOT")]
        WINDOWS_HOST_ROOT


    } // enum HostRoot

} // namespace Rubrik.SecurityCloud.Types