// CertificateRotationStatus.cs
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
    public enum CertificateRotationStatus
    {
        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS,

        [EnumMember(Value = "NOT_SCHEDULED")]
        NOT_SCHEDULED,

        [EnumMember(Value = "READY_TO_MIGRATE")]
        READY_TO_MIGRATE,

        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "UNSUPPORTED")]
        UNSUPPORTED


    } // enum CertificateRotationStatus

} // namespace RubrikSecurityCloud.Types