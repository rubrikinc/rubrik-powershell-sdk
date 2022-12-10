// AzureSqlBackupStorageRedundancyType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:15.
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
    public enum AzureSqlBackupStorageRedundancyType
    {
        [EnumMember(Value = "GRS")]
        GRS,

        [EnumMember(Value = "LRS")]
        LRS,

        [EnumMember(Value = "ZRS")]
        ZRS


    } // enum AzureSqlBackupStorageRedundancyType

} // namespace Rubrik.SecurityCloud.Types