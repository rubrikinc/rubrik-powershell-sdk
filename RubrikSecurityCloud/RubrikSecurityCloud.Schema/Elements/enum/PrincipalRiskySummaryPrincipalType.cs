// PrincipalRiskySummaryPrincipalType.cs
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
    public enum PrincipalRiskySummaryPrincipalType
    {
        [EnumMember(Value = "ACCESS_POLICY")]
        ACCESS_POLICY,

        [EnumMember(Value = "ASSUMABLE_IDENTITY")]
        ASSUMABLE_IDENTITY,

        [EnumMember(Value = "COMPUTER")]
        COMPUTER,

        [EnumMember(Value = "CONTACT")]
        CONTACT,

        [EnumMember(Value = "CONTAINER")]
        CONTAINER,

        [EnumMember(Value = "EXTERNAL_ACCOUNT")]
        EXTERNAL_ACCOUNT,

        [EnumMember(Value = "EXTERNAL_PRINCIPAL")]
        EXTERNAL_PRINCIPAL,

        [EnumMember(Value = "GPO")]
        GPO,

        [EnumMember(Value = "GROUP")]
        GROUP,

        [EnumMember(Value = "ORG_WIDE")]
        ORG_WIDE,

        [EnumMember(Value = "OU")]
        OU,

        [EnumMember(Value = "PUBLIC")]
        PUBLIC,

        [EnumMember(Value = "SERVICE_ACCOUNT")]
        SERVICE_ACCOUNT,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "USER")]
        USER


    } // enum PrincipalRiskySummaryPrincipalType

} // namespace RubrikSecurityCloud.Types