// IntegrationEnabledStatus.cs
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
    public enum IntegrationEnabledStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DISABLED")]
        DISABLED,

        [EnumMember(Value = "ENABLED")]
        ENABLED,

        [EnumMember(Value = "ENABLED_STATUS_UNSPECIFIED")]
        ENABLED_STATUS_UNSPECIFIED,

        [EnumMember(Value = "ENABLED_STATUS_UNSUPPORTED")]
        ENABLED_STATUS_UNSUPPORTED


    } // enum IntegrationEnabledStatus

} // namespace RubrikSecurityCloud.Types