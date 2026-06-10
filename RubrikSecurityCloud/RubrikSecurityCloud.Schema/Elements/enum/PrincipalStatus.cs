// PrincipalStatus.cs
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
    public enum PrincipalStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NEWLY_ADDED")]
        NEWLY_ADDED,

        [EnumMember(Value = "NEW_PRIVILEGE_ESCALATION")]
        NEW_PRIVILEGE_ESCALATION,

        [EnumMember(Value = "PRINCIPAL_STATUS_UNSPECIFIED")]
        PRINCIPAL_STATUS_UNSPECIFIED


    } // enum PrincipalStatus

} // namespace RubrikSecurityCloud.Types