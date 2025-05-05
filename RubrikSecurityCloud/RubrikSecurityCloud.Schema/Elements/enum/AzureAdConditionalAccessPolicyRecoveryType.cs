// AzureAdConditionalAccessPolicyRecoveryType.cs
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
    public enum AzureAdConditionalAccessPolicyRecoveryType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_AD_POLICY_RECOVERY_METHOD_UNKNOWN")]
        AZURE_AD_POLICY_RECOVERY_METHOD_UNKNOWN,

        [EnumMember(Value = "EXPORT")]
        EXPORT,

        [EnumMember(Value = "OVERWRITE")]
        OVERWRITE


    } // enum AzureAdConditionalAccessPolicyRecoveryType

} // namespace RubrikSecurityCloud.Types