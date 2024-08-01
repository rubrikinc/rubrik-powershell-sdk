// KmsType.cs
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
    public enum KmsType
    {
        [EnumMember(Value = "AZURE_KEY_VAULT")]
        AZURE_KEY_VAULT,

        [EnumMember(Value = "KMIP_SERVER")]
        KMIP_SERVER,

        [EnumMember(Value = "KMS_TYPE_UNSPECIFIED")]
        KMS_TYPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum KmsType

} // namespace RubrikSecurityCloud.Types