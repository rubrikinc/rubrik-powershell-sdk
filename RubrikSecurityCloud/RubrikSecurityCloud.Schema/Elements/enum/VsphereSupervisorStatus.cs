// VsphereSupervisorStatus.cs
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
    public enum VsphereSupervisorStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONFIGURING")]
        CONFIGURING,

        [EnumMember(Value = "DEGRADED")]
        DEGRADED,

        [EnumMember(Value = "ERROR")]
        ERROR,

        [EnumMember(Value = "RUNNING")]
        RUNNING


    } // enum VsphereSupervisorStatus

} // namespace RubrikSecurityCloud.Types