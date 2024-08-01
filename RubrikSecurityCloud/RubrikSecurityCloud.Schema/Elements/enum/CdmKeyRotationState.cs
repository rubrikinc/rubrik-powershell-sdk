// CdmKeyRotationState.cs
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
    public enum CdmKeyRotationState
    {
        [EnumMember(Value = "ABORTED")]
        ABORTED,

        [EnumMember(Value = "DONE")]
        DONE,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS,

        [EnumMember(Value = "KEY_ROTATION_STATE_UNSPECIFIED")]
        KEY_ROTATION_STATE_UNSPECIFIED,

        [EnumMember(Value = "QUEUED")]
        QUEUED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CdmKeyRotationState

} // namespace RubrikSecurityCloud.Types