// ProvisionStatus.cs
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
    public enum ProvisionStatus
    {
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        [EnumMember(Value = "DELETED")]
        DELETED,

        [EnumMember(Value = "DELETING")]
        DELETING,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "REFRESHING")]
        REFRESHING,

        [EnumMember(Value = "UNHEALTHY")]
        UNHEALTHY


    } // enum ProvisionStatus

} // namespace RubrikSecurityCloud.Types