// PolicyInsight.cs
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
    public enum PolicyInsight
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "POLICY_INSIGHT_KERBEROS_POLICY")]
        POLICY_INSIGHT_KERBEROS_POLICY,

        [EnumMember(Value = "POLICY_INSIGHT_UNSPECIFIED")]
        POLICY_INSIGHT_UNSPECIFIED


    } // enum PolicyInsight

} // namespace RubrikSecurityCloud.Types