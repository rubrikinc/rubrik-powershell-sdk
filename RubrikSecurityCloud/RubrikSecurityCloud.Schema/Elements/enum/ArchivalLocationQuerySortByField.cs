// ArchivalLocationQuerySortByField.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum ArchivalLocationQuerySortByField
    {
        [EnumMember(Value = "ARCHIVAL_GROUP_NAME")]
        ARCHIVAL_GROUP_NAME,

        [EnumMember(Value = "CLUSTER_NAME")]
        CLUSTER_NAME,

        [EnumMember(Value = "FAILED_TASKS")]
        FAILED_TASKS,

        [EnumMember(Value = "IMMUTABILITY_DAYS")]
        IMMUTABILITY_DAYS,

        [EnumMember(Value = "LOCATION_TYPE")]
        LOCATION_TYPE,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "RUNNING_TASKS")]
        RUNNING_TASKS,

        [EnumMember(Value = "STATUS")]
        STATUS,

        [EnumMember(Value = "STORAGE_CONSUMED_BYTES")]
        STORAGE_CONSUMED_BYTES


    } // enum ArchivalLocationQuerySortByField

} // namespace Rubrik.SecurityCloud.Types