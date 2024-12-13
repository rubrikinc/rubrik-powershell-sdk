// UserAuditStatusEnum.cs
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
    public enum UserAuditStatusEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "Canceled")]
        CANCELED,

        [EnumMember(Value = "Failure")]
        FAILURE,

        [EnumMember(Value = "Success")]
        SUCCESS


    } // enum UserAuditStatusEnum

} // namespace RubrikSecurityCloud.Types