// EntraIdTokenResponseSigningPolicy.cs
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
    public enum EntraIdTokenResponseSigningPolicy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ENTRA_ID_TOKEN_RESPONSE_SIGNING_POLICY_RESPONSE_AND_TOKEN")]
        ENTRA_ID_TOKEN_RESPONSE_SIGNING_POLICY_RESPONSE_AND_TOKEN,

        [EnumMember(Value = "ENTRA_ID_TOKEN_RESPONSE_SIGNING_POLICY_RESPONSE_ONLY")]
        ENTRA_ID_TOKEN_RESPONSE_SIGNING_POLICY_RESPONSE_ONLY,

        [EnumMember(Value = "ENTRA_ID_TOKEN_RESPONSE_SIGNING_POLICY_TOKEN_ONLY")]
        ENTRA_ID_TOKEN_RESPONSE_SIGNING_POLICY_TOKEN_ONLY,

        [EnumMember(Value = "ENTRA_ID_TOKEN_RESPONSE_SIGNING_POLICY_UNKNOWN")]
        ENTRA_ID_TOKEN_RESPONSE_SIGNING_POLICY_UNKNOWN


    } // enum EntraIdTokenResponseSigningPolicy

} // namespace RubrikSecurityCloud.Types