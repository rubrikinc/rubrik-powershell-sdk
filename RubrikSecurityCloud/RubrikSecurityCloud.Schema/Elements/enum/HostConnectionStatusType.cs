// HostConnectionStatusType.cs
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
    public enum HostConnectionStatusType
    {
        [EnumMember(Value = "HOST_CONNECTION_STATUS_TYPE_CONNECTED")]
        HOST_CONNECTION_STATUS_TYPE_CONNECTED,

        [EnumMember(Value = "HOST_CONNECTION_STATUS_TYPE_CONNECTION_FAILURE")]
        HOST_CONNECTION_STATUS_TYPE_CONNECTION_FAILURE,

        [EnumMember(Value = "HOST_CONNECTION_STATUS_TYPE_DNS_RESOLUTION_FAILURE")]
        HOST_CONNECTION_STATUS_TYPE_DNS_RESOLUTION_FAILURE,

        [EnumMember(Value = "HOST_CONNECTION_STATUS_TYPE_INVALID_CERTIFICATE")]
        HOST_CONNECTION_STATUS_TYPE_INVALID_CERTIFICATE,

        [EnumMember(Value = "HOST_CONNECTION_STATUS_TYPE_INVALID_CREDENTIALS")]
        HOST_CONNECTION_STATUS_TYPE_INVALID_CREDENTIALS,

        [EnumMember(Value = "HOST_CONNECTION_STATUS_TYPE_NO_ADDRESS_FOUND")]
        HOST_CONNECTION_STATUS_TYPE_NO_ADDRESS_FOUND,

        [EnumMember(Value = "HOST_CONNECTION_STATUS_TYPE_NO_ROUTE_TO_HOST")]
        HOST_CONNECTION_STATUS_TYPE_NO_ROUTE_TO_HOST,

        [EnumMember(Value = "HOST_CONNECTION_STATUS_TYPE_SECURITY_CONNECTION_FAILURE")]
        HOST_CONNECTION_STATUS_TYPE_SECURITY_CONNECTION_FAILURE,

        [EnumMember(Value = "HOST_CONNECTION_STATUS_TYPE_UNKNOWN_ERROR")]
        HOST_CONNECTION_STATUS_TYPE_UNKNOWN_ERROR,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum HostConnectionStatusType

} // namespace RubrikSecurityCloud.Types