// AuditStatus.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum AuditStatus
    {
        [EnumMember(Value = "AUDIT_STATUS_UNSPECIFIED")]
        AUDIT_STATUS_UNSPECIFIED,

        [EnumMember(Value = "FAILURE")]
        FAILURE,

        [EnumMember(Value = "SUCCESS")]
        SUCCESS


    } // enum AuditStatus

} // namespace Rubrik.SecurityCloud.Types