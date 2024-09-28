// TprPolicyScope.cs
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
    public enum TprPolicyScope
    {
        [EnumMember(Value = "DATA_MANAGEMENT_BY_CLUSTER")]
        DATA_MANAGEMENT_BY_CLUSTER,

        [EnumMember(Value = "DATA_MANAGEMENT_BY_OBJECT")]
        DATA_MANAGEMENT_BY_OBJECT,

        [EnumMember(Value = "DATA_MANAGEMENT_BY_SLA")]
        DATA_MANAGEMENT_BY_SLA,

        [EnumMember(Value = "INTERNAL")]
        INTERNAL,

        [EnumMember(Value = "SYSTEM_CONFIGURATION")]
        SYSTEM_CONFIGURATION,

        [EnumMember(Value = "TPR_POLICY_SCOPE_UNSPECIFIED")]
        TPR_POLICY_SCOPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TprPolicyScope

} // namespace RubrikSecurityCloud.Types