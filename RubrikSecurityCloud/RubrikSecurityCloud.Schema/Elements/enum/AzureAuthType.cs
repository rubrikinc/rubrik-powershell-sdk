// AzureAuthType.cs
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
    public enum AzureAuthType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_AUTH_TYPE_NON_OAUTH")]
        AZURE_AUTH_TYPE_NON_OAUTH,

        [EnumMember(Value = "AZURE_AUTH_TYPE_OAUTH_CUSTOMER_APP")]
        AZURE_AUTH_TYPE_OAUTH_CUSTOMER_APP,

        [EnumMember(Value = "AZURE_AUTH_TYPE_OAUTH_RUBRIK_APP")]
        AZURE_AUTH_TYPE_OAUTH_RUBRIK_APP,

        [EnumMember(Value = "AZURE_AUTH_TYPE_UNSPECIFIED")]
        AZURE_AUTH_TYPE_UNSPECIFIED


    } // enum AzureAuthType

} // namespace RubrikSecurityCloud.Types