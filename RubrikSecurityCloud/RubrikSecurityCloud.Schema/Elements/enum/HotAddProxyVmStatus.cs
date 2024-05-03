// HotAddProxyVmStatus.cs
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
    public enum HotAddProxyVmStatus
    {
        [EnumMember(Value = "EXPIRED")]
        EXPIRED,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "MAINTAINING")]
        MAINTAINING,

        [EnumMember(Value = "RUNNING")]
        RUNNING,

        [EnumMember(Value = "TO_BE_ACTIVATED")]
        TO_BE_ACTIVATED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum HotAddProxyVmStatus

} // namespace RubrikSecurityCloud.Types