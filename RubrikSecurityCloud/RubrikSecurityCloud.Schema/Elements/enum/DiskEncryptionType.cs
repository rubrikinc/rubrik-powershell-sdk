// DiskEncryptionType.cs
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
    public enum DiskEncryptionType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CUSTOMER_MANAGED_KEY")]
        CUSTOMER_MANAGED_KEY,

        [EnumMember(Value = "CUSTOMER_MANAGED_KEY_RESOURCE_ID")]
        CUSTOMER_MANAGED_KEY_RESOURCE_ID,

        [EnumMember(Value = "GOOGLE_MANAGED_KEY")]
        GOOGLE_MANAGED_KEY,

        [EnumMember(Value = "SOURCE_DISK_ENCRYPTION")]
        SOURCE_DISK_ENCRYPTION


    } // enum DiskEncryptionType

} // namespace RubrikSecurityCloud.Types