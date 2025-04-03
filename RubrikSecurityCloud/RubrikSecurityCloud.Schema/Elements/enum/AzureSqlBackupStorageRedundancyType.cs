// AzureSqlBackupStorageRedundancyType.cs
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
    public enum AzureSqlBackupStorageRedundancyType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "GRS")]
        GRS,

        [EnumMember(Value = "LRS")]
        LRS,

        [EnumMember(Value = "UNKNOWN_AZURE_REDUNDANCY")]
        UNKNOWN_AZURE_REDUNDANCY,

        [EnumMember(Value = "ZRS")]
        ZRS


    } // enum AzureSqlBackupStorageRedundancyType

} // namespace RubrikSecurityCloud.Types