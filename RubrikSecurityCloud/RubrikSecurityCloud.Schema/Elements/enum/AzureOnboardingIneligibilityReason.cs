// AzureOnboardingIneligibilityReason.cs
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
    public enum AzureOnboardingIneligibilityReason
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_ONBOARDING_INELIGIBILITY_REASON_ALREADY_ONBOARDED")]
        AZURE_ONBOARDING_INELIGIBILITY_REASON_ALREADY_ONBOARDED,

        [EnumMember(Value = "AZURE_ONBOARDING_INELIGIBILITY_REASON_AUTH_TYPE_MISMATCH")]
        AZURE_ONBOARDING_INELIGIBILITY_REASON_AUTH_TYPE_MISMATCH,

        [EnumMember(Value = "AZURE_ONBOARDING_INELIGIBILITY_REASON_DIFFERENT_MANAGEMENT_GROUP")]
        AZURE_ONBOARDING_INELIGIBILITY_REASON_DIFFERENT_MANAGEMENT_GROUP,

        [EnumMember(Value = "AZURE_ONBOARDING_INELIGIBILITY_REASON_UNSPECIFIED")]
        AZURE_ONBOARDING_INELIGIBILITY_REASON_UNSPECIFIED


    } // enum AzureOnboardingIneligibilityReason

} // namespace RubrikSecurityCloud.Types