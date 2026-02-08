// ReportObjectFilterField.cs
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
    public enum ReportObjectFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLUSTER_ID")]
        CLUSTER_ID,

        [EnumMember(Value = "IS_ACTIVE")]
        IS_ACTIVE,

        [EnumMember(Value = "IS_GHOST")]
        IS_GHOST,

        [EnumMember(Value = "K8S_CLUSTER_NAME")]
        K8S_CLUSTER_NAME,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "REPORT_CLUSTER_TYPE")]
        REPORT_CLUSTER_TYPE,

        [EnumMember(Value = "REPORT_OBJECT_TYPE")]
        REPORT_OBJECT_TYPE


    } // enum ReportObjectFilterField

} // namespace RubrikSecurityCloud.Types