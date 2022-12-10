// DiskEncryptionType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:26.
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
    public enum DiskEncryptionType
    {
        [EnumMember(Value = "CUSTOMER_MANAGED_KEY")]
        CUSTOMER_MANAGED_KEY,

        [EnumMember(Value = "CUSTOMER_MANAGED_KEY_RESOURCE_ID")]
        CUSTOMER_MANAGED_KEY_RESOURCE_ID,

        [EnumMember(Value = "GOOGLE_MANAGED_KEY")]
        GOOGLE_MANAGED_KEY,

        [EnumMember(Value = "SOURCE_DISK_ENCRYPTION")]
        SOURCE_DISK_ENCRYPTION


    } // enum DiskEncryptionType

} // namespace Rubrik.SecurityCloud.Types