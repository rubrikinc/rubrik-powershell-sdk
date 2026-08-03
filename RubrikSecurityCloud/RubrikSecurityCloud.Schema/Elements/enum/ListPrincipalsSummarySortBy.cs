// ListPrincipalsSummarySortBy.cs
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
    public enum ListPrincipalsSummarySortBy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CREATION_TIME")]
        CREATION_TIME,

        [EnumMember(Value = "ENTITY_NAME")]
        ENTITY_NAME,

        [EnumMember(Value = "IDENTITY_PROVIDER_TYPE")]
        IDENTITY_PROVIDER_TYPE,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "ORIGIN")]
        ORIGIN,

        [EnumMember(Value = "PRINCIPAL_TYPE")]
        PRINCIPAL_TYPE,

        [EnumMember(Value = "RISK_LEVEL")]
        RISK_LEVEL,

        [EnumMember(Value = "RISK_SENSITIVE_FILES")]
        RISK_SENSITIVE_FILES,

        [EnumMember(Value = "RISK_SENSITIVE_HITS")]
        RISK_SENSITIVE_HITS,

        [EnumMember(Value = "RISK_TOTAL_SENSITIVE_HITS")]
        RISK_TOTAL_SENSITIVE_HITS,

        [EnumMember(Value = "SID")]
        SID,

        [EnumMember(Value = "TITLE")]
        TITLE,

        [EnumMember(Value = "TOTAL_SENSITIVE_FILES")]
        TOTAL_SENSITIVE_FILES,

        [EnumMember(Value = "TOTAL_SENSITIVE_HITS")]
        TOTAL_SENSITIVE_HITS,

        [EnumMember(Value = "TOTAL_SENSITIVE_OBJECTS")]
        TOTAL_SENSITIVE_OBJECTS,

        [EnumMember(Value = "UNIQUE_IDENTIFIER")]
        UNIQUE_IDENTIFIER,

        [EnumMember(Value = "VIOLATIONS")]
        VIOLATIONS


    } // enum ListPrincipalsSummarySortBy

} // namespace RubrikSecurityCloud.Types