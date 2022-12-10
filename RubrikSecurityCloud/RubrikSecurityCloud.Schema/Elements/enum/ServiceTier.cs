// ServiceTier.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:16.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
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

} // namespace Rubrik.SecurityCloud.Types