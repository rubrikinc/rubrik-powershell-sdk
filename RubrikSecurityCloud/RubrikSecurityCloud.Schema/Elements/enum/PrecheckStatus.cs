// PrecheckStatus.cs
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
    public enum PrecheckStatus
    {
        [EnumMember(Value = "ERROR")]
        ERROR,

        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS,

        [EnumMember(Value = "NOT_RUN")]
        NOT_RUN,

        [EnumMember(Value = "SUCCESS")]
        SUCCESS,

        [EnumMember(Value = "WARN")]
        WARN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum PrecheckStatus

} // namespace RubrikSecurityCloud.Types