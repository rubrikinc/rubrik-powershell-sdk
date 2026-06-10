// DevopsConnectionStatus.cs
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
    public enum DevopsConnectionStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONNECTION_STATUS_CONNECTED")]
        CONNECTION_STATUS_CONNECTED,

        [EnumMember(Value = "CONNECTION_STATUS_CONNECTING")]
        CONNECTION_STATUS_CONNECTING,

        [EnumMember(Value = "CONNECTION_STATUS_DISCONNECTED")]
        CONNECTION_STATUS_DISCONNECTED,

        [EnumMember(Value = "CONNECTION_STATUS_MISSING_PERMISSIONS")]
        CONNECTION_STATUS_MISSING_PERMISSIONS,

        [EnumMember(Value = "CONNECTION_STATUS_UNSPECIFIED")]
        CONNECTION_STATUS_UNSPECIFIED


    } // enum DevopsConnectionStatus

} // namespace RubrikSecurityCloud.Types