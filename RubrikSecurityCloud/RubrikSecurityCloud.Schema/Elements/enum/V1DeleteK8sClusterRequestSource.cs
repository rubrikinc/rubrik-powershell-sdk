// V1DeleteK8sClusterRequestSource.cs
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
    public enum V1DeleteK8sClusterRequestSource
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "V1_DELETE_K8S_CLUSTER_REQUEST_SOURCE_HELM")]
        V1_DELETE_K8S_CLUSTER_REQUEST_SOURCE_HELM,

        [EnumMember(Value = "V1_DELETE_K8S_CLUSTER_REQUEST_SOURCE_UI")]
        V1_DELETE_K8S_CLUSTER_REQUEST_SOURCE_UI


    } // enum V1DeleteK8sClusterRequestSource

} // namespace RubrikSecurityCloud.Types