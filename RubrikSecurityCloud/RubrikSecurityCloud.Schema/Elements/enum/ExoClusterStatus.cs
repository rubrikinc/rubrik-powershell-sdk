// ExoClusterStatus.cs
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
    public enum ExoClusterStatus
    {
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        [EnumMember(Value = "SETUP_FAILED")]
        SETUP_FAILED,

        [EnumMember(Value = "SETUP_PENDING")]
        SETUP_PENDING,

        [EnumMember(Value = "SETUP_RUNNING")]
        SETUP_RUNNING,

        [EnumMember(Value = "TEARDOWN_FAILED")]
        TEARDOWN_FAILED,

        [EnumMember(Value = "TEARDOWN_PENDING")]
        TEARDOWN_PENDING,

        [EnumMember(Value = "TEARDOWN_RUNNING")]
        TEARDOWN_RUNNING,

        [EnumMember(Value = "TERMINATED")]
        TERMINATED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ExoClusterStatus

} // namespace RubrikSecurityCloud.Types