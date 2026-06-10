// Category.cs
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
    public enum Category
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AUTHENTICATION_AND_SECRET_MANAGEMENT")]
        AUTHENTICATION_AND_SECRET_MANAGEMENT,

        [EnumMember(Value = "CATEGORY_UNSPECIFIED")]
        CATEGORY_UNSPECIFIED,

        [EnumMember(Value = "CONFIGURATION_SECURITY")]
        CONFIGURATION_SECURITY,

        [EnumMember(Value = "EXCESSIVE_IDENTITY_RIGHTS")]
        EXCESSIVE_IDENTITY_RIGHTS,

        [EnumMember(Value = "GPO_CHANGE")]
        GPO_CHANGE,

        [EnumMember(Value = "IDENTITY_HYGIENE")]
        IDENTITY_HYGIENE,

        [EnumMember(Value = "IDENTITY_PROVIDER_SECURITY")]
        IDENTITY_PROVIDER_SECURITY,

        [EnumMember(Value = "IDENTITY_RISK")]
        IDENTITY_RISK,

        [EnumMember(Value = "INFRASTRUCTURE_SECURITY")]
        INFRASTRUCTURE_SECURITY,

        [EnumMember(Value = "MEMBERSHIP_CHANGE")]
        MEMBERSHIP_CHANGE,

        [EnumMember(Value = "MISPLACED")]
        MISPLACED,

        [EnumMember(Value = "OVEREXPOSED")]
        OVEREXPOSED,

        [EnumMember(Value = "PRIVILEGED_ACCOUNT_RISK")]
        PRIVILEGED_ACCOUNT_RISK,

        [EnumMember(Value = "REDUNDANT")]
        REDUNDANT,

        [EnumMember(Value = "UNPROTECTED")]
        UNPROTECTED


    } // enum Category

} // namespace RubrikSecurityCloud.Types