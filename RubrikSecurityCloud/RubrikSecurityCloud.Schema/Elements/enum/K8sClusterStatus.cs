// K8sClusterStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:37.
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

} // namespace Rubrik.SecurityCloud.Types