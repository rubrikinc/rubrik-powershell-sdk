// QueryVcdClusterRequestStatus.cs
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
    public enum QueryVcdClusterRequestStatus
    {
        [EnumMember(Value = "V1_QUERY_VCD_CLUSTER_V1_REQUEST_STATUS_BADLY_CONFIGURED")]
        V1_QUERY_VCD_CLUSTER_V1_REQUEST_STATUS_BADLY_CONFIGURED,

        [EnumMember(Value = "V1_QUERY_VCD_CLUSTER_V1_REQUEST_STATUS_CONNECTED")]
        V1_QUERY_VCD_CLUSTER_V1_REQUEST_STATUS_CONNECTED,

        [EnumMember(Value = "V1_QUERY_VCD_CLUSTER_V1_REQUEST_STATUS_DELETING")]
        V1_QUERY_VCD_CLUSTER_V1_REQUEST_STATUS_DELETING,

        [EnumMember(Value = "V1_QUERY_VCD_CLUSTER_V1_REQUEST_STATUS_DISCONNECTED")]
        V1_QUERY_VCD_CLUSTER_V1_REQUEST_STATUS_DISCONNECTED,

        [EnumMember(Value = "V1_QUERY_VCD_CLUSTER_V1_REQUEST_STATUS_REFRESHING")]
        V1_QUERY_VCD_CLUSTER_V1_REQUEST_STATUS_REFRESHING,

        [EnumMember(Value = "V1_QUERY_VCD_CLUSTER_V1_REQUEST_STATUS_REMOTE")]
        V1_QUERY_VCD_CLUSTER_V1_REQUEST_STATUS_REMOTE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum QueryVcdClusterRequestStatus

} // namespace RubrikSecurityCloud.Types