// QuarantineOperationType.cs
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
    public enum QuarantineOperationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "QUARANTINE")]
        QUARANTINE,

        [EnumMember(Value = "QUARANTINE_OPERATION_TYPE_UNSPECIFIED")]
        QUARANTINE_OPERATION_TYPE_UNSPECIFIED,

        [EnumMember(Value = "RELEASE_FROM_QUARANTINE")]
        RELEASE_FROM_QUARANTINE


    } // enum QuarantineOperationType

} // namespace RubrikSecurityCloud.Types