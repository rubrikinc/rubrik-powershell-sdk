// GlobalSlaQueryFilterInputField.cs
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
    public enum GlobalSlaQueryFilterInputField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ARCHIVAL_GROUP_ID")]
        ARCHIVAL_GROUP_ID,

        [EnumMember(Value = "ARCHIVAL_LOCATION_ID")]
        ARCHIVAL_LOCATION_ID,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "IS_ELIGIBLE_FOR_UPGRADE")]
        IS_ELIGIBLE_FOR_UPGRADE,

        [EnumMember(Value = "IS_READ_ONLY")]
        IS_READ_ONLY,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "OBJECT_TYPE")]
        OBJECT_TYPE,

        [EnumMember(Value = "ORG_ID_WITH_VIEW_ACCESS_ONLY")]
        ORG_ID_WITH_VIEW_ACCESS_ONLY,

        [EnumMember(Value = "OWNER_ORG_ID")]
        OWNER_ORG_ID,

        [EnumMember(Value = "SHOW_ALL_RUBRIK_AND_APPLIANCE_SLAS")]
        SHOW_ALL_RUBRIK_AND_APPLIANCE_SLAS,

        [EnumMember(Value = "SHOW_ASSIGNED_CLUSTER_SLAS_ONLY")]
        SHOW_ASSIGNED_CLUSTER_SLAS_ONLY,

        [EnumMember(Value = "SHOW_CLUSTER_SLAS_ONLY")]
        SHOW_CLUSTER_SLAS_ONLY,

        [EnumMember(Value = "UPGRADE_STATUS")]
        UPGRADE_STATUS


    } // enum GlobalSlaQueryFilterInputField

} // namespace RubrikSecurityCloud.Types