// RefreshableObjectConnectionStatusType.cs
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
    public enum RefreshableObjectConnectionStatusType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "REFRESHABLE_OBJECT_CONNECTION_STATUS_TYPE_BADLY_CONFIGURED")]
        REFRESHABLE_OBJECT_CONNECTION_STATUS_TYPE_BADLY_CONFIGURED,

        [EnumMember(Value = "REFRESHABLE_OBJECT_CONNECTION_STATUS_TYPE_CONNECTED")]
        REFRESHABLE_OBJECT_CONNECTION_STATUS_TYPE_CONNECTED,

        [EnumMember(Value = "REFRESHABLE_OBJECT_CONNECTION_STATUS_TYPE_DELETING")]
        REFRESHABLE_OBJECT_CONNECTION_STATUS_TYPE_DELETING,

        [EnumMember(Value = "REFRESHABLE_OBJECT_CONNECTION_STATUS_TYPE_DISCONNECTED")]
        REFRESHABLE_OBJECT_CONNECTION_STATUS_TYPE_DISCONNECTED,

        [EnumMember(Value = "REFRESHABLE_OBJECT_CONNECTION_STATUS_TYPE_REFRESHING")]
        REFRESHABLE_OBJECT_CONNECTION_STATUS_TYPE_REFRESHING,

        [EnumMember(Value = "REFRESHABLE_OBJECT_CONNECTION_STATUS_TYPE_REMOTE")]
        REFRESHABLE_OBJECT_CONNECTION_STATUS_TYPE_REMOTE


    } // enum RefreshableObjectConnectionStatusType

} // namespace RubrikSecurityCloud.Types