// DevopsAuthMechanism.cs
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
    public enum DevopsAuthMechanism
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DEVOPS_AUTH_MECHANISM_NON_OAUTH")]
        DEVOPS_AUTH_MECHANISM_NON_OAUTH,

        [EnumMember(Value = "DEVOPS_AUTH_MECHANISM_OAUTH")]
        DEVOPS_AUTH_MECHANISM_OAUTH,

        [EnumMember(Value = "DEVOPS_AUTH_MECHANISM_UNSPECIFIED")]
        DEVOPS_AUTH_MECHANISM_UNSPECIFIED


    } // enum DevopsAuthMechanism

} // namespace RubrikSecurityCloud.Types