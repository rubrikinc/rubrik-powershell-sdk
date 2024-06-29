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
        [EnumMember(Value = "AWS_PLATFORM")]
        AWS_PLATFORM,

        [EnumMember(Value = "AZURE_PLATFORM")]
        AZURE_PLATFORM,

        [EnumMember(Value = "DATA_CENTRE_PLATFORM")]
        DATA_CENTRE_PLATFORM,

        [EnumMember(Value = "GCP_PLATFORM")]
        GCP_PLATFORM,

        [EnumMember(Value = "GCP_WORKSPACE_PLATFORM")]
        GCP_WORKSPACE_PLATFORM,

        [EnumMember(Value = "M365_PLATFORM")]
        M365_PLATFORM,

        [EnumMember(Value = "PLATFORM_UNSPECIFIED")]
        PLATFORM_UNSPECIFIED,

        [EnumMember(Value = "SNOWFLAKE_PLATFORM")]
        SNOWFLAKE_PLATFORM


    } // enum Platform

} // namespace RubrikSecurityCloud.Types