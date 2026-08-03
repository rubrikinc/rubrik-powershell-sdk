// WebhookOauth2ClientAuthMethodV2.cs
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
    public enum WebhookOauth2ClientAuthMethodV2
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLIENT_SECRET_BASIC")]
        CLIENT_SECRET_BASIC,

        [EnumMember(Value = "CLIENT_SECRET_POST")]
        CLIENT_SECRET_POST,

        [EnumMember(Value = "OAUTH2_CLIENT_AUTH_METHOD_UNSPECIFIED")]
        OAUTH2_CLIENT_AUTH_METHOD_UNSPECIFIED


    } // enum WebhookOauth2ClientAuthMethodV2

} // namespace RubrikSecurityCloud.Types