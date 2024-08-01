// Platform.cs
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
    public enum Platform
    {
        [EnumMember(Value = "PLATFORM_AWS")]
        PLATFORM_AWS,

        [EnumMember(Value = "PLATFORM_AZURE")]
        PLATFORM_AZURE,

        [EnumMember(Value = "PLATFORM_DATA_CENTER")]
        PLATFORM_DATA_CENTER,

        [EnumMember(Value = "PLATFORM_GCP")]
        PLATFORM_GCP,

        [EnumMember(Value = "PLATFORM_GCP_WORKSPACE")]
        PLATFORM_GCP_WORKSPACE,

        [EnumMember(Value = "PLATFORM_M365")]
        PLATFORM_M365,

        [EnumMember(Value = "PLATFORM_SNOWFLAKE")]
        PLATFORM_SNOWFLAKE,

        [EnumMember(Value = "PLATFORM_UNSPECIFIED")]
        PLATFORM_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum Platform

} // namespace RubrikSecurityCloud.Types