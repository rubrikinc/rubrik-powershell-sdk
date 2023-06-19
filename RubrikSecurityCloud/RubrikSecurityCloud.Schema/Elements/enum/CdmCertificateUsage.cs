// CdmCertificateUsage.cs
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
    public enum CdmCertificateUsage
    {
        [EnumMember(Value = "AGENT")]
        AGENT,

        [EnumMember(Value = "KMIP_CLIENT")]
        KMIP_CLIENT,

        [EnumMember(Value = "KMIP_SERVER")]
        KMIP_SERVER,

        [EnumMember(Value = "LDAP")]
        LDAP,

        [EnumMember(Value = "RSA")]
        RSA,

        [EnumMember(Value = "SMTP")]
        SMTP,

        [EnumMember(Value = "SSO_ENC")]
        SSO_ENC,

        [EnumMember(Value = "SSO_SIGN")]
        SSO_SIGN,

        [EnumMember(Value = "SYSLOG")]
        SYSLOG,

        [EnumMember(Value = "USAGE_UNKNOWN")]
        USAGE_UNKNOWN,

        [EnumMember(Value = "WEB_SERVER")]
        WEB_SERVER


    } // enum CdmCertificateUsage

} // namespace RubrikSecurityCloud.Types