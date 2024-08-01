// PrivateEndpointConnectionStatus.cs
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
    public enum PrivateEndpointConnectionStatus
    {
        [EnumMember(Value = "APPROVED")]
        APPROVED,

        [EnumMember(Value = "PENDING")]
        PENDING,

        [EnumMember(Value = "REJECTED")]
        REJECTED,

        [EnumMember(Value = "REMOVED")]
        REMOVED,

        [EnumMember(Value = "UNSPECIFIED_PE_CONNECTION_STATUS")]
        UNSPECIFIED_PE_CONNECTION_STATUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum PrivateEndpointConnectionStatus

} // namespace RubrikSecurityCloud.Types