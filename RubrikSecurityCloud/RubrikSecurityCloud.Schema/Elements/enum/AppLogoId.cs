// AppLogoId.cs
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
    public enum AppLogoId
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "APP_LOGO_ID_CONFLUENCE")]
        APP_LOGO_ID_CONFLUENCE,

        [EnumMember(Value = "APP_LOGO_ID_GOOGLE_WORKSPACE")]
        APP_LOGO_ID_GOOGLE_WORKSPACE,

        [EnumMember(Value = "APP_LOGO_ID_JIRA")]
        APP_LOGO_ID_JIRA,

        [EnumMember(Value = "APP_LOGO_ID_SALESFORCE")]
        APP_LOGO_ID_SALESFORCE,

        [EnumMember(Value = "APP_LOGO_ID_UNSPECIFIED")]
        APP_LOGO_ID_UNSPECIFIED


    } // enum AppLogoId

} // namespace RubrikSecurityCloud.Types