// LambdaEventActionType.cs
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
    public enum LambdaEventActionType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EVENT_ACTION_TYPE_ATTRIBUTE_CHANGE")]
        EVENT_ACTION_TYPE_ATTRIBUTE_CHANGE,

        [EnumMember(Value = "EVENT_ACTION_TYPE_AUTHENTICATION")]
        EVENT_ACTION_TYPE_AUTHENTICATION,

        [EnumMember(Value = "EVENT_ACTION_TYPE_BASELINE")]
        EVENT_ACTION_TYPE_BASELINE,

        [EnumMember(Value = "EVENT_ACTION_TYPE_CREATE")]
        EVENT_ACTION_TYPE_CREATE,

        [EnumMember(Value = "EVENT_ACTION_TYPE_DELETE")]
        EVENT_ACTION_TYPE_DELETE,

        [EnumMember(Value = "EVENT_ACTION_TYPE_MEMBERSHIP_CHANGE")]
        EVENT_ACTION_TYPE_MEMBERSHIP_CHANGE,

        [EnumMember(Value = "EVENT_ACTION_TYPE_PERMISSION_CHANGE")]
        EVENT_ACTION_TYPE_PERMISSION_CHANGE,

        [EnumMember(Value = "EVENT_ACTION_TYPE_POLICY_CONFIGURATION_CHANGE")]
        EVENT_ACTION_TYPE_POLICY_CONFIGURATION_CHANGE,

        [EnumMember(Value = "EVENT_ACTION_TYPE_TENANT_SETTINGS_CHANGE")]
        EVENT_ACTION_TYPE_TENANT_SETTINGS_CHANGE,

        [EnumMember(Value = "EVENT_ACTION_TYPE_UNSPECIFIED")]
        EVENT_ACTION_TYPE_UNSPECIFIED


    } // enum LambdaEventActionType

} // namespace RubrikSecurityCloud.Types