// SapHanaSslInfoEncryptionProvider.cs
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
    public enum SapHanaSslInfoEncryptionProvider
    {
        [EnumMember(Value = "SAP_HANA_SSL_INFO_ENCRYPTION_PROVIDER_COMMON_CRYPTO")]
        SAP_HANA_SSL_INFO_ENCRYPTION_PROVIDER_COMMON_CRYPTO,

        [EnumMember(Value = "SAP_HANA_SSL_INFO_ENCRYPTION_PROVIDER_OPENSSL")]
        SAP_HANA_SSL_INFO_ENCRYPTION_PROVIDER_OPENSSL,

        [EnumMember(Value = "SAP_HANA_SSL_INFO_ENCRYPTION_PROVIDER_SAP_CRYPTO")]
        SAP_HANA_SSL_INFO_ENCRYPTION_PROVIDER_SAP_CRYPTO,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SapHanaSslInfoEncryptionProvider

} // namespace RubrikSecurityCloud.Types