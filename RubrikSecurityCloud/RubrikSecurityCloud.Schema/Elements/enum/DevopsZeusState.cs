// DevopsZeusState.cs
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
    public enum DevopsZeusState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DEVOPS_ZEUS_NOT_REQUIRED")]
        DEVOPS_ZEUS_NOT_REQUIRED,

        [EnumMember(Value = "DEVOPS_ZEUS_PROVISIONED")]
        DEVOPS_ZEUS_PROVISIONED,

        [EnumMember(Value = "DEVOPS_ZEUS_REQUIRED")]
        DEVOPS_ZEUS_REQUIRED,

        [EnumMember(Value = "DEVOPS_ZEUS_STATE_UNSPECIFIED")]
        DEVOPS_ZEUS_STATE_UNSPECIFIED


    } // enum DevopsZeusState

} // namespace RubrikSecurityCloud.Types