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

namespace Rubrik.SecurityCloud.Types
{
    public enum UserAuditStatusEnum
    {
        [EnumMember(Value = "Failure")]
        FAILURE,

        [EnumMember(Value = "Success")]
        SUCCESS


    } // enum UserAuditStatusEnum

} // namespace Rubrik.SecurityCloud.Types