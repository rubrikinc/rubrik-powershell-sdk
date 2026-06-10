// PolicyType.cs
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
    public enum PolicyType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "POLICY_TYPE_CROWDSTRIKE")]
        POLICY_TYPE_CROWDSTRIKE,

        [EnumMember(Value = "POLICY_TYPE_DATAGOV")]
        POLICY_TYPE_DATAGOV,

        [EnumMember(Value = "POLICY_TYPE_IDENTITY")]
        POLICY_TYPE_IDENTITY,

        [EnumMember(Value = "POLICY_TYPE_IDENTITY_EVENT")]
        POLICY_TYPE_IDENTITY_EVENT,

        [EnumMember(Value = "POLICY_TYPE_IDP")]
        POLICY_TYPE_IDP,

        [EnumMember(Value = "POLICY_TYPE_MICROSOFT_DEFENDER")]
        POLICY_TYPE_MICROSOFT_DEFENDER,

        [EnumMember(Value = "POLICY_TYPE_UNSPECIFIED")]
        POLICY_TYPE_UNSPECIFIED


    } // enum PolicyType

} // namespace RubrikSecurityCloud.Types