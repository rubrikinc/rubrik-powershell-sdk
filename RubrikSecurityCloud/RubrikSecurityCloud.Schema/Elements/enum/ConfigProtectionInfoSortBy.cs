// ConfigProtectionInfoSortBy.cs
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
    public enum ConfigProtectionInfoSortBy
    {
        [EnumMember(Value = "CLUSTER_NAME")]
        CLUSTER_NAME,

        [EnumMember(Value = "CONFIG_PROTECTION_STATUS")]
        CONFIG_PROTECTION_STATUS,

        [EnumMember(Value = "LAST_BACKUP_TIME")]
        LAST_BACKUP_TIME,

        [EnumMember(Value = "UPLOAD_LOCATION")]
        UPLOAD_LOCATION,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ConfigProtectionInfoSortBy

} // namespace RubrikSecurityCloud.Types