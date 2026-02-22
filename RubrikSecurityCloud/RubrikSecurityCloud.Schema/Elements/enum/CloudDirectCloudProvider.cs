// CloudDirectCloudProvider.cs
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
    public enum CloudDirectCloudProvider
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLOUD_DIRECT_CLOUD_PROVIDER_AWS")]
        CLOUD_DIRECT_CLOUD_PROVIDER_AWS,

        [EnumMember(Value = "CLOUD_DIRECT_CLOUD_PROVIDER_AZURE")]
        CLOUD_DIRECT_CLOUD_PROVIDER_AZURE,

        [EnumMember(Value = "CLOUD_DIRECT_CLOUD_PROVIDER_GCP")]
        CLOUD_DIRECT_CLOUD_PROVIDER_GCP


    } // enum CloudDirectCloudProvider

} // namespace RubrikSecurityCloud.Types