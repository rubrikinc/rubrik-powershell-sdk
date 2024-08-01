// LicenseCloudProvider.cs
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
    public enum LicenseCloudProvider
    {
        [EnumMember(Value = "CP_AWS")]
        CP_AWS,

        [EnumMember(Value = "CP_AZURE")]
        CP_AZURE,

        [EnumMember(Value = "CP_GCP")]
        CP_GCP,

        [EnumMember(Value = "CP_UNSPECIFIED")]
        CP_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum LicenseCloudProvider

} // namespace RubrikSecurityCloud.Types