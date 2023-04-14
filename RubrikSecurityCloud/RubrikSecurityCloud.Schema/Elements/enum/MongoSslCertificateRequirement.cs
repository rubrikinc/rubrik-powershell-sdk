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

namespace Rubrik.SecurityCloud.Types
{
    public enum MongoSslCertificateRequirement
    {
        [EnumMember(Value = "MONGO_SSL_CERTIFICATE_REQUIREMENT_NONE")]
        MONGO_SSL_CERTIFICATE_REQUIREMENT_NONE,

        [EnumMember(Value = "MONGO_SSL_CERTIFICATE_REQUIREMENT_OPTIONAL")]
        MONGO_SSL_CERTIFICATE_REQUIREMENT_OPTIONAL,

        [EnumMember(Value = "MONGO_SSL_CERTIFICATE_REQUIREMENT_REQUIRED")]
        MONGO_SSL_CERTIFICATE_REQUIREMENT_REQUIRED


    } // enum MongoSslCertificateRequirement

} // namespace Rubrik.SecurityCloud.Types