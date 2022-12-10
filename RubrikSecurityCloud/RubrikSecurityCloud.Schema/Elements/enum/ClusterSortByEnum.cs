// ClusterSortByEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:21.
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

} // namespace Rubrik.SecurityCloud.Types