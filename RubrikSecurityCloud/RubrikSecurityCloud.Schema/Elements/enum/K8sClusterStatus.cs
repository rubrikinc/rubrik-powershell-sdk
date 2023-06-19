// K8sClusterStatus.cs
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
    public enum K8sClusterStatus
    {
        [EnumMember(Value = "STATUS_CONNECTED")]
        STATUS_CONNECTED,

        [EnumMember(Value = "STATUS_DISCONNECTED")]
        STATUS_DISCONNECTED,

        [EnumMember(Value = "STATUS_ERROR")]
        STATUS_ERROR,

        [EnumMember(Value = "STATUS_INIT")]
        STATUS_INIT,

        [EnumMember(Value = "STATUS_UNKNOWN")]
        STATUS_UNKNOWN


    } // enum K8sClusterStatus

} // namespace RubrikSecurityCloud.Types