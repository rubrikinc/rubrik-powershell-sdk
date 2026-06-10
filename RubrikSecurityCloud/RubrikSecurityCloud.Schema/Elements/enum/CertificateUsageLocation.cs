// CertificateUsageLocation.cs
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
    public enum CertificateUsageLocation
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CDM")]
        CDM,

        [EnumMember(Value = "CERTIFICATE_USAGE_LOCATION_UNSPECIFIED")]
        CERTIFICATE_USAGE_LOCATION_UNSPECIFIED,

        [EnumMember(Value = "RSC")]
        RSC


    } // enum CertificateUsageLocation

} // namespace RubrikSecurityCloud.Types