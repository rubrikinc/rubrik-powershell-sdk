// AzureAdConditionalAccessPolicyStateEnumType.cs
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
    public enum AzureAdConditionalAccessPolicyStateEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_AD_POLICY_STATE_UNKNOWN")]
        AZURE_AD_POLICY_STATE_UNKNOWN,

        [EnumMember(Value = "OFF")]
        OFF,

        [EnumMember(Value = "ON")]
        ON,

        [EnumMember(Value = "REPORT_ONLY")]
        REPORT_ONLY


    } // enum AzureAdConditionalAccessPolicyStateEnumType

} // namespace RubrikSecurityCloud.Types