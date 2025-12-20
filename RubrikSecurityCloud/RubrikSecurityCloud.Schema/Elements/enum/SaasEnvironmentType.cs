// SaasEnvironmentType.cs
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
    public enum SaasEnvironmentType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DEVELOPER")]
        DEVELOPER,

        [EnumMember(Value = "ENVIRONMENT_TYPE_UNSPECIFIED")]
        ENVIRONMENT_TYPE_UNSPECIFIED,

        [EnumMember(Value = "PRODUCTION")]
        PRODUCTION,

        [EnumMember(Value = "SANDBOX")]
        SANDBOX,

        [EnumMember(Value = "TRIAL")]
        TRIAL


    } // enum SaasEnvironmentType

} // namespace RubrikSecurityCloud.Types