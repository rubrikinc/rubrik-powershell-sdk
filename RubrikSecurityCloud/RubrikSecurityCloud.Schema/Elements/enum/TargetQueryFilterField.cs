// TargetQueryFilterField.cs
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
    public enum TargetQueryFilterField
    {
        [EnumMember(Value = "ADDITIONAL_FIELDS_REQUIRED")]
        ADDITIONAL_FIELDS_REQUIRED,

        [EnumMember(Value = "ARCHIVAL_ENTITY_USE_CASE_TYPE")]
        ARCHIVAL_ENTITY_USE_CASE_TYPE,

        [EnumMember(Value = "CLUSTER_ID")]
        CLUSTER_ID,

        [EnumMember(Value = "EXCLUDE_CLOUD_NATIVE")]
        EXCLUDE_CLOUD_NATIVE,

        [EnumMember(Value = "GROUP_NAME")]
        GROUP_NAME,

        [EnumMember(Value = "IS_ARCHIVED")]
        IS_ARCHIVED,

        [EnumMember(Value = "IS_MANAGED_BY_AUTO_AG")]
        IS_MANAGED_BY_AUTO_AG,

        [EnumMember(Value = "LOCATION_ID")]
        LOCATION_ID,

        [EnumMember(Value = "LOCATION_REGION")]
        LOCATION_REGION,

        [EnumMember(Value = "LOCATION_SCOPE")]
        LOCATION_SCOPE,

        [EnumMember(Value = "LOCATION_TIER")]
        LOCATION_TIER,

        [EnumMember(Value = "LOCATION_TYPE")]
        LOCATION_TYPE,

        [EnumMember(Value = "LOC_NAME_OR_GROUP_NAME")]
        LOC_NAME_OR_GROUP_NAME,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "STATUS")]
        STATUS


    } // enum TargetQueryFilterField

} // namespace Rubrik.SecurityCloud.Types