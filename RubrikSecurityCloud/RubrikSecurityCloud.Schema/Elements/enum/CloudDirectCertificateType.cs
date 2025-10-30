// CloudDirectCertificateType.cs
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
    public enum CloudDirectCertificateType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PEM")]
        PEM,

        [EnumMember(Value = "PKCS12")]
        PKC_S12


    } // enum CloudDirectCertificateType

} // namespace RubrikSecurityCloud.Types