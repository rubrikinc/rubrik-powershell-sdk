// CertificateUsage.cs
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
    public enum CertificateUsage
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CERTIFICATE_USAGE_UNKNOWN")]
        CERTIFICATE_USAGE_UNKNOWN,

        [EnumMember(Value = "ON_PREM_SMTP")]
        ON_PREM_SMTP,

        [EnumMember(Value = "ON_PREM_TLS_CERT")]
        ON_PREM_TLS_CERT,

        [EnumMember(Value = "SSO_SP_ENCRYPTION")]
        SSO_SP_ENCRYPTION,

        [EnumMember(Value = "SSO_SP_SIGNING")]
        SSO_SP_SIGNING


    } // enum CertificateUsage

} // namespace RubrikSecurityCloud.Types