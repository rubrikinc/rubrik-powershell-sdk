// AzureNativeResourceEncryptionType.cs
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
    public enum AzureNativeResourceEncryptionType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_NATIVE_RESOURCE_ENCRYPTION_TYPE_UNSPECIFIED")]
        AZURE_NATIVE_RESOURCE_ENCRYPTION_TYPE_UNSPECIFIED,

        [EnumMember(Value = "CUSTOMER_MANAGED_KEY_ENCRYPTION")]
        CUSTOMER_MANAGED_KEY_ENCRYPTION,

        [EnumMember(Value = "PLATFORM_MANAGED_KEY_ENCRYPTION")]
        PLATFORM_MANAGED_KEY_ENCRYPTION


    } // enum AzureNativeResourceEncryptionType

} // namespace RubrikSecurityCloud.Types