// ClusterConnectionStatusFromDb.cs
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
    public enum ClusterConnectionStatusFromDb
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONNECTED")]
        CONNECTED,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED


    } // enum ClusterConnectionStatusFromDb

} // namespace RubrikSecurityCloud.Types