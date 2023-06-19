// TaskchainState.cs
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
    public enum TaskchainState
    {
        [EnumMember(Value = "CANCELED")]
        CANCELED,

        [EnumMember(Value = "CANCELING")]
        CANCELING,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "READY")]
        READY,

        [EnumMember(Value = "RUNNING")]
        RUNNING,

        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED,

        [EnumMember(Value = "UNDOING")]
        UNDOING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TaskchainState

} // namespace RubrikSecurityCloud.Types