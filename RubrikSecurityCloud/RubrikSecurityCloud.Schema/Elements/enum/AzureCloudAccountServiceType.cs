// AzureCloudAccountServiceType.cs
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
    public enum AzureCloudAccountServiceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_CLOUD_ACCOUNT_SERVICE_TYPE_BAAS")]
        AZURE_CLOUD_ACCOUNT_SERVICE_TYPE_BAAS,

        [EnumMember(Value = "AZURE_CLOUD_ACCOUNT_SERVICE_TYPE_NON_BAAS")]
        AZURE_CLOUD_ACCOUNT_SERVICE_TYPE_NON_BAAS,

        [EnumMember(Value = "AZURE_CLOUD_ACCOUNT_SERVICE_TYPE_UNSPECIFIED")]
        AZURE_CLOUD_ACCOUNT_SERVICE_TYPE_UNSPECIFIED


    } // enum AzureCloudAccountServiceType

} // namespace RubrikSecurityCloud.Types