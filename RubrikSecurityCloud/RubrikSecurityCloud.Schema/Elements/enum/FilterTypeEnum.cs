// FilterTypeEnum.cs
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
    public enum FilterTypeEnum
    {
        [EnumMember(Value = "AUDIT_OBJECT_TYPE")]
        AUDIT_OBJECT_TYPE,

        [EnumMember(Value = "CLUSTER_FILTER")]
        CLUSTER_FILTER,

        [EnumMember(Value = "DATE_RANGE")]
        DATE_RANGE,

        [EnumMember(Value = "EVENT_OBJECT_TYPE")]
        EVENT_OBJECT_TYPE,

        [EnumMember(Value = "EVENT_TYPE")]
        EVENT_TYPE,

        [EnumMember(Value = "MULTI_SELECT")]
        MULTI_SELECT,

        [EnumMember(Value = "OBJECT_FID")]
        OBJECT_FID,

        [EnumMember(Value = "OBJECT_LOCATION")]
        OBJECT_LOCATION,

        [EnumMember(Value = "ORGANIZATION")]
        ORGANIZATION,

        [EnumMember(Value = "SEARCH")]
        SEARCH,

        [EnumMember(Value = "SINGLE_SELECT")]
        SINGLE_SELECT,

        [EnumMember(Value = "SLA_COMPLIANCE_RANGE")]
        SLA_COMPLIANCE_RANGE,

        [EnumMember(Value = "SLA_DOMAIN")]
        SLA_DOMAIN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum FilterTypeEnum

} // namespace RubrikSecurityCloud.Types