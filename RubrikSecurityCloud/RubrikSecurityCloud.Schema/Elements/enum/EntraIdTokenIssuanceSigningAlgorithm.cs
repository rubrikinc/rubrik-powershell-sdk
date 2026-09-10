// EntraIdTokenIssuanceSigningAlgorithm.cs
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
    public enum EntraIdTokenIssuanceSigningAlgorithm
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ENTRA_ID_TOKEN_ISSUANCE_SIGNING_ALGORITHM_RSA_SHA1")]
        ENTRA_ID_TOKEN_ISSUANCE_SIGNING_ALGORITHM_RSA_SHA1,

        [EnumMember(Value = "ENTRA_ID_TOKEN_ISSUANCE_SIGNING_ALGORITHM_RSA_SHA256")]
        ENTRA_ID_TOKEN_ISSUANCE_SIGNING_ALGORITHM_RSA_SHA256,

        [EnumMember(Value = "ENTRA_ID_TOKEN_ISSUANCE_SIGNING_ALGORITHM_UNKNOWN")]
        ENTRA_ID_TOKEN_ISSUANCE_SIGNING_ALGORITHM_UNKNOWN


    } // enum EntraIdTokenIssuanceSigningAlgorithm

} // namespace RubrikSecurityCloud.Types