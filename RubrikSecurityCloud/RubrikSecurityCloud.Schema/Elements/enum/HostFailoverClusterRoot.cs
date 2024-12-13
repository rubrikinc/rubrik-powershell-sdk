// HostFailoverClusterRoot.cs
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
    public enum HostFailoverClusterRoot
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "LINUX_HOST_ROOT")]
        LINUX_HOST_ROOT,

        [EnumMember(Value = "WINDOWS_HOST_ROOT")]
        WINDOWS_HOST_ROOT


    } // enum HostFailoverClusterRoot

} // namespace RubrikSecurityCloud.Types