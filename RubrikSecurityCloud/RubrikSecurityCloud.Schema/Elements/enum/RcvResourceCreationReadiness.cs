// RcvResourceCreationReadiness.cs
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
    public enum RcvResourceCreationReadiness
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "RCV_RESOURCE_CREATION_FAILED")]
        RCV_RESOURCE_CREATION_FAILED,

        [EnumMember(Value = "RCV_RESOURCE_CREATION_IN_PROGRESS")]
        RCV_RESOURCE_CREATION_IN_PROGRESS,

        [EnumMember(Value = "RCV_RESOURCE_CREATION_READINESS_UNSPECIFIED")]
        RCV_RESOURCE_CREATION_READINESS_UNSPECIFIED,

        [EnumMember(Value = "RCV_RESOURCE_CREATION_READY")]
        RCV_RESOURCE_CREATION_READY


    } // enum RcvResourceCreationReadiness

} // namespace RubrikSecurityCloud.Types