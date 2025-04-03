// AdForestTransitionStatus.cs
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
    public enum AdForestTransitionStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLUSTER_UNSUPPORTED")]
        CLUSTER_UNSUPPORTED,

        [EnumMember(Value = "INTERNAL_ERROR")]
        INTERNAL_ERROR,

        [EnumMember(Value = "OK")]
        OK


    } // enum AdForestTransitionStatus

} // namespace RubrikSecurityCloud.Types