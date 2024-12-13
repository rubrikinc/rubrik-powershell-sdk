// NfAnomalyResultSortBy.cs
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
    public enum NfAnomalyResultSortBy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "IS_ANOMALY")]
        IS_ANOMALY,

        [EnumMember(Value = "OBJECT_TYPE")]
        OBJECT_TYPE,

        [EnumMember(Value = "WORKLOAD_NAME")]
        WORKLOAD_NAME


    } // enum NfAnomalyResultSortBy

} // namespace RubrikSecurityCloud.Types