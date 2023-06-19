// ClusterSortByEnum.cs
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
    public enum ClusterSortByEnum
    {
        [EnumMember(Value = "CLUSTER_LOCATION")]
        CLUSTER_LOCATION,

        [EnumMember(Value = "ClusterName")]
        CLUSTER_NAME,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "ESTIMATED_RUNWAY")]
        ESTIMATED_RUNWAY,

        [EnumMember(Value = "INSTALLED_VERSION")]
        INSTALLED_VERSION,

        [EnumMember(Value = "RegisteredAt")]
        REGISTERED_AT


    } // enum ClusterSortByEnum

} // namespace RubrikSecurityCloud.Types