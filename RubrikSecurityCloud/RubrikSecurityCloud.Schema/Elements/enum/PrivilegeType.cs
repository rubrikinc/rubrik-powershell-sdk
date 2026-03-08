// PrivilegeType.cs
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
    public enum PrivilegeType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NORMAL")]
        NORMAL,

        [EnumMember(Value = "PRIVILEGED")]
        PRIVILEGED,

        [EnumMember(Value = "PRIVILEGE_TYPE_UNSPECIFIED")]
        PRIVILEGE_TYPE_UNSPECIFIED


    } // enum PrivilegeType

} // namespace RubrikSecurityCloud.Types