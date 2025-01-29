// ServiceAppStatus.cs
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
    public enum ServiceAppStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        [EnumMember(Value = "INACTIVE")]
        INACTIVE,

        [EnumMember(Value = "PENDING_ACTIVE")]
        PENDING_ACTIVE,

        [EnumMember(Value = "PENDING_INACTIVE")]
        PENDING_INACTIVE,

        [EnumMember(Value = "SERVICE_APP_STATUS_UNSPECIFIED")]
        SERVICE_APP_STATUS_UNSPECIFIED


    } // enum ServiceAppStatus

} // namespace RubrikSecurityCloud.Types