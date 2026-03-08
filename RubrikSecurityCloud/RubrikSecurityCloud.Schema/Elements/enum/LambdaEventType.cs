// LambdaEventType.cs
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
    public enum LambdaEventType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EVENT_TYPE_AUTHENTICATION")]
        EVENT_TYPE_AUTHENTICATION,

        [EnumMember(Value = "EVENT_TYPE_IDENTITY_ACL_CHANGE")]
        EVENT_TYPE_IDENTITY_ACL_CHANGE,

        [EnumMember(Value = "EVENT_TYPE_IDENTITY_ADD")]
        EVENT_TYPE_IDENTITY_ADD,

        [EnumMember(Value = "EVENT_TYPE_IDENTITY_ATTRIBUTE_CHANGE")]
        EVENT_TYPE_IDENTITY_ATTRIBUTE_CHANGE,

        [EnumMember(Value = "EVENT_TYPE_IDENTITY_BASELINE")]
        EVENT_TYPE_IDENTITY_BASELINE,

        [EnumMember(Value = "EVENT_TYPE_IDENTITY_DELETE")]
        EVENT_TYPE_IDENTITY_DELETE,

        [EnumMember(Value = "EVENT_TYPE_IDENTITY_GPO_ADD")]
        EVENT_TYPE_IDENTITY_GPO_ADD,

        [EnumMember(Value = "EVENT_TYPE_IDENTITY_GPO_CHANGE")]
        EVENT_TYPE_IDENTITY_GPO_CHANGE,

        [EnumMember(Value = "EVENT_TYPE_IDENTITY_GPO_DELETE")]
        EVENT_TYPE_IDENTITY_GPO_DELETE,

        [EnumMember(Value = "EVENT_TYPE_IDENTITY_MEMBERSHIP_ADD")]
        EVENT_TYPE_IDENTITY_MEMBERSHIP_ADD,

        [EnumMember(Value = "EVENT_TYPE_IDENTITY_MEMBERSHIP_REMOVE")]
        EVENT_TYPE_IDENTITY_MEMBERSHIP_REMOVE,

        [EnumMember(Value = "EVENT_TYPE_UNSPECIFIED")]
        EVENT_TYPE_UNSPECIFIED


    } // enum LambdaEventType

} // namespace RubrikSecurityCloud.Types