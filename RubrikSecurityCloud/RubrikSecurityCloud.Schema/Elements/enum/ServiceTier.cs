// ServiceTier.cs
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
    public enum ServiceTier
    {
        [EnumMember(Value = "BASIC")]
        BASIC,

        [EnumMember(Value = "BUSINESS_CRITICAL")]
        BUSINESS_CRITICAL,

        [EnumMember(Value = "GENERAL_PURPOSE")]
        GENERAL_PURPOSE,

        [EnumMember(Value = "HYPERSCALE")]
        HYPERSCALE,

        [EnumMember(Value = "PREMIUM")]
        PREMIUM,

        [EnumMember(Value = "STANDARD")]
        STANDARD


    } // enum ServiceTier

} // namespace RubrikSecurityCloud.Types