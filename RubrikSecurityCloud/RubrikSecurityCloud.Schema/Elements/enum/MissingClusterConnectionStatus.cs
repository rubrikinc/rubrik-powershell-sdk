// MissingClusterConnectionStatus.cs
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
    public enum MissingClusterConnectionStatus
    {
        [EnumMember(Value = "CONNECTED")]
        CONNECTED,

        [EnumMember(Value = "CONNECTION_STATUS_NOT_SPECIFIED")]
        CONNECTION_STATUS_NOT_SPECIFIED,

        [EnumMember(Value = "NOT_CONNECTED")]
        NOT_CONNECTED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MissingClusterConnectionStatus

} // namespace RubrikSecurityCloud.Types