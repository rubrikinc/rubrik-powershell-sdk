// PowerPlatformFlowType.cs
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
    public enum PowerPlatformFlowType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AI_FLOW")]
        AI_FLOW,

        [EnumMember(Value = "BUSINESS_PROCESS")]
        BUSINESS_PROCESS,

        [EnumMember(Value = "BUSINESS_RULE")]
        BUSINESS_RULE,

        [EnumMember(Value = "CLASSIC_WORKFLOW")]
        CLASSIC_WORKFLOW,

        [EnumMember(Value = "CLOUD")]
        CLOUD,

        [EnumMember(Value = "CUSTOM_ACTION")]
        CUSTOM_ACTION,

        [EnumMember(Value = "DESKTOP")]
        DESKTOP,

        [EnumMember(Value = "DIALOG")]
        DIALOG


    } // enum PowerPlatformFlowType

} // namespace RubrikSecurityCloud.Types