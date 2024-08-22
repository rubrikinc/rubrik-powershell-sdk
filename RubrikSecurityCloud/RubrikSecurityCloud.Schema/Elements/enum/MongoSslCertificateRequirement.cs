// MongoSslCertificateRequirement.cs
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
    public enum MongoSslCertificateRequirement
    {
        [EnumMember(Value = "MONGO_SSL_CERTIFICATE_REQUIREMENT_NONE")]
        MONGO_SSL_CERTIFICATE_REQUIREMENT_NONE,

        [EnumMember(Value = "MONGO_SSL_CERTIFICATE_REQUIREMENT_OPTIONAL")]
        MONGO_SSL_CERTIFICATE_REQUIREMENT_OPTIONAL,

        [EnumMember(Value = "MONGO_SSL_CERTIFICATE_REQUIREMENT_REQUIRED")]
        MONGO_SSL_CERTIFICATE_REQUIREMENT_REQUIRED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MongoSslCertificateRequirement

} // namespace RubrikSecurityCloud.Types