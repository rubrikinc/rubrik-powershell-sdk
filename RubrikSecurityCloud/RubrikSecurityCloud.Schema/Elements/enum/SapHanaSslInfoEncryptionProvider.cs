// SapHanaSslInfoEncryptionProvider.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:39.
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
    public enum SapHanaSslInfoEncryptionProvider
    {
        [EnumMember(Value = "SAP_HANA_SSL_INFO_ENCRYPTION_PROVIDER_COMMON_CRYPTO")]
        SAP_HANA_SSL_INFO_ENCRYPTION_PROVIDER_COMMON_CRYPTO,

        [EnumMember(Value = "SAP_HANA_SSL_INFO_ENCRYPTION_PROVIDER_OPENSSL")]
        SAP_HANA_SSL_INFO_ENCRYPTION_PROVIDER_OPENSSL,

        [EnumMember(Value = "SAP_HANA_SSL_INFO_ENCRYPTION_PROVIDER_SAP_CRYPTO")]
        SAP_HANA_SSL_INFO_ENCRYPTION_PROVIDER_SAP_CRYPTO


    } // enum SapHanaSslInfoEncryptionProvider

} // namespace Rubrik.SecurityCloud.Types