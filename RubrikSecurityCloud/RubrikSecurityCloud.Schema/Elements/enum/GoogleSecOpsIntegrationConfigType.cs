// GoogleSecOpsIntegrationConfigType.cs
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
    public enum GoogleSecOpsIntegrationConfigType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONFIG_TYPE_UNSPECIFIED")]
        CONFIG_TYPE_UNSPECIFIED,

        [EnumMember(Value = "SIEM")]
        SIEM,

        [EnumMember(Value = "SIEM_SOAR")]
        SIEM_SOAR,

        [EnumMember(Value = "SOAR")]
        SOAR


    } // enum GoogleSecOpsIntegrationConfigType

} // namespace RubrikSecurityCloud.Types