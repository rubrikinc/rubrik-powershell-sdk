// AzureSqlEncryptionType.cs
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
    public enum AzureSqlEncryptionType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_SQL_ENCRYPTION_TYPE_UNSPECIFIED")]
        AZURE_SQL_ENCRYPTION_TYPE_UNSPECIFIED,

        [EnumMember(Value = "CUSTOMER_MANAGED_KEY")]
        CUSTOMER_MANAGED_KEY,

        [EnumMember(Value = "PLATFORM_MANAGED_KEY")]
        PLATFORM_MANAGED_KEY


    } // enum AzureSqlEncryptionType

} // namespace RubrikSecurityCloud.Types