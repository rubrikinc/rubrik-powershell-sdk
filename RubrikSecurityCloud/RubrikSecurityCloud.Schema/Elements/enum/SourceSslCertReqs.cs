// SourceSslCertReqs.cs
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
    public enum SourceSslCertReqs
    {
        [EnumMember(Value = "SOURCE_SSL_CERT_REQS_NONE")]
        SOURCE_SSL_CERT_REQS_NONE,

        [EnumMember(Value = "SOURCE_SSL_CERT_REQS_OPTIONAL")]
        SOURCE_SSL_CERT_REQS_OPTIONAL,

        [EnumMember(Value = "SOURCE_SSL_CERT_REQS_REQUIRED")]
        SOURCE_SSL_CERT_REQS_REQUIRED


    } // enum SourceSslCertReqs

} // namespace RubrikSecurityCloud.Types