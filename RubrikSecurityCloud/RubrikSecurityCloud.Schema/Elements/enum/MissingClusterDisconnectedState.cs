// MissingClusterDisconnectedState.cs
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
    public enum MissingClusterDisconnectedState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DECOMMISSIONED")]
        DECOMMISSIONED,

        [EnumMember(Value = "DISCONNECTED_STATE_NOT_SPECIFIED")]
        DISCONNECTED_STATE_NOT_SPECIFIED,

        [EnumMember(Value = "ISOLATED")]
        ISOLATED,

        [EnumMember(Value = "OTHER_REASON")]
        OTHER_REASON


    } // enum MissingClusterDisconnectedState

} // namespace RubrikSecurityCloud.Types