// CertificateTrustMode.cs
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
    public enum CertificateTrustMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CERTIFICATE_TRUST_MODE_CUSTOM")]
        CERTIFICATE_TRUST_MODE_CUSTOM,

        [EnumMember(Value = "CERTIFICATE_TRUST_MODE_DEFAULT")]
        CERTIFICATE_TRUST_MODE_DEFAULT,

        [EnumMember(Value = "CERTIFICATE_TRUST_MODE_TOFU")]
        CERTIFICATE_TRUST_MODE_TOFU


    } // enum CertificateTrustMode

} // namespace RubrikSecurityCloud.Types